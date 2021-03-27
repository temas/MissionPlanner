using Force.Crc32;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.Utilities
{

    public enum packetID
    {
        heartBeat = 0,
        chklistApproved,
        termStatus,
        routeApproved,
        routeDeclined,
        nothingToSay,
        routeUploaded,
        catapultAssigned,
        fenceUploaded,
        notify,
        payloadSetup,
        catapultReady,
        motorAtMax,
        airpseedCalibrated,
        preflightChanged
    }

    public enum nodeID
    {
        supervisor = 0,
        plane1 = 1,
        plane2 = 2,
        plane3 = 3
    }


    public static class protarComm
    {

        public static int serverIpPort { get; set; } = 11000;
        public static string serverIP { get; set; } = "127.0.0.1";


        //input queue from all planes
        public static ConcurrentQueue<byte[]> inQueue = new ConcurrentQueue<byte[]>();
        //output queues for downlink planes, one queue for each plane
        public static ConcurrentQueue<byte[]>[] outQueue = new ConcurrentQueue<byte[]>[4];

        public static bool isRunning { get; set; } = false;

        public static byte myNodeID { get; set; }

        public static bool lastConnectOK { get; set; } = true;  //Is it either OK or we just start and assuming that it will be OK

        // Incoming data from the client.
        private static string data = null;

        public static void ServerThread()
        {
            // Data buffer for incoming data.
            byte[] buff = new Byte[1024];
            byte[] payload;


            outQueue[(byte)nodeID.supervisor] = new ConcurrentQueue<byte[]>();
            outQueue[(byte)nodeID.plane1] = new ConcurrentQueue<byte[]>();
            outQueue[(byte)nodeID.plane2] = new ConcurrentQueue<byte[]>();
            outQueue[(byte)nodeID.plane3] = new ConcurrentQueue<byte[]>();


            // Establish the local endpoint for the socket.
            // Dns.GetHostName returns the name of the
            // host running the application.
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = IPAddress.Parse(serverIP);
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, serverIpPort);

            // Create a TCP/IP socket.
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and
            // listen for incoming connections.
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                isRunning = true;
                Console.WriteLine("Protar Server thread started");
                // Start listening for connections.
                while (true)
                {
                    //Console.WriteLine("Waiting for a connection...");
                    //Set receiver buffer size back to original
                    Array.Resize(ref buff, 300);
                    // Program is suspended while waiting for an incoming connection.
                    Socket handler = listener.Accept();
                    int bytesRec = handler.Receive(buff);
                    Array.Resize(ref buff, bytesRec);

                    byte senderID;
                    if (processReceivedPacket(out payload, ref buff, out senderID))
                    {

                        // On the server side we are not supposed to receive packets with zero ID (Server)
                        if (senderID != 0)
                        {
                            byte[] outPayload;
                            byte[] outPacket;

                            inQueue.Enqueue(payload);

                            var hasOutData = outQueue[senderID].TryPeek(out outPayload);

                            if (!hasOutData) outPayload = protarComm.createPacket(packetID.nothingToSay);

                            assemblePacket(out outPacket, ref outPayload, myNodeID);

                            handler.Send(outPacket);
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();

                            if (hasOutData) outQueue[senderID].TryDequeue(out outPayload);

                            //if (hasOutData) Console.WriteLine("Data Sent Back");
                            //else Console.WriteLine("No Data to send back");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        public static void ClientThread()
        {

            byte[] payload;

            // Data buffer for incoming data.
            byte[] packetIn = new byte[300];

            outQueue[(byte)nodeID.supervisor] = new ConcurrentQueue<byte[]>();
            outQueue[(byte)nodeID.plane1] = new ConcurrentQueue<byte[]>();
            outQueue[(byte)nodeID.plane2] = new ConcurrentQueue<byte[]>();
            outQueue[(byte)nodeID.plane3] = new ConcurrentQueue<byte[]>();
            isRunning = true;

            // Thread ends if isRunning is false and there are no message in the queue
            while (isRunning || outQueue[(byte)nodeID.supervisor].Count > 0)
            {
                //If we have message then process it.

                if (outQueue[(byte)nodeID.supervisor].Count > 0)
                {
                    if (outQueue[(byte)nodeID.supervisor].TryPeek(out payload))
                    {
                        //We assume that the connection will fail :(
                        lastConnectOK = false;


                        byte[] outpacket;
                        assemblePacket(out outpacket, ref payload, myNodeID);

                        // Connect to a remote device.
                        try
                        {
                            // Establish the remote endpoint for the socket.
                            // This example uses port 11000 on the local computer.

                            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                            IPAddress ipAddress = IPAddress.Parse(serverIP);
                            IPEndPoint remoteEP = new IPEndPoint(ipAddress, serverIpPort);

                            // Create a TCP/IP  socket.
                            Socket sender = new Socket(ipAddress.AddressFamily,
                                SocketType.Stream, ProtocolType.Tcp);

                            // Connect the socket to the remote endpoint. Catch any errors.
                            try
                            {
                                sender.Connect(remoteEP);
                                // Encode the data string into a byte array.
                                // Send the data through the socket.
                                int bytesSent = sender.Send(outpacket);

                                // Receive the response from the remote device.

                                //Size back the packet buffer
                                Array.Resize(ref packetIn, 300);
                                int bytesRec = sender.Receive(packetIn);
                                Array.Resize(ref packetIn, bytesRec);

                                // process incoming message
                                byte senderID;
                                if (processReceivedPacket(out payload, ref packetIn, out senderID))
                                {
                                    if (getPacketID(ref payload) != packetID.nothingToSay)
                                    {
                                        inQueue.Enqueue(payload);
                                    }

                                }

                                // Release the socket.
                                sender.Shutdown(SocketShutdown.Both);
                                sender.Close();
                                //We were successfull, we can dequeue the item
                                outQueue[(byte)nodeID.supervisor].TryDequeue(out payload);
                                lastConnectOK = true;

                            }
                            catch (ArgumentNullException ane)
                            {
                                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                            }
                            catch (SocketException se)
                            {
                                Console.WriteLine("SocketException : {0}", se.ToString());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unexpected exception : {0}", e.ToString());
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }

                    }
                }
            }
        }
        // Assembles a packet with magic numbers, senderID, length and CRC with the payload. The output packet array is trimmed to correct size.

        private static void assemblePacket(out byte[] packet, ref byte[] payload, byte nodeID)
        {

            packet = new byte[payload.Length + 8];

            packet[0] = 0xaa;
            packet[1] = 0x55;
            packet[6] = nodeID;
            packet[7] = Convert.ToByte(payload.Length);

            uint crc = Crc32Algorithm.Compute(payload);
            byte[] crcbytes = BitConverter.GetBytes(crc);
            Buffer.BlockCopy(crcbytes, 0, packet, 2, 4);
            Buffer.BlockCopy(payload, 0, packet, 8, payload.Length);

        }


        // Process incoming packet, checks for magic number, length, crc and senderID
        // output payload array is trimmed to the correct length
        private static bool processReceivedPacket(out byte[] payload, ref byte[] packet, out byte senderID)
        {

            // Create out array, we will trim it later
            payload = new byte[packet.Length];
            senderID = 0;

            var packetLength = packet[7];


            //check magic bytes
            if ((packet[0] != 0xaa) || (packet[1] != 0x55))
            {
                Console.WriteLine("bad packet");
                return false;
            }
            //Check payload length
            if (packetLength != packet.Length - 8)
            {
                Console.WriteLine("bad length");
                return false;
            }
            //Check CRC
            uint crc = BitConverter.ToUInt32(packet, 2);
            if (crc != Crc32Algorithm.Compute(packet, 8, packetLength))
            {
                Console.WriteLine("bad crc");
                return false;
            }
            senderID = packet[6];

            if (senderID > 3)
            {
                Console.WriteLine("Invalid Sender ID");
                return false;
            }

            Array.Resize(ref payload, packetLength);
            Buffer.BlockCopy(packet, 8, payload, 0, packetLength);
            return true;

        }


        public static packetID getPacketID(ref byte[] payload)
        {
            return (packetID)payload[0];
        }

        public static byte[] createPacket(packetID id, byte data1 = 0, byte data2 = 0, byte data3 = 0, byte data4 = 0)
        {
            byte[] packet = new byte[5];
            packet[0] = (byte)id;
            packet[1] = data1;
            packet[2] = data2;
            packet[3] = data3;
            packet[4] = data4;
            return packet;

        }
        public static byte[] createPacket(packetID id, byte[] p)
        {
            byte[] packet = new byte[p.Length + 1];
            packet[0] = (byte)id;
            Buffer.BlockCopy(p, 0, packet, 1, p.Length);
            return packet;

        }

        public static byte[] createPacket(packetID id, string str)
        {
            byte[] packet = new byte[str.Length + 1];
            var encoding = Encoding.UTF8;
            packet[0] = (byte)id;
            encoding.GetBytes(str, 0, str.Length, packet, 1);
            return packet;

        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public enum Payload { left1 = 0, left2, left3, left4, right1, right2, right3, right4, rear1, rear2 }
    public enum PayloadType { empty, smoke, flare }

    public partial class payloadcontrol : UserControl
    {
        private string[] payloads = { "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY" };
        private List<Button> buttons;

        public List<Payload> toIgnite;

        public event EventHandler igniteClicked;

        public payloadcontrol()
        {
            InitializeComponent();
            buttons = new List<Button>();
            buttons.Add(l1);
            buttons.Add(l2);
            buttons.Add(l3);
            buttons.Add(l4);

            buttons.Add(r1);
            buttons.Add(r2);
            buttons.Add(r3);
            buttons.Add(r4);

            buttons.Add(rear1);
            buttons.Add(rear2);
            resetControls();

            setPayloads(Payload.right1, PayloadType.flare);

        }

        private void payload_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Text == "EMPTY") return;
            if (btn.BackColor == Color.Lime) btn.BackColor = Color.Yellow;
            else btn.BackColor = Color.Lime;

        }


        public void setPayloads(Payload position, PayloadType type)
        {
            switch (type)
            {
                case PayloadType.empty:
                    payloads[(int)position] = "EMPTY";
                    break;
                case PayloadType.flare:
                    payloads[(int)position] = "FLARE";
                    break;
                case PayloadType.smoke:
                    payloads[(int)position] = "SMOKE";
                    break;
            }
            resetControls();


        }

        public void resetControls()
        {
            var a = 0;
            foreach (Button b in buttons)
            {
                b.Text = payloads[a++];

                if (b.Text == "EMPTY") b.BackColor = Color.Gray;
                else b.BackColor = Color.Lime;

                b.ForeColor = Color.DarkSlateGray;

            }
            btnIgnite.ForeColor = Color.DarkSlateGray;
            btnIgnite.BackColor = Color.Red;


        }

        private void btnIgnite_Click(object sender, EventArgs e)
        {

            toIgnite = new List<Payload>();

            var a = 0;
            foreach (Button b in buttons)
            {
                if (b.BackColor == Color.Yellow)
                {
                    toIgnite.Add((Payload)a);
                    b.BackColor = Color.Gray;
                    b.Text = "EMPTY";
                }
                a++;
            }

            this.OnIgniteClicked(EventArgs.Empty);
        }

        protected virtual void OnIgniteClicked(EventArgs e)
        {
            EventHandler handler = this.igniteClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        }



    }

}

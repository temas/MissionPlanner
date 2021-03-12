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
    public partial class payloadsetup : UserControl
    {
        private string[] payloads = { "SMOKE", "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY", "EMPTY" };
        private bool[] payload_status = { true, true, true, true, true, true, true, true, true, true };

        private List<Button> buttons;

        public List<Payload> toIgnite;

        public event EventHandler igniteClicked;

        public payloadsetup()
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

            refreshControls();

        }

        private void payload_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Text == "EMPTY")
            {
                btn.Text = "FLARE";
                btn.BackColor = Color.Lime;
            }
            else if (btn.Text == "FLARE")
            {
                btn.Text = "SMOKE";
                btn.BackColor = Color.Green;
            }
            else if (btn.Text == "SMOKE")
            {
                btn.Text = "EMPTY";
                btn.BackColor = Color.Gray;
            }

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
            refreshControls();
        }


        public void updateStatus()
        {

        }

        public void refreshControls()
        {
            var a = 0;

            this.SuspendLayout();

            foreach (Button b in buttons)
            {
                b.Text = payloads[a++];

                if (b.Text == "FLARE")
                {
                    b.BackColor = Color.Lime;
                }
                else if (b.Text == "SMOKE")
                {
                    b.BackColor = Color.Green;
                }
                else b.BackColor = Color.Gray;


                b.ForeColor = Color.DarkSlateGray;

            }
            btnIgnite.ForeColor = Color.DarkSlateGray;
            btnIgnite.BackColor = Color.Red;
            this.ResumeLayout();


        }

        private void btnIgnite_Click(object sender, EventArgs e)
        {
            var a = 0;

            foreach (Button b in buttons)
            {

                payloads[a++] = b.Text;
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

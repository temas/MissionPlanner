using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Utilities;

namespace MissionPlanner.Controls
{
    public enum Stat { EKF = 0, ENGINE, BATT, GPS, COMM, VIBE, FUEL, FENCE, AIRPSPEED, MAG, PAYLOAD, PARACHUTE, TERMINATION, CATAPULT, PREFLIGHT, PANEL15 }
    public enum StatLight { NOMINAL, WARNING, ALERT, DISABLED }


    [PreventTheming]
    public partial class annunciator : UserControl
    {

        private string[] btnLabels = { "EKF", "ENGINE", "BATT", "GPS", "COMM", "VIBE", "FUEL", "FENCE", "AIRSPD", "MAG", "PAYLD", "CHUTE", "TERM", "CPULT", "PRFLT", "PNL15" };

        public StringBuilder messages;

        public event EventHandler preflightClicked;

        private Form messagesForm;
        private System.Windows.Forms.RichTextBox messagesBox;
        private bool messagesFormShown = false;


        public annunciator()
        {
            InitializeComponent();
            int a = 0;
            foreach (Button b in layoutPanel.Controls)
            {
                b.Text = btnLabels[a];
                b.Name = btnLabels[a++];
                b.BackColor = Color.Lime;
                b.ForeColor = Color.DarkSlateGray;
                if ((a - 1) != (int)Stat.PREFLIGHT) b.Click += new System.EventHandler(this.panel_Click);
                else b.Click += new System.EventHandler(this.preflighClickHandler);
            }

            messagesForm = new Form();
            messagesForm.FormBorderStyle = FormBorderStyle.None;
            messagesForm.Size = new Size(500, 400);
            messagesForm.StartPosition = FormStartPosition.Manual;
            messagesForm.BackColor = Color.DarkSlateGray;


            messagesBox = new RichTextBox();
            messagesBox.Location = new System.Drawing.Point(1, 1);
            messagesBox.Name = "messagesBox";
            messagesBox.Size = new System.Drawing.Size(498, 398);
            messagesBox.BackColor = Color.DarkSlateGray;
            messagesBox.ForeColor = Color.Yellow;
            messagesBox.ReadOnly = true;


            messagesForm.Controls.Add(messagesBox);


            messages = new StringBuilder();
            messages.Append(@"{\rtf1 {\colortbl \red255\green255\blue255;\red255\green0\blue0;\red255\green255\blue102;} {\fonttbl{\f0\fnil\fcharset0 Arial Rounded MT Bold;}{\f1\fnil\fcharset0 Calibri;}}");
            addMessage("Log Started...");



        }


        public void addMessage(string str)
        {
            messages.Append(@"\cf0");
            messages.Append(str);
            messages.Append(@"\par");       //Add paragraph end
            messagesBox.Rtf = messages.ToString();


            if (!messagesFormShown)
            {
                messagesBox.SelectionStart = messagesBox.Text.Length;
                messagesBox.ScrollToCaret();
            }

        }


        public void setColor(Stat panelID, StatLight c)
        {

            Button b = layoutPanel.Controls.Find(btnLabels[(int)panelID], false).First() as Button;

            switch (c)
            {
                case StatLight.DISABLED:
                    b.BackColor = Color.LightSlateGray;
                    break;
                case StatLight.NOMINAL:
                    b.BackColor = Color.Lime;
                    break;
                case StatLight.WARNING:
                    b.BackColor = Color.Yellow;
                    break;
                case StatLight.ALERT:
                    b.BackColor = Color.Red; ;
                    break;
            }


        }

        private void panel_Click(object sender, EventArgs e)
        {


            if (messagesFormShown)
            {
                messagesForm.Hide();
                messagesFormShown = false;
                return;
            }

            Point p = this.PointToScreen(this.Location);
            messagesForm.Location = new Point(p.X + this.Size.Width - messagesForm.Size.Width, p.Y + this.Height);
            messagesForm.PerformLayout();
            messagesBox.SelectionStart = messagesBox.Text.Length;
            messagesBox.ScrollToCaret();
            messagesForm.Show();
            messagesForm.BringToFront();
            messagesFormShown = true;

        }

        private void preflighClickHandler(object sender, EventArgs e)
        {
            this.OnpreflightClicked(EventArgs.Empty);
        }

        protected virtual void OnpreflightClicked(EventArgs e)
        {
            EventHandler handler = this.preflightClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        }

    }

}

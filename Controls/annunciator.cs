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
    public enum Stat { NOMINAL, WARNING, ALERT, DISABLED }


    [PreventTheming]
    public partial class annunciator : UserControl
    {

        private string[] _btnLabels = { "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE", "NONE" };

        public StringBuilder messages;

        [Browsable(true)]
        [Category("Action")]
        public event EventHandler buttonClicked;

        private string _clickedButtonName = "NONE";

        public string clickedButtonName
        {
            get { return _clickedButtonName; }

        }

        [System.ComponentModel.Browsable(true)]
        public string[] btnLabels
        {
            get { return _btnLabels; }
            set
            {
                _btnLabels = value;
                int a = 0;
                foreach (Button b in layoutPanel.Controls)
                {
                    b.Text = _btnLabels[a];
                    b.Name = _btnLabels[a];
                    a++;
                }
            }
        }

        public annunciator()
        {
            InitializeComponent();
            int a = 0;
            foreach (Button b in layoutPanel.Controls)
            {
                b.Text = _btnLabels[a];
                b.Name = _btnLabels[a++];
                b.BackColor = Color.Lime;
                b.ForeColor = Color.DarkSlateGray;
                b.Click += new System.EventHandler(this.panel_Click);
            }

            timer1.Interval = 500;
            timer1.Tick += Timer_Tick;
            timer1.Enabled = false;
            if (!this.DesignMode)
            {
                timer1.Enabled = true;
            }
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Button b in layoutPanel.Controls)
            {
                if (b.BackColor == Color.Red) b.BackColor = Color.DarkRed;
                else if (b.BackColor == Color.DarkRed) b.BackColor = Color.Red;

                if (b.BackColor == Color.Yellow) b.BackColor = Color.Gold;
                else if (b.BackColor == Color.Gold) b.BackColor = Color.Yellow;

            }
        }

        public void setStatus(string panelName, Stat c)
        {

            foreach (Button b in layoutPanel.Controls.Find(panelName, false))
            {
                switch (c)
                {
                    case Stat.DISABLED:
                        b.BackColor = Color.DarkSlateGray;
                        b.ForeColor = Color.LightSlateGray;
                        break;
                    case Stat.NOMINAL:
                        b.BackColor = Color.Lime;
                        b.ForeColor = Color.DarkSlateGray;
                        break;
                    case Stat.WARNING:
                        b.BackColor = Color.Yellow;
                        b.ForeColor = Color.DarkSlateGray;
                        break;
                    case Stat.ALERT:
                        b.BackColor = Color.Red;
                        b.ForeColor = Color.White;
                        break;
                }

            }



        }

        private void panel_Click(object sender, EventArgs e)
        {

            var b = (Button)sender;

            _clickedButtonName = b.Text;
            if (b.FlatAppearance.BorderSize == 1)
            {
                foreach(Button btn in layoutPanel.Controls)
                {
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.Black; ;
                }
                b.FlatAppearance.BorderSize = 3;
                b.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = Color.Black; ;
            }



            EventHandler handler = this.buttonClicked;
            if (handler != null)
            {
                handler(this, e);
            }

        }
    }

}
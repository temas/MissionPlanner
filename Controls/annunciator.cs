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
        private Stat[] _btnStatus = { Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED, Stat.DISABLED };


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
                b.Name = _btnLabels[a];
                _btnStatus[a] = Stat.NOMINAL;
                setButtonColor(b, _btnStatus[a]);
                b.Click += new System.EventHandler(this.panel_Click);
                a++;
            }

            timer1.Interval = 500;
            timer1.Tick += Timer_Tick;
            timer1.Enabled = false;
            if (!this.DesignMode)
            {
                timer1.Enabled = true;
            }
        }


        private void setButtonColor(Button b, Stat s)
        {
            switch (s)
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


        public Stat getStatus(string panelName)
        {
            Button b = layoutPanel.Controls.Find(panelName, false).FirstOrDefault() as Button;
            int index = Array.IndexOf(_btnLabels, panelName);
            return _btnStatus[index];
        }


        public void setStatus(string panelName, Stat c)
        {

            Button b = layoutPanel.Controls.Find(panelName, false).FirstOrDefault() as Button;
            int index = Array.IndexOf(_btnLabels,panelName);
            if (_btnStatus[index] != c)
            {
                _btnStatus[index] = c;
                setButtonColor(b, c);
                this.Invalidate();
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

        private void annunciator_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                int a = 0;
                foreach (Button b in layoutPanel.Controls)
                {
                    setButtonColor(b, _btnStatus[a++]);
                }
            }
            else
            {
                foreach (Button b in layoutPanel.Controls)
                {
                    b.BackColor = Color.DarkSlateGray;
                    b.ForeColor = Color.LightSlateGray;
                }
            }


        }
    }

}
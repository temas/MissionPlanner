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
    public enum Stat { NOMINAL, WARNING, ALERT, DISABLED, NOTEXIST }


    [PreventTheming]
    public partial class annunciator : UserControl
    {
        private List<panelItem> panelItems = new List<panelItem>();

        public event EventHandler buttonClicked;
        public event EventHandler undock;

        private string _clickedButtonName;

        public string clickedButtonName
        {
            get { return _clickedButtonName; }

        }

        private bool _blinkStat = true;

        public annunciator()
        {
            InitializeComponent();
        }

        public annunciator(int btnCount, Size btnSize)
        {
            InitializeComponent();

            for (int i = 0; i < btnCount; i++)
            {
                panelItem item = new panelItem();

                item.btn.Size = btnSize;
                item.btn.Name = "button" + i.ToString();
                item.btn.Location = new Point(i * (btnSize.Width), 0);
                item.btn.Margin = new Padding(1, 1, 1, 1);
                item.btn.Click += new System.EventHandler(this.panel_Click);
                item.btn.FlatAppearance.BorderSize = 1;
                item.btn.FlatAppearance.BorderColor = Color.Black;
                item.btn.FlatStyle = FlatStyle.Flat;
                item.btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                item.btn.panelName = "EMPTY";
                item.btn.ContextMenu = contextMenu1;
                item.setStatus(Stat.ALERT);

                item.name = "EMPTY";
                item._disabled = true;

                layoutPanel.Controls.Add(item.btn);
                panelItems.Add(item);
            }

            timer1.Interval = 500;
            timer1.Tick += Timer_Tick;
            timer1.Enabled = true;

            if (!this.DesignMode)
            {
                timer1.Enabled = true;
            }
        }

        public void setPanels(string[] panelNames, string[] panelLabels)
        {

            if (panelLabels.Count() != panelNames.Count()) return;
            if (panelLabels.Count() == 0) return;
            if (panelLabels.Count() > panelItems.Count) Array.Resize(ref panelLabels, panelItems.Count);

            int index = 0;
            foreach (panelItem i in panelItems)
            {
                i.name = panelNames[index];
                i.btn.Text = panelLabels[index++];
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _blinkStat = !_blinkStat;

            foreach (panelItem i in panelItems)
            {
                i.blink(_blinkStat);
            }
            this.Invalidate();
        }

        public Stat getStatus(string panelName)
        {

            panelItem p = panelItems.Find(x => x.name == panelName);

            if (p is null) return Stat.NOTEXIST;
            else return p.status;

        }


        public void setStatus(string panelName, Stat c)
        {
            panelItem p = panelItems.Find(x => x.name == panelName);
            if (p != null)
            {
                //p.status = c;
                p.setStatus(c);
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {

            var b = (panelButton)sender;
            //find the panel by the button
            panelItem p = panelItems.Find(x => x.name == b.panelName);

            if ((p.status == Stat.DISABLED) && (b.BackColor == Color.DarkSlateGray)) return;


            if (b.FlatAppearance.BorderSize == 3)
            {
                p.deselect();
            }
            else
            {
                _clickedButtonName = p.name;

                foreach (panelItem i in panelItems)
                    i.deselect();

                p.select();
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
                foreach (panelItem i in panelItems)
                {
                    i.enable();
                }
            }
            else
            {
                foreach (panelItem i in panelItems)
                {
                    i.disable();
                }
            }

        }

        private void menuUndockDock_Click(object sender, EventArgs e)
        {
            EventHandler handler = this.undock;
            if (handler != null)
            {
                handler(this, e);
            }
        }


    }

    public partial class panelButton : Button
    {
        public string panelName { get; set; }
    }


    public class panelItem : IEquatable<panelItem>
    {

        public panelButton btn { get; set; }

        private string _name;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                btn.panelName = _name;
            }
        }

        private Stat _status;

        public Stat status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public bool _disabled { get; set; }

        private Color _disabledBGColor = Color.DarkSlateGray;
        private Color _disabledFGColor = Color.LightSlateGray;

        private Color _nominalBGColor = Color.Lime;
        private Color _nominalFGColor = Color.DarkSlateGray;

        private Color _warningBGColor = Color.Yellow;
        private Color _warningBGColorBlink = Color.Gold;
        private Color _warningFGColor = Color.DarkSlateGray;

        private Color _alertBGColor = Color.Red;
        private Color _alertBGColorBlink = Color.DarkRed;
        private Color _alertFGColor = Color.White;


        public panelItem()
        {
            btn = new panelButton();
        }


        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            panelItem objAsPart = obj as panelItem;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public bool Equals(panelItem other)
        {
            if (other == null) return false;
            return (this.name.Equals(other.name));
        }


        public void disable()
        {
            this.btn.BackColor = _disabledBGColor;
            this.btn.ForeColor = _disabledFGColor;
            this._disabled = true;
        }

        public void enable()
        {
            setStatus(this.status);
            this._disabled = false;
        }

        public void select()
        {
            this.btn.FlatAppearance.BorderSize = 3;
            this.btn.FlatAppearance.BorderColor = Color.White;
        }

        public void deselect()
        {
            this.btn.FlatAppearance.BorderSize = 1;
            this.btn.FlatAppearance.BorderColor = Color.Black;
        }

        public void setStatus(Stat s)
        {
            switch (s)
            {
                case Stat.NOMINAL:
                    this.btn.BackColor = _nominalBGColor;
                    this.btn.ForeColor = _nominalFGColor;
                    break;
                case Stat.WARNING:
                    this.btn.BackColor = _warningBGColor;
                    this.btn.ForeColor = _warningFGColor;
                    break;
                case Stat.ALERT:
                    this.btn.BackColor = _alertBGColor;
                    this.btn.ForeColor = _alertFGColor;
                    break;
                case Stat.DISABLED:
                    this.btn.BackColor = _disabledBGColor;
                    this.btn.ForeColor = _disabledFGColor;
                    break;
                default:
                    break;
            }
            status = s;
        }

        public void blink(bool b)
        {

            if (!this._disabled)
            {
                if (b)
                {
                    if (status == Stat.ALERT) this.btn.BackColor = _alertBGColorBlink;
                    else if (status == Stat.WARNING) this.btn.BackColor = _warningBGColorBlink;
                }
                else
                {
                    if (status == Stat.ALERT) this.btn.BackColor = _alertBGColor;
                    else if (status == Stat.WARNING) this.btn.BackColor = _warningBGColor;
                }
            }
        }
    }


}
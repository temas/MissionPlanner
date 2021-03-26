using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.StatusForms
{
    public partial class engineStatusForm : Form
    {


        public event EventHandler armClicked;

        public engineStatusForm()
        {
            InitializeComponent();
        }

        public void setRPM(float rpm)
        {
            engineRpmGauge.Value0 = rpm;
            engineRpmGauge.Cap_Idx = 1;
            engineRpmGauge.CapText = (rpm * 1000).ToString("F0");
        }

        public void setTemp(float temp)
        {

            float t;
            t = temp;

            if (temp < 150)
            {
                t = 150;
            }

            engineTempGauge.Value0 = t;
            engineTempGauge.Cap_Idx = 1;
            engineTempGauge.CapText = temp.ToString("F0") + " C°";

        }

        public void setText(string text)
        {
            engineStatusText.Text += (text + Environment.NewLine);
        }


        //pass arming click up
        private void btnArmVehicle_Click(object sender, EventArgs e)
        {
            EventHandler handler = this.armClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}

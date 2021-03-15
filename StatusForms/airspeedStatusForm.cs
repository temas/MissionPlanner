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
    public partial class airspeedStatusForm : Form
    {

        public event EventHandler controlStatusUpdated;

        public int status = 0;

        public airspeedStatusForm()
        {
            InitializeComponent();
        }


        public void addText(String t)
        {
            textBox1.Text += t + "\r\n";
        }

        public void clearText()
        {
            textBox1.Text = "";
        }

        private void bDoPreflight_Click(object sender, EventArgs e)
        {

            status = 0;

            if (CustomMessageBox.Show("Are you sure you want to do Preflight Calibration ?", "Action", MessageBoxButtons.YesNo) == (int)DialogResult.Yes)
            {
                try
                {
                    ((Control)sender).Enabled = false;

                    int param1 = 0;
                    int param2 = 0;
                    int param3 = 1;

                    //baro/airspeed calibration, but no gyro !
                    param3 = 1; // baro / airspeed
                    var cmd = (MAVLink.MAV_CMD)Enum.Parse(typeof(MAVLink.MAV_CMD), "Preflight_Calibration".ToUpper());

                    if (MainV2.comPort.doCommand(cmd, param1, param2, param3, 0, 0, 0, 0))
                    {
                        status = 2;
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed + " " + cmd, Strings.ERROR);
                        status = 0;
                    }
                }
                catch
                {
                    CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    status = 0;
                }

                ((Control)sender).Enabled = true;
                clearText();

                EventHandler handler = this.controlStatusUpdated;
                if (handler != null) handler(this, EventArgs.Empty);


            }






        }
    }
}

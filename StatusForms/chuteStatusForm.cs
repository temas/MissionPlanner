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
    public partial class chuteStatusForm : Form
    {
        private bool _airspeedStatus;
        private bool _fuelStatus;

        public chuteStatusForm()
        {
            InitializeComponent();
            setAirSpeedStatus(false);
            setFuelStatus(false);
        }

        public void setAirSpeedStatus(bool s)
        {
            if (s)
            {
                bAirspeed.BGGradBot = Color.Green;
                bAirspeed.BGGradTop = Color.Lime;
                bAirspeed.TextColor = Color.DarkGray;
                bAirspeed.Text = "Airspeed below threshold";
            }
            else
            {
                bAirspeed.BGGradBot = Color.DarkRed;
                bAirspeed.BGGradTop = Color.Red;
                bAirspeed.TextColor = Color.White;
                bAirspeed.Text = "Airspeed above threshold";
            }

            _airspeedStatus = s;
            setStartButtonState();

        }

        public void setFuelStatus(bool s)
        {
                if (s)
                {
                    bFuel.BGGradBot = Color.Green;
                    bFuel.BGGradTop = Color.Lime;
                    bFuel.TextColor = Color.DarkGray;
                    bFuel.Text = "Fuel below threshold";
                }
                else
                {
                    bFuel.BGGradTop = Color.Red;
                    bFuel.BGGradBot = Color.DarkRed;
                    bFuel.TextColor = Color.White;
                    bFuel.Text = "Fuel above threshold";
                }

            _fuelStatus = s;
            setStartButtonState();

        }

        private void setStartButtonState()
        {
            btnStart.Enabled = _fuelStatus && _airspeedStatus;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.BGGradBot == Color.Green)
            {
                btnExecute.Enabled = false;
                btnStart.BGGradBot = Color.DarkSlateGray;
                btnStart.BGGradTop = Color.DarkSlateGray;
                btnExecute.BGGradTop = Color.DarkSlateGray;
                btnExecute.BGGradBot = Color.DarkSlateGray;
            }
            else
            {

                btnStart.BGGradBot = Color.Green;
                btnStart.BGGradTop = Color.Green;
                btnExecute.BGGradTop = Color.DarkRed;
                btnExecute.BGGradBot = Color.DarkRed;
                btnExecute.Enabled = true;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

        }
    }
}

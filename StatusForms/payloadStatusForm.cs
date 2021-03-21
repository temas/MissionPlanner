using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;

namespace MissionPlanner.StatusForms
{
    [PreventTheming]
    public partial class payloadStatusForm : Form
    {

        public List<Payload> plStat;
        public event EventHandler payloadSetupUpdated;

        public payloadStatusForm()
        {
            InitializeComponent();
            setSafetyPinStatus(false);
            payloadsetup1.redrawControls();
            payloadsetup1.Enabled = false;
            payloadsetup1.Refresh();
        }


        protected virtual void OnUpdateClicked(EventArgs e)
        {
        EventHandler handler = this.payloadSetupUpdated;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void setSafetyPinStatus(bool pinRemoved)
        {

            if (pinRemoved)
            {
                pinStatusButton.Text = "Safety PIN removed";
                pinStatusButton.BGGradBot = Color.Green;
                pinStatusButton.BGGradTop = Color.Lime;
                pinStatusButton.TextColor = Color.DarkSlateGray;
            }
            else
            {
                pinStatusButton.Text = "Safety PIN in place";
                pinStatusButton.BGGradBot = Color.DarkRed;
                pinStatusButton.BGGradTop = Color.Red;
                pinStatusButton.TextColor = Color.White;

            }


        }

        public void updatePayloads(List<Payload> p )
        {
            payloadsetup1.updateAll(p);
        }


        public void refreshPayloads()
        {
            payloadsetup1.redrawControls();
        }


        private void payloadsetup1_igniteClicked(object sender, EventArgs e)
        {


            plStat = payloadsetup1.payloadSetup;

            refreshPayloads();
            payloadsetup1.Enabled = false;
            OnUpdateClicked(EventArgs.Empty);

        }

        private void payloadSetupButton_Click(object sender, EventArgs e)
        {

            if (!MainV2.comPort.MAV.cs.armed)
            {
                payloadsetup1.Enabled = true;
            }
            else
            {
                CustomMessageBox.Show("Only before flight! ", "Payload", MessageBoxButtons.OK);
            }
        }
    }
}

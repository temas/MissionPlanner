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
    public partial class payloadStatusForm : Form
    {
        public payloadStatusForm()
        {
            InitializeComponent();
            setSafetyPinStatus(false);
            payloadsetup1.refreshControls();
            payloadsetup1.Enabled = false;
            payloadsetup1.Refresh();
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

        public void refreshPayloads()
        {
            payloadsetup1.refreshControls();
        }


        private void payloadsetup1_igniteClicked(object sender, EventArgs e)
        {
            //Process payload
            refreshPayloads();
            payloadsetup1.Enabled = false;



        }

        private void payloadSetupButton_Click(object sender, EventArgs e)
        {
            payloadsetup1.Enabled = true;
        }
    }
}

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
    public partial class preflightForm : Form
    {

        public event EventHandler controlStatusUpdated;

        public preflightForm()
        {


            InitializeComponent();
            preflightCheckControl1.noimage = MissionPlanner.Properties.Resources.noimage;
            preflightCheckControl1.ready = MissionPlanner.Properties.Resources.ready;
            preflightCheckControl1.notready = MissionPlanner.Properties.Resources.notready;
            preflightCheckControl1.displayStep(MissionPlanner.Controls.PreflightList.currentStep);

        }

        private void preflightCheckControl1_statusUpdated(object sender, EventArgs e)
        {

            EventHandler handler = this.controlStatusUpdated;
            if (handler != null)
            {
                handler(this, e);
            }


        }
    }
}

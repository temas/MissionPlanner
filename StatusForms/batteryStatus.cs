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
    public partial class batteryStatusForm : Form
    {
        public batteryStatusForm()
        {
            InitializeComponent();
        }


        public void updateBatteryStatusForm( double battVolts, double ctrBattPercent)
        {
            battGauge.Cap_Idx = 1;
            battGauge.CapText = battVolts.ToString("F1") + " volt";
            if (battVolts < 12) battVolts = 12;
            battGauge.Value0 = (float)battVolts;
            ctrPultGauge.Value0 = (float)ctrBattPercent * 100;

        }


    }
}

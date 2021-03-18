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

namespace MissionPlanner.StatusForms
{


    public enum StartItem
    {
        catapultAllocated = 0,
        catapultReady,
        aircraftArmed,
        takeoffMode,
        fullThrottle
    }


    public partial class startProcessForm : Form
    {

        public bool bCatAllocated = false;
        public bool bCatReady = false;
        public bool bArmed = false;
        public bool bTakeoff = false;
        public bool bFullThrottle = false;

        public bool bExternal = false;

        public startProcessForm()
        {
            InitializeComponent();
            setColor(btnCatAllocated, bCatAllocated);
            setColor(btnCatReady, bCatReady);
            setColor(btnArmed, bArmed);
            setColor(btnTakeoff, bTakeoff);
            setColor(btnFullThrottle, bFullThrottle);

            btnStart.Enabled = false;
            btnExecute.Enabled = false;

        }

        private void setColor(myButtonNoTheme b, bool state)
        {
            if (state)
            {
                b.BGGradBot = Color.LawnGreen;
                b.BGGradTop = Color.LawnGreen;
            }
            else
            {
                b.BGGradBot = Color.Red;
                b.BGGradTop = Color.Red;
            }
        }

        public void setItem(StartItem i, bool b)
        {
            switch (i)
            {
                case StartItem.catapultAllocated:
                    setColor(btnCatAllocated, b);
                    bCatAllocated = b;
                    break;
                case StartItem.catapultReady:
                    setColor(btnCatReady, b);
                    bCatReady = b;
                    break;
                case StartItem.aircraftArmed:
                    setColor(btnArmed, b);
                    bArmed = b;
                    break;
                case StartItem.takeoffMode:
                    setColor(btnTakeoff, b);
                    bTakeoff = b;
                    break;
                case StartItem.fullThrottle:
                    setColor(btnFullThrottle, b);
                    bFullThrottle = b;
                    break;
                default:
                    break;
            }

            if (bCatAllocated && bCatReady && bArmed && bTakeoff && bFullThrottle && bExternal)
            {
                btnStart.Enabled = true;
                btnExecute.Enabled = false;
            }
            else
            {
                btnStart.Enabled = false;
                btnExecute.Enabled = false;

            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.BGGradBot == Color.LawnGreen)
            {
                btnExecute.Enabled = false;
                btnStart.BGGradBot = Color.DarkSlateGray;
                btnStart.BGGradTop = Color.DarkSlateGray;
                btnExecute.BGGradTop = Color.DarkSlateGray;
                btnExecute.BGGradBot = Color.DarkSlateGray;
            }
            else
            {
                setColor(btnStart, true);
                btnExecute.Enabled = true;
                setColor(btnExecute, false);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {





        }
    }
}

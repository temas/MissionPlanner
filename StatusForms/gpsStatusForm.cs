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
    public partial class gpsStatusForm : Form
    {
        public gpsStatusForm()
        {
            InitializeComponent();
        }


        public void addText(string t)
        {
            textBox1.Text += t + "\r\n";
        }

        public void clearText()
        {
            textBox1.Text = "";
        }

    }
}

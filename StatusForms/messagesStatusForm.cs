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
    public partial class messagesStatusForm : Form
    {
        public messagesStatusForm()
        {
            InitializeComponent();
        }

        public void addText(string text)
        {
            txtMessagebox.Text = text;
        }


    }
}

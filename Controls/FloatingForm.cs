using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class FloatingForm : Form
    {
        public FloatingForm()
        {
            //InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable; // get rid of the standard title bar
            this.ShowInTaskbar = false;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Rectangle rc = new Rectangle(this.ClientSize.Width - _cGrip, this.ClientSize.Height - _cGrip, _cGrip, _cGrip);
        //    ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        //    this.title.Size = new Size(this.Width - 90, _cCaption - 4);
        //    //rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
        //    //e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        //}

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.Style &= ~0xC00000; //WS_CAPTION;
        //        return cp;
        //    }
        //}

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {  // Trap WM_NCHITTEST
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);

        //        if (pos.Y < _cCaption)
        //        {
        //            m.Result = (IntPtr)2;  // HTCAPTION
        //            return;
        //        }

        //        if (pos.X >= this.ClientSize.Width - _cGrip && pos.Y >= this.ClientSize.Height - _cGrip)
        //        {
        //            m.Result = (IntPtr)17; // HTBOTTOMRIGHT
        //            return;
        //        }
        //        if (pos.Y >= this.ClientSize.Height - 5)
        //        {
        //            m.Result = (IntPtr)15;
        //            return;
        //        }
        //        if (pos.X <= 5)
        //        {
        //            m.Result = (IntPtr)10;
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - 5)
        //        {
        //            m.Result = (IntPtr)11;
        //            return;
        //        }

        //    }
        //    base.WndProc(ref m);
        //}

    }   // end of the class
}

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
        private PictureBox titleBar = new PictureBox(); // create a PictureBox
        private PictureBox maximise = new PictureBox(); // this will simulate our this.maximise box
        private PictureBox close = new PictureBox(); // simulates the this.close box
        private Label title = new Label();

        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0); // also for the moving

        private int _cGrip = 16;      // Grip size
        private int _cCaption = 24;   // Caption bar height;


        public int captionSize
        {
            get { return _cCaption; }
            set { _cCaption = value; }
        }

        private string _caption;

        public string Caption
        {
            get { return _caption; }
            set
            {
                _caption = value;
                this.title.Text = _caption;
            }
        }

        private Color _captionColor;

        public Color CaptionColor
        {
            get { return _captionColor; }
            set
            {
                _captionColor = value;
                this.title.ForeColor = _captionColor;
            }
        }

        private Color _captionBackColor;

        public Color CaptionBackColor
        {
            get { return _captionBackColor; }
            set
            {
                _captionBackColor = value;
                this.titleBar.BackColor = _captionBackColor;
                this.title.BackColor = _captionBackColor;
            }
        }



        public FloatingForm()
        {
            //InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // get rid of the standard title bar
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            this.titleBar.Location = this.Location; // assign the location to the form location
            this.titleBar.Width = this.Width; // make it the same width as the form
            this.titleBar.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            this.titleBar.Height = _cCaption; // give it a default height (you may want it taller/shorter)
            this.titleBar.BackColor = Color.Black; // give it a default colour (or load an image)
            this.Controls.Add(this.titleBar); // add it to the form's controls, so it gets displayed
                                              // if you have an image to display, you can load it, instead of assigning a bg colour
                                              // this.title.Image = new Bitmap(System.Environment.CurrentDirectory + "\\title.jpg");
                                              // if you displayed an image, alter the SizeMode to get it to display as you want it to
                                              // examples:
                                              // this.title.SizeMode = PictureBoxSizeMode.StretchImage;
                                              // this.title.SizeMode = PictureBoxSizeMode.CenterImage;
                                              // this.title.SizeMode = PictureBoxSizeMode.Zoom;
                                              // etc

            this.title.Location = new Point(this.Location.X + 5, this.Location.Y);
            this.title.Padding = new Padding(0, 0, 0, 0);
            this.title.Size = new Size(this.Width - 100, _cCaption - 4);
            this.title.ForeColor = Color.White;
            this.title.BackColor = Color.Black;
            this.title.Font = new Font("Ariel", _cCaption - 8, FontStyle.Bold, GraphicsUnit.Pixel);
            this.titleBar.Controls.Add(this.title);
            this.title.BringToFront();


            this.close.Location = new Point(this.Location.X + this.Width - 45, this.Location.Y + (_cCaption - 20) / 2); // give it a default location
            this.close.BackColor = Color.Black; // make it the same as the PictureBox
            this.close.Image = new Bitmap(System.Environment.CurrentDirectory + "\\close.png");
            this.close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.close.Size = new Size(20, 20);
            this.close.BackColor = Color.Transparent;
            this.titleBar.Controls.Add(this.close); // add it to the form's controls
            this.close.BringToFront(); // bring it to the front, to display it above the picture box


            this.maximise.Location = new Point(this.Location.X + this.Width - 85, this.Location.Y + (_cCaption - 20) / 2);
            this.maximise.BackColor = Color.Black; // remember, we want it to match the background
            this.maximise.Image = new Bitmap(System.Environment.CurrentDirectory + "\\maximalise.png");
            this.maximise.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.maximise.Size = new Size(20, 20);
            this.maximise.BackColor = Color.Transparent;
            this.titleBar.Controls.Add(this.maximise); // add it to the form
            this.maximise.BringToFront();

            // now we need to add some functionality. First off, let's give those labels
            // MouseHover and MouseLeave events, so they change colour
            // Since they're all going to change to the same colour, we can give them the same
            // event handler, which saves time of writing out all those extra functions
            this.maximise.MouseEnter += new EventHandler(Control_MouseEnter);
            this.close.MouseEnter += new EventHandler(Control_MouseEnter);

            // and we need to do the same for MouseLeave events, to change it back
            this.maximise.MouseLeave += new EventHandler(Control_MouseLeave);
            this.close.MouseLeave += new EventHandler(Control_MouseLeave);

            // and lastly, for these controls, we need to add some functionality
            this.maximise.MouseClick += new MouseEventHandler(Control_MouseClick);
            this.close.MouseClick += new MouseEventHandler(Control_MouseClick);

            // finally, wouldn't it be nice to get some moveability on this control?
            this.titleBar.MouseDown += new MouseEventHandler(Title_MouseDown);
            this.titleBar.MouseUp += new MouseEventHandler(Title_MouseUp);
            this.titleBar.MouseMove += new MouseEventHandler(Title_MouseMove);

            this.title.MouseDown += new MouseEventHandler(Title_MouseDown);
            this.title.MouseUp += new MouseEventHandler(Title_MouseUp);
            this.title.MouseMove += new MouseEventHandler(Title_MouseMove);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - _cGrip, this.ClientSize.Height - _cGrip, _cGrip, _cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            this.title.Size = new Size(this.Width - 90, _cCaption - 4);
            //rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            //e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < _cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - _cGrip && pos.Y >= this.ClientSize.Height - _cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            if (sender.Equals(this.close))
                this.close.BackColor = Color.Gray;
            else if (sender.Equals(this.maximise))
                this.maximise.BackColor = Color.Gray;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        { // return them to their default colours
            if (sender.Equals(this.close))
                this.close.BackColor = Color.Transparent;
            else if (sender.Equals(this.maximise))
                this.maximise.BackColor = Color.Transparent;
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.Equals(this.close))
                this.Close(); // close the form
            else if (sender.Equals(this.maximise))
            { // maximise is more interesting. We need to give it different functionality,
              // depending on the window state (Maximise/Restore)
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized; // maximise the form
                    this.maximise.Image = new Bitmap(System.Environment.CurrentDirectory + "\\restore.png");
                }
                else // we need to restore
                {
                    this.WindowState = FormWindowState.Normal;
                    this.maximise.Image = new Bitmap(System.Environment.CurrentDirectory + "\\maximalise.png");
                }
            }
        }

        void Title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        void Title_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }
        void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            { // if we should be dragging it, we need to figure out some movement
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }
    }   // end of the class
}

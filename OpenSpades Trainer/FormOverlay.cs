using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSpades_Trainer
{
    public partial class FormOverlay : Form
    {

        Graphics g;
        Pen myPen = new Pen(Color.Red);

        public const string gamename = "OpenSpades 0.1.3 MSVC 19.12.25831.0";

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr window, int index);
        IntPtr handle = FindWindowByCaption(IntPtr.Zero, gamename);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        public struct RECT
        {
            public int left, top, right, bottom;
        }

        public FormOverlay()
        {
            InitializeComponent();
        }

        private void FormOverlay_Load(object sender, EventArgs e)
        {

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);

            RECT outrect;
            GetWindowRect(handle, out outrect);

           this.Size = new Size(outrect.right - outrect.left, outrect.bottom - outrect.top);

            this.Top = outrect.top;
            this.Left = outrect.left;

           // this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.Black;
            this.TransparencyKey = System.Drawing.Color.Black;

            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            this.TopMost = true;

           MainForm.CheckForIllegalCrossThreadCalls = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr curhandle = GetForegroundWindow();
            RECT outrect;
            GetWindowRect(handle, out outrect);
            this.Size = new Size(outrect.right - outrect.left, outrect.bottom - outrect.top);
            this.Top = outrect.top;
            this.Left = outrect.left;
        }

        private void FormOverlay_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            //g.DrawRectangle(myPen, 10, 10, 100, 100);
            //g.DrawEllipse(myPen, 10, 10, 100, 100);
        }
    }
}

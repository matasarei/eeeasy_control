using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace EeeasyControl
{
    public partial class Main : Form
    {
        int _timeToClose = 10;
        bool _doNotClose = false;

        Point _startposition;

        List<PictureBox> Level1;
        List<PictureBox> Level2;

        public Main()
        {
            InitializeComponent();

            Point XMousePosition = new Point(Cursor.Position.X - this.Width / 2);
            if (XMousePosition.X < 0)
                XMousePosition.X = 0;
            if (XMousePosition.X + this.Width > Screen.PrimaryScreen.WorkingArea.Width)
                XMousePosition.X = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            _startposition = new Point(XMousePosition.X, (Screen.PrimaryScreen.WorkingArea.Bottom - this.Height));
            this.Location = _startposition;

            Level1 = new List<PictureBox>();
            Level1.Add(StartPic);
            Level1.Add(CBarPic);
            Level1.Add(ApplicationsPic);
            Level1.Add(CSEPic);
            Level1.Add(MorePic);

            Level2 = new List<PictureBox>();
            Level2.Add(ControlPic);
            Level2.Add(Rotate180);
            Level2.Add(Rotate240);
            Level2.Add(Rotate90);
            Level2.Add(RotateNorm);
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartPic_Click(object sender, EventArgs e)
        {
            HCUser32Tools.PressKey(0x5B);
            Application.Exit();
        }

        private void CBarPic_Click(object sender, EventArgs e)
        {
            HCUser32Tools.PressKeys(0x5B, 0x43);
            Application.Exit();
        }

        private void ApplicationsPic_Click(object sender, EventArgs e)
        {
            HCUser32Tools.PressKeys(0x5B, 0x51);
            Application.Exit();
        }

        private void CSEPic_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
            Application.Exit();
        }

        private void MorePic_Click(object sender, EventArgs e)
        {
            this.Height = 200;
            this.Location = new Point(_startposition.X, (Screen.PrimaryScreen.WorkingArea.Bottom - this.Height));
            MorePic.Visible = false;

            foreach (PictureBox Pic in Level1)
            {
                Pic.Location = new Point(Pic.Location.X, Pic.Location.Y + 100);
            }

            foreach (PictureBox Pic in Level2)
            {
                Pic.Visible = true;
            }
        }

        private void ControlPic_Click(object sender, EventArgs e)
        {
            Process.Start("control");
            Application.Exit();
        }

        private void Rotate90_Click(object sender, EventArgs e)
        {
            HCUser32Tools Tools = new HCUser32Tools();
            Tools.SetScreenOrientation(HCUser32Tools.ScreenOpientations.Orientation90);
            Application.Exit();
        }

        private void RotateNorm_Click(object sender, EventArgs e)
        {
            HCUser32Tools Tools = new HCUser32Tools();
            Tools.SetScreenOrientation(HCUser32Tools.ScreenOpientations.Default);
            Application.Exit();
        }

        private void Rotate240_Click(object sender, EventArgs e)
        {
            HCUser32Tools Tools = new HCUser32Tools();
            Tools.SetScreenOrientation(HCUser32Tools.ScreenOpientations.Orientation240);
            Application.Exit();
        }

        private void Rotate180_Click(object sender, EventArgs e)
        {
            HCUser32Tools Tools = new HCUser32Tools();
            Tools.SetScreenOrientation(HCUser32Tools.ScreenOpientations.Orientation180);
            Application.Exit();
        }

        private void LogoPic_Click(object sender, EventArgs e)
        {
            _doNotClose = true;
            About Dialog = new About();
            Dialog.ShowDialog();
            _timeToClose = 10;
            _doNotClose = false;
        }

        private void Main_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClosingTimer_Tick(object sender, EventArgs e)
        {
            _timeToClose--;
            if (_timeToClose < 0 && !_doNotClose)
                Application.Exit();
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            _timeToClose = 10;
        }

        private void Main_MouseLeave(object sender, EventArgs e)
        {
            _timeToClose -= 9;
        }
    }
}

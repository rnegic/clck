using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AutoClickerNew
{
    public partial class FormAutoClicker : Form
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public FormAutoClicker()
        {
            InitializeComponent();
        }

        private void AutoClicker_Tick(object sender, EventArgs e)
        {
            if(!Bounds.Contains(PointToClient(MousePosition)))
            {
                mouse_event(0x02, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(10);
                mouse_event(0x04, 0, 0, 0, 0);
            }
        }

        private void StartAutoClick()
        {
            AutoClicker.Interval = (int)(1000.0 / trackBar.Value);
            AutoClicker.Start();
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void StopAutoClick()
        {
            AutoClicker.Stop();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartAutoClick();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopAutoClick();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            trackBarText.Text = trackBar.Value.ToString();
        }

    }
}

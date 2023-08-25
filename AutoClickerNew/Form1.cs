using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AutoClickerNew
{
    public partial class FormAutoClicker : Form
    {
        bool isAutoClicking = false;

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr hookId = IntPtr.Zero;
        private LowLevelKeyboardProc keyboardProcDelegate;
        public FormAutoClicker()
        {
            InitializeComponent();
            keyboardProcDelegate = HookCallback;
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr IParam)
        {
            if(nCode == 0 && (wParam == (IntPtr)0x0100) || wParam == (IntPtr)0x0101)
            {
                if(Marshal.ReadInt32(IParam) == 0x046 && wParam == (IntPtr)0x0100)
                {
                    if(true)
                    {
                        if(!isAutoClicking)
                        {
                            StartAutoClick();
                        }

                        else if(isAutoClicking)
                        {
                            StopAutoClick();
                        }
                    }
                }
            }

            return CallNextHookEx(IntPtr.Zero, nCode, wParam, IParam);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            hookId = SetHook(keyboardProcDelegate);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            UnhookWindowsHookEx(hookId);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(13, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        //таймер
        private void AutoClicker_Tick(object sender, EventArgs e)
        {
                //нажатие
                mouse_event(0x02, 0, 0, 0, 0);
                //отпускание
                mouse_event(0x04, 0, 0, 0, 0);
        }

        private void StartAutoClick()
        {
            if (!isAutoClicking)
            {
                //чем больше значение ползунка, тем меньше интервал между кликами.
                AutoClicker.Interval = (int)(1000.0 / trackBar.Value);
                AutoClicker.Start();
                isAutoClicking = true;
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
            }
        }

        private void StopAutoClick()
        {
            if(isAutoClicking)
            {
                AutoClicker.Stop();
                isAutoClicking=false;
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
            }
            
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

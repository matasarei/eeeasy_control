using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace EeeasyControl
{
    public static class HCUser32KeyPress
    {
        //keybd_event
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public static void PressKey(byte KEY)
        {
            keybd_event(KEY, 0, 0, 0);
            keybd_event(KEY, 0, 0x2, 0);
        }

        public static void PressKeys(byte KEY1, byte KEY2)
        {
            keybd_event(KEY1, 0, 0, 0);
            keybd_event(KEY2, 0, 0, 0);
            keybd_event(KEY1, 0, 0x2, 0);
            keybd_event(KEY2, 0, 0x2, 0);
        }

        public static void PressKeys(byte KEY1, byte KEY2, byte KEY3)
        {
            keybd_event(KEY1, 0, 0, 0);
            keybd_event(KEY2, 0, 0, 0);
            keybd_event(KEY3, 0, 0, 0);
            keybd_event(KEY3, 0, 0x2, 0);
            keybd_event(KEY2, 0, 0x2, 0);
            keybd_event(KEY1, 0, 0x2, 0);
        }

        public static void PressKeys(byte KEY1, byte KEY2, byte KEY3, byte KEY4)
        {
            keybd_event(KEY1, 0, 0, 0);
            keybd_event(KEY2, 0, 0, 0);
            keybd_event(KEY3, 0, 0, 0);
            keybd_event(KEY4, 0, 0, 0);
            keybd_event(KEY1, 0, 0x2, 0);
            keybd_event(KEY2, 0, 0x2, 0);
            keybd_event(KEY3, 0, 0x2, 0);
            keybd_event(KEY4, 0, 0x2, 0);
        }
    }
}

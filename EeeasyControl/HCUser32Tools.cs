using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace EeeasyControl
{
    /// <summary>
    /// Инструменты для работы с User32
    /// </summary>
    public class HCUser32Tools
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        /// <summary>
        /// Программное нажатие клавиши
        /// </summary>
        /// <param name="KEY">Код клавиши</param>
        public static void PressKey(byte KEY)
        {
            keybd_event(KEY, 0, 0, 0);
            keybd_event(KEY, 0, 0x2, 0);
        }

        /// <summary>
        /// Программное нажатие нескольких кнопок
        /// </summary>
        /// <param name="KEY1">Код первой клавиши</param>
        /// <param name="KEY2">Код второй клавиши</param>
        public static void PressKeys(byte KEY1, byte KEY2)
        {
            keybd_event(KEY1, 0, 0, 0);
            keybd_event(KEY2, 0, 0, 0);
            keybd_event(KEY1, 0, 0x2, 0);
            keybd_event(KEY2, 0, 0x2, 0);
        }

        /// <summary>
        /// Программное нажатие нескольких кнопок
        /// </summary>
        /// <param name="KEY3">Код третей клавиши</param>
        public static void PressKeys(byte KEY1, byte KEY2, byte KEY3)
        {
            keybd_event(KEY1, 0, 0, 0);
            keybd_event(KEY2, 0, 0, 0);
            keybd_event(KEY3, 0, 0, 0);
            keybd_event(KEY3, 0, 0x2, 0);
            keybd_event(KEY2, 0, 0x2, 0);
            keybd_event(KEY1, 0, 0x2, 0);
        }

        /// <summary>
        /// Программное нажатие нескольких кнопок
        /// </summary>
        /// <param name="KEY4">Код четвертой клавиши</param>
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

        /// <summary>
        /// Перечисление ориентаций экрана
        /// </summary>
        public enum ScreenOpientations { Default = 0, Orientation90 = 1, Orientation180 = 2, Orientation240 = 3 };

        /// <summary>
        /// Изменяет ориентацию экрана
        /// </summary>
        /// <param name="orientation">Использует перечисление ориентаций описанное в классе</param>
        public void SetScreenOrientation(ScreenOpientations orientation)
        {
            DEVMODE dm = NativeMethods.CreateDevmode();
            GetSettings(ref dm);
            SwapDisplaySize(ref dm.dmPelsHeight, ref dm.dmPelsWidth, orientation);
            dm.dmDisplayOrientation = (int)orientation;
            int iRet = NativeMethods.ChangeDisplaySettings(ref dm, 0);
        }

        /// <summary>
        /// Переворачивает разришение экрана
        /// </summary>
        /// <param name="height">По высоте</param>
        /// <param name="wight">По ширине</param>
        /// <param name="orientation">Использует перечисление ориентаций описанное в классе</param>
        private void SwapDisplaySize(ref int height, ref int wight, ScreenOpientations orientation)
        {
            if (height < wight && (int)orientation % 2 != 0)
            {
                int temp = height;
                height = wight;
                wight = temp;
                return;
            }
            else if (height > wight && (int)orientation % 2 == 0)
            {
                int temp = height;
                height = wight;
                wight = temp;
                return;
            }
        }

        /// <summary>
        /// Импортиваронный метод из кода microsoft
        /// </summary>
        /// <param name="dm"></param>
        /// <returns></returns>
        private int GetSettings(ref DEVMODE dm)
        {
            // helper to obtain current settings
            return GetSettings(ref dm, NativeMethods.ENUM_CURRENT_SETTINGS);
        }

        /// <summary>
        /// Импортиваронный метод из кода microsoft
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="iModeNum"></param>
        /// <returns></returns>
        private int GetSettings(ref DEVMODE dm, int iModeNum)
        {
            // helper to wrap EnumDisplaySettings Win32 API
            return NativeMethods.EnumDisplaySettings(null, iModeNum, ref dm);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ini;
using System.Collections;
using System.IO;
using System.Threading;
using System.Net;
using System.Management;
using LoLLauncher;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
using System.Management.Instrumentation;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Timers;

namespace RitoBot
{
    class function_add
    {
        public class ClickOnPointTool
        {

            [DllImport("user32.dll")]
            static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

            [DllImport("user32.dll")]
            internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

#pragma warning disable 649
            internal struct INPUT
            {
                public UInt32 Type;
                public MOUSEKEYBDHARDWAREINPUT Data;
            }

            [StructLayout(LayoutKind.Explicit)]
            internal struct MOUSEKEYBDHARDWAREINPUT
            {
                [FieldOffset(0)]
                public MOUSEINPUT Mouse;
            }

            internal struct MOUSEINPUT
            {
                public Int32 X;
                public Int32 Y;
                public UInt32 MouseData;
                public UInt32 Flags;
                public UInt32 Time;
                public IntPtr ExtraInfo;
            }

#pragma warning restore 649


            public static void ClickOnPoint(IntPtr wndHandle, Point clientPoint)
            {
                var oldPos = Cursor.Position;

                /// get screen coordinates
                ClientToScreen(wndHandle, ref clientPoint);

                /// set cursor on coords, and press mouse
                Cursor.Position = new Point(clientPoint.X, clientPoint.Y);

                var inputMouseDown = new INPUT();
                inputMouseDown.Type = 0; /// input type mouse
                inputMouseDown.Data.Mouse.Flags = 0x0002; /// left button down

                var inputMouseUp = new INPUT();
                inputMouseUp.Type = 0; /// input type mouse
                inputMouseUp.Data.Mouse.Flags = 0x0004; /// left button up

                var inputs = new INPUT[] { inputMouseDown, inputMouseUp };
                SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

                /// return mouse 
                Cursor.Position = oldPos;
            }

        }

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);

        private static void updateStatus(string status)
        {
            Program.MainWindow.Print(string.Concat(new object[4]
              {     
                (object) "[",
                (object) DateTime.Now,
                (object) "] ",     
                (object) status
              }));
        }


        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        public static void hide_lol()
        {
            int hWnd;
            Process[] processRlol = Process.GetProcesses();
            foreach (Process pr in processRlol)
            {
                if (pr.ProcessName == "LolClient")
                {
                    hWnd = pr.MainWindowHandle.ToInt32();
                    ShowWindow(hWnd, 6);
                }

            }
        }
        public static void show_lol()
        {
            int hWnd;
            Process[] processRlol = Process.GetProcesses();
            foreach (Process pr in processRlol)
            {
                if (pr.ProcessName == "LolClient")
                {
                    hWnd = pr.MainWindowHandle.ToInt32();
                    ShowWindow(hWnd, 11);
                }

            }
        }

        public static int start_lol()
        {
            Process[] processRlol = Process.GetProcesses();
            foreach (Process pr in processRlol)
            {
                if (pr.ProcessName == "lol")
                {
                    pr.Kill(); 
                }

            }

            int hWnd;
            Boolean check = false;
            Process[] processRunning = Process.GetProcesses();
            foreach (Process pr in processRunning)
            {
                if (pr.ProcessName == "GarenaMessenger")
                {
                    try
                    {

                        hWnd = pr.MainWindowHandle.ToInt32();
                        
                        ShowWindow(hWnd, 1);
                       
                        Thread.Sleep(1000);
                        MoveWindow(pr.MainWindowHandle, 0, 0, 365, 685, true);
                        Thread.Sleep(1000);
                        Cursor.Position = new Point(30, 306);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                        updateStatus("Click LOL ");
                        MoveWindow(pr.MainWindowHandle, 0, 0, 365, 685, true);

                       
                        Cursor.Position = new Point(700, 600);
                        Thread.Sleep(2000);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                        updateStatus("Click bắt đầu ");
                       
                        // ShowWindow(hWnd, 3);
                        check = true;
                    }
                    catch (Exception)
                    {
                        throw;
                       
                    }

                }
            }
            if (check)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        public static void khoidonglai_LOL()
        {
            if (start_lol() == 1)
            {
                Thread.Sleep(5000);
                Boolean check = false;
                Process[] processRunning = Process.GetProcesses();
                foreach (Process pr in processRunning)
                {
                    if (pr.ProcessName == "lol")
                    {
                        check = true;
                    }

                }
                if (check)
                {
                    updateStatus(" Khởi động file lol.exe thành công rực rỡ  ");
                    updateStatus(" Lấy thành công mã Token . Quẩy cmn luông :) ");
                    Program.MainWindow.update_token(true);
                    Program.loadAccounts();
                    Program.MainWindow.queueLoop();
  
                }
                else
                {
                   khoidonglai_LOL();
                }
            }
            else
            {
                updateStatus(" Not ok ");
              
            }
        }
        static System.Timers.Timer timer = new System.Timers.Timer();
        public static void sys_check_lol_5p(int phut=5) {
            updateStatus("Đã bật auto check !");
            updateStatus("Chú ý : bị hàng chờ thì không nên bật auto check nhé !");
            timer.Elapsed += new System.Timers.ElapsedEventHandler(check_lol_5p);
            timer.Interval = 1000 * 60 * phut; // 5 phút
            timer.Start();
        }
        static void check_lol_5p(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();
            Boolean check = false;
            Process[] processRunning = Process.GetProcesses();
            foreach (Process pr in processRunning)
            {
                if (pr.ProcessName == "League of Legends")
                {
                    check = true;
                }

            }
            if (check)
            {
                updateStatus("Update Check : ");
                updateStatus("Tìm thấy chương trình League of Legends.exe!"); ;
            }else{
                updateStatus("Update Check : ");
                updateStatus("Không tìm thấy chương trình League of Legends.exe . Khởi độnglại game nào !");
                khoidonglai_LOL();
            }

            timer.Start();
        }
    
        
       


    }
}

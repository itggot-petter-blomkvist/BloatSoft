using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace BloatSoft
{
    class Program
    {
        //Future :)

            //hahahahah
        //Lol

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        //XD







        static void Main(string[] args)
        {
            Console.WriteLine("Installing Windows updates...");
            Thread.Sleep(300);
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            MessageBox.Show("fem");
            

        }
    }
}

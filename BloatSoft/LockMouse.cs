using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BloatSoft
{
    public class LockMouse
    {
        static bool isLocked = true;

        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("User32.Dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }

        public static void move()
        {
            Random rand = new Random();
            while (true) {
                if (isLocked)
                {
                    double xv = (double)(Math.Cos((double)(DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) / 50.0) * 5) + rand.NextDouble()*20-10;
                    double yv = (double)(Math.Sin((double)(DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) / 50.0) * 5) + rand.NextDouble()*20-10;
                    SetCursorPos(Cursor.Position.X + (int)(xv), Cursor.Position.Y + (int)(yv));
                }
                Thread.Sleep(5);
            }
        }
    }
}

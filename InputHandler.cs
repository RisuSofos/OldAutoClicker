using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClicker
{
    public class InputHandler
    {
        [Flags]
        public enum MouseEvents
        {
            Move = 0x00000001,
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            RightDown = 0x00000008,
            RightUp = 0x00000010,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Absolute = 0x00008000
        }
        

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //private static extern void ();
        //keyboard hooks need some research

        public static void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        public static void SetCursorPosition(MousePoint point)
        {
            SetCursorPos(point.X, point.Y);
        }

        public static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        public static void MouseEvent(MouseEvents value)
        {
            MousePoint position = GetCursorPosition();

            mouse_event
                ((int)value,
                 position.X,
                 position.Y,
                 0,
                 0)
                ;
        }

        public static void KeyDownEvent()
        {
            
        }

        public static void KeyUpEvent()
        {

        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public static void Event_KeyDown(object sender, KeyEventArgs e)
        {
            Menu._args = new string[] { $"{e.KeyCode}", $"{e.KeyValue}", $"{e.Modifiers}" };
        }
    }
}

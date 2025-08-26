using System.Runtime.InteropServices;
using static SimplyClick.Handlers.Autoclick;

namespace SimplyClick.Utils
{
    internal class Mouse
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        // Mouse event flags
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        internal static void MouseClick()
        {
            Point cursorPosition = Cursor.Position;

            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)cursorPosition.X, (uint)cursorPosition.Y, 0, UIntPtr.Zero);

            Wait(ACData.pressDownForTime);

            mouse_event(MOUSEEVENTF_LEFTUP, (uint)cursorPosition.X, (uint)cursorPosition.Y, 0, UIntPtr.Zero);
        }
    }
}

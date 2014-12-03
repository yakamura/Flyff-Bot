using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace macro
{
    class Macro
    {
        [DllImport("PMX.dll")]
        private static extern bool PostMessageX(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        List<uint> delay = new List<uint>();
        IntPtr WindowHandle;
        List<uint> keys = new List<uint>();

        public Macro(IntPtr _WindowHandle, List<uint> _keys, List<uint> _delay)
        {
            delay = _delay;
            WindowHandle = _WindowHandle;
            keys = _keys;
        }

        public void MacroStart()
        {
            int x = 0;
            foreach(uint keycode in keys)
            {
                PostMessageX(WindowHandle, 0x100, keycode, 0);
                System.Threading.Thread.Sleep(Convert.ToInt32(delay[x]));
                x++;
            }
        }
    }
}

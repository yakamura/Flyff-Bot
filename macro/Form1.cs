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
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);
        [DllImport("User32")] 
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(uint vKey);
        [DllImport("kernel32.dll")]
        public static extern bool Beep(UInt32 frequency, UInt32 duration);

        IntPtr windowhandle = (IntPtr)0;
        string programName = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            programName = this.Text;
        }
        private void btnLockOn_Click(object sender, EventArgs e)
        {
            if (btnLockOn.Text != "Release")
            {
                if (FindWindow(null, boxWindowTitle.Text) != (IntPtr)0)
                {
                    windowhandle = FindWindow(null, boxWindowTitle.Text);
                    btnLockOn.Text = "Release";
                }
            }
            else
            {
                windowhandle = (IntPtr)0;
                btnLockOn.Text = "Lock on";
            }
        }

        private void boxWindowTitle_TextChanged(object sender, EventArgs e)
        {
            if (boxWindowTitle.Text.Length > 0)
            {
                SetWindowText(windowhandle, boxWindowTitle.Text);
                this.Text = programName + " - " + boxWindowTitle.Text;
            }
            else
                this.Text = programName;
        }

        private void btnHideWindow_Click(object sender, EventArgs e)
        {
            ShowWindow((int)windowhandle, 0);
        }

        private void btnShowWindow_Click(object sender, EventArgs e)
        {
            ShowWindow((int)windowhandle, 5);
        }

        private void HotKeyPress(uint hotkey, ref bool repeat, ref CheckBox chkStart, ref BackgroundWorker worker)
        {
            int state = Convert.ToInt32(GetAsyncKeyState(hotkey).ToString());

            if (state == -32767)
            {
                if (sound2)
                    Beep(300000, 1000);
                if (!repeat)
                {
                    if (chkStart.Checked)
                        repeat = true;
                    else
                        repeat = false;
                    try
                    {
                        worker.RunWorkerAsync();
                    }
                    catch { }
                }
                else
                    repeat = false;
            }

        }

        private void GetKeyCode(KeyEventArgs e, ref TextBox boxMacro, int delay, ref List<uint> keys, ref List<uint> delays)
        {
            try
            {
            delays.Add(Convert.ToUInt32(delay));
            keys.Add(Convert.ToUInt32(e.KeyCode));
            boxMacro.Text += e.KeyCode + "(" + delay + ")  ";
            }
            catch
            { MessageBox.Show("Only numbers are allowed in the delay box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void AddDelay(ref TextBox boxMacro, ref TextBox boxDelay, ref List<uint> keys, ref List<uint> delays)
        {
            try
            {
                delays.Add(Convert.ToUInt32(boxDelay.Text));
                keys.Add(Convert.ToUInt32(null));
                boxMacro.Text += "Delay(" + boxDelay.Text + ")  ";
            }
            catch
            { MessageBox.Show("Only numbers are allowed in the delay box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            
        }

        #region bot1
        List<uint> keys1 = new List<uint>();
        List<uint> delays1 = new List<uint>();

        private void boxMacro1_KeyDown(object sender, KeyEventArgs e)
        {
            GetKeyCode(e, ref boxMacro1, int.Parse(boxDelay1.Text), ref keys1, ref delays1);
            e.SuppressKeyPress = true;
        }

        private void lblDelay1_Click(object sender, EventArgs e)
        {
            AddDelay(ref boxMacro1, ref boxDelay1, ref keys1, ref delays1);
        }

        private void btnClearMacro1_Click(object sender, EventArgs e)
        {
            boxMacro1.Text = "";
            keys1 = new List<uint>();
            delays1 = new List<uint>();
        }

        bool repeat1 = false;
        private void back1_DoWork(object sender, DoWorkEventArgs e)
        {
            Macro macro = new Macro(windowhandle, keys1, delays1);
            do
            {
                macro.MacroStart();
            }
            while (repeat1);
        }

        private void btnStartMacro1_Click(object sender, EventArgs e)
        {
            if (!repeat1)
            {
                repeat1 = true;
                try
                {
                    back1.RunWorkerAsync();
                }
                catch { }
            }
            else
                repeat1 = false;
        }

        uint hotkey1;
        private void boxHotKey1_KeyDown(object sender, KeyEventArgs e)
        {
            boxHotKey1.Text = e.KeyCode.ToString();
            hotkey1 = Convert.ToUInt32(e.KeyCode);
            e.SuppressKeyPress = true;
        }


        bool sound1 = true;

        private void lblSound1_Click(object sender, EventArgs e)
        {
            if (sound1)
                sound1 = false;
            else
                sound1 = true;
        }

        private void macro1_Tick(object sender, EventArgs e)
        {
            if (repeat1)
                btnStartMacro1.Text = "Stop Auto Cast";
            else
                btnStartMacro1.Text = "Start Auto Cast";
            if (chkHotKey1.Checked)
            {
                HotKeyPress(hotkey1, ref repeat1, ref chkStart1, ref back1);
            }

        }


        #endregion

        #region bot2
        List<uint> keys2 = new List<uint>();
        List<uint> delays2 = new List<uint>();

        private void boxMacro2_KeyDown(object sender, KeyEventArgs e)
        {
            GetKeyCode(e, ref boxMacro2, int.Parse(boxDelay2.Text), ref keys2, ref delays2);
            e.SuppressKeyPress = true;
        }

        private void lblDelay2_Click(object sender, EventArgs e)
        {
            AddDelay(ref boxMacro2, ref boxDelay2, ref keys2, ref delays2);
        }

        private void btnClearMacro2_Click(object sender, EventArgs e)
        {
            boxMacro2.Text = "";
            keys2 = new List<uint>();
            delays2 = new List<uint>();
        }

        bool repeat2 = false;
        private void back2_DoWork(object sender, DoWorkEventArgs e)
        {
            Macro macro = new Macro(windowhandle, keys2, delays2);
            do
            {
                macro.MacroStart();
            }
            while (repeat2);
        }

        private void btnStartMacro2_Click(object sender, EventArgs e)
        {
            if (!repeat2)
            {
                repeat2 = true;
                try
                {
                    back2.RunWorkerAsync();
                }
                catch { }
            }
            else
                repeat2 = false;
        }

        uint hotkey2;
        private void boxHotKey2_KeyDown(object sender, KeyEventArgs e)
        {
            boxHotKey2.Text = e.KeyCode.ToString();
            hotkey2 = Convert.ToUInt32(e.KeyCode);
            e.SuppressKeyPress = true;
        }

        bool sound2 = true;

        private void lblSound2_Click(object sender, EventArgs e)
        {
            if (sound2)
                sound2 = false;
            else
                sound2 = true;
        }

        private void macro2_Tick(object sender, EventArgs e)
        {
            if (repeat2)
                btnStartMacro2.Text = "Stop Auto Cast";
            else
                btnStartMacro2.Text = "Start Auto Cast";
            if (chkHotKey2.Checked)
            {
                HotKeyPress(hotkey2, ref repeat2, ref chkStart2, ref back2);
            }

        }


        #endregion


















    }
}

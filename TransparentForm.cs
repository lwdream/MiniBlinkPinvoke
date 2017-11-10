using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MiniBlinkPinvoke
{
    public partial class TransparentForm : Form
    {
        public TransparentForm()
        {
            InitializeComponent();
            blinkBrowser1.GlobalObjectJs = this;
            Load += TransparentForm_Load;
        }

        private void TransparentForm_Load(object sender, EventArgs e)
        {
            if (blinkBrowser1.handle!=IntPtr.Zero)
            {
                blinkBrowser1.DocumentReadyCallback += BlinkBrowser1_DocumentReadyCallback;
                BlinkBrowserPInvoke.wkeSetTransparent(blinkBrowser1.handle, true);
                blinkBrowser1.Url = "file:///F:/Project/MiniBlinkPinvokeForGithub/MiniBlinkPinvoke/%E7%BA%AFCSS3%E5%AE%9E%E7%8E%B0%E8%8B%B9%E6%9E%9C%E8%AE%BE%E5%A4%87DEMO%E6%BC%94%E7%A4%BAiPhone/devices.html";
              
            }
        }

        private void BlinkBrowser1_DocumentReadyCallback()
        {
            blinkBrowser1.Invalidate();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public static void MouseToMoveControl(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, 0x112, 0xf012, 0);
        }

        [JSFunctin]
        public void MoveWindow()
        {
            MouseToMoveControl(base.Handle);
        }
    }
}

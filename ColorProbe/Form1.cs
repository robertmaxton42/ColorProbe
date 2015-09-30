using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorProbe
{
    //From Pinvoke.net: http://www.pinvoke.net/default.aspx/gdi32/GetPixel.html

    public partial class probeForm : Form
    {
        public probeForm()
        {
            InitializeComponent();            
        }
        
        private void getColorTimer_Tick(object sender, EventArgs e)
        {
            Point pos = System.Windows.Forms.Cursor.Position;

            Color c = Win32.GetPixelColor(pos.X, pos.Y);

            //Fills labels
            colorLabel.BackColor = c;
            hueLabel.Text = c.GetHue().ToString("N0");
            satLabel.Text = c.GetSaturation().ToString("P0");
            valLabel.Text = c.GetBrightness().ToString("P0");

            redLabel.Text = c.R.ToString() + "/" + c.R.ToString("X2");
            greenLabel.Text = c.G.ToString() + "/" + c.G.ToString("X2");
            blueLabel.Text = c.B.ToString() + "/" + c.B.ToString("X2");
        }
    }

    sealed class Win32
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        //Gets color at screen coordinate (x, y)
        static public System.Drawing.Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
    }
}

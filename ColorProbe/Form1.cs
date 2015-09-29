﻿using System;
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

    public partial class probeForm : Form
    {
        public probeForm()
        {
            InitializeComponent();

            //Captures mouse and runs position-checker.
            this.Capture = true;
            this.MouseMove += probeForm_MouseMove;
        }

        private void probeForm_MouseMove(object sender, MouseEventArgs e)
        {
            colorLabel.BackColor = Win32.GetPixelColor(e.X, e.Y);
        }
    }
}

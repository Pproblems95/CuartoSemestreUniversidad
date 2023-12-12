using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse
{
    public partial class Form1 : Form
    {
        bool PuedePintar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            PuedePintar = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (PuedePintar)
            {
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(new SolidBrush(Color.DarkBlue), e.X, e.Y, 4, 4);
                graphics.Dispose();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            PuedePintar = false;
        }
    }
}

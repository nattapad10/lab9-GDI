using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace lab9_githab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;        
            Pen mypen = new Pen(Color.Green, 2);
            mypen.DashStyle = DashStyle.DashDot;
            e.Graphics.DrawLine(mypen,10,80,220,80);
            mypen.Dispose();
            mypen = new Pen(Brushes.DeepSkyBlue, 40);
            e.Graphics.DrawLine(mypen, 10, 120, 220, 120);
            mypen.Dispose();


        }
    }
}

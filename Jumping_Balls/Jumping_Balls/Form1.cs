using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jumping_Balls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer Timer = new Timer();

        int x, y;
        int xvelocity = 50;
        int yvelocity = 50;

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Interval = 50;
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            x += xvelocity;
            if ((x > Width - xvelocity - 80) || (x < 0))
            {
                xvelocity = -xvelocity;
            }

            y += yvelocity;
            if ((y > Height - yvelocity - 80) || (y < 0))
            {
                yvelocity = -yvelocity;
            }

            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawEllipse(new Pen(Brushes.BlueViolet, 10), x, y, 80, 80);
        }
    }
}

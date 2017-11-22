using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Jumping_Balls
{
    public partial class Form1 : Form
    {
        Ball b1;
        Ball[] ballArr = new Ball[70];
        Random rnd = new Random();
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            for (int i = 0; i < ballArr.Count(); i++)
            {
                Size size = new Size(rnd.Next(1, 100), rnd.Next(1, 100));

                Brush result = Brushes.Transparent;
                Type brushesType = typeof(Brushes);
                PropertyInfo[] properties = brushesType.GetProperties();
                int Random = rnd.Next(properties.Length);
                result = (Brush)properties[Random].GetValue(null, null);

                int x_rand = rnd.Next(1, Width - 50);
                int y_rand = rnd.Next(1, Height - 70);
                ballArr[i] = new Ball(result, 50, x_rand, y_rand, Size);
            }

            b1 = new Ball(Size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 5;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            for (int i = 0; i < ballArr.Count(); i++)
            {
                ballArr[i].ChangePosition();
            }
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i < ballArr.Count(); i++)
            {
                ballArr[i].draw(e.Graphics);
            }
        }
    }
}

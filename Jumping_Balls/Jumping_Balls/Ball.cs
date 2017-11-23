using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jumping_Balls
{
    class Ball
    {
        Brush brush_color = Brushes.BlueViolet;
        float size = 50;
        int x = 0;
        int y = 0;
        Size formSize;

        int xvelocity = 3;
        int yvelocity = 3;

        public Ball(Size _formSize)
        {
            this.formSize = _formSize;
        }

        public Ball(Brush _brush_color, float _size, int _x, int _y, Size _formSize)
        {
            this.brush_color = _brush_color;
            this.size = _size;
            this.x = _x;
            this.y = _y;
            this.formSize = _formSize;
        }

        public void draw(Graphics g1)
        {
            Pen p = new Pen(brush_color, size);
            g1.DrawEllipse(p, x, y, 10, 10);
        }

        public void ChangePosition()
        {
            x += xvelocity;
            y += yvelocity;

            if (x <= 0)
            {
                xvelocity = -xvelocity;
            }

            if (y <= 0)
            {
                yvelocity = -yvelocity;
            }

            if (x > formSize.Width - 50)
            {
                xvelocity = -xvelocity;
            }

            if (y > formSize.Height - 70)
            {
                yvelocity = -yvelocity;
            }
        }
    }
}

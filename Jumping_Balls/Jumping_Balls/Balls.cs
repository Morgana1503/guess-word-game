using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jumping_Balls
{
    class Balls
    {
        Brush brush_color = Brushes.BlueViolet;
        float size = 50;
        int x_coord = 0;
        int y_coord = 0;
        Size formSize;

        int xv_coord = 3;
        int yv_coord = 3;

        public Balls(Size _formSize)
        {
            this.formSize = _formSize;
        }

        public Balls(Brush _brush_color, float _size, int _x_coord, int _y_coord, Size _formSize)
        {
            this.brush_color = _brush_color;
            this.size = _size;
            this.x_coord = _x_coord;
            this.y_coord = _y_coord;
            this.formSize = _formSize;
        }

        public void draw(Graphics g1)
        {
            Pen p = new Pen(brush_color, size);
            g1.DrawEllipse(p, x_coord, y_coord, 10, 10);
            return;
        }

        public void change_position()
        {
            x_coord += xv_coord;
            y_coord += yv_coord;

            if (x_coord <= 0)
            {
                xv_coord = -xv_coord;
            }

            if (y_coord <= 0)
            {
                yv_coord = -yv_coord;
            }

            if (x_coord > formSize.Width - 50)
            {
                xv_coord = -xv_coord;
            }

            if (y_coord > formSize.Height - 70)
            {
                yv_coord = -yv_coord;
            }
        }
    }
}

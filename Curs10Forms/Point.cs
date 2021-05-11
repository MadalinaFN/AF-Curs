using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Curs10Forms
{
    public class myPoint
    {
        public static int size = 4;
        public float X, Y;
        public Color fillColor;

        public myPoint()
        {
            PointF T = Engine.getRNDPoint();
            X = T.X;
            Y = T.Y;
            fillColor = Engine.getRNDColor();
        }

        public void draw()
        {
            Engine.grp.FillEllipse(new SolidBrush(fillColor), X - size, Y - size, 2 * size + 1, 2 * size + 1);
            Engine.grp.DrawEllipse(new Pen(Color.Black), X - size, Y - size, 2 * size + 1, 2 * size + 1);
        }

        public PointF getPoint()
        {
            return new PointF(X, Y);
        }
    }
}

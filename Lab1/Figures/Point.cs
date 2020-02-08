using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Figures
{
    public class Point : Figure
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override void Draw(Graphics g, Control control, Color color)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"[{X};{Y}]";
        }

        public override bool Equals(object obj)
        {
            var p = obj as Point;
            if( p==null)
            {
                return false;
            }
            return X == p.X && Y == p.Y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"[{X};{Y}]";
        }
    }
}

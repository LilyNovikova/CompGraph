using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Utils
{
    public static class GeometryUtils
    {
        public static double GetDistanсe(this Point startPoint, Point point)
        {
            return Math.Sqrt(Math.Pow(point.Y - startPoint.Y, 2) + Math.Pow(point.X - startPoint.X, 2));
        }

        public static Point GetPoint1(Circle circle, Point o)
        {
            var a = circle.Center;
            var length = a.GetDistanсe(o);
            var aX1 = a.X + Convert.ToInt32((o.X - a.X) * (circle.Radius / length));
            var aY1 = a.Y + Convert.ToInt32((o.Y - a.Y) * (circle.Radius / length));
            return new Point(aX1, aY1);
        }
    }
}

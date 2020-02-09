using Lab1.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Models
{
    public class Circle
    {
        public Point Center { get; private set; }
        public int Radius { get; private set; }
        public string Name { get; set; }

        public Circle(int x, int y, int radius, string name = null)
        {
            Center = new Point(x, y);
            Radius = radius;
            Name = name;
        }

        public static Circle FromUpDowns(NumericUpDown centerX, NumericUpDown centerY, NumericUpDown radius)
        {
            var x = Decimal.ToInt32(centerX.Value);
            var y = Decimal.ToInt32(centerY.Value);
            var rad = Decimal.ToInt32(radius.Value);
            return new Circle(x, y, rad);
        }

        public Point GetTangentsIntersectionPoint(Circle circle)
        {
            var oX = Center.X + (circle.Center.X - Center.X) * Radius / (Radius + circle.Radius);
            var oY = Center.Y + (circle.Center.Y - Center.Y) * Radius / (Radius + circle.Radius);
            return new Point(oX, oY);
        }

        public Section GetCommonTangentPoints(Circle circleB, bool side)
        {
            var pointO = GetTangentsIntersectionPoint(circleB);
            var alpha = Math.PI / 2 - Math.Asin(Radius / Center.GetDistanсe(pointO));
            alpha = side ? -1 * alpha : alpha;
            var pointA1 = GeometryUtils.GetPoint1(this, pointO);
            var pointB1 = GeometryUtils.GetPoint1(circleB, pointO);

            return new Section(
                PivotPointAroundPoint(-alpha, Center, pointA1), 
                PivotPointAroundPoint(-alpha, circleB.Center, pointB1)
                );
        }

        private Point PivotPointAroundPoint(double alpha, Point center, Point point)
        {
            return new Point(
                Convert.ToInt32((point.X - center.X) * Math.Cos(alpha) - (point.Y - center.Y) * Math.Sin(alpha) + center.X),
                Convert.ToInt32((point.X - center.X) * Math.Sin(alpha) + (point.Y - center.Y) * Math.Cos(alpha) + center.Y)
            );
        }
    }
}

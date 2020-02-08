using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab1.Config.Settings;

namespace Lab1.Figures
{
    public class Circle : Figure
    {
        public double CenterX { get; private set; }
        public double CenterY { get; private set; }
        public double Radius { get; private set; }

        public Circle(double radius, double centerX = 0, double centerY = 0)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("radius must be positive");
            }
            Radius = radius;
            CenterX = centerX;
            CenterY = centerY;
        }

        public double[] GetValues(double x)
        {
            if (Math.Abs(x - CenterX) > Radius + Tolerance)
            {
                throw new ArgumentException("x is not in function's domain");
            }
            var c = Math.Pow(CenterY, 2) + Math.Pow((x - CenterX), 2) - Math.Pow(Radius, 2);
            var sqrtD = Math.Sqrt(Math.Pow(CenterY, 2) - c);
            double[] values = {
                CenterY + sqrtD,
                CenterY - sqrtD
            };
            return values;
        }

        public bool IsCirclePoint(Point p)
        {
            try
            {
                if (p == null)
                {
                    return false;
                }
                var values = GetValues(p.X);
                return Math.Abs(values[0] - p.Y) < Tolerance
                    || Math.Abs(values[1] - p.Y) < Tolerance;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public Line GetTangent(Point p)
        {
            if (!IsCirclePoint(p))
            {
                return null;
                // throw new ArgumentException($"Point {p} doesn't belong the circle");
            }
            var k = -(p.X - CenterX) / (p.Y - CenterY);
            var b = (CenterX * p.X + CenterY * p.Y - CenterX * CenterX - CenterY * CenterY + Radius * Radius) / (p.Y - CenterY);
            return new Line(k, b);
        }

        public Line[] GetTangents(double x)
        {
            var values = GetValues(x);
            var p0 = new Point(x, values[0]);
            var p1 = new Point(x, values[1]);
            Line[] lines = { GetTangent(p0), GetTangent(p1) };
            return lines;
        }

        public bool IsTangent(Line line, out Point p)
        {
            p = FindPoint(
                (point) => GetTangent(point).Equals(line)
                );
            return p != null;
        }

        public Point FindPoint(Func<Point, bool> condition)
        {
            for (double x = -Radius + CenterX; x <= Radius + CenterX; x += Tolerance)
            {
                var values = GetValues(x);
                var p0 = new Point(x, values[0]);
                var p1 = new Point(x, values[1]);
                if (condition(p0))
                {
                    return p0;
                }
                else if (condition(p1))
                {
                    return p1;
                }
            }
            return null;
        }

        public List<Point> FindPoints(Func<Point, bool> condition)
        {
            var list = new List<Point>();
            for (double x = -Radius + CenterX; x <= Radius + CenterX; x += Tolerance)
            {
                var values = GetValues(x);
                var p0 = new Point(x, values[0]);
                var p1 = new Point(x, values[1]);
                if (Math.Abs(x + 5) < Tolerance)
                {
                    ;
                }
                if (condition(p0))
                {
                    list.Add(p0);
                }
                else if (condition(p1))
                {
                    list.Add(p1);
                }
            }
            return list;
        }

        public Line GetAnyCommonTangent(Circle circle)
        {
            Point p = null;
            FindPoint(
                (point) =>
                IsTangent(GetTangent(point), out p)
                );
            return GetTangent(p);
        }

        public List<Line> GetCommonTangents(Circle circle)
        {
            try
            {
                var points = (Radius < circle.Radius) ?
                                FindPoints((point) =>
                                circle.IsTangent(GetTangent(point), out point)) :
                                circle.FindPoints((point) =>
                                IsTangent(circle.GetTangent(point), out point));
                var tangents = new List<Line>();
                foreach (Point p in points)
                {
                    var c = (Radius < circle.Radius) ? this : circle;
                    tangents.Add(c.GetTangent(p));
                }
                return tangents;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}

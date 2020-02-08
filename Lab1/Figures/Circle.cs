using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab1.Const.CalculationConst;

namespace Lab1.Figures
{
    public class Circle : Figure
    {
        public enum TangentTypes
        {
            NotATangent,
            Lower,
            Upper
        }

        public enum CommonTangentTypes
        {
            NotATangent,
            Inner,
            Outer
        }

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

        public bool IsCirclePoint(Point p, double tolerance = 0)
        {

            if (tolerance == 0)
            {
                tolerance = Tolerance;
            }
            try
            {
                if (p == null)
                {
                    return false;
                }
                var values = GetValues(p.X);
                return Math.Abs(values[0] - p.Y) < tolerance
                    || Math.Abs(values[1] - p.Y) < tolerance;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public Line GetTangent(Point p, double tolerance = 0)
        {
            if (tolerance == 0)
            {
                tolerance = Tolerance;
            }
            if (!IsCirclePoint(p, tolerance))
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

        public bool IsTangent(Line line, out Point p, double tolerance = 0)
        {
            if (tolerance == 0)
            {
                tolerance = Tolerance;
            }
            p = FindPoint(
                (point) => GetTangent(point).Equals(line),
                tolerance
                );
            return p != null;
        }

        public Point FindPoint(Func<Point, bool> condition, double tolerance = 0)
        {
            if (tolerance == 0)
            {
                tolerance = Tolerance;
            }
            for (double x = -Radius + CenterX; x <= Radius + CenterX; x += tolerance)
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
                if (condition(p0))
                {
                    list.Add(p0);
                }
                if ((p0 != p1) && condition(p1))
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
                    var c1 = (Radius < circle.Radius) ? this : circle;
                    var c2 = (Radius < circle.Radius) ? circle : this;
                    var tan = c1.GetTangent(p);
                    Point p1;
                    Tolerance /= 15;
                    if (c2.IsTangent(tan, out p1))
                    {
                        tangents.Add(tan);
                    }
                    Tolerance *= 15;
                }
                return tangents;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        public override void Draw(Graphics g, Control control, Color color)
        {
            var brush = new SolidBrush(color);
            var pen = new Pen(brush);
            var h = control.Height;
            var w = control.Width;
            var rect = new Rectangle(
               (int)Math.Round(CenterX - Radius + w / 2),
               (int)Math.Round(CenterY - Radius + h / 2),
               (int)Math.Round(2 * Radius),
               (int)Math.Round(2 * Radius)
                );
            g.DrawEllipse(pen, rect);
        }

        public TangentTypes GetTangentType(Line line)
        {
            Point p;
            if (!IsTangent(line, out p))
            {
                return TangentTypes.NotATangent;
            }
            var values0 = GetValues(p.X);
            if (Math.Abs(p.Y - Math.Max(values0[0], values0[1])) < Tolerance)
            {
                return TangentTypes.Upper;
            }
            else if (Math.Abs(p.Y - Math.Min(values0[0], values0[1])) < Tolerance)
            {
                return TangentTypes.Lower;
            }
            else
            {
                return TangentTypes.NotATangent;
            }
            /*var p0 = new Point(p.X - Tolerance, line.GetValue(p.X - Tolerance));
            var p1 = new Point(p.X + Tolerance, line.GetValue(p.X + Tolerance));
            var values0 = GetValues(p0.X);
            var values1 = GetValues(p1.X);
            if ((p0.Y > values0[0] && p0.Y > values0[1]) && (p1.Y > values1[0] && p1.Y > values1[1]))
            {
                return TangentTypes.Upper;
            }
            else if ((p0.Y < values0[0] && p0.Y < values0[1]) && (p1.Y < values1[0] && p1.Y < values1[1]))
            {
                return TangentTypes.Lower;
            }
            else
            {
                return TangentTypes.NotATangent;
            }*/
        }

        public CommonTangentTypes GetCommonTangentType(Line line, Circle circle)
        {
            var type0 = GetTangentType(line);
            var type1 = circle.GetTangentType(line);
            if ((type0 == TangentTypes.Lower && type1 == TangentTypes.Upper)
                || (type0 == TangentTypes.Upper && type1 == TangentTypes.Lower))
            {
                return CommonTangentTypes.Inner;
            }
            else if ((type0 == TangentTypes.Upper && type1 == TangentTypes.Upper)
                || (type0 == TangentTypes.Lower && type1 == TangentTypes.Lower))
            {
                return CommonTangentTypes.Outer;
            }
            return CommonTangentTypes.NotATangent;
        }
    }
}

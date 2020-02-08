using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab1.Const.CalculationConst;
using PointD = System.Drawing.Point;

namespace Lab1.Figures
{
    public class Line : Figure
    {
        public double K { get; private set; }
        public double B { get; private set; }

        public Line(double k, double b = 0)
        {
            K = k;
            B = b;
        }

        public double GetValue(double x)
        {
            return K * x + B;
        }

        public override string ToString()
        {
            var kStr =
                K == 0
                ? (B == 0 ? "0" : string.Empty)
                : $"{K}x";
            var bStr =
                (B != 0)
                ? string.Format("{0} {1}", B > 0 ? (K == 0 ? string.Empty : " +") : " -", Math.Abs(B))
                : string.Empty;
            return $"y = {kStr}{bStr}";
        }

        public override bool Equals(object obj)
        {
            var line = obj as Line;
            if (line == null)
            {
                return false;
            }
            return Math.Abs(line.K - K) < Tolerance
                && Math.Abs(line.B - B) < Tolerance;
        }

        public override void Draw(Graphics g, Control control, Color color)
        {
            var brush = new SolidBrush(color);
            var pen = new Pen(brush);
            var h = control.Height;
            var w = control.Width;
            var p1 = new PointD(0, (int)Math.Round(GetValue(0 - w / 2)) + h / 2);
            var p2 = new PointD(w, (int)Math.Round(GetValue(w / 2)) + h / 2);
            g.DrawLine(pen, p1, p2);
        }
    }
}

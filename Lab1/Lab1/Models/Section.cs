using System.Drawing;

namespace Lab1.Models
{
    public class Section
    {
        public Point A { get; private set; }
        public Point B { get; private set; }

        public Section(Point a, Point b)
        {
            A = a;
            B = b;
        }
    }
}

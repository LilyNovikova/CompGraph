using Lab1.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointF = Lab1.Figures.Point;
using PointD = System.Drawing.Point;

namespace Lab1.Forms
{
    public partial class PerformForm : Form
    {
        private Figure[] drawingFigures;
        private Graphics g;
        private List<Line> drawingTangents;

        public PerformForm(List<Line> tangents = null, params Figure[] figures)
        {
            InitializeComponent();
            drawingFigures = figures;
            drawingTangents = tangents;
            g = PictureBox.CreateGraphics();
        }

        private void DrawAxes()
        {
            var brush = new SolidBrush(Color.Black);
            var pen = new Pen(brush);
            var h = PictureBox.Height;
            var w = PictureBox.Width;
            //x
            var p1 = new PointD(0, h / 2);
            var p2 = new PointD(w, h / 2);
            g.DrawLine(pen, p1, p2);

            //y
            var p3 = new PointD(w / 2, 0);
            var p4 = new PointD(w / 2, h);
            g.DrawLine(pen, p3, p4);

        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawAxes();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            DrawAxes();
            foreach(Figure f in drawingFigures)
            {
                f.Draw(g, PictureBox, Color.Blue);
            }
            foreach(Line line in drawingTangents)
            {
                line.Draw(g, PictureBox, Color.Red);
            }
        }

        private void PerformForm_Load(object sender, EventArgs e)
        {
            var g = PictureBox.CreateGraphics();
            var h = PictureBox.Height;
            var w = PictureBox.Width;
            var rect = new Rectangle(new PointD(0, 0), new Size(w, h));
            this.OnPaint(new PaintEventArgs(g, rect));
        }

        private void PerformForm_Shown(object sender, EventArgs e)
        {
            DrawAxes();
        }

        private void PictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DrawAxes();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.Figures;

namespace Lab1.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PointYUpdn.Enabled = false;
        }

        private void FindTangentBtn_Click(object sender, EventArgs e)
        {
            var cX = (double)CircleXUpdn.Value;
            var cY = (double)CircleYUpdn.Value;
            var rad = (double)CircleRadiusUpdn.Value;
            var circle = new Circle(rad, cX, cY);
            var x = (double)PointXUpdn.Value;
            var y = (double)PointYUpdn.Value;
            var point = new Figures.Point(x, y);
            var tangents = circle.GetTangents(x);
            ResultLbl.Text = (tangents == null) ? "error" : $"{tangents[0]}; {tangents[1]}";
        }

        private void IsTangentBtn_Click(object sender, EventArgs e)
        {
            var cX = (double)CircleXUpdn.Value;
            var cY = (double)CircleYUpdn.Value;
            var rad = (double)CircleRadiusUpdn.Value;
            var circle = new Circle(rad, cX, cY);
            var k = (double)LineKUpdn.Value;
            var b = (double)LineBUpdn.Value;
            var line = new Line(k, b);
            Figures.Point p;
            var isTangent = circle.IsTangent(line, out p);
            ResultLbl.Text = (p != null) ? p.ToString() : isTangent.ToString();
        }

        private void GetCommonTangentsBtn_Click(object sender, EventArgs e)
        {
            var cX1 = (double)CircleXUpdn.Value;
            var cY1 = (double)CircleYUpdn.Value;
            var rad1 = (double)CircleRadiusUpdn.Value;
            var cX2 = (double)Circle2XUpdn.Value;
            var cY2 = (double)Circle2YUpdn.Value;
            var rad2 = (double)Circle2RadiusUpdn.Value;
            var circle1 = new Circle(rad1, cX1, cY1);
            var circle2 = new Circle(rad2, cX2, cY2);

            var tangents = circle1.GetCommonTangents(circle2);
            foreach (Line t in tangents)
            {
                TangentsLV.Items.Add(t.ToString());
            }
        }

        private void PerformBtn_Click(object sender, EventArgs e)
        {
            TangentsLV.Items.Clear();
            var cX1 = (double)CircleXUpdn.Value;
            var cY1 = (double)CircleYUpdn.Value;
            var rad1 = (double)CircleRadiusUpdn.Value;
            var cX2 = (double)Circle2XUpdn.Value;
            var cY2 = (double)Circle2YUpdn.Value;
            var rad2 = (double)Circle2RadiusUpdn.Value;
            var circle1 = new Circle(rad1, cX1, cY1);
            var circle2 = new Circle(rad2, cX2, cY2);
            var tangents = circle1.GetCommonTangents(circle2);
            var select = TangentTypeCmb.SelectedItem == null ? string.Empty : TangentTypeCmb.SelectedItem.ToString();
            if (select.Equals("Inner"))
            {
                tangents = tangents.Where(t => circle1.GetCommonTangentType(t, circle2) == Circle.CommonTangentTypes.Inner).ToList();
            }
            else if (select.Equals("Outer"))
            {
                tangents = tangents.Where(t => circle1.GetCommonTangentType(t, circle2) == Circle.CommonTangentTypes.Outer).ToList();
            }

            foreach (Line t in tangents)
            {
                TangentsLV.Items.Add(t.ToString());
            }
            PerformForm P = new PerformForm(tangents, circle1, circle2);
            P.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        Graphics g;
        Bitmap bm;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Pen axis = new Pen(Color.Gray, 2);
            Pen graphic = new Pen(Color.Red, 4);

            g = Graphics.FromImage(pictureBox1.Image = bm);
            
            Matrix matrix = new Matrix(1, 0, 0, -1, 0, 0);
            g.Transform = matrix;
            g.TranslateTransform(160, 160, MatrixOrder.Append);

            g.DrawLine(axis, -160, 0, Right, 0);
            g.DrawLine(axis, 0, 160, 0, -Bottom);
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            Pen graphic = new Pen(Color.Red, 4);
            switch (comboBox1.SelectedItem)
            {
                case "y = x":
                    g.DrawLine(graphic, -160, -160, 160, 160);
                    break;

                case "y = |x|":
                    Point[] points = new Point[3]
                    {
                        new Point(-160, Math.Abs(-160)),
                        new Point(0, Math.Abs(0)),
                        new Point(160, Math.Abs(160))
                    };
                    g.DrawLines(graphic, points);
                    break;

                case "y = x^2":
                    PointF[] points2 = new PointF[17]
                    {
                        new PointF(-160, (float)Math.Pow(-160/5, 2)),
                        new PointF(-140, (float)Math.Pow(-140/5, 2)),
                        new PointF(-120, (float)Math.Pow(-120/5, 2)),
                        new PointF(-100, (float)Math.Pow(-100/5, 2)),
                        new PointF(-80, (float)Math.Pow(-80/5, 2)),
                        new PointF(-60, (float)Math.Pow(-60/5, 2)),
                        new PointF(-40, (float)Math.Pow(-40/5, 2)),
                        new PointF(-20, (float)Math.Pow(-20/5, 2)),
                        new PointF(0,   (float)Math.Pow(0/5, 2)),
                        new PointF(20,  (float)Math.Pow(20/5, 2)),
                        new PointF(40,  (float)Math.Pow(40/5, 2)),
                        new PointF(60,  (float)Math.Pow(60/5, 2)),
                        new PointF(80,  (float)Math.Pow(80/5, 2)),
                        new PointF(100, (float)Math.Pow(100/5, 2)),
                        new PointF(120, (float)Math.Pow(120/5, 2)),
                        new PointF(140, (float)Math.Pow(140/5, 2)),
                        new PointF(160, (float)Math.Pow(160/5, 2))
                    };
                    g.DrawCurve(graphic, points2);
                    break;

                case "y = sin(x)":
                    PointF[] points3 = new PointF[]
                    {
                        new PointF(-160, (float)Math.Sin(-160)*10),
                        new PointF(-140, (float)Math.Sin(-140)*10),
                        new PointF(-120, (float)Math.Sin(-120)*10),
                        new PointF(-100, (float)Math.Sin(-100)*10),
                        new PointF(-80, (float)Math.Sin(-80)*10),
                        new PointF(-60, (float)Math.Sin(-60)*10),
                        new PointF(-40, (float)Math.Sin(-40)*10),
                        new PointF(-20, (float)Math.Sin(-20)*10),
                        new PointF(0,   (float)Math.Sin(0)*10),
                        new PointF(20,  (float)Math.Sin(20)*10),
                        new PointF(40,  (float)Math.Sin(40)*10),
                        new PointF(60,  (float)Math.Sin(60)*10),
                        new PointF(80,  (float)Math.Sin(80)*10),
                        new PointF(100, (float)Math.Sin(100)*10),
                        new PointF(120, (float)Math.Sin(120)*10),
                        new PointF(140, (float)Math.Sin(140)*10),
                        new PointF(160, (float)Math.Sin(160)*10)
                    };

                    g.DrawCurve(graphic, points3);
                    break;

                case "y = cos(x)":
                    PointF[] points4 = new PointF[]
                    {
                        new PointF(-160, (float)Math.Cos(-160)*10),
                        new PointF(-140, (float)Math.Cos(-140)*10),
                        new PointF(-120, (float)Math.Cos(-120)*10),
                        new PointF(-100, (float)Math.Cos(-100)*10),
                        new PointF(-80, (float)Math.Cos(-80)*10),
                        new PointF(-60, (float)Math.Cos(-60)*10),
                        new PointF(-40, (float)Math.Cos(-40)*10),
                        new PointF(-20, (float)Math.Cos(-20)*10),
                        new PointF(0,   (float)Math.Cos(0)*10),
                        new PointF(20,  (float)Math.Cos(20)*10),
                        new PointF(40,  (float)Math.Cos(40)*10),
                        new PointF(60,  (float)Math.Cos(60)*10),
                        new PointF(80,  (float)Math.Cos(80)*10),
                        new PointF(100, (float)Math.Cos(100)*10),
                        new PointF(120, (float)Math.Cos(120)*10),
                        new PointF(140, (float)Math.Cos(140)*10),
                        new PointF(160, (float)Math.Cos(160)*10)
                    };

                    g.DrawCurve(graphic, points4);
                    break;
                
                default:
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Practica_Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Point[] points;
        Point center;
        Pen pen;
        int W;
        int H;
        int step;
        int numPoint;



        public Point GetCenter()
        {
            
            int Xleft = 0, Xright = 0, Yup = 0, Ydown = 0;

            for(int i = 0; i < points.Length; i++)
            {
                if (points[i].X < Xleft || i == 0) Xleft = points[i].X;
                if (points[i].X > Xright || i == 0) Xright = points[i].X;
                if (points[i].Y > Yup || i == 0) Yup = points[i].Y;
                if (points[i].Y < Ydown || i == 0) Ydown = points[i].Y;
            }
            center = new Point(Xleft/2 + Xright/2, Yup/2 + Ydown/2);
            //можно улучшить, а можно оставить
            return center;
        }

        public void DrawFigure()
        {
            pen.Width = 3;

            for (int i = 0; i < points.Length; i++)
            {
                if (i + 1 != points.Length)
                    g.DrawLine(pen, points[i], points[i + 1]);
                else g.DrawLine(pen, points[i], points[0]);
            }
            g.DrawRectangle(pen, center.X, center.Y, 3, 3);
        }

        public void DrawAxis()
        {

            Refresh();
            g = this.CreateGraphics();
            pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            W = ClientSize.Width;
            H = ClientSize.Height;
            step = 50;
            numPoint = 5;

            //координатные оси
            g.DrawLine(pen, W / 2, 0, W / 2, H);
            g.DrawLine(pen, 0, H / 2, W, H / 2);

            //стрелочки
            g.DrawLine(pen, W / 2, 0, W / 2 - 10, 15);
            g.DrawLine(pen, W / 2, 0, W / 2 + 10, 15);
            g.DrawLine(pen, W, H / 2, W - 15, H / 2 - 10);
            g.DrawLine(pen, W, H / 2, W - 15, H / 2 + 10);

            //насечки с цифрами на координатных осях 
            int x = 0, y = 0, text = 0;
            x = W / 2; y = H / 2;
            while (x < ClientSize.Width)
            {
                g.DrawLine(pen, x, y - 5, x, y + 5);
                if (x != W / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x - 4, y + 7);
                text += 1;
                x += 50;
            }
            x = W / 2; text = 0;
            while (x > 0)
            {
                g.DrawLine(pen, x, y - 5, x, y + 5);
                if (x != W / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x - 8, y + 7);
                text -= 1;
                x -= 50;
            }
            x = W / 2; text = 0;
            while (y < H)
            {
                g.DrawLine(pen, x - 5, y, x + 5, y);
                if (y != H / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x + 7, y - 5);
                text -= 1;
                y += 50;
            }
            y = H / 2; text = 0;
            while (y > 0)
            {
                g.DrawLine(pen, x - 5, y, x + 5, y);
                if (y != H / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x + 7, y - 5);
                y -= 50;
                text += 1;
            }
        }

        public int[ , ] ToMatrix(Point[] points)
        {
            int[,] ints = new int[points.Length, 3];

            for(int i = 0; i < ints.GetLength(0); i++)
            {
                ints[i, 0] = points[i].X;
                ints[i, 1] = points[i].Y;
                ints[i, 2] = 1;
            }

            return ints;
        }

        public Point[] ToPoints(int[,] ints)
        {
            Point[] points = new Point[ints.Length / 3];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(ints[i, 0], ints[i, 1]);
            }

            return points;
        }

        public Point[] ShiftPoints(Point[] points, int X, int Y)
        {
            int[,] ints = ToMatrix(points);

            int[,] shiftMatrix = new int[3, 3] { 
                { 1, 0, 0}, 
                { 0, 1, 0}, 
                { X, Y, 1} 
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);
            return points;
        }

        public Point[] ScaleMatrix(Point[] points, double X, double Y)
        {
            int[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[3, 3] {
                { X, 0, 0},
                { 0, Y, 0},
                { 0, 0, 1}
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);
            return points;
        }

        public int[,] MultyplicationMatrix(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0)) return new int[,] { { 0, 0 }, { 0, 0} };
            int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    int temp = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        temp += matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = temp;
                }
            }

            return resultMatrix;
        }

        public Point[] HorizontalReflection()
        {
            int[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[3, 3] {
                { 1, 0, 0},
                { 0, -1, 0},
                { 0, 0, 1}
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);
            return points;
        }

        public Point[] VerticalReflection()
        {
            int[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[3, 3] {
                { -1, 0, 0},
                { 0, 1, 0},
                { 0, 0, 1}
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);
            return points;
        }

        public int[,] MultyplicationMatrix(int[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0)) return new int[,] { { 0, 0 }, { 0, 0 } };
            int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    double temp = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        temp += matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = (int)temp;
                }
            }

            return resultMatrix;
        }

        public Point[] RotatePoints(Point[] points, int degree)
        {
            int[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[3, 3] {
                { Math.Cos(degree * Math.PI / 180), Math.Sin(degree * Math.PI / 180), 0},
                { -Math.Sin(degree * Math.PI / 180), Math.Cos(degree * Math.PI / 180), 0},
                { 0, 0, 1}
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);

            return points;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {

            {
                Refresh();
                g = this.CreateGraphics();
                pen = new Pen(Color.FromArgb(255, 0, 0, 0));
                W = ClientSize.Width;
                H = ClientSize.Height;
                step = 50;
                numPoint = 5;

                //координатные оси
                g.DrawLine(pen, W / 2, 0, W / 2, H);
                g.DrawLine(pen, 0, H / 2, W, H / 2);

                //стрелочки
                g.DrawLine(pen, W / 2, 0, W / 2 - 10, 15);
                g.DrawLine(pen, W / 2, 0, W / 2 + 10, 15);
                g.DrawLine(pen, W, H / 2, W - 15, H / 2 - 10);
                g.DrawLine(pen, W, H / 2, W - 15, H / 2 + 10);

                //насечки с цифрами на координатных осях 
                int x = 0, y = 0, text = 0;
                x = W / 2; y = H / 2;
                while (x < ClientSize.Width)
                {
                    g.DrawLine(pen, x, y - 5, x, y + 5);
                    if (x != W / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x - 4, y + 7);
                    text += 1;
                    x += 50;
                }
                x = W / 2; text = 0;
                while (x > 0)
                {
                    g.DrawLine(pen, x, y - 5, x, y + 5);
                    if (x != W / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x - 8, y + 7);
                    text -= 1;
                    x -= 50;
                }
                x = W / 2; text = 0;
                while (y < H)
                {
                    g.DrawLine(pen, x - 5, y, x + 5, y);
                    if (y != H / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x + 7, y - 5);
                    text -= 1;
                    y += 50;
                }
                y = H / 2; text = 0;
                while (y > 0)
                {
                    g.DrawLine(pen, x - 5, y, x + 5, y);
                    if (y != H / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x + 7, y - 5);
                    y -= 50;
                    text += 1;
                }

                pen.Width = 3;
                points = new Point[numPoint];
                points[0] = new Point((W / 2) - 2 * step, H / 2 - 4 * step);
                points[1] = new Point(W / 2 + 2 * step, H / 2 - 2 * step);
                points[2] = new Point(W / 2 - step, H / 2 + 2 * step);
                points[3] = new Point(W / 2 - step, H / 2);
                points[4] = new Point(W / 2 - 3 * step, H / 2 + 2 * step);
                //Фигура
                for (int i = 0; i < points.Length; i++)
                {
                    if (i + 1 != points.Length)
                        g.DrawLine(pen, points[i], points[i + 1]);
                    else g.DrawLine(pen, points[i], points[0]);
                }

                Point center = GetCenter();
                g.DrawRectangle(pen, center.X, center.Y, 3, 3);
                g.DrawLine(pen, W / 2 + center.X * step, W / 2 + center.X * step, H / 2 + center.Y * step, H / 2 + center.Y * step);

                g.Dispose();
            }
        }

        private void Horizontal_Click(object sender, EventArgs e)
        {

            {
                points = ShiftPoints(points, -W / 2, -H / 2);
                points = HorizontalReflection();
                points = ShiftPoints(points, W / 2, H / 2);
                DrawAxis();
                DrawFigure();
            }
        }

        private void Vertical_Click(object sender, EventArgs e)
        {

            {
                points = ShiftPoints(points, -W / 2, -H / 2);
                points = VerticalReflection();
                points = ShiftPoints(points, W / 2, H / 2);
                DrawAxis();
                DrawFigure();
            }
        }

        private void Shift_Click(object sender, EventArgs e)
        {

            {
                int X = int.Parse(textBox1.Text);
                int Y = int.Parse(textBox2.Text);

                points = ShiftPoints(points, X, Y);
                GetCenter();
                DrawAxis();
                DrawFigure();
            }
        }

        private void Scale_Click(object sender, EventArgs e)
        {

            {
                double X = Double.Parse(textBox3.Text);
                double Y = Double.Parse(textBox4.Text);

                points = ShiftPoints(points, -center.X, -center.Y);
                points = ScaleMatrix(points, X, Y);
                points = ShiftPoints(points, center.X, center.Y);
                DrawAxis();
                DrawFigure();
            }
        }

        private void Rotate_Click(object sender, EventArgs e)
        {

            {
                int degree = int.Parse(textBox5.Text);
                points = ShiftPoints(points, -center.X, -center.Y);
                points = RotatePoints(points, degree);
                points = ShiftPoints(points, center.X, center.Y);
                DrawAxis();
                DrawFigure();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        SpacePoint[] points;
        SpacePoint[] points2;
        SpacePoint center;
        SpacePoint center2;
        SpacePoint[] axisXYZ = new SpacePoint[]
        {
            new SpacePoint(0, 0, 0),
            new SpacePoint(6, 0, 0),
            new SpacePoint(0, 0, 0),
            new SpacePoint(0, 6, 0),
            new SpacePoint(0, 0, 0),
            new SpacePoint(0, 0, 6),
        };
        Pen pen;
        int W;
        int H;
        int step;
        int stepZ;
        int numPoint;
        double angleY, angleX;
        double[,] proectionMatrix;
        double k = 0.50;
        int angleXMark = 1, angleYMark = -1;


        public void SetProectionMatrix()
        {
            angleX = angleXMark * Math.Asin(k / Math.Sqrt(2));
            angleY = angleYMark * Math.Asin(k / Math.Sqrt(2 - Math.Pow(k, 2)));

            proectionMatrix = new double[,]
            {
                {Math.Cos(angleY), Math.Sin(angleY) * Math.Sin(angleX), 0, 0 },
                {0, Math.Cos(angleX), 0, 0 },
                {Math.Sin(angleY), -1 * Math.Cos(angleY) * Math.Sin(angleX), 0, 0 },
                {0, 0, 0, 1 }
            };
        }

        public double ToRadian(double angle)
        {
            return angle * Math.PI / 180;
        }

        public void SetPointsFigure1()
        {
            numPoint = 5;
            points = new SpacePoint[numPoint];

            points[0] = new SpacePoint(-2, -4, 0);
            points[1] = new SpacePoint(2, -2, 0);
            points[2] = new SpacePoint(-1, 2, 0);
            points[3] = new SpacePoint(-1, 0, 0);
            points[4] = new SpacePoint(-3, 2, 0);

            points2 = new SpacePoint[numPoint];
            points2[0] = new SpacePoint(-2, -4, 1);
            points2[1] = new SpacePoint(2, -2, 1);
            points2[2] = new SpacePoint(-1, 2, 1);
            points2[3] = new SpacePoint(-1, 0, 1);
            points2[4] = new SpacePoint(-3, 2, 1);
        }

        public void SetPointsTetrahedron()
        {
            numPoint = 4;
            points = new SpacePoint[numPoint];

            points[0] = new SpacePoint(1, 0, 1);
            points[1] = new SpacePoint(4, 0, 1);
            points[2] = new SpacePoint(1, 3, 1);
            points[3] = new SpacePoint(1, 0, 4);
        }

        public SpacePoint GetCenter()
        {

            double Xleft = 0, Xright = 0, Yup = 0, Ydown = 0, Zcloser = 0, Zfarther = 0;

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].X < Xleft || i == 0) Xleft = points[i].X;
                if (points[i].X > Xright || i == 0) Xright = points[i].X;
                if (points[i].Y > Yup || i == 0) Yup = points[i].Y;
                if (points[i].Y < Ydown || i == 0) Ydown = points[i].Y;
                if (points[i].Z < Zfarther || i == 0) Zfarther = points[i].Z;
                if (points[i].Z > Zcloser || i == 0) Zcloser = points[i].Z;
            }
            center = new SpacePoint(Xleft / 2 + Xright / 2, Yup / 2 + Ydown / 2, Zcloser / 2 + Zfarther / 2);
            //????? ????????, ? ????? ????????
            return center;
        }

        public void DrawFigure()
        {
            pen.Width = 2;

            for (int i = 0; i < points.Length; i++)
            {
                if (i + 1 != points.Length)
                    g.DrawLine(pen,
                        (int)(points[i].X * step - points[i].Z * stepZ + W / 2),
                        (int)(points[i].Y * step + points[i].Z * stepZ + H / 2),
                        (int)(points[i + 1].X * step - points[i + 1].Z * stepZ + W / 2),
                        (int)(points[i + 1].Y * step + points[i + 1].Z * stepZ + H / 2));
                else g.DrawLine(pen,
                        (int)(points[i].X * step - points[i].Z * stepZ + W / 2),
                        (int)(points[i].Y * step + points[i].Z * stepZ + H / 2),
                        (int)(points[0].X * step - points[0].Z * stepZ + W / 2),
                        (int)(points[0].Y * step + points[0].Z * stepZ + H / 2));
            }

            for (int i = 0; i < points2.Length; i++)
            {
                if (i + 1 != points.Length)
                    g.DrawLine(pen,
                        (int)(points2[i].X * step - points2[i].Z * stepZ + W / 2),
                        (int)(points2[i].Y * step + points2[i].Z * stepZ + H / 2),
                        (int)(points2[i + 1].X * step - points2[i + 1].Z * stepZ + W / 2),
                        (int)(points2[i + 1].Y * step + points2[i + 1].Z * stepZ + H / 2));
                else g.DrawLine(pen,
                        (int)(points2[i].X * step - points2[i].Z * stepZ + W / 2),
                        (int)(points2[i].Y * step + points2[i].Z * stepZ + H / 2),
                        (int)(points2[0].X * step - points2[0].Z * stepZ + W / 2),
                        (int)(points2[0].Y * step + points2[0].Z * stepZ + H / 2));
            }

            for (int i = 0; i < points.Length; i++)
            {
                g.DrawLine(pen,
                        (int)(points[i].X * step - points[i].Z * stepZ + W / 2),
                        (int)(points[i].Y * step + points[i].Z * stepZ + H / 2),
                        (int)(points2[i].X * step - points2[i].Z * stepZ + W / 2),
                        (int)(points2[i].Y * step + points2[i].Z * stepZ + H / 2));
            }

            g.DrawRectangle
                (pen,
                (int)(center.X * step - center.Z * stepZ + W / 2),
                (int)(center.Y * step + center.Z * stepZ + H / 2),
                2, 2);

        }

        public void DrawTetrahedron()
        {
            double[,] proectionCoordinate = MultyplicationMatrix(ToMatrix(points), proectionMatrix);
            SpacePoint[] proectionPoints = ToPoints(proectionCoordinate);
            pen.Width = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    g.DrawLine(pen,
                        (int)(proectionPoints[i].X * step + W / 2),
                        (int)(-proectionPoints[i].Y * step + H / 2),
                        (int)(proectionPoints[j].X * step + W / 2),
                        (int)(-proectionPoints[j].Y * step + H / 2));
                }
            }
        }

        public void DrawAxis()
        {

            Refresh();
            g = this.CreateGraphics();
            pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            W = ClientSize.Width;
            H = ClientSize.Height;

            //???????????? ???
            g.DrawLine(pen, W / 2, 0, W / 2, H);
            g.DrawLine(pen, 0, H / 2, W, H / 2);
            //??? Z
            g.DrawLine(pen, W / 2 + H / 2, 0, W / 2 - H / 2, H);

            //?????????
            g.DrawLine(pen, W / 2, 0, W / 2 - 10, 15);
            g.DrawLine(pen, W / 2, 0, W / 2 + 10, 15);
            g.DrawLine(pen, W, H / 2, W - 15, H / 2 - 10);
            g.DrawLine(pen, W, H / 2, W - 15, H / 2 + 10);

            //??????? ? ??????? ?? ???????????? ???? 
            int x = 0, y = 0, text = 0;
            x = W / 2; y = H / 2;
            while (x < ClientSize.Width)
            {
                g.DrawLine(pen, x, y - 5, x, y);
                g.DrawLine(pen, x, y, x - 5, y + 5);
                if (x != W / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x - 4, y + 7);
                text += 1;
                x += 50;
            }
            x = W / 2; text = 0;
            while (x > 0)
            {
                g.DrawLine(pen, x, y - 5, x, y);
                g.DrawLine(pen, x, y, x - 5, y + 5);
                if (x != W / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x - 8, y + 7);
                text -= 1;
                x -= 50;
            }
            x = W / 2; text = 0;
            while (y < H)
            {
                g.DrawLine(pen, x - 5, y + 5, x, y);
                g.DrawLine(pen, x, y, x + 5, y);
                if (y != H / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x + 7, y - 5);
                text -= 1;
                y += 50;
            }
            y = H / 2; text = 0;
            while (y > 0)
            {
                g.DrawLine(pen, x - 5, y + 5, x, y);
                g.DrawLine(pen, x, y, x + 5, y);
                if (y != H / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x + 7, y - 5);
                y -= 50;
                text += 1;
            }
            y = H / 2; text = 0;
            x = W / 2;
            while (x < W && y > 0)
            {
                g.DrawLine(pen, x, y - 5, x, y);
                g.DrawLine(pen, x, y, x + 5, y + 5);
                if (y != H / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x + 7, y - 5);
                y -= 30;
                x += 30;
                text -= 1;
            }
            y = H / 2; text = 0;
            x = W / 2;
            while (x > 0 && y < H)
            {
                g.DrawLine(pen, x, y - 5, x, y);
                g.DrawLine(pen, x, y, x + 5, y + 5);
                if (y != H / 2) g.DrawString(text.ToString(), new Font("Tahoma", 7), Brushes.Black, x + 7, y - 5);
                y += 30;
                x -= 30;
                text += 1;
            }
        }

        public void DrawProectionAxis()
        {
            Refresh();
            g = this.CreateGraphics();
            pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            W = ClientSize.Width;
            H = ClientSize.Height;

            double[,] proectionCoordinate = MultyplicationMatrix(ToMatrix(axisXYZ), proectionMatrix);
            SpacePoint[] proectionPoints = ToPoints(proectionCoordinate);

            g.DrawLine(pen,
                    (int)(proectionPoints[0].X * step + W / 2),
                    (int)(-proectionPoints[0].Y * step + H / 2),
                    (int)(proectionPoints[1].X * step + W / 2),
                    (int)(-proectionPoints[1].Y * step + H / 2));

            g.DrawLine(pen,
        (int)(proectionPoints[2].X * step + W / 2),
        (int)(-proectionPoints[2].Y * step + H / 2),
        (int)(proectionPoints[3].X * step + W / 2),
        (int)(-proectionPoints[3].Y * step + H / 2));
            g.DrawLine(pen,
        (int)(proectionPoints[4].X * step + W / 2),
        (int)(-proectionPoints[4].Y * step + H / 2),
        (int)(proectionPoints[5].X * step + W / 2),
        (int)(-proectionPoints[5].Y * step + H / 2));


            g.DrawString("X",
                Font,
                new SolidBrush(Color.Black),
                (int)(proectionPoints[1].X * step + W / 2),
                (int)(-proectionPoints[1].Y * step + H / 2));
            g.DrawString("Y",
                Font,
                new SolidBrush(Color.Black),
                (int)(proectionPoints[3].X * step + W / 2),
                (int)(-proectionPoints[3].Y * step + H / 2));
            g.DrawString("Z",
                Font,
                new SolidBrush(Color.Black),
                (int)(proectionPoints[5].X * step + W / 2),
                (int)(-proectionPoints[5].Y * step + H / 2));
        }

        public double[,] ToMatrix(SpacePoint[] points)
        {
            double[,] ints = new double[points.Length, 4];

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                ints[i, 0] = points[i].X;
                ints[i, 1] = points[i].Y;
                ints[i, 2] = points[i].Z;
                ints[i, 3] = 1;
            }

            return ints;
        }

        public SpacePoint[] ToPoints(double[,] ints)
        {
            SpacePoint[] points = new SpacePoint[ints.Length / 4];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new SpacePoint(ints[i, 0], ints[i, 1], ints[i, 2]);
            }

            return points;
        }

        public SpacePoint[] ShiftPoints(SpacePoint[] points, double X, double Y, double Z)
        {
            double[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[4, 4] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { X, Y, Z, 1 }
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);
            return points;
        }

        public SpacePoint[] ScaleMatrix(SpacePoint[] points, double X, double Y, double Z)
        {
            double[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[4, 4] {
                { X, 0, 0, 0 },
                { 0, Y, 0, 0 },
                { 0, 0, Z, 0 },
                { 0, 0, 0, 1 }
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);
            return points;
        }

        public int[,] MultyplicationMatrix(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0)) return new int[,] { { 0, 0 }, { 0, 0 } };
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

        public double[,] MultyplicationMatrix(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0)) return new double[,] { { 0, 0 }, { 0, 0 } };
            double[,] resultMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    double temp = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        temp += matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = temp;
                }
            }

            return resultMatrix;
        }

        public SpacePoint[] HorizontalReflection(SpacePoint[] points)
        {
            double[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[4, 4] {
                { 1, 0, 0, 0 },
                { 0, -1, 0, 0},
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);
            return points;
        }

        public SpacePoint[] VerticalReflection(SpacePoint[] points)
        {
            double[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[4, 4] {
                { -1, 0, 0, 0},
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);
            return points;
        }

        public SpacePoint[] ZReflection(SpacePoint[] points)
        {
            double[,] ints = ToMatrix(points);

            double[,] ZreflectionMatrix = new double[4, 4]
            {
                {1, 0, 0, 0 },
                {0, 1, 0, 0 },
                {0, 0, -1, 0},
                {0, 0, 0, 1 }
            };

            ints = MultyplicationMatrix(ints, ZreflectionMatrix);

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

        public SpacePoint[] RotatePointsZ(SpacePoint[] points, int degree)
        {
            double[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[4, 4] {
                { Math.Cos(degree * Math.PI / 180),  Math.Sin(degree * Math.PI / 180), 0, 0},
                { -Math.Sin(degree * Math.PI / 180), Math.Cos(degree * Math.PI / 180), 0, 0},
                { 0,                                 0,                                1, 0},
                { 0,                                 0,                                0, 1}
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);

            return points;
        }

        public SpacePoint[] RotatePointsX(SpacePoint[] points, int degree)
        {
            double[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[4, 4] {
                { 1,                                 0,                                0,                                0},
                { 0,                                 Math.Cos(degree * Math.PI / 180), Math.Sin(degree * Math.PI / 180), 0},
                { 0,                                -Math.Sin(degree * Math.PI / 180), Math.Cos(degree * Math.PI / 180), 0},
                { 0,                                 0,                                0,                                1}
            };

            ints = MultyplicationMatrix(ints, shiftMatrix);

            points = ToPoints(ints);

            return points;
        }

        public SpacePoint[] RotatePointsY(SpacePoint[] points, int degree)
        {
            double[,] ints = ToMatrix(points);

            double[,] shiftMatrix = new double[4, 4] {
                { Math.Cos(degree * Math.PI / 180),  0,                             -Math.Sin(degree * Math.PI / 180), 0},
                { 0,                                 1,                              0,                                0},
                { Math.Sin(degree * Math.PI / 180),  0,                              Math.Cos(degree * Math.PI / 180), 0},
                { 0,                                 0,                                0,                              1}
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
                stepZ = 30;

                SetProectionMatrix();
                DrawProectionAxis();
                SetPointsTetrahedron();
                DrawTetrahedron();

                pen.Width = 3;

                //points[0] = new SpacePoint((W / 2) - 2 * step, H / 2 - 4 * step);
                //points[1] = new SpacePoint(W / 2 + 2 * step, H / 2 - 2 * step);
                //points[2] = new SpacePoint(W / 2 - step, H / 2 + 2 * step);
                //points[3] = new SpacePoint(W / 2 - step, H / 2);
                //points[4] = new SpacePoint(W / 2 - 3 * step, H / 2 + 2 * step);

                //SetPointsFigure1();

                //??????

                center = GetCenter();

                //DrawFigure();
                g.Dispose();
            }
        }

        private void Horizontal_Click(object sender, EventArgs e)
        {

            {
                points = ShiftPoints(points, -center.X, -center.Y, -center.Z);
                points = HorizontalReflection(points);
                points = ShiftPoints(points, center.X, center.Y, center.Z);
                //points2 = ShiftPoints(points2, -center.X, -center.Y, -center.Z);
                //points2 = HorizontalReflection(points2);
                //points2 = ShiftPoints(points2, center.X, center.Y, center.Z);
                //DrawAxis();
                //DrawFigure();

                DrawProectionAxis();
                DrawTetrahedron();
            }
        }

        private void Vertical_Click(object sender, EventArgs e)
        {
            points = ShiftPoints(points, -center.X, -center.Y, -center.Z);
            points = VerticalReflection(points);
            points = ShiftPoints(points, center.X, center.Y, center.Z);
            //points2 = ShiftPoints(points2, -center.X, -center.Y, -center.Z);
            //points2 = VerticalReflection(points2);
            //points2 = ShiftPoints(points2, center.X, center.Y, center.Z);
            //DrawAxis();
            //DrawFigure();

            DrawProectionAxis();
            DrawTetrahedron();
        }

        //?? ?????????? Z
        private void Shift_Click(object sender, EventArgs e)
        {

            {
                double X = Double.Parse(XShiftTB.Text);
                double Y = Double.Parse(YShiftTB.Text);
                double Z = Double.Parse(ZShiftTB.Text);

                points = ShiftPoints(points, X, -Y, Z);
                //points2 = ShiftPoints(points2, X, -Y, Z);
                GetCenter();
                //DrawAxis();
                //DrawFigure();
                DrawProectionAxis();
                DrawTetrahedron();
            }
        }

        //?? ?????????? Z
        private void Scale_Click(object sender, EventArgs e)
        {

            {
                double X = Double.Parse(XScaleTB.Text);
                double Y = Double.Parse(YScaleTB.Text);
                double Z = Double.Parse(ZScaleTB.Text);

                points = ShiftPoints(points, -center.X, -center.Y, -center.Z);
                points = ScaleMatrix(points, X, Y, Z);
                points = ShiftPoints(points, center.X, center.Y, center.Z);
                //points2 = ShiftPoints(points2, -center.X, -center.Y, -center.Z);
                //points2 = ScaleMatrix(points2, X, Y, Z);
                //points2 = ShiftPoints(points2, center.X, center.Y, center.Z);
                //DrawAxis();
                //DrawFigure();

                DrawProectionAxis();
                DrawTetrahedron();
            }
        }

        //???????????? ??? Y
        private void Rotate_Click(object sender, EventArgs e)
        {
            int degree = int.Parse(RotateTB.Text);
            points = ShiftPoints(points, -center.X, -center.Y, -center.Z);
            points = RotatePointsY(points, degree);
            points = ShiftPoints(points, center.X, center.Y, center.Z);
            //points2 = ShiftPoints(points2, -center.X, -center.Y, -center.Z);
            //points2 = RotatePointsY(points2, degree);
            //points2 = ShiftPoints(points2, center.X, center.Y, center.Z);

            //DrawAxis();
            //DrawFigure();

            DrawProectionAxis();
            DrawTetrahedron();
        }

        private void RotateX_Click(object sender, EventArgs e)
        {
            int degree = int.Parse(RotateTB.Text);
            points = ShiftPoints(points, -center.X, -center.Y, -center.Z);
            points = RotatePointsX(points, degree);
            points = ShiftPoints(points, center.X, center.Y, center.Z);
            //points2 = ShiftPoints(points2, -center.X, -center.Y, -center.Z);
            //points2 = RotatePointsX(points2, degree);
            //points2 = ShiftPoints(points2, center.X, center.Y, center.Z);

            //DrawAxis();
            //DrawFigure();

            DrawProectionAxis();
            DrawTetrahedron();
        }

        private void RotateZ_Click(object sender, EventArgs e)
        {
            int degree = int.Parse(RotateTB.Text);
            points = ShiftPoints(points, -center.X, -center.Y, -center.Z);
            points = RotatePointsZ(points, degree);
            points = ShiftPoints(points, center.X, center.Y, center.Z);
            //points2 = ShiftPoints(points2, -center.X, -center.Y, -center.Z);
            //points2 = RotatePointsZ(points2, degree);
            //points2 = ShiftPoints(points2, center.X, center.Y, center.Z);

            //DrawAxis();
            //DrawFigure();

            DrawProectionAxis();
            DrawTetrahedron();
        }

        private void ZReflectionButton_Click(object sender, EventArgs e)
        {
            points = ShiftPoints(points, -center.X, -center.Y, -center.Z);
            points = ZReflection(points);
            points = ShiftPoints(points, center.X, center.Y, center.Z);
            //points2 = ShiftPoints(points2, -center.X, -center.Y, -center.Z);
            //points2 = ZReflection(points2);
            //points2 = ShiftPoints(points2, center.X, center.Y, center.Z);
            //DrawAxis();
            //DrawFigure();

            DrawProectionAxis();
            DrawTetrahedron();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Coefficient_Scroll(object sender, EventArgs e)
        {
            k = Coefficient.Value * 0.02;
            LabelCoefficient.Text = String.Format("{0:F2}", k);

            //Refresh();
            pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            W = ClientSize.Width;
            H = ClientSize.Height;
            step = 50;
            stepZ = 30;

            SetProectionMatrix();
            DrawProectionAxis();
            SetPointsTetrahedron();
            DrawTetrahedron();

            pen.Width = 3;
            center = GetCenter();
            g.Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AngleXMinus_CheckedChanged(object sender, EventArgs e)
        {
            angleXMark = -1;

            pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            W = ClientSize.Width;
            H = ClientSize.Height;
            step = 50;
            stepZ = 30;

            SetProectionMatrix();
            DrawProectionAxis();
            SetPointsTetrahedron();
            DrawTetrahedron();

            pen.Width = 3;
            center = GetCenter();
            g.Dispose();
        }

        private void AngleXPlus_CheckedChanged(object sender, EventArgs e)
        {
            angleXMark = 1;

            pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            W = ClientSize.Width;
            H = ClientSize.Height;
            step = 50;
            stepZ = 30;

            SetProectionMatrix();
            DrawProectionAxis();
            SetPointsTetrahedron();
            DrawTetrahedron();

            pen.Width = 3;
            center = GetCenter();
            g.Dispose();
        }

        private void AngleYMinus_CheckedChanged(object sender, EventArgs e)
        {
            angleYMark = -1;

            pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            W = ClientSize.Width;
            H = ClientSize.Height;
            step = 50;
            stepZ = 30;

            SetProectionMatrix();
            DrawProectionAxis();
            SetPointsTetrahedron();
            DrawTetrahedron();

            pen.Width = 3;
            center = GetCenter();
            g.Dispose();
        }

        private void AngleYPlus_CheckedChanged(object sender, EventArgs e)
        {
            angleYMark = 1;

            pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            W = ClientSize.Width;
            H = ClientSize.Height;
            step = 50;
            stepZ = 30;

            SetProectionMatrix();
            DrawProectionAxis();
            SetPointsTetrahedron();
            DrawTetrahedron();

            pen.Width = 3;
            center = GetCenter();
            g.Dispose();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void XScaleTB_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class SpacePoint
    {
        public double X;
        public double Y;
        public double Z;

        public SpacePoint(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public SpacePoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}


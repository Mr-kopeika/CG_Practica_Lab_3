using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tao.OpenGl;
using GlmSharp;

namespace OpenGL_Lab
{
    public partial class Form1 : Form
    {
        int corners = 3;
        double radius = 2;
        SpacePoint centerFirst = new SpacePoint(0, 0, 0);
        SpacePoint centerSecond = new SpacePoint(0, 0, 0);
        double step = 0.1;
        SpacePoint[] firstFigure;
        SpacePoint[] secondFigure;
        float[] matrixFirst = new float[16];
        float[] matrixSecond = new float[16];
        

        public Form1()
        {
            InitializeComponent();
            Holst.InitializeContexts();

            Gl.glViewport(0, 0, Holst.Width, Holst.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);



            firstFigure = GetPointsFirstFigure(corners, centerFirst, radius);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            centerFirst.X += -0.5 / step;
            centerFirst.Y += -0.5 / step;
            Gl.glTranslated(-0.5, -0.5, 0);
            DrawFirstFigure(firstFigure);
            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
            Gl.glLoadIdentity();
            matrixFirst[12] = matrixFirst[12] / (float)step;
            matrixFirst[13] = matrixFirst[13] / (float)step;
            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));

            Gl.glLoadIdentity();
            secondFigure = GetPointsSecondFigure(centerSecond, radius * 3);
            DrawSecondFigure(secondFigure);
            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
            Gl.glLoadIdentity();

            Holst.Invalidate();
        }

        private void Holst_Paint(object sender, PaintEventArgs e) { }

        private void DrawFirstFigure(SpacePoint[] figure)
        {
            Gl.glLineWidth(3);
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3d(0, 0, 0); Gl.glVertex2d(figure[4].X * step, figure[4].Y * step);
            Gl.glColor3d(1, 0, 0); Gl.glVertex2d(figure[3].X * step, figure[3].Y * step);
            Gl.glColor3d(0, 1, 0); Gl.glVertex2d(figure[2].X * step, figure[2].Y * step);
            Gl.glColor3d(0, 0, 0); Gl.glVertex2d(figure[4].X * step, figure[4].Y * step);
            Gl.glColor3d(1, 0, 0); Gl.glVertex2d(figure[0].X * step, figure[0].Y * step);
            Gl.glColor3d(0, 1, 0); Gl.glVertex2d(figure[2].X * step, figure[2].Y * step);
            Gl.glColor3d(0, 0, 0); Gl.glVertex2d(figure[1].X * step, figure[1].Y * step);
            Gl.glColor3d(1, 0, 0); Gl.glVertex2d(figure[3].X * step, figure[3].Y * step);
            Gl.glColor3d(0, 1, 0); Gl.glVertex2d(figure[5].X * step, figure[5].Y * step);
            Gl.glColor3d(0, 0, 0); Gl.glVertex2d(figure[1].X * step, figure[1].Y * step);
            Gl.glColor3d(1, 0, 0); Gl.glVertex2d(figure[0].X * step, figure[0].Y * step);
            Gl.glColor3d(0, 1, 0); Gl.glVertex2d(figure[5].X * step, figure[5].Y * step);
            Gl.glColor3d(0, 0, 0); Gl.glVertex2d(figure[4].X * step, figure[4].Y * step);
            Gl.glEnd();

            Holst.Invalidate();
        }
        private SpacePoint[] GetPointsFirstFigure(int corners, SpacePoint center, double radius)
        {
            SpacePoint[] figure = new SpacePoint[6];

            SpacePoint[] points = GetPointsRegularPolygon(corners, center, radius / 4);
            points = RotatePointsZ(points, -90);
            figure[0] = points[0];
            figure[1] = points[1];
            figure[2] = points[2];

            points = GetPointsRegularPolygon(corners, center, radius);
            points = RotatePointsZ(points, 90);
            figure[3] = points[0];
            figure[4] = points[1];
            figure[5] = points[2];

            return figure;
        }
        private SpacePoint[] GetPointsRegularPolygon(int corners, SpacePoint center, double radius)
        {
            SpacePoint[] points = new SpacePoint[corners];
            for (int i = 0; i < corners; i++) { points[i] = new SpacePoint(); }

            double z = 0;
            for (int i = 0; i < corners; i++)
            {
                points[i].X = center.X + Math.Cos((Math.PI * z) / 180) * radius;
                points[i].Y = center.Y + Math.Sin((Math.PI * z) / 180) * radius;
                z += 360 / corners;
            }   

            return points;
        }

        private void DrawSecondFigure(SpacePoint[] figure) 
        {
            Gl.glLineWidth(3);
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3d(0, 0, 0);
            Gl.glVertex2d(figure[4].X * step, figure[4].Y * step);
            Gl.glVertex2d(figure[0].X * step, figure[0].Y * step);
            Gl.glVertex2d(figure[8].X * step, figure[8].Y * step);
            Gl.glVertex2d(figure[1].X * step, figure[1].Y * step);
            Gl.glVertex2d(figure[5].X * step, figure[5].Y * step);
            Gl.glVertex2d(figure[8].X * step, figure[8].Y * step);
            Gl.glVertex2d(figure[4].X * step, figure[4].Y * step);
            Gl.glVertex2d(figure[7].X * step, figure[7].Y * step);
            Gl.glVertex2d(figure[9].X * step, figure[9].Y * step);
            Gl.glVertex2d(figure[6].X * step, figure[6].Y * step);
            Gl.glVertex2d(figure[5].X * step, figure[5].Y * step);
            Gl.glVertex2d(figure[6].X * step, figure[6].Y * step);
            Gl.glVertex2d(figure[2].X * step, figure[2].Y * step);
            Gl.glVertex2d(figure[9].X * step, figure[9].Y * step);
            Gl.glVertex2d(figure[3].X * step, figure[3].Y * step);
            Gl.glVertex2d(figure[7].X * step, figure[7].Y * step);
            Gl.glEnd();

            Holst.Invalidate();
        }
        private SpacePoint[] GetPointsSecondFigure(SpacePoint center, double radius)
        {
            SpacePoint[] figure = new SpacePoint[10];
            figure[0] = new SpacePoint(center.X - radius / 2, center.Y + radius / 2, 0);
            figure[1] = new SpacePoint(center.X + radius / 2, center.Y + radius / 2, 0);
            figure[2] = new SpacePoint(center.X + radius / 2, center.Y - radius / 2, 0);
            figure[3] = new SpacePoint(center.X - radius / 2, center.Y - radius / 2, 0);
            figure[4] = new SpacePoint(center.X - radius / 2, center.Y + radius / 3, 0);
            figure[5] = new SpacePoint(center.X + radius / 2, center.Y + radius / 3, 0);
            figure[6] = new SpacePoint(center.X + radius / 2, center.Y - radius / 3, 0);
            figure[7] = new SpacePoint(center.X - radius / 2, center.Y - radius / 3, 0);
            figure[8] = new SpacePoint(center.X, center.Y + radius / 3, 0);
            figure[9] = new SpacePoint(center.X, center.Y - radius / 3, 0);
            return figure;
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
        public double[,] ToMatrix(float[] array)
        {
            double[,] matrix = new double[4, 4];
            for (int i = 0; i < array.Length; i++)
            {
                matrix[i / matrix.GetLength(0), i % matrix.GetLength(0)] = array[i];
            }
            return matrix;
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
        public SpacePoint GetCenterFirstFigure()
        {
            SpacePoint center = new SpacePoint();

            center.X = firstFigure[0].X + 2.0 * (((firstFigure[1].X + firstFigure[2].X) / 2) - firstFigure[0].X) / 3.0;
            center.Y = firstFigure[0].Y + 2.0 * (((firstFigure[1].Y + firstFigure[2].Y) / 2) - firstFigure[0].Y) / 3.0;
            return center;
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

            public SpacePoint() { }
        }

        private void Holst_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.A:

                    if (RBFigureFirst.Checked == true)
                    {
                        if (RBRotate.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            DrawSecondFigure(secondFigure);

                            //draw rotate
                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerFirst.X, centerFirst.Y, centerFirst.Z);
                            Gl.glRotated(15, 0, 0, 1);
                            Gl.glTranslated(-centerFirst.X, -centerFirst.Y, -centerFirst.Z);
                            
                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                            Gl.glLoadIdentity();

                            //update points
                            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                            DrawFirstFigure(firstFigure);

                            Holst.Invalidate();
                        }

                        if (RBScale.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadMatrixf(matrixSecond);
                            DrawSecondFigure(secondFigure);

                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerFirst.X, centerFirst.Y, centerFirst.Z);
                            Gl.glScaled(0.9, 1, 1);
                            Gl.glTranslated(-centerFirst.X, -centerFirst.Y, -centerFirst.Z);
                            
                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                            Gl.glLoadIdentity();
  

                            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                            DrawFirstFigure(firstFigure);
                            Holst.Invalidate();
                        }

                        if (RBShift.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadMatrixf(matrixSecond);
                            DrawSecondFigure(secondFigure);

                            Gl.glLoadIdentity();
                            centerFirst.X += -0.1;
                            centerFirst.Y += 0 / step;
                            Gl.glTranslated(-0.1 * step, 0, 0);
                            
                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                            Gl.glLoadIdentity();
                            
                            matrixFirst[12] = matrixFirst[12] / (float)step;
                            matrixFirst[13] = matrixFirst[13] / (float)step;
                            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                            DrawFirstFigure(firstFigure);
                            Holst.Invalidate();
                        }
                    }

                    if (RBFigureSecond.Checked == true)
                    {
                        if (RBRotate.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadIdentity();
                            DrawFirstFigure(firstFigure);

                            //draw rotate
                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerSecond.X, centerSecond.Y, centerSecond.Z);
                            Gl.glRotated(15, 0, 0, 1);
                            Gl.glTranslated(-centerSecond.X, -centerSecond.Y, -centerSecond.Z);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
                            Gl.glLoadIdentity();

                            //update points
                            secondFigure = ToPoints(MultyplicationMatrix(ToMatrix(secondFigure), ToMatrix(matrixSecond)));
                            DrawSecondFigure(secondFigure);

                            Holst.Invalidate();
                        }

                        if (RBScale.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadIdentity();
                            DrawFirstFigure(firstFigure);

                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerSecond.X, centerSecond.Y, centerSecond.Z);
                            Gl.glScaled(0.9, 1, 1);
                            Gl.glTranslated(-centerSecond.X, -centerSecond.Y, -centerSecond.Z);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
                            Gl.glLoadIdentity();


                            secondFigure = ToPoints(MultyplicationMatrix(ToMatrix(secondFigure), ToMatrix(matrixSecond)));
                            DrawSecondFigure(secondFigure);
                            Holst.Invalidate();
                        }

                        if (RBShift.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadIdentity();
                            DrawFirstFigure(firstFigure);

                            Gl.glLoadIdentity();
                            centerSecond.X += -0.1;
                            centerSecond.Y += 0 / step;
                            Gl.glTranslated(-0.1 * step, 0, 0);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
                            Gl.glLoadIdentity();

                            matrixSecond[12] = matrixSecond[12] / (float)step;
                            matrixSecond[13] = matrixSecond[13] / (float)step;
                            secondFigure = ToPoints(MultyplicationMatrix(ToMatrix(secondFigure), ToMatrix(matrixSecond)));
                            DrawSecondFigure(secondFigure);
                            Holst.Invalidate();
                        }
                    }
                    break;
                case Keys.D:
                    if (RBFigureFirst.Checked == true)
                    {
                        if (RBRotate.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            DrawSecondFigure(secondFigure);

                            //draw rotate
                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerFirst.X, centerFirst.Y, centerFirst.Z);
                            Gl.glRotated(-15, 0, 0, 1);
                            Gl.glTranslated(-centerFirst.X, -centerFirst.Y, -centerFirst.Z);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                            Gl.glLoadIdentity();

                            //update points
                            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                            DrawFirstFigure(firstFigure);

                            Holst.Invalidate();
                        }

                        if (RBScale.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadMatrixf(matrixSecond);
                            DrawSecondFigure(secondFigure);

                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerFirst.X, centerFirst.Y, centerFirst.Z);
                            Gl.glScaled(1.111, 1, 1);
                            Gl.glTranslated(-centerFirst.X, -centerFirst.Y, -centerFirst.Z);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                            Gl.glLoadIdentity();


                            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                            DrawFirstFigure(firstFigure);
                            Holst.Invalidate();
                        }

                        if (RBShift.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadMatrixf(matrixSecond);
                            DrawSecondFigure(secondFigure);

                            Gl.glLoadIdentity();
                            centerFirst.X += 0.1;
                            centerFirst.Y += 0 / step;
                            Gl.glTranslated(0.1 * step, 0, 0);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                            Gl.glLoadIdentity();

                            matrixFirst[12] = matrixFirst[12] / (float)step;
                            matrixFirst[13] = matrixFirst[13] / (float)step;
                            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                            DrawFirstFigure(firstFigure);
                            Holst.Invalidate();
                        }
                    }

                    if (RBFigureSecond.Checked == true)
                    {
                        if (RBRotate.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadIdentity();
                            DrawFirstFigure(firstFigure);

                            //draw rotate
                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerSecond.X, centerSecond.Y, centerSecond.Z);
                            Gl.glRotated(-15, 0, 0, 1);
                            Gl.glTranslated(-centerSecond.X, -centerSecond.Y, -centerSecond.Z);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
                            Gl.glLoadIdentity();

                            //update points
                            secondFigure = ToPoints(MultyplicationMatrix(ToMatrix(secondFigure), ToMatrix(matrixSecond)));
                            DrawSecondFigure(secondFigure);

                            Holst.Invalidate();
                        }

                        if (RBScale.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadIdentity();
                            DrawFirstFigure(firstFigure);

                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerSecond.X, centerSecond.Y, centerSecond.Z);
                            Gl.glScaled(1.111, 1, 1);
                            Gl.glTranslated(-centerSecond.X, -centerSecond.Y, -centerSecond.Z);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
                            Gl.glLoadIdentity();


                            secondFigure = ToPoints(MultyplicationMatrix(ToMatrix(secondFigure), ToMatrix(matrixSecond)));
                            DrawSecondFigure(secondFigure);
                            Holst.Invalidate();
                        }

                        if (RBShift.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadIdentity();
                            DrawFirstFigure(firstFigure);

                            Gl.glLoadIdentity();
                            centerSecond.X += 0.1;
                            centerSecond.Y += 0 / step;
                            Gl.glTranslated(0.1 * step, 0, 0);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
                            Gl.glLoadIdentity();

                            matrixSecond[12] = matrixSecond[12] / (float)step;
                            matrixSecond[13] = matrixSecond[13] / (float)step;
                            secondFigure = ToPoints(MultyplicationMatrix(ToMatrix(secondFigure), ToMatrix(matrixSecond)));
                            DrawSecondFigure(secondFigure);
                            Holst.Invalidate();
                        }
                    }
                    break;
                case Keys.W:
                    if (RBFigureFirst.Checked == true)
                    {
                        if (RBScale.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadMatrixf(matrixSecond);
                            DrawSecondFigure(secondFigure);

                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerFirst.X, centerFirst.Y, centerFirst.Z);
                            Gl.glScaled(1, 1.111, 1);
                            Gl.glTranslated(-centerFirst.X, -centerFirst.Y, -centerFirst.Z);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                            Gl.glLoadIdentity();


                            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                            DrawFirstFigure(firstFigure);
                            Holst.Invalidate();
                        }

                        if (RBShift.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadMatrixf(matrixSecond);
                            DrawSecondFigure(secondFigure);

                            Gl.glLoadIdentity();
                            centerFirst.X += 0;
                            centerFirst.Y += 0.1;
                            Gl.glTranslated(0, 0.1 * step, 0);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                            Gl.glLoadIdentity();

                            matrixFirst[12] = matrixFirst[12] / (float)step;
                            matrixFirst[13] = matrixFirst[13] / (float)step;
                            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                            DrawFirstFigure(firstFigure);
                            Holst.Invalidate();
                        }
                    }

                    if (RBFigureSecond.Checked == true)
                    {
                        if (RBScale.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadIdentity();
                            DrawFirstFigure(firstFigure);

                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerSecond.X, centerSecond.Y, centerSecond.Z);
                            Gl.glScaled(1, 1.111, 1);
                            Gl.glTranslated(-centerSecond.X, -centerSecond.Y, -centerSecond.Z);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
                            Gl.glLoadIdentity();


                            secondFigure = ToPoints(MultyplicationMatrix(ToMatrix(secondFigure), ToMatrix(matrixSecond)));
                            DrawSecondFigure(secondFigure);
                            Holst.Invalidate();
                        }

                        if (RBShift.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadIdentity();
                            DrawFirstFigure(firstFigure);

                            Gl.glLoadIdentity();
                            centerSecond.X += 0;
                            centerSecond.Y += 0.1;
                            Gl.glTranslated(0, 0.1 * step, 0);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
                            Gl.glLoadIdentity();

                            matrixSecond[12] = matrixSecond[12] / (float)step;
                            matrixSecond[13] = matrixSecond[13] / (float)step;
                            secondFigure = ToPoints(MultyplicationMatrix(ToMatrix(secondFigure), ToMatrix(matrixSecond)));
                            DrawSecondFigure(secondFigure);
                            Holst.Invalidate();
                        }
                    }
                    break;
                case Keys.S:
                    if (RBFigureFirst.Checked == true)
                    {
                        if (RBScale.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadMatrixf(matrixSecond);
                            DrawSecondFigure(secondFigure);

                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerFirst.X, centerFirst.Y, centerFirst.Z);
                            Gl.glScaled(1, 0.9, 1);
                            Gl.glTranslated(-centerFirst.X, -centerFirst.Y, -centerFirst.Z);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                            Gl.glLoadIdentity();


                            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                            DrawFirstFigure(firstFigure);
                            Holst.Invalidate();
                        }

                        if (RBShift.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadMatrixf(matrixSecond);
                            DrawSecondFigure(secondFigure);

                            Gl.glLoadIdentity();
                            centerFirst.X += 0;
                            centerFirst.Y += -0.1;
                            Gl.glTranslated(0, -0.1 * step, 0);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                            Gl.glLoadIdentity();

                            matrixFirst[12] = matrixFirst[12] / (float)step;
                            matrixFirst[13] = matrixFirst[13] / (float)step;
                            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                            DrawFirstFigure(firstFigure);
                            Holst.Invalidate();
                        }
                    }

                    if (RBFigureSecond.Checked == true)
                    {
                        if (RBScale.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadIdentity();
                            DrawFirstFigure(firstFigure);

                            Gl.glLoadIdentity();
                            Gl.glTranslated(centerSecond.X, centerSecond.Y, centerSecond.Z);
                            Gl.glScaled(1, 0.9, 1);
                            Gl.glTranslated(-centerSecond.X, -centerSecond.Y, -centerSecond.Z);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
                            Gl.glLoadIdentity();


                            secondFigure = ToPoints(MultyplicationMatrix(ToMatrix(secondFigure), ToMatrix(matrixSecond)));
                            DrawSecondFigure(secondFigure);
                            Holst.Invalidate();
                        }

                        if (RBShift.Checked == true)
                        {
                            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                            Gl.glMatrixMode(Gl.GL_MODELVIEW);
                            Gl.glLoadIdentity();
                            DrawFirstFigure(firstFigure);

                            Gl.glLoadIdentity();
                            centerSecond.X += 0;
                            centerSecond.Y += -0.1;
                            Gl.glTranslated(0, -0.1 * step, 0);

                            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
                            Gl.glLoadIdentity();

                            matrixSecond[12] = matrixSecond[12] / (float)step;
                            matrixSecond[13] = matrixSecond[13] / (float)step;
                            secondFigure = ToPoints(MultyplicationMatrix(ToMatrix(secondFigure), ToMatrix(matrixSecond)));
                            DrawSecondFigure(secondFigure);
                            Holst.Invalidate();
                        }
                    }
                    break;
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LeftRotate.Checked == true)
            {
                if (LoopCB.Checked == false)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    Gl.glMatrixMode(Gl.GL_MODELVIEW);
                    DrawSecondFigure(secondFigure);
                } 


                Gl.glLoadIdentity();
                Gl.glTranslated(centerSecond.X, centerSecond.Y, centerSecond.Z);
                Gl.glRotated(3, 0, 0, 1);
                Gl.glTranslated(-centerSecond.X, -centerSecond.Y, -centerSecond.Z);

                Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                Gl.glLoadIdentity();


                firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                DrawFirstFigure(firstFigure);
                centerFirst = GetCenterFirstFigure();
                Holst.Invalidate();
            }

            if (RightRotate.Checked == true)
            {
                if (LoopCB.Checked == false)
                {
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    Gl.glMatrixMode(Gl.GL_MODELVIEW);
                    DrawSecondFigure(secondFigure);
                }

                Gl.glLoadIdentity();
                Gl.glTranslated(centerSecond.X, centerSecond.Y, centerSecond.Z);
                Gl.glRotated(-3, 0, 0, 1);
                Gl.glTranslated(-centerSecond.X, -centerSecond.Y, -centerSecond.Z);

                Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
                Gl.glLoadIdentity();


                firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));
                DrawFirstFigure(firstFigure);
                centerFirst = GetCenterFirstFigure();
                Holst.Invalidate();
            }
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void StopRotate_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            centerFirst = new SpacePoint(0, 0, 0);
            centerSecond = new SpacePoint(0, 0, 0);

            Gl.glViewport(0, 0, Holst.Width, Holst.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            firstFigure = GetPointsFirstFigure(corners, centerFirst, radius);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            centerFirst.X += -0.5 / step;
            centerFirst.Y += -0.5 / step;
            Gl.glTranslated(-0.5, -0.5, 0);
            DrawFirstFigure(firstFigure);
            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixFirst);
            Gl.glLoadIdentity();
            matrixFirst[12] = matrixFirst[12] / (float)step;
            matrixFirst[13] = matrixFirst[13] / (float)step;
            firstFigure = ToPoints(MultyplicationMatrix(ToMatrix(firstFigure), ToMatrix(matrixFirst)));

            Gl.glLoadIdentity();
            secondFigure = GetPointsSecondFigure(centerSecond, radius * 3);
            DrawSecondFigure(secondFigure);
            Gl.glGetFloatv(Gl.GL_MODELVIEW_MATRIX, matrixSecond);
            Gl.glLoadIdentity();

        }
    }
}

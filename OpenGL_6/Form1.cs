using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace OpenGL_6
{
    public partial class Form1 : Form
    {
        int corners = 5;
        double[] center = new double[4] { 0, 0, 0, 0 };
        double radius = 4;
        double step = 0.2;
        double[,] proectionMatrix;
        double[] pMatrix = new double[16];
        double angleX = 30 * Math.PI / 180;
        double angleY = 45 * Math.PI / 180;
        double[,] startPositionFigure = new double[6, 4];
        double Xstep = 0;
        double Ystep = 0;
        double Zstep = 0;
        double Xrotate = 0;
        double Yrotate = 0;
        double Zrotate = 0;
        double Xscale = 0;
        double Yscale = 0;
        double Zscale = 0;



        public Form1()
        {
            InitializeComponent();
            Holst.InitializeContexts();

            Gl.glViewport(0, 0, Holst.Width, Holst.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LINE_STIPPLE);
            Gl.glEnable(Gl.GL_CULL_FACE);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            //Gl.glOrtho(-1.0, -1.0, -1.0, 1.0, -1.0, 1.0);

            Gl.glFrustum(-1f, 1f, -1f, 1f, 3f, 10);
            Gl.glTranslated(0, 0, -5);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            

            //SetProectionMatrix();
            //for(int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        pMatrix[i * 4 + j] = proectionMatrix[i, j];
            //    }
            //}

            //Gl.glLoadMatrixd(pMatrix);
            
            //DrawAxis();

            SetFigurePosition();

            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            Gl.glCullFace(Gl.GL_FRONT);
            Gl.glLineStipple(2, 0XFFFF);
            Gl.glPopMatrix();
            DrawFigure();
            Gl.glPushMatrix();

            Gl.glCullFace(Gl.GL_BACK);
            Gl.glLineStipple(2, 0X00FF);
            Gl.glPopMatrix();
            DrawFigure();
            Gl.glPushMatrix();



            Holst.Invalidate();
        }

        public void DrawFigure()
        {
            double[,] spf = startPositionFigure;
            Gl.glLineWidth(3);
            Gl.glColor3b(0, 0, 0);
            Gl.glBegin(Gl.GL_TRIANGLES);

                Gl.glVertex3d(step * spf[0, 0], step * spf[0, 1], step * spf[0, 2]);
                Gl.glVertex3d(step * spf[1, 0], step * spf[1, 1], step * spf[1, 2]);
                Gl.glVertex3d(step * spf[2, 0], step * spf[2, 1], step * spf[2, 2]);

            Gl.glVertex3d(step * spf[0, 0], step * spf[0, 1], step * spf[0, 2]);
                Gl.glVertex3d(step * spf[2, 0], step * spf[2, 1], step * spf[2, 2]);
                Gl.glVertex3d(step * spf[3, 0], step * spf[3, 1], step * spf[3, 2]);

            Gl.glVertex3d(step * spf[0, 0], step * spf[0, 1], step * spf[0, 2]);
                Gl.glVertex3d(step * spf[3, 0], step * spf[3, 1], step * spf[3, 2]);
                Gl.glVertex3d(step * spf[4, 0], step * spf[4, 1], step * spf[4, 2]);

            Gl.glVertex3d(step * spf[0, 0], step * spf[0, 1], step * spf[0, 2]);
                Gl.glVertex3d(step * spf[4, 0], step * spf[4, 1], step * spf[4, 2]);
                Gl.glVertex3d(step * spf[5, 0], step * spf[5, 1], step * spf[5, 2]);

            Gl.glVertex3d(step * spf[0, 0], step * spf[0, 1], step * spf[0, 2]);
                Gl.glVertex3d(step * spf[5, 0], step * spf[5, 1], step * spf[5, 2]);
                Gl.glVertex3d(step * spf[1, 0], step * spf[1, 1], step * spf[1, 2]);

            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3d(step * spf[5, 0], step * spf[5, 1], step * spf[5, 2]);
            Gl.glVertex3d(step * spf[4, 0], step * spf[4, 1], step * spf[4, 2]);
            Gl.glVertex3d(step * spf[3, 0], step * spf[3, 1], step * spf[3, 2]);
            Gl.glVertex3d(step * spf[2, 0], step * spf[2, 1], step * spf[2, 2]);
            Gl.glVertex3d(step * spf[1, 0], step * spf[1, 1], step * spf[1, 2]);
            Gl.glEnd();
        }
        
        public void DrawAxis() 
        {
            Gl.glLineWidth(1);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3d(255, 0, 0);
            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(5 * step, 0, 0);
            Gl.glColor3d(0, 255, 0);
            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0, 5 * step, 0);
            Gl.glColor3d(0, 0, 255);
            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0, 0, 5 * step);
            Gl.glEnd();
        }

        public void SetFigurePosition()
        {
            startPositionFigure[0, 0] = 0;
            startPositionFigure[0, 1] = 7;
            startPositionFigure[0, 2] = 0;
            startPositionFigure[0, 3] = 0;

            double[,] position = GetPointsRegularPolygon(corners, center, radius);
            for(int i = 1; i < startPositionFigure.GetLength(0); i++)
            {
                for(int j = 0; j < startPositionFigure.GetLength(1); j++)
                {
                    startPositionFigure[i, j] = position[i - 1, j];
                }
            }
        }

        public void SetProectionMatrix()
        {
            proectionMatrix = new double[,]
            {
                {Math.Cos(angleY), Math.Sin(angleY) * Math.Sin(angleX), 0, 0 },
                {0, Math.Cos(angleX), 0, 0 },
                {Math.Sin(angleY), -1 * Math.Cos(angleY) * Math.Sin(angleX), 0, 0 },
                {0, 0, 0, 1 }
            };
        }

        //модифицировано - задает матрицу точек для плосксти XoZ (вместо XoY)
        private double[,] GetPointsRegularPolygon(int corners, double[] center, double radius)
        {
            double[,] points = new double[corners, 4];

            double z = 0;
            for (int i = 0; i < corners; i++)
            {
                points[i, 0] = center[0] + Math.Cos((Math.PI * z) / 180) * radius;
                points[i, 1] = 0;
                points[i, 2] = center[2] + Math.Sin((Math.PI * z) / 180) * radius;
                points[i, 3] = 0;
                z += 360 / corners;
            }

            return points;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Yrotate += 20 * Math.PI / 180;
            Xrotate += 15 * Math.PI / 180;
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            //Gl.glTranslated(0, 0, -7);
            Gl.glRotated(Yrotate, 0, 1, 0);
            Gl.glRotated(Yrotate, 1, 0, 0);

            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            Gl.glCullFace(Gl.GL_BACK);
            Gl.glLineStipple(2, 0X00FF);
            DrawFigure();

            Gl.glCullFace(Gl.GL_FRONT);
            Gl.glLineStipple(2, 0XFFFF);
            DrawFigure();

            Gl.glLoadIdentity();
            //DrawAxis();

            Holst.Invalidate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void Holst_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

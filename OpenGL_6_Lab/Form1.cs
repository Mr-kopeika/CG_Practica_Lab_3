using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace OpenGL_6_Lab
{
    public partial class Form1 : Form
    {

        double step = 0.08;
        double[,] proectionMatrix;
        double[] pMatrix = new double[16];
        double angleX = 30 * Math.PI / 180;
        double angleY = 30 * Math.PI / 180;
        double[,] cube = new double[8, 3]
        {
            { 0, 0, 0 }, //0
            { 3, 0, 0 }, //1
            { 3, 0, 3 }, //2
            { 0, 0, 3 }, //3
            { 0, 3, 0 }, //4
            { 3, 3, 0 }, //5
            { 3, 3, 3 }, //6
            { 0, 3, 3 }  //7
        };
        double[,] pyramid1 = new double[5, 3]
        {
            { 5, 5, 5 },
            { 4, 0, 4 },
            { 4, 0, 6 },
            { 6, 0, 6 },
            { 6, 0, 4 }
        };
        double[,] pyramid2 = new double[4, 3]
        {
            { -5, 5, 5},
            { -3, -1, 4},
            { -5, -1, 4},
            { -5, -1, 7}
        };
        double Yrotate = 0;
        double Xrotate = 0;

        public Form1()
        {
            InitializeComponent();
            Holst.InitializeContexts();
            
            Gl.glViewport(0, 0, Holst.Width, Holst.Height);
            Gl.glClearColor( 0.65f, 0.7f, 0.82f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_CULL_FACE);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glFrustum(-1, 1, -1, 1, 3, 10);
            Gl.glTranslated(0, 0, -4);

            //SetProectionMatrix();
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        pMatrix[i * 4 + j] = proectionMatrix[i, j];
            //    }
            //}

            //Gl.glLoadMatrixd(pMatrix);
            //Gl.glOrtho(-1, 1, -1, 1, -1, 1);

            Gl.glCullFace(Gl.GL_BACK);
            DrawAxis();
            DrawCube();
            DrawPyramid1();
            DrawPyramid2();

            Holst.Invalidate();
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

        public void DrawCube()
        {
            Gl.glBegin(Gl.GL_QUADS);

                Gl.glColor3d(255, 0, 0);
                Gl.glVertex3d(cube[0, 0] * step, cube[0, 1] * step, cube[0, 2] * step);
                Gl.glVertex3d(cube[1, 0] * step, cube[1, 1] * step, cube[1, 2] * step);
                Gl.glVertex3d(cube[2, 0] * step, cube[2, 1] * step, cube[2, 2] * step);
                Gl.glVertex3d(cube[3, 0] * step, cube[3, 1] * step, cube[3, 2] * step);

                Gl.glColor3d(255, 255, 0);
                Gl.glVertex3d(cube[3, 0] * step, cube[3, 1] * step, cube[3, 2] * step);
                Gl.glVertex3d(cube[2, 0] * step, cube[2, 1] * step, cube[2, 2] * step);
                Gl.glVertex3d(cube[6, 0] * step, cube[6, 1] * step, cube[6, 2] * step);
                Gl.glVertex3d(cube[7, 0] * step, cube[7, 1] * step, cube[7, 2] * step);

                Gl.glColor3d(0, 255, 0);
                Gl.glVertex3d(cube[2, 0] * step, cube[2, 1] * step, cube[2, 2] * step);
                Gl.glVertex3d(cube[1, 0] * step, cube[1, 1] * step, cube[1, 2] * step);
                Gl.glVertex3d(cube[5, 0] * step, cube[5, 1] * step, cube[5, 2] * step);
                Gl.glVertex3d(cube[6, 0] * step, cube[6, 1] * step, cube[6, 2] * step);

                Gl.glColor3d(0, 255, 255);
                Gl.glVertex3d(cube[1, 0] * step, cube[1, 1] * step, cube[1, 2] * step);
                Gl.glVertex3d(cube[0, 0] * step, cube[0, 1] * step, cube[0, 2] * step);
                Gl.glVertex3d(cube[4, 0] * step, cube[4, 1] * step, cube[4, 2] * step);
                Gl.glVertex3d(cube[5, 0] * step, cube[5, 1] * step, cube[5, 2] * step);

                Gl.glColor3d(0, 0, 255);
                Gl.glVertex3d(cube[0, 0] * step, cube[0, 1] * step, cube[0, 2] * step);
                Gl.glVertex3d(cube[3, 0] * step, cube[3, 1] * step, cube[3, 2] * step);
                Gl.glVertex3d(cube[7, 0] * step, cube[7, 1] * step, cube[7, 2] * step);
                Gl.glVertex3d(cube[4, 0] * step, cube[4, 1] * step, cube[4, 2] * step);

                Gl.glColor3d(255, 0, 255);
                Gl.glVertex3d(cube[7, 0] * step, cube[7, 1] * step, cube[7, 2] * step);
                Gl.glVertex3d(cube[6, 0] * step, cube[6, 1] * step, cube[6, 2] * step);
                Gl.glVertex3d(cube[5, 0] * step, cube[5, 1] * step, cube[5, 2] * step);
                Gl.glVertex3d(cube[4, 0] * step, cube[4, 1] * step, cube[4, 2] * step);

            Gl.glEnd();
        }

        public void DrawPyramid1()
        {
            
            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glColor3b(127, 0, 0);
                Gl.glVertex3d(pyramid1[0, 0] * step, pyramid1[0, 1] * step, pyramid1[0, 2] * step);
                Gl.glVertex3d(pyramid1[2, 0] * step, pyramid1[2, 1] * step, pyramid1[2, 2] * step);
                Gl.glVertex3d(pyramid1[3, 0] * step, pyramid1[3, 1] * step, pyramid1[3, 2] * step);

            Gl.glColor3b(69, 17, 17);
                Gl.glVertex3d(pyramid1[0, 0] * step, pyramid1[0, 1] * step, pyramid1[0, 2] * step);
                Gl.glVertex3d(pyramid1[3, 0] * step, pyramid1[3, 1] * step, pyramid1[3, 2] * step);
                Gl.glVertex3d(pyramid1[4, 0] * step, pyramid1[4, 1] * step, pyramid1[4, 2] * step);

            Gl.glColor3b(70, 0, 0);
                Gl.glVertex3d(pyramid1[0, 0] * step, pyramid1[0, 1] * step, pyramid1[0, 2] * step);
                Gl.glVertex3d(pyramid1[4, 0] * step, pyramid1[4, 1] * step, pyramid1[4, 2] * step);
                Gl.glVertex3d(pyramid1[1, 0] * step, pyramid1[1, 1] * step, pyramid1[1, 2] * step);

            Gl.glColor3b(90, 10, 30);
                Gl.glVertex3d(pyramid1[0, 0] * step, pyramid1[0, 1] * step, pyramid1[0, 2] * step);
                Gl.glVertex3d(pyramid1[1, 0] * step, pyramid1[1, 1] * step, pyramid1[1, 2] * step);
                Gl.glVertex3d(pyramid1[2, 0] * step, pyramid1[2, 1] * step, pyramid1[2, 2] * step);

            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);

                Gl.glVertex3d(pyramid1[4, 0] * step, pyramid1[4, 1] * step, pyramid1[4, 2] * step);
                Gl.glVertex3d(pyramid1[3, 0] * step, pyramid1[3, 1] * step, pyramid1[3, 2] * step);
                Gl.glVertex3d(pyramid1[2, 0] * step, pyramid1[2, 1] * step, pyramid1[2, 2] * step);
                Gl.glVertex3d(pyramid1[1, 0] * step, pyramid1[1, 1] * step, pyramid1[1, 2] * step);

            Gl.glEnd();
        }

        public void DrawPyramid2()
        {
            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glColor3b(127, 0, 0);
            Gl.glVertex3d(pyramid2[0, 0] * step, pyramid2[0, 1] * step, pyramid2[0, 2] * step);
                Gl.glVertex3d(pyramid2[2, 0] * step, pyramid2[2, 1] * step, pyramid2[2, 2] * step);
                Gl.glVertex3d(pyramid2[3, 0] * step, pyramid2[3, 1] * step, pyramid2[3, 2] * step);

            Gl.glColor3b(69, 17, 17);
            Gl.glVertex3d(pyramid2[0, 0] * step, pyramid2[0, 1] * step, pyramid2[0, 2] * step);
                Gl.glVertex3d(pyramid2[3, 0] * step, pyramid2[3, 1] * step, pyramid2[3, 2] * step);
                Gl.glVertex3d(pyramid2[1, 0] * step, pyramid2[1, 1] * step, pyramid2[1, 2] * step);

            Gl.glColor3b(70, 0, 0);
            Gl.glVertex3d(pyramid2[0, 0] * step, pyramid2[0, 1] * step, pyramid2[0, 2] * step);
                Gl.glVertex3d(pyramid2[1, 0] * step, pyramid2[1, 1] * step, pyramid2[1, 2] * step);
                Gl.glVertex3d(pyramid2[2, 0] * step, pyramid2[2, 1] * step, pyramid2[2, 2] * step);

            Gl.glColor3b(90, 10, 30);
            Gl.glVertex3d(pyramid2[1, 0] * step, pyramid2[1, 1] * step, pyramid2[1, 2] * step);
                Gl.glVertex3d(pyramid2[3, 0] * step, pyramid2[3, 1] * step, pyramid2[3, 2] * step);
                Gl.glVertex3d(pyramid2[2, 0] * step, pyramid2[2, 1] * step, pyramid2[2, 2] * step);

            Gl.glEnd();
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

        private void Holst_Paint(object sender, PaintEventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Yrotate += 40 * Math.PI / 180;
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glRotated(Yrotate, 0, 1, 0);
            Xrotate += 20 * Math.PI / 180;
            
            Gl.glRotated(Xrotate, 1, 0, 0);

            DrawCube();
            DrawPyramid1();
            DrawPyramid2();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL);
                Gl.glDisable(Gl.GL_CULL_FACE);
            }
            else
            {
                Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
                Gl.glDisable(Gl.GL_CULL_FACE);
            }
        }
    }
}

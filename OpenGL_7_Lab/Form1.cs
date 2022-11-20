using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace OpenGL_7_Lab
{
    public partial class Form1 : Form
    {
        float[] color_am = { 0f, 0f, 0f };
        double Yrotate = 3;
        double[,] figure = new double[8, 3]
{
            {-2, -2, -0.5},
            {2, -2, -0.5},
            {2, -2, 0.5},
            {-2, -2, 0.5},
            {-2, 2, -0.5},
            {2, 2, -0.5},
            {2, 2, 0.5},
            {-2, 2, 0.5}
};

        public Form1()
        {
            InitializeComponent();
            Holst.InitializeContexts();

            //Настроим туман



        }

        public void DrawFigure()
        {

            Gl.glBegin(Gl.GL_QUADS);

            //Нижняя грань
            Gl.glNormal3d(0, -1, 0);
            Gl.glVertex3d(figure[0, 0], figure[0, 1], figure[0, 2]);
            Gl.glVertex3d(figure[1, 0], figure[1, 1], figure[1, 2]);
            Gl.glVertex3d(figure[2, 0], figure[2, 1], figure[2, 2]);
            Gl.glVertex3d(figure[3, 0], figure[3, 1], figure[3, 2]);

            //Верхняя грань
            Gl.glNormal3d(0, 1, 0);
            Gl.glVertex3d(figure[4, 0], figure[4, 1], figure[4, 2]);
            Gl.glVertex3d(figure[7, 0], figure[7, 1], figure[7, 2]);
            Gl.glVertex3d(figure[6, 0], figure[6, 1], figure[6, 2]);
            Gl.glVertex3d(figure[5, 0], figure[5, 1], figure[5, 2]);


            //Передняя грань
            Gl.glNormal3d(0, 0, 1);
            Gl.glVertex3d(figure[3, 0], figure[3, 1], figure[3, 2]);
            Gl.glVertex3d(figure[2, 0], figure[2, 1], figure[2, 2]);
            Gl.glVertex3d(figure[6, 0], figure[6, 1], figure[6, 2]);
            Gl.glVertex3d(figure[7, 0], figure[7, 1], figure[7, 2]);

            //Задняя грань
            Gl.glNormal3d(0, 0, -1);
            Gl.glVertex3d(figure[4, 0], figure[4, 1], figure[4, 2]);
            Gl.glVertex3d(figure[5, 0], figure[5, 1], figure[5, 2]);
            Gl.glVertex3d(figure[1, 0], figure[1, 1], figure[1, 2]);
            Gl.glVertex3d(figure[0, 0], figure[0, 1], figure[0, 2]);

            //Левая грань
            Gl.glNormal3d(-1, 0, 0);
            Gl.glVertex3d(figure[0, 0], figure[0, 1], figure[0, 2]);
            Gl.glVertex3d(figure[3, 0], figure[3, 1], figure[3, 2]);
            Gl.glVertex3d(figure[7, 0], figure[7, 1], figure[7, 2]);
            Gl.glVertex3d(figure[4, 0], figure[4, 1], figure[4, 2]);

            //Правая грань
            Gl.glNormal3d(1, 0, 0);
            Gl.glVertex3d(figure[1, 0], figure[1, 1], figure[1, 2]);
            Gl.glVertex3d(figure[5, 0], figure[5, 1], figure[5, 2]);
            Gl.glVertex3d(figure[6, 0], figure[6, 1], figure[6, 2]);
            Gl.glVertex3d(figure[2, 0], figure[2, 1], figure[2, 2]);

            Gl.glEnd();
        }

        public void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glRotated(Yrotate, 0, 1, 0);
            // Рисуем цилиндр
            Gl.glPushMatrix();
            Gl.glTranslated(0, -1, 0);
            Gl.glRotated(-90, 1, 0, 0);
            Gl.glColor4f(1, 0, 0, 0.5f);
            Glut.glutSolidCylinder(1, 2, 20, 20);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glColor4f(1, 1, 0, 1);
            Gl.glTranslated(5, 0, 0);
            Glut.glutSolidDodecahedron();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glColor4f(0, 1, 1, 1);
            Gl.glTranslated(-5, 0, 0);
            Glut.glutSolidTeapot(1);
            Gl.glPopMatrix();

        }

        private void Holst_Paint(object sender, PaintEventArgs e)
        {      

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
            Holst.Invalidate();
        }

        private void Holst_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glEnable(Gl.GL_DEPTH_TEST);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glFrustum(-5, 5, -5, 5, 5, 25);
            

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glTranslated(0, 0, -12);
            Gl.glRotated(25, 1, 0, 0);
            Gl.glPushMatrix();

            Gl.glClearColor(0.9f, 0.9f, 0.9f, 1.0f);
            Gl.glViewport(0, 0, Holst.Width, Holst.Height);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            Gl.glEnable(Gl.GL_CULL_FACE);
            Gl.glEnable(Gl.GL_NORMALIZE);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);

            float[] fog_color = new float[] { 0.9f, 0.9f, 0.9f, 1 };
            Gl.glEnable(Gl.GL_FOG);
            Gl.glFogi(Gl.GL_FOG_MODE, Gl.GL_LINEAR);
            Gl.glFogfv(Gl.GL_FOG_COLOR, fog_color);
            Gl.glFogf(Gl.GL_FOG_DENSITY, 0.3f);
            Gl.glFogf(Gl.GL_FOG_START, 8f);
            Gl.glFogf(Gl.GL_FOG_END, 14.0f);

        }
    }
}

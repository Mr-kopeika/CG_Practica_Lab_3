using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace OpenGL_7
{
    public partial class Form1 : Form
    {
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

        double Xrotate = 0;
        double Yrotate = 0;
        float[] light0_dif = { 1, 1, 1 };
        float[] light0_pos = { 0.0f, 0.0f, 1.0f, 0.0f };
        float[] color_am = { 0f, 0f, 0f };


        public Form1()
        {
            InitializeComponent();
            Holst.InitializeContexts();
            Gl.glViewport(0, 0, Holst.Width, Holst.Height);
            Gl.glClearColor(0.5f, 0.2f, 0.6f, 1);

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_CULL_FACE);
            Gl.glEnable(Gl.GL_NORMALIZE);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glLightModelf(Gl.GL_LIGHT_MODEL_TWO_SIDE, Gl.GL_TRUE);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, light0_dif);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light0_pos);
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_EMISSION, color_am);

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glFrustum(-5, 5, -5, 5, 5, 25);
            Gl.glTranslated(0, 0, -10);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glCullFace(Gl.GL_BACK);

            Draw();
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

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glRotated(Xrotate, 1, 0, 0);
            Gl.glRotated(Yrotate, 0, 1, 0);

            DrawFigure();
            Gl.glLoadIdentity();

            Holst.Invalidate();
        }

        private void Holst_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Xrotate += 25 * Math.PI / 180;
            Yrotate += 45 * Math.PI / 180;

            Draw();
        }

        private void рассеяныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_am = new float[] { 0f, 0f, 1f };
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT, color_am);
        }

        private void поХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            light0_pos = new float[] { 1.0f, 0.0f, 0.0f, 0.0f };
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light0_pos);
        }

        private void поУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            light0_pos = new float[] { 0.0f, 1.0f, 0.0f, 0.0f };
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light0_pos);
        }

        private void поZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            light0_pos = new float[] { 0.0f, 0.0f, 1.0f, 0.0f };
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light0_pos);
        }

        private void diffuseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_am = new float[] { 1f, 0f, 1f };
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT, color_am);
        }

        private void specularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_am = new float[] { 1f, 0f, 0f };
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT, color_am);
        }

        private void shininessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_am = new float[] { 1f, 1f, 0f };
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT, color_am);
        }

        private void emissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_am = new float[] { 0f, 1f, 0f };
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT, color_am);
        }

        private void ambientAndDiffuseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_am = new float[] { 1f, 0f, 1f };
            Gl.glMaterialfv(Gl.GL_FRONT_AND_BACK, Gl.GL_AMBIENT, color_am);
        }
    }
}

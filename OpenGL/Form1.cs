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
using Tao.Platform.Windows;

namespace OpenGL
{
    public partial class Form1 : Form
    {
        double step = 0.2;


        public Form1()
        {
            InitializeComponent();
            Holst.InitializeContexts();

            XLabel.Visible = false;
            YLabel.Visible = false;

            Gl.glViewport(0, 0, Holst.Width, Holst.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Holst.Invalidate();
        }

        private void Holst_Paint(object sender, PaintEventArgs e) { }

        //polygon
        private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLabel.Visible = true;
            YLabel.Visible = true;

            Gl.glViewport(0, 0, Holst.Width, Holst.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glColor3f(0, 0, 0);
            Gl.glLineWidth(1);

            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2f(-1, 0);
            Gl.glVertex2f(1, 0);
            Gl.glVertex2f(0, -1);
            Gl.glVertex2f(0, 1);
            Gl.glEnd();


            Gl.glLineWidth(3);
            //Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor4f(1, 1, 1, 0.5f);
            Gl.glVertex2d(0 * step, 0 * step);
            Gl.glColor4f(1, 1, 0, 0.5f);
            Gl.glVertex2d(2 * step, 1 * step);
            Gl.glColor4f(0, 1, 1, 0.5f);
            Gl.glVertex2d(3 * step, -1 * step);
            Gl.glColor4f(0, 0, 1, 0.5f);
            Gl.glVertex2d(-3 * step, -1 * step);
            Gl.glColor4f(1, 0, 1, 0.5f);
            Gl.glVertex2d(-2 * step, 3 * step);
            Gl.glEnd();

            Holst.Invalidate();
        }
        
        //lines
        private void linesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XLabel.Visible = true;
            YLabel.Visible = true;

            Gl.glViewport(0, 0, Holst.Width, Holst.Height);
            Gl.glClearColor(1f, 1f, 1f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glColor3f(0, 0, 0);
            Gl.glLineWidth(1);

            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(-1, 0);
                Gl.glVertex2f(1, 0);
                Gl.glVertex2f(0, -1);
                Gl.glVertex2f(0, 1);
            Gl.glEnd();


            Gl.glLineWidth(3);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            //Gl.glVertex3d(0, 0, 0);
            //Gl.glVertex3d(2 * step, 1 * step, 0);
            //Gl.glVertex3d(3 * step, -1 * step, 0);
            //Gl.glVertex3d(-3 * step, -1 * step, 0);
            //Gl.glVertex3d(-2 * step, 3 * step, 0);

            Gl.glColor4f(1, 0, 0, 0.5f);
            Gl.glVertex2d(0 * step, 0 * step);
            Gl.glColor4f(1, 1, 0, 0.5f);
            Gl.glVertex2d(2 * step, 1 * step);
            Gl.glColor4f(0, 1, 1, 0.5f);
            Gl.glVertex2d(3 * step, -1 * step);
            Gl.glColor4f(0, 0, 1, 0.5f);
            Gl.glVertex2d(-3 * step, -1 * step);
            Gl.glColor4f(1, 0, 1, 0.5f);
            Gl.glVertex2d(-2 * step, 3 * step);
            Gl.glEnd();


            Holst.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

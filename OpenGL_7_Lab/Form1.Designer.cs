namespace OpenGL_7_Lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Holst = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Holst
            // 
            this.Holst.AccumBits = ((byte)(0));
            this.Holst.AutoCheckErrors = false;
            this.Holst.AutoFinish = false;
            this.Holst.AutoMakeCurrent = true;
            this.Holst.AutoSwapBuffers = true;
            this.Holst.BackColor = System.Drawing.Color.Black;
            this.Holst.ColorBits = ((byte)(32));
            this.Holst.DepthBits = ((byte)(16));
            this.Holst.Location = new System.Drawing.Point(36, 32);
            this.Holst.Name = "Holst";
            this.Holst.Size = new System.Drawing.Size(700, 700);
            this.Holst.StencilBits = ((byte)(0));
            this.Holst.TabIndex = 0;
            this.Holst.Load += new System.EventHandler(this.Holst_Load);
            this.Holst.Paint += new System.Windows.Forms.PaintEventHandler(this.Holst_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.Holst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl Holst;
        private System.Windows.Forms.Timer timer1;
    }
}


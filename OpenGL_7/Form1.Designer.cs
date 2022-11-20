namespace OpenGL_7
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.материалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.позицияИсточникаСветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассеяныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diffuseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shininessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambientAndDiffuseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.Holst.Location = new System.Drawing.Point(38, 34);
            this.Holst.Name = "Holst";
            this.Holst.Size = new System.Drawing.Size(700, 700);
            this.Holst.StencilBits = ((byte)(0));
            this.Holst.TabIndex = 0;
            this.Holst.Paint += new System.Windows.Forms.PaintEventHandler(this.Holst_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.материалToolStripMenuItem,
            this.позицияИсточникаСветаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // материалToolStripMenuItem
            // 
            this.материалToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассеяныйToolStripMenuItem,
            this.diffuseToolStripMenuItem,
            this.specularToolStripMenuItem,
            this.shininessToolStripMenuItem,
            this.emissionToolStripMenuItem,
            this.ambientAndDiffuseToolStripMenuItem});
            this.материалToolStripMenuItem.Name = "материалToolStripMenuItem";
            this.материалToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.материалToolStripMenuItem.Text = "Материал";
            // 
            // позицияИсточникаСветаToolStripMenuItem
            // 
            this.позицияИсточникаСветаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поХToolStripMenuItem,
            this.поУToolStripMenuItem,
            this.поZToolStripMenuItem});
            this.позицияИсточникаСветаToolStripMenuItem.Name = "позицияИсточникаСветаToolStripMenuItem";
            this.позицияИсточникаСветаToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.позицияИсточникаСветаToolStripMenuItem.Text = "Позиция источника света";
            // 
            // поХToolStripMenuItem
            // 
            this.поХToolStripMenuItem.Name = "поХToolStripMenuItem";
            this.поХToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поХToolStripMenuItem.Text = "По Х";
            this.поХToolStripMenuItem.Click += new System.EventHandler(this.поХToolStripMenuItem_Click);
            // 
            // поУToolStripMenuItem
            // 
            this.поУToolStripMenuItem.Name = "поУToolStripMenuItem";
            this.поУToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поУToolStripMenuItem.Text = "По У";
            this.поУToolStripMenuItem.Click += new System.EventHandler(this.поУToolStripMenuItem_Click);
            // 
            // поZToolStripMenuItem
            // 
            this.поZToolStripMenuItem.Name = "поZToolStripMenuItem";
            this.поZToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поZToolStripMenuItem.Text = "По Z";
            this.поZToolStripMenuItem.Click += new System.EventHandler(this.поZToolStripMenuItem_Click);
            // 
            // рассеяныйToolStripMenuItem
            // 
            this.рассеяныйToolStripMenuItem.Name = "рассеяныйToolStripMenuItem";
            this.рассеяныйToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.рассеяныйToolStripMenuItem.Text = "Ambient";
            this.рассеяныйToolStripMenuItem.Click += new System.EventHandler(this.рассеяныйToolStripMenuItem_Click);
            // 
            // diffuseToolStripMenuItem
            // 
            this.diffuseToolStripMenuItem.Name = "diffuseToolStripMenuItem";
            this.diffuseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.diffuseToolStripMenuItem.Text = "Diffuse";
            this.diffuseToolStripMenuItem.Click += new System.EventHandler(this.diffuseToolStripMenuItem_Click);
            // 
            // specularToolStripMenuItem
            // 
            this.specularToolStripMenuItem.Name = "specularToolStripMenuItem";
            this.specularToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.specularToolStripMenuItem.Text = "Specular";
            this.specularToolStripMenuItem.Click += new System.EventHandler(this.specularToolStripMenuItem_Click);
            // 
            // shininessToolStripMenuItem
            // 
            this.shininessToolStripMenuItem.Name = "shininessToolStripMenuItem";
            this.shininessToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.shininessToolStripMenuItem.Text = "Shininess";
            this.shininessToolStripMenuItem.Click += new System.EventHandler(this.shininessToolStripMenuItem_Click);
            // 
            // emissionToolStripMenuItem
            // 
            this.emissionToolStripMenuItem.Name = "emissionToolStripMenuItem";
            this.emissionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.emissionToolStripMenuItem.Text = "Emission";
            this.emissionToolStripMenuItem.Click += new System.EventHandler(this.emissionToolStripMenuItem_Click);
            // 
            // ambientAndDiffuseToolStripMenuItem
            // 
            this.ambientAndDiffuseToolStripMenuItem.Name = "ambientAndDiffuseToolStripMenuItem";
            this.ambientAndDiffuseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ambientAndDiffuseToolStripMenuItem.Text = "Ambient and Diffuse";
            this.ambientAndDiffuseToolStripMenuItem.Click += new System.EventHandler(this.ambientAndDiffuseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.Holst);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl Holst;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem материалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассеяныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem позицияИсточникаСветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diffuseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shininessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambientAndDiffuseToolStripMenuItem;
    }
}


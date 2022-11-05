namespace OpenGL
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
            this.Holst = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Holst
            // 
            this.Holst.AccumBits = ((byte)(0));
            this.Holst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Holst.AutoCheckErrors = false;
            this.Holst.AutoFinish = false;
            this.Holst.AutoMakeCurrent = true;
            this.Holst.AutoSwapBuffers = true;
            this.Holst.BackColor = System.Drawing.Color.Silver;
            this.Holst.ColorBits = ((byte)(32));
            this.Holst.DepthBits = ((byte)(16));
            this.Holst.Location = new System.Drawing.Point(40, 40);
            this.Holst.Name = "Holst";
            this.Holst.Size = new System.Drawing.Size(700, 700);
            this.Holst.StencilBits = ((byte)(0));
            this.Holst.TabIndex = 0;
            this.Holst.Paint += new System.Windows.Forms.PaintEventHandler(this.Holst_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polygonToolStripMenuItem,
            this.linesToolStripMenuItem1});
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.linesToolStripMenuItem.Text = "View";
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.polygonToolStripMenuItem.Text = "Polygon";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.polygonToolStripMenuItem_Click);
            // 
            // linesToolStripMenuItem1
            // 
            this.linesToolStripMenuItem1.Name = "linesToolStripMenuItem1";
            this.linesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.linesToolStripMenuItem1.Text = "Lines";
            this.linesToolStripMenuItem1.Click += new System.EventHandler(this.linesToolStripMenuItem1_Click);
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.BackColor = System.Drawing.SystemColors.Window;
            this.YLabel.Location = new System.Drawing.Point(700, 400);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 2;
            this.YLabel.Text = "X";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.BackColor = System.Drawing.SystemColors.Window;
            this.XLabel.Location = new System.Drawing.Point(400, 60);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 3;
            this.XLabel.Text = "Y";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.YLabel);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem1;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


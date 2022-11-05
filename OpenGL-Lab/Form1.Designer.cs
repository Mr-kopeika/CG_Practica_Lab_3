namespace OpenGL_Lab
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
            this.FigureGroupBox = new System.Windows.Forms.GroupBox();
            this.RBFigureSecond = new System.Windows.Forms.RadioButton();
            this.RBFigureFirst = new System.Windows.Forms.RadioButton();
            this.TransformGroupBox = new System.Windows.Forms.GroupBox();
            this.RBRotate = new System.Windows.Forms.RadioButton();
            this.RBScale = new System.Windows.Forms.RadioButton();
            this.RBShift = new System.Windows.Forms.RadioButton();
            this.LoopCB = new System.Windows.Forms.CheckBox();
            this.RotateButton = new System.Windows.Forms.Button();
            this.StopRotate = new System.Windows.Forms.Button();
            this.RotateOrientation = new System.Windows.Forms.GroupBox();
            this.RightRotate = new System.Windows.Forms.RadioButton();
            this.LeftRotate = new System.Windows.Forms.RadioButton();
            this.Reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FigureGroupBox.SuspendLayout();
            this.TransformGroupBox.SuspendLayout();
            this.RotateOrientation.SuspendLayout();
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
            this.Holst.BackColor = System.Drawing.Color.White;
            this.Holst.ColorBits = ((byte)(32));
            this.Holst.DepthBits = ((byte)(16));
            this.Holst.Location = new System.Drawing.Point(12, 12);
            this.Holst.Name = "Holst";
            this.Holst.Size = new System.Drawing.Size(760, 737);
            this.Holst.StencilBits = ((byte)(0));
            this.Holst.TabIndex = 0;
            this.Holst.Paint += new System.Windows.Forms.PaintEventHandler(this.Holst_Paint);
            this.Holst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Holst_KeyDown);
            // 
            // FigureGroupBox
            // 
            this.FigureGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.FigureGroupBox.Controls.Add(this.RBFigureSecond);
            this.FigureGroupBox.Controls.Add(this.RBFigureFirst);
            this.FigureGroupBox.Location = new System.Drawing.Point(13, 13);
            this.FigureGroupBox.Name = "FigureGroupBox";
            this.FigureGroupBox.Size = new System.Drawing.Size(102, 72);
            this.FigureGroupBox.TabIndex = 1;
            this.FigureGroupBox.TabStop = false;
            this.FigureGroupBox.Text = "Фигура";
            // 
            // RBFigureSecond
            // 
            this.RBFigureSecond.AutoSize = true;
            this.RBFigureSecond.Location = new System.Drawing.Point(7, 43);
            this.RBFigureSecond.Name = "RBFigureSecond";
            this.RBFigureSecond.Size = new System.Drawing.Size(67, 17);
            this.RBFigureSecond.TabIndex = 1;
            this.RBFigureSecond.Text = "Квадрат";
            this.RBFigureSecond.UseVisualStyleBackColor = true;
            // 
            // RBFigureFirst
            // 
            this.RBFigureFirst.AutoSize = true;
            this.RBFigureFirst.Checked = true;
            this.RBFigureFirst.Location = new System.Drawing.Point(7, 20);
            this.RBFigureFirst.Name = "RBFigureFirst";
            this.RBFigureFirst.Size = new System.Drawing.Size(90, 17);
            this.RBFigureFirst.TabIndex = 0;
            this.RBFigureFirst.TabStop = true;
            this.RBFigureFirst.Text = "Треугольник";
            this.RBFigureFirst.UseVisualStyleBackColor = true;
            // 
            // TransformGroupBox
            // 
            this.TransformGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.TransformGroupBox.Controls.Add(this.RBRotate);
            this.TransformGroupBox.Controls.Add(this.RBScale);
            this.TransformGroupBox.Controls.Add(this.RBShift);
            this.TransformGroupBox.Location = new System.Drawing.Point(121, 13);
            this.TransformGroupBox.Name = "TransformGroupBox";
            this.TransformGroupBox.Size = new System.Drawing.Size(130, 97);
            this.TransformGroupBox.TabIndex = 2;
            this.TransformGroupBox.TabStop = false;
            this.TransformGroupBox.Text = "Трансформация";
            // 
            // RBRotate
            // 
            this.RBRotate.AutoSize = true;
            this.RBRotate.Location = new System.Drawing.Point(7, 66);
            this.RBRotate.Name = "RBRotate";
            this.RBRotate.Size = new System.Drawing.Size(68, 17);
            this.RBRotate.TabIndex = 2;
            this.RBRotate.Text = "Поворот";
            this.RBRotate.UseVisualStyleBackColor = true;
            // 
            // RBScale
            // 
            this.RBScale.AutoSize = true;
            this.RBScale.Location = new System.Drawing.Point(7, 43);
            this.RBScale.Name = "RBScale";
            this.RBScale.Size = new System.Drawing.Size(119, 17);
            this.RBScale.TabIndex = 1;
            this.RBScale.Text = "Масштабирование";
            this.RBScale.UseVisualStyleBackColor = true;
            // 
            // RBShift
            // 
            this.RBShift.AutoSize = true;
            this.RBShift.Checked = true;
            this.RBShift.Location = new System.Drawing.Point(7, 20);
            this.RBShift.Name = "RBShift";
            this.RBShift.Size = new System.Drawing.Size(55, 17);
            this.RBShift.TabIndex = 0;
            this.RBShift.TabStop = true;
            this.RBShift.Text = "Сдвиг";
            this.RBShift.UseVisualStyleBackColor = true;
            // 
            // LoopCB
            // 
            this.LoopCB.AutoSize = true;
            this.LoopCB.BackColor = System.Drawing.SystemColors.Window;
            this.LoopCB.Location = new System.Drawing.Point(392, 90);
            this.LoopCB.Name = "LoopCB";
            this.LoopCB.Size = new System.Drawing.Size(80, 17);
            this.LoopCB.TabIndex = 3;
            this.LoopCB.Text = "Зациклить";
            this.LoopCB.UseVisualStyleBackColor = false;
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(257, 16);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(128, 51);
            this.RotateButton.TabIndex = 4;
            this.RotateButton.Text = "Вращать треугольник вокруг квадрата";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // StopRotate
            // 
            this.StopRotate.Location = new System.Drawing.Point(257, 73);
            this.StopRotate.Name = "StopRotate";
            this.StopRotate.Size = new System.Drawing.Size(128, 34);
            this.StopRotate.TabIndex = 6;
            this.StopRotate.Text = "Остановить вращение";
            this.StopRotate.UseVisualStyleBackColor = true;
            this.StopRotate.Click += new System.EventHandler(this.StopRotate_Click);
            // 
            // RotateOrientation
            // 
            this.RotateOrientation.BackColor = System.Drawing.SystemColors.Window;
            this.RotateOrientation.Controls.Add(this.RightRotate);
            this.RotateOrientation.Controls.Add(this.LeftRotate);
            this.RotateOrientation.Location = new System.Drawing.Point(392, 16);
            this.RotateOrientation.Name = "RotateOrientation";
            this.RotateOrientation.Size = new System.Drawing.Size(165, 69);
            this.RotateOrientation.TabIndex = 7;
            this.RotateOrientation.TabStop = false;
            this.RotateOrientation.Text = "Направление вращения";
            // 
            // RightRotate
            // 
            this.RightRotate.AutoSize = true;
            this.RightRotate.Location = new System.Drawing.Point(7, 43);
            this.RightRotate.Name = "RightRotate";
            this.RightRotate.Size = new System.Drawing.Size(127, 17);
            this.RightRotate.TabIndex = 1;
            this.RightRotate.Text = "По часовой стрелке";
            this.RightRotate.UseVisualStyleBackColor = true;
            // 
            // LeftRotate
            // 
            this.LeftRotate.AutoSize = true;
            this.LeftRotate.Checked = true;
            this.LeftRotate.Location = new System.Drawing.Point(7, 20);
            this.LeftRotate.Name = "LeftRotate";
            this.LeftRotate.Size = new System.Drawing.Size(150, 17);
            this.LeftRotate.TabIndex = 0;
            this.LeftRotate.TabStop = true;
            this.LeftRotate.Text = "Против часовой стрелки";
            this.LeftRotate.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(697, 16);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.RotateOrientation);
            this.Controls.Add(this.StopRotate);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.LoopCB);
            this.Controls.Add(this.TransformGroupBox);
            this.Controls.Add(this.FigureGroupBox);
            this.Controls.Add(this.Holst);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Holst_KeyDown);
            this.FigureGroupBox.ResumeLayout(false);
            this.FigureGroupBox.PerformLayout();
            this.TransformGroupBox.ResumeLayout(false);
            this.TransformGroupBox.PerformLayout();
            this.RotateOrientation.ResumeLayout(false);
            this.RotateOrientation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl Holst;
        private System.Windows.Forms.GroupBox FigureGroupBox;
        private System.Windows.Forms.RadioButton RBFigureSecond;
        private System.Windows.Forms.RadioButton RBFigureFirst;
        private System.Windows.Forms.GroupBox TransformGroupBox;
        private System.Windows.Forms.RadioButton RBRotate;
        private System.Windows.Forms.RadioButton RBScale;
        private System.Windows.Forms.RadioButton RBShift;
        private System.Windows.Forms.CheckBox LoopCB;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.Button StopRotate;
        private System.Windows.Forms.GroupBox RotateOrientation;
        private System.Windows.Forms.RadioButton RightRotate;
        private System.Windows.Forms.RadioButton LeftRotate;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer timer1;
    }
}


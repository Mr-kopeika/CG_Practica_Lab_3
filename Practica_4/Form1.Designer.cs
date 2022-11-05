namespace Practica_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawButton = new System.Windows.Forms.Button();
            this.ZReflectionButton = new System.Windows.Forms.Button();
            this.YReflection = new System.Windows.Forms.Button();
            this.XReflection = new System.Windows.Forms.Button();
            this.ShiftButton = new System.Windows.Forms.Button();
            this.ScaleButton = new System.Windows.Forms.Button();
            this.XRotate = new System.Windows.Forms.Button();
            this.YRotate = new System.Windows.Forms.Button();
            this.ZRotate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.XShiftTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YShiftTB = new System.Windows.Forms.TextBox();
            this.YScaleTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.XScaleTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RotateTB = new System.Windows.Forms.TextBox();
            this.ZShiftTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ZScaleTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Coefficient = new System.Windows.Forms.TrackBar();
            this.LabelCoefficient = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AngleXPlus = new System.Windows.Forms.RadioButton();
            this.AngleXMinus = new System.Windows.Forms.RadioButton();
            this.XAngle = new System.Windows.Forms.GroupBox();
            this.YAngle = new System.Windows.Forms.GroupBox();
            this.AngleYMinus = new System.Windows.Forms.RadioButton();
            this.AngleYPlus = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Coefficient)).BeginInit();
            this.XAngle.SuspendLayout();
            this.YAngle.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawButton
            // 
            this.DrawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DrawButton.Location = new System.Drawing.Point(12, 626);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(150, 23);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "Нарисовать фигуру";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // ZReflectionButton
            // 
            this.ZReflectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ZReflectionButton.Location = new System.Drawing.Point(168, 626);
            this.ZReflectionButton.Name = "ZReflectionButton";
            this.ZReflectionButton.Size = new System.Drawing.Size(150, 23);
            this.ZReflectionButton.TabIndex = 1;
            this.ZReflectionButton.Text = "Отразить по Z";
            this.ZReflectionButton.UseVisualStyleBackColor = true;
            this.ZReflectionButton.Click += new System.EventHandler(this.ZReflectionButton_Click);
            // 
            // YReflection
            // 
            this.YReflection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YReflection.Location = new System.Drawing.Point(168, 597);
            this.YReflection.Name = "YReflection";
            this.YReflection.Size = new System.Drawing.Size(150, 23);
            this.YReflection.TabIndex = 2;
            this.YReflection.Text = "Отразить по Y";
            this.YReflection.UseVisualStyleBackColor = true;
            this.YReflection.Click += new System.EventHandler(this.Horizontal_Click);
            // 
            // XReflection
            // 
            this.XReflection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XReflection.Location = new System.Drawing.Point(168, 568);
            this.XReflection.Name = "XReflection";
            this.XReflection.Size = new System.Drawing.Size(150, 23);
            this.XReflection.TabIndex = 3;
            this.XReflection.Text = "Отразить по X";
            this.XReflection.UseVisualStyleBackColor = true;
            this.XReflection.Click += new System.EventHandler(this.Vertical_Click);
            // 
            // ShiftButton
            // 
            this.ShiftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShiftButton.Location = new System.Drawing.Point(324, 627);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(231, 23);
            this.ShiftButton.TabIndex = 4;
            this.ShiftButton.Text = "Подвинуть";
            this.ShiftButton.UseVisualStyleBackColor = true;
            this.ShiftButton.Click += new System.EventHandler(this.Shift_Click);
            // 
            // ScaleButton
            // 
            this.ScaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ScaleButton.Location = new System.Drawing.Point(579, 626);
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.Size = new System.Drawing.Size(225, 23);
            this.ScaleButton.TabIndex = 5;
            this.ScaleButton.Text = "Масштабировать";
            this.ScaleButton.UseVisualStyleBackColor = true;
            this.ScaleButton.Click += new System.EventHandler(this.Scale_Click);
            // 
            // XRotate
            // 
            this.XRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XRotate.Location = new System.Drawing.Point(810, 626);
            this.XRotate.Name = "XRotate";
            this.XRotate.Size = new System.Drawing.Size(50, 23);
            this.XRotate.TabIndex = 6;
            this.XRotate.Text = "X";
            this.XRotate.UseVisualStyleBackColor = true;
            this.XRotate.Click += new System.EventHandler(this.RotateX_Click);
            // 
            // YRotate
            // 
            this.YRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YRotate.Location = new System.Drawing.Point(866, 626);
            this.YRotate.Name = "YRotate";
            this.YRotate.Size = new System.Drawing.Size(50, 23);
            this.YRotate.TabIndex = 7;
            this.YRotate.Text = "Y";
            this.YRotate.UseVisualStyleBackColor = true;
            this.YRotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // ZRotate
            // 
            this.ZRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ZRotate.Location = new System.Drawing.Point(922, 626);
            this.ZRotate.Name = "ZRotate";
            this.ZRotate.Size = new System.Drawing.Size(50, 23);
            this.ZRotate.TabIndex = 8;
            this.ZRotate.Text = "Z";
            this.ZRotate.UseVisualStyleBackColor = true;
            this.ZRotate.Click += new System.EventHandler(this.RotateZ_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "X:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // XShiftTB
            // 
            this.XShiftTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XShiftTB.Location = new System.Drawing.Point(349, 597);
            this.XShiftTB.Name = "XShiftTB";
            this.XShiftTB.Size = new System.Drawing.Size(50, 23);
            this.XShiftTB.TabIndex = 10;
            this.XShiftTB.Text = "0";
            this.XShiftTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y:";
            // 
            // YShiftTB
            // 
            this.YShiftTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YShiftTB.Location = new System.Drawing.Point(426, 597);
            this.YShiftTB.Name = "YShiftTB";
            this.YShiftTB.Size = new System.Drawing.Size(50, 23);
            this.YShiftTB.TabIndex = 12;
            this.YShiftTB.Text = "0";
            this.YShiftTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YScaleTB
            // 
            this.YScaleTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YScaleTB.Location = new System.Drawing.Point(677, 598);
            this.YScaleTB.Name = "YScaleTB";
            this.YScaleTB.Size = new System.Drawing.Size(50, 23);
            this.YScaleTB.TabIndex = 16;
            this.YScaleTB.Text = "1";
            this.YScaleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Y:";
            // 
            // XScaleTB
            // 
            this.XScaleTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XScaleTB.Location = new System.Drawing.Point(600, 598);
            this.XScaleTB.Name = "XScaleTB";
            this.XScaleTB.Size = new System.Drawing.Size(50, 23);
            this.XScaleTB.TabIndex = 14;
            this.XScaleTB.Text = "1";
            this.XScaleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.XScaleTB.TextChanged += new System.EventHandler(this.XScaleTB_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "X:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RotateTB
            // 
            this.RotateTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateTB.Location = new System.Drawing.Point(810, 597);
            this.RotateTB.Name = "RotateTB";
            this.RotateTB.Size = new System.Drawing.Size(162, 23);
            this.RotateTB.TabIndex = 17;
            this.RotateTB.Text = "45";
            this.RotateTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ZShiftTB
            // 
            this.ZShiftTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ZShiftTB.Location = new System.Drawing.Point(505, 597);
            this.ZShiftTB.Name = "ZShiftTB";
            this.ZShiftTB.Size = new System.Drawing.Size(50, 23);
            this.ZShiftTB.TabIndex = 19;
            this.ZShiftTB.Text = "0";
            this.ZShiftTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 601);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Z:";
            // 
            // ZScaleTB
            // 
            this.ZScaleTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ZScaleTB.Location = new System.Drawing.Point(754, 599);
            this.ZScaleTB.Name = "ZScaleTB";
            this.ZScaleTB.Size = new System.Drawing.Size(50, 23);
            this.ZScaleTB.TabIndex = 21;
            this.ZScaleTB.Text = "1";
            this.ZScaleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(733, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Z:";
            // 
            // Coefficient
            // 
            this.Coefficient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Coefficient.Location = new System.Drawing.Point(12, 577);
            this.Coefficient.Maximum = 50;
            this.Coefficient.Minimum = -50;
            this.Coefficient.Name = "Coefficient";
            this.Coefficient.Size = new System.Drawing.Size(150, 45);
            this.Coefficient.TabIndex = 22;
            this.Coefficient.Value = 10;
            this.Coefficient.Scroll += new System.EventHandler(this.Coefficient_Scroll);
            // 
            // LabelCoefficient
            // 
            this.LabelCoefficient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCoefficient.AutoSize = true;
            this.LabelCoefficient.Location = new System.Drawing.Point(128, 550);
            this.LabelCoefficient.Name = "LabelCoefficient";
            this.LabelCoefficient.Size = new System.Drawing.Size(22, 15);
            this.LabelCoefficient.TabIndex = 23;
            this.LabelCoefficient.Text = "0.5";
            this.LabelCoefficient.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Коэффициент:";
            // 
            // AngleXPlus
            // 
            this.AngleXPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AngleXPlus.AutoSize = true;
            this.AngleXPlus.Checked = true;
            this.AngleXPlus.Location = new System.Drawing.Point(19, 65);
            this.AngleXPlus.Name = "AngleXPlus";
            this.AngleXPlus.Size = new System.Drawing.Size(52, 19);
            this.AngleXPlus.TabIndex = 25;
            this.AngleXPlus.TabStop = true;
            this.AngleXPlus.Text = "Х > 0";
            this.AngleXPlus.UseVisualStyleBackColor = true;
            this.AngleXPlus.CheckedChanged += new System.EventHandler(this.AngleXPlus_CheckedChanged);
            // 
            // AngleXMinus
            // 
            this.AngleXMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AngleXMinus.AutoSize = true;
            this.AngleXMinus.Location = new System.Drawing.Point(19, 31);
            this.AngleXMinus.Name = "AngleXMinus";
            this.AngleXMinus.Size = new System.Drawing.Size(52, 19);
            this.AngleXMinus.TabIndex = 26;
            this.AngleXMinus.Text = "Х < 0";
            this.AngleXMinus.UseVisualStyleBackColor = true;
            this.AngleXMinus.CheckedChanged += new System.EventHandler(this.AngleXMinus_CheckedChanged);
            // 
            // XAngle
            // 
            this.XAngle.Controls.Add(this.AngleXMinus);
            this.XAngle.Controls.Add(this.AngleXPlus);
            this.XAngle.Location = new System.Drawing.Point(24, 435);
            this.XAngle.Name = "XAngle";
            this.XAngle.Size = new System.Drawing.Size(79, 100);
            this.XAngle.TabIndex = 29;
            this.XAngle.TabStop = false;
            this.XAngle.Text = "Угол Х";
            // 
            // YAngle
            // 
            this.YAngle.Controls.Add(this.AngleYMinus);
            this.YAngle.Controls.Add(this.AngleYPlus);
            this.YAngle.Location = new System.Drawing.Point(128, 435);
            this.YAngle.Name = "YAngle";
            this.YAngle.Size = new System.Drawing.Size(79, 100);
            this.YAngle.TabIndex = 30;
            this.YAngle.TabStop = false;
            this.YAngle.Text = "Угол Y";
            // 
            // AngleYMinus
            // 
            this.AngleYMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AngleYMinus.AutoSize = true;
            this.AngleYMinus.Checked = true;
            this.AngleYMinus.Location = new System.Drawing.Point(19, 31);
            this.AngleYMinus.Name = "AngleYMinus";
            this.AngleYMinus.Size = new System.Drawing.Size(52, 19);
            this.AngleYMinus.TabIndex = 26;
            this.AngleYMinus.TabStop = true;
            this.AngleYMinus.Text = "Y < 0";
            this.AngleYMinus.UseVisualStyleBackColor = true;
            this.AngleYMinus.CheckedChanged += new System.EventHandler(this.AngleYMinus_CheckedChanged);
            // 
            // AngleYPlus
            // 
            this.AngleYPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AngleYPlus.AutoSize = true;
            this.AngleYPlus.Location = new System.Drawing.Point(19, 65);
            this.AngleYPlus.Name = "AngleYPlus";
            this.AngleYPlus.Size = new System.Drawing.Size(52, 19);
            this.AngleYPlus.TabIndex = 25;
            this.AngleYPlus.Text = "Y > 0";
            this.AngleYPlus.UseVisualStyleBackColor = true;
            this.AngleYPlus.CheckedChanged += new System.EventHandler(this.AngleYPlus_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.YAngle);
            this.Controls.Add(this.XAngle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LabelCoefficient);
            this.Controls.Add(this.Coefficient);
            this.Controls.Add(this.ZScaleTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ZShiftTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RotateTB);
            this.Controls.Add(this.YScaleTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.XScaleTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YShiftTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XShiftTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZRotate);
            this.Controls.Add(this.YRotate);
            this.Controls.Add(this.XRotate);
            this.Controls.Add(this.ScaleButton);
            this.Controls.Add(this.ShiftButton);
            this.Controls.Add(this.XReflection);
            this.Controls.Add(this.YReflection);
            this.Controls.Add(this.ZReflectionButton);
            this.Controls.Add(this.DrawButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ClientSizeChanged += new System.EventHandler(this.DrawButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Coefficient)).EndInit();
            this.XAngle.ResumeLayout(false);
            this.XAngle.PerformLayout();
            this.YAngle.ResumeLayout(false);
            this.YAngle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DrawButton;
        private Button ZReflectionButton;
        private Button YReflection;
        private Button XReflection;
        private Button ShiftButton;
        private Button ScaleButton;
        private Button XRotate;
        private Button YRotate;
        private Button ZRotate;
        private Label label1;
        private TextBox XShiftTB;
        private Label label2;
        private TextBox YShiftTB;
        private TextBox YScaleTB;
        private Label label3;
        private TextBox XScaleTB;
        private Label label4;
        private TextBox RotateTB;
        private TextBox ZShiftTB;
        private Label label5;
        private TextBox ZScaleTB;
        private Label label6;
        private TrackBar Coefficient;
        private Label LabelCoefficient;
        private Label label7;
        private RadioButton AngleXPlus;
        private RadioButton AngleXMinus;
        private GroupBox XAngle;
        private GroupBox YAngle;
        private RadioButton AngleYMinus;
        private RadioButton AngleYPlus;
    }
}
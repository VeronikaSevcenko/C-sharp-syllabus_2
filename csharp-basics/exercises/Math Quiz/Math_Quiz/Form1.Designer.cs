
using System;

namespace Math_Quiz
{
    partial class Math_Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Math_Quiz));
            this.NumberLeftPlus = new System.Windows.Forms.Label();
            this.Symbol = new System.Windows.Forms.Label();
            this.NumberRightPlus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberRightMinus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberLeftMinus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NumberRightMultiply = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NumberLeftMultiply = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NumberRightDivision = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.NumberLeftDivision = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.NumericUpDown();
            this.Minus = new System.Windows.Forms.NumericUpDown();
            this.Multiply = new System.Windows.Forms.NumericUpDown();
            this.Division = new System.Windows.Forms.NumericUpDown();
            this.Start_Button = new System.Windows.Forms.Button();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Multiply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Division)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberLeftPlus
            // 
            this.NumberLeftPlus.AutoSize = true;
            this.NumberLeftPlus.BackColor = System.Drawing.Color.Transparent;
            this.NumberLeftPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLeftPlus.ForeColor = System.Drawing.Color.Gray;
            this.NumberLeftPlus.Location = new System.Drawing.Point(45, 118);
            this.NumberLeftPlus.Name = "NumberLeftPlus";
            this.NumberLeftPlus.Size = new System.Drawing.Size(41, 29);
            this.NumberLeftPlus.TabIndex = 1;
            this.NumberLeftPlus.Text = "00";
            // 
            // Symbol
            // 
            this.Symbol.AutoSize = true;
            this.Symbol.BackColor = System.Drawing.Color.Transparent;
            this.Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Symbol.ForeColor = System.Drawing.Color.Gray;
            this.Symbol.Location = new System.Drawing.Point(150, 118);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(28, 29);
            this.Symbol.TabIndex = 2;
            this.Symbol.Text = "+";
            // 
            // NumberRightPlus
            // 
            this.NumberRightPlus.AutoSize = true;
            this.NumberRightPlus.BackColor = System.Drawing.Color.Transparent;
            this.NumberRightPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberRightPlus.ForeColor = System.Drawing.Color.Gray;
            this.NumberRightPlus.Location = new System.Drawing.Point(258, 118);
            this.NumberRightPlus.Name = "NumberRightPlus";
            this.NumberRightPlus.Size = new System.Drawing.Size(41, 29);
            this.NumberRightPlus.TabIndex = 3;
            this.NumberRightPlus.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(367, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(367, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "=";
            // 
            // NumberRightMinus
            // 
            this.NumberRightMinus.AutoSize = true;
            this.NumberRightMinus.BackColor = System.Drawing.Color.Transparent;
            this.NumberRightMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberRightMinus.ForeColor = System.Drawing.Color.Gray;
            this.NumberRightMinus.Location = new System.Drawing.Point(258, 164);
            this.NumberRightMinus.Name = "NumberRightMinus";
            this.NumberRightMinus.Size = new System.Drawing.Size(41, 29);
            this.NumberRightMinus.TabIndex = 11;
            this.NumberRightMinus.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(154, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "-";
            // 
            // NumberLeftMinus
            // 
            this.NumberLeftMinus.AutoSize = true;
            this.NumberLeftMinus.BackColor = System.Drawing.Color.Transparent;
            this.NumberLeftMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLeftMinus.ForeColor = System.Drawing.Color.Gray;
            this.NumberLeftMinus.Location = new System.Drawing.Point(45, 164);
            this.NumberLeftMinus.Name = "NumberLeftMinus";
            this.NumberLeftMinus.Size = new System.Drawing.Size(41, 29);
            this.NumberLeftMinus.TabIndex = 9;
            this.NumberLeftMinus.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(367, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "=";
            // 
            // NumberRightMultiply
            // 
            this.NumberRightMultiply.AutoSize = true;
            this.NumberRightMultiply.BackColor = System.Drawing.Color.Transparent;
            this.NumberRightMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberRightMultiply.ForeColor = System.Drawing.Color.Gray;
            this.NumberRightMultiply.Location = new System.Drawing.Point(258, 217);
            this.NumberRightMultiply.Name = "NumberRightMultiply";
            this.NumberRightMultiply.Size = new System.Drawing.Size(41, 29);
            this.NumberRightMultiply.TabIndex = 16;
            this.NumberRightMultiply.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(152, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "x";
            // 
            // NumberLeftMultiply
            // 
            this.NumberLeftMultiply.AutoSize = true;
            this.NumberLeftMultiply.BackColor = System.Drawing.Color.Transparent;
            this.NumberLeftMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLeftMultiply.ForeColor = System.Drawing.Color.Gray;
            this.NumberLeftMultiply.Location = new System.Drawing.Point(45, 217);
            this.NumberLeftMultiply.Name = "NumberLeftMultiply";
            this.NumberLeftMultiply.Size = new System.Drawing.Size(41, 29);
            this.NumberLeftMultiply.TabIndex = 14;
            this.NumberLeftMultiply.Text = "00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(367, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = "=";
            // 
            // NumberRightDivision
            // 
            this.NumberRightDivision.AutoSize = true;
            this.NumberRightDivision.BackColor = System.Drawing.Color.Transparent;
            this.NumberRightDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberRightDivision.ForeColor = System.Drawing.Color.Gray;
            this.NumberRightDivision.Location = new System.Drawing.Point(258, 267);
            this.NumberRightDivision.Name = "NumberRightDivision";
            this.NumberRightDivision.Size = new System.Drawing.Size(41, 29);
            this.NumberRightDivision.TabIndex = 21;
            this.NumberRightDivision.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(153, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 29);
            this.label14.TabIndex = 20;
            this.label14.Text = "/";
            // 
            // NumberLeftDivision
            // 
            this.NumberLeftDivision.AutoSize = true;
            this.NumberLeftDivision.BackColor = System.Drawing.Color.Transparent;
            this.NumberLeftDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLeftDivision.ForeColor = System.Drawing.Color.Gray;
            this.NumberLeftDivision.Location = new System.Drawing.Point(45, 267);
            this.NumberLeftDivision.Name = "NumberLeftDivision";
            this.NumberLeftDivision.Size = new System.Drawing.Size(41, 29);
            this.NumberLeftDivision.TabIndex = 19;
            this.NumberLeftDivision.Text = "00";
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.ForeColor = System.Drawing.Color.Gray;
            this.Sum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sum.Location = new System.Drawing.Point(436, 118);
            this.Sum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(140, 29);
            this.Sum.TabIndex = 23;
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.ForeColor = System.Drawing.Color.Gray;
            this.Minus.Location = new System.Drawing.Point(436, 163);
            this.Minus.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(140, 29);
            this.Minus.TabIndex = 24;
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiply.ForeColor = System.Drawing.Color.Gray;
            this.Multiply.Location = new System.Drawing.Point(436, 217);
            this.Multiply.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(140, 29);
            this.Multiply.TabIndex = 25;
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Division.ForeColor = System.Drawing.Color.Gray;
            this.Division.Location = new System.Drawing.Point(436, 267);
            this.Division.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(140, 29);
            this.Division.TabIndex = 26;
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.Transparent;
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Button.ForeColor = System.Drawing.Color.Black;
            this.Start_Button.Location = new System.Drawing.Point(123, 358);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(224, 44);
            this.Start_Button.TabIndex = 27;
            this.Start_Button.Text = "Start the Quiz";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLeftLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.TimeLeftLabel.Location = new System.Drawing.Point(165, 33);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(0, 31);
            this.TimeLeftLabel.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Math_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(688, 695);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NumberRightDivision);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NumberLeftDivision);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumberRightMultiply);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NumberLeftMultiply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberRightMinus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumberLeftMinus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumberRightPlus);
            this.Controls.Add(this.Symbol);
            this.Controls.Add(this.NumberLeftPlus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Math_Quiz";
            this.Text = "Math_Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Multiply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Division)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NumberLeftPlus;
        private System.Windows.Forms.Label Symbol;
        private System.Windows.Forms.Label NumberRightPlus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberRightMinus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NumberLeftMinus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NumberRightMultiply;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label NumberLeftMultiply;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label NumberRightDivision;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label NumberLeftDivision;
        private System.Windows.Forms.NumericUpDown Sum;
        private System.Windows.Forms.NumericUpDown Minus;
        private System.Windows.Forms.NumericUpDown Multiply;
        private System.Windows.Forms.NumericUpDown Division;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.Timer timer1;
    }
}


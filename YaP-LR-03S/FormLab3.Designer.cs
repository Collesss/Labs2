namespace YaP_LR_03S
{
    partial class FormLab3
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
            this.button1Calculate = new System.Windows.Forms.Button();
            this.listBox1ApproximateRoot = new System.Windows.Forms.ListBox();
            this.label1ApproximateRoot = new System.Windows.Forms.Label();
            this.label2Iteration = new System.Windows.Forms.Label();
            this.listBox2Iteration = new System.Windows.Forms.ListBox();
            this.textBox1E = new System.Windows.Forms.TextBox();
            this.label3E = new System.Windows.Forms.Label();
            this.label4X = new System.Windows.Forms.Label();
            this.textBox2X = new System.Windows.Forms.TextBox();
            this.label5LogX = new System.Windows.Forms.Label();
            this.textBox3LogX = new System.Windows.Forms.TextBox();
            this.button2Exit = new System.Windows.Forms.Button();
            this.label6ApproximateX = new System.Windows.Forms.Label();
            this.textBox4ApproximateX = new System.Windows.Forms.TextBox();
            this.label7DeltaX = new System.Windows.Forms.Label();
            this.textBox5DeltaX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1Calculate
            // 
            this.button1Calculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Calculate.Location = new System.Drawing.Point(12, 342);
            this.button1Calculate.Name = "button1Calculate";
            this.button1Calculate.Size = new System.Drawing.Size(101, 39);
            this.button1Calculate.TabIndex = 3;
            this.button1Calculate.Text = "Вычислить";
            this.button1Calculate.UseVisualStyleBackColor = true;
            this.button1Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1ApproximateRoot
            // 
            this.listBox1ApproximateRoot.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1ApproximateRoot.FormattingEnabled = true;
            this.listBox1ApproximateRoot.ItemHeight = 17;
            this.listBox1ApproximateRoot.Location = new System.Drawing.Point(580, 179);
            this.listBox1ApproximateRoot.Name = "listBox1ApproximateRoot";
            this.listBox1ApproximateRoot.Size = new System.Drawing.Size(208, 361);
            this.listBox1ApproximateRoot.TabIndex = 9;
            // 
            // label1ApproximateRoot
            // 
            this.label1ApproximateRoot.AutoSize = true;
            this.label1ApproximateRoot.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1ApproximateRoot.Location = new System.Drawing.Point(576, 157);
            this.label1ApproximateRoot.Name = "label1ApproximateRoot";
            this.label1ApproximateRoot.Size = new System.Drawing.Size(172, 19);
            this.label1ApproximateRoot.TabIndex = 11;
            this.label1ApproximateRoot.Text = "Приближённый корень";
            // 
            // label2Iteration
            // 
            this.label2Iteration.AutoSize = true;
            this.label2Iteration.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Iteration.Location = new System.Drawing.Point(362, 157);
            this.label2Iteration.Name = "label2Iteration";
            this.label2Iteration.Size = new System.Drawing.Size(77, 19);
            this.label2Iteration.TabIndex = 10;
            this.label2Iteration.Text = "Итерация";
            // 
            // listBox2Iteration
            // 
            this.listBox2Iteration.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2Iteration.FormattingEnabled = true;
            this.listBox2Iteration.ItemHeight = 17;
            this.listBox2Iteration.Location = new System.Drawing.Point(366, 179);
            this.listBox2Iteration.Name = "listBox2Iteration";
            this.listBox2Iteration.Size = new System.Drawing.Size(208, 361);
            this.listBox2Iteration.TabIndex = 8;
            // 
            // textBox1E
            // 
            this.textBox1E.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1E.Location = new System.Drawing.Point(113, 163);
            this.textBox1E.Name = "textBox1E";
            this.textBox1E.Size = new System.Drawing.Size(130, 24);
            this.textBox1E.TabIndex = 1;
            // 
            // label3E
            // 
            this.label3E.AutoSize = true;
            this.label3E.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3E.Location = new System.Drawing.Point(89, 166);
            this.label3E.Name = "label3E";
            this.label3E.Size = new System.Drawing.Size(17, 19);
            this.label3E.TabIndex = 12;
            this.label3E.Text = "E";
            // 
            // label4X
            // 
            this.label4X.AutoSize = true;
            this.label4X.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4X.Location = new System.Drawing.Point(89, 195);
            this.label4X.Name = "label4X";
            this.label4X.Size = new System.Drawing.Size(18, 19);
            this.label4X.TabIndex = 13;
            this.label4X.Text = "X";
            // 
            // textBox2X
            // 
            this.textBox2X.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2X.Location = new System.Drawing.Point(113, 192);
            this.textBox2X.Name = "textBox2X";
            this.textBox2X.Size = new System.Drawing.Size(130, 24);
            this.textBox2X.TabIndex = 2;
            // 
            // label5LogX
            // 
            this.label5LogX.AutoSize = true;
            this.label5LogX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5LogX.Location = new System.Drawing.Point(89, 434);
            this.label5LogX.Name = "label5LogX";
            this.label5LogX.Size = new System.Drawing.Size(18, 19);
            this.label5LogX.TabIndex = 14;
            this.label5LogX.Text = "X";
            // 
            // textBox3LogX
            // 
            this.textBox3LogX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3LogX.Location = new System.Drawing.Point(113, 431);
            this.textBox3LogX.Name = "textBox3LogX";
            this.textBox3LogX.ReadOnly = true;
            this.textBox3LogX.Size = new System.Drawing.Size(130, 24);
            this.textBox3LogX.TabIndex = 5;
            // 
            // button2Exit
            // 
            this.button2Exit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Exit.Location = new System.Drawing.Point(142, 342);
            this.button2Exit.Name = "button2Exit";
            this.button2Exit.Size = new System.Drawing.Size(101, 39);
            this.button2Exit.TabIndex = 4;
            this.button2Exit.Text = "Выход";
            this.button2Exit.UseVisualStyleBackColor = true;
            this.button2Exit.Click += new System.EventHandler(this.button2Exit_Click);
            // 
            // label6ApproximateX
            // 
            this.label6ApproximateX.AutoSize = true;
            this.label6ApproximateX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6ApproximateX.Location = new System.Drawing.Point(81, 464);
            this.label6ApproximateX.Name = "label6ApproximateX";
            this.label6ApproximateX.Size = new System.Drawing.Size(26, 19);
            this.label6ApproximateX.TabIndex = 15;
            this.label6ApproximateX.Text = "≈X";
            // 
            // textBox4ApproximateX
            // 
            this.textBox4ApproximateX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4ApproximateX.Location = new System.Drawing.Point(113, 461);
            this.textBox4ApproximateX.Name = "textBox4ApproximateX";
            this.textBox4ApproximateX.ReadOnly = true;
            this.textBox4ApproximateX.Size = new System.Drawing.Size(130, 24);
            this.textBox4ApproximateX.TabIndex = 6;
            // 
            // label7DeltaX
            // 
            this.label7DeltaX.AutoSize = true;
            this.label7DeltaX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7DeltaX.Location = new System.Drawing.Point(79, 494);
            this.label7DeltaX.Name = "label7DeltaX";
            this.label7DeltaX.Size = new System.Drawing.Size(28, 19);
            this.label7DeltaX.TabIndex = 16;
            this.label7DeltaX.Text = "ΔX";
            // 
            // textBox5DeltaX
            // 
            this.textBox5DeltaX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5DeltaX.Location = new System.Drawing.Point(113, 491);
            this.textBox5DeltaX.Name = "textBox5DeltaX";
            this.textBox5DeltaX.ReadOnly = true;
            this.textBox5DeltaX.Size = new System.Drawing.Size(130, 24);
            this.textBox5DeltaX.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Вычисление приближенного корня";
            // 
            // FormLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7DeltaX);
            this.Controls.Add(this.textBox5DeltaX);
            this.Controls.Add(this.label6ApproximateX);
            this.Controls.Add(this.textBox4ApproximateX);
            this.Controls.Add(this.button2Exit);
            this.Controls.Add(this.label5LogX);
            this.Controls.Add(this.textBox3LogX);
            this.Controls.Add(this.label4X);
            this.Controls.Add(this.textBox2X);
            this.Controls.Add(this.label3E);
            this.Controls.Add(this.textBox1E);
            this.Controls.Add(this.label2Iteration);
            this.Controls.Add(this.listBox2Iteration);
            this.Controls.Add(this.label1ApproximateRoot);
            this.Controls.Add(this.listBox1ApproximateRoot);
            this.Controls.Add(this.button1Calculate);
            this.Name = "FormLab3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Calculate;
        private System.Windows.Forms.ListBox listBox1ApproximateRoot;
        private System.Windows.Forms.Label label1ApproximateRoot;
        private System.Windows.Forms.Label label2Iteration;
        private System.Windows.Forms.ListBox listBox2Iteration;
        private System.Windows.Forms.TextBox textBox1E;
        private System.Windows.Forms.Label label3E;
        private System.Windows.Forms.Label label4X;
        private System.Windows.Forms.TextBox textBox2X;
        private System.Windows.Forms.Label label5LogX;
        private System.Windows.Forms.TextBox textBox3LogX;
        private System.Windows.Forms.Button button2Exit;
        private System.Windows.Forms.Label label6ApproximateX;
        private System.Windows.Forms.TextBox textBox4ApproximateX;
        private System.Windows.Forms.Label label7DeltaX;
        private System.Windows.Forms.TextBox textBox5DeltaX;
        private System.Windows.Forms.Label label1;
    }
}


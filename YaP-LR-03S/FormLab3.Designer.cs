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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2Iteration = new System.Windows.Forms.ListBox();
            this.textBox1E = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3ApproximateX = new System.Windows.Forms.TextBox();
            this.button2Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1Calculate
            // 
            this.button1Calculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Calculate.Location = new System.Drawing.Point(12, 342);
            this.button1Calculate.Name = "button1Calculate";
            this.button1Calculate.Size = new System.Drawing.Size(101, 39);
            this.button1Calculate.TabIndex = 0;
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
            this.listBox1ApproximateRoot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Приближённый корень";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Итерация";
            // 
            // listBox2Iteration
            // 
            this.listBox2Iteration.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2Iteration.FormattingEnabled = true;
            this.listBox2Iteration.ItemHeight = 17;
            this.listBox2Iteration.Location = new System.Drawing.Point(366, 179);
            this.listBox2Iteration.Name = "listBox2Iteration";
            this.listBox2Iteration.Size = new System.Drawing.Size(208, 361);
            this.listBox2Iteration.TabIndex = 3;
            // 
            // textBox1E
            // 
            this.textBox1E.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1E.Location = new System.Drawing.Point(113, 163);
            this.textBox1E.Name = "textBox1E";
            this.textBox1E.Size = new System.Drawing.Size(130, 24);
            this.textBox1E.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "E";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "X";
            // 
            // textBox2X
            // 
            this.textBox2X.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2X.Location = new System.Drawing.Point(113, 192);
            this.textBox2X.Name = "textBox2X";
            this.textBox2X.Size = new System.Drawing.Size(130, 24);
            this.textBox2X.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            // 
            // textBox3ApproximateX
            // 
            this.textBox3ApproximateX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3ApproximateX.Location = new System.Drawing.Point(113, 431);
            this.textBox3ApproximateX.Name = "textBox3ApproximateX";
            this.textBox3ApproximateX.Size = new System.Drawing.Size(130, 24);
            this.textBox3ApproximateX.TabIndex = 9;
            // 
            // button2Exit
            // 
            this.button2Exit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Exit.Location = new System.Drawing.Point(142, 342);
            this.button2Exit.Name = "button2Exit";
            this.button2Exit.Size = new System.Drawing.Size(101, 39);
            this.button2Exit.TabIndex = 11;
            this.button2Exit.Text = "Выход";
            this.button2Exit.UseVisualStyleBackColor = true;
            this.button2Exit.Click += new System.EventHandler(this.button2Exit_Click);
            // 
            // FormLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.button2Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3ApproximateX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2X);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1E);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2Iteration);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2Iteration;
        private System.Windows.Forms.TextBox textBox1E;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3ApproximateX;
        private System.Windows.Forms.Button button2Exit;
    }
}


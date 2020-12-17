namespace YaP_LR_01C
{
    partial class FormLab1
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
            this.label7Z = new System.Windows.Forms.Label();
            this.textBox5Z = new System.Windows.Forms.TextBox();
            this.button1Calculate = new System.Windows.Forms.Button();
            this.label1Red = new System.Windows.Forms.Label();
            this.label2Text = new System.Windows.Forms.Label();
            this.textBox2Y = new System.Windows.Forms.TextBox();
            this.label4Y = new System.Windows.Forms.Label();
            this.textBox1X = new System.Windows.Forms.TextBox();
            this.label3X = new System.Windows.Forms.Label();
            this.button2Exit = new System.Windows.Forms.Button();
            this.textBox4B = new System.Windows.Forms.TextBox();
            this.label6B = new System.Windows.Forms.Label();
            this.textBox3A = new System.Windows.Forms.TextBox();
            this.label5A = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7Z
            // 
            this.label7Z.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7Z.ForeColor = System.Drawing.Color.Black;
            this.label7Z.Location = new System.Drawing.Point(100, 120);
            this.label7Z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7Z.Name = "label7Z";
            this.label7Z.Size = new System.Drawing.Size(25, 20);
            this.label7Z.TabIndex = 8;
            this.label7Z.Text = "z:";
            this.label7Z.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5Z
            // 
            this.textBox5Z.BackColor = System.Drawing.Color.LightGray;
            this.textBox5Z.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5Z.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5Z.ForeColor = System.Drawing.Color.Black;
            this.textBox5Z.Location = new System.Drawing.Point(130, 120);
            this.textBox5Z.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5Z.Name = "textBox5Z";
            this.textBox5Z.ReadOnly = true;
            this.textBox5Z.Size = new System.Drawing.Size(100, 20);
            this.textBox5Z.TabIndex = 3;
            // 
            // button1Calculate
            // 
            this.button1Calculate.BackColor = System.Drawing.Color.DarkGray;
            this.button1Calculate.FlatAppearance.BorderSize = 0;
            this.button1Calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1Calculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Calculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Calculate.ForeColor = System.Drawing.Color.Black;
            this.button1Calculate.Location = new System.Drawing.Point(320, 60);
            this.button1Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.button1Calculate.Name = "button1Calculate";
            this.button1Calculate.Size = new System.Drawing.Size(110, 50);
            this.button1Calculate.TabIndex = 4;
            this.button1Calculate.Text = "Вычислить\r\nz=f(x, y, a, b)";
            this.button1Calculate.UseVisualStyleBackColor = false;
            this.button1Calculate.Click += new System.EventHandler(this.button1Calculate_Click);
            // 
            // label1Red
            // 
            this.label1Red.AutoSize = true;
            this.label1Red.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Red.ForeColor = System.Drawing.Color.Red;
            this.label1Red.Location = new System.Drawing.Point(35, 10);
            this.label1Red.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Red.Name = "label1Red";
            this.label1Red.Size = new System.Drawing.Size(123, 28);
            this.label1Red.TabIndex = 9;
            this.label1Red.Text = "Задание:";
            // 
            // label2Text
            // 
            this.label2Text.AutoSize = true;
            this.label2Text.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Text.ForeColor = System.Drawing.Color.Black;
            this.label2Text.Location = new System.Drawing.Point(175, 15);
            this.label2Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2Text.Name = "label2Text";
            this.label2Text.Size = new System.Drawing.Size(379, 19);
            this.label2Text.TabIndex = 10;
            this.label2Text.Text = "Вычислить значение условной функции z=f(x, y, a, b)";
            // 
            // textBox2Y
            // 
            this.textBox2Y.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2Y.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2Y.ForeColor = System.Drawing.Color.Black;
            this.textBox2Y.Location = new System.Drawing.Point(60, 90);
            this.textBox2Y.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2Y.Name = "textBox2Y";
            this.textBox2Y.Size = new System.Drawing.Size(100, 20);
            this.textBox2Y.TabIndex = 2;
            // 
            // label4Y
            // 
            this.label4Y.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4Y.ForeColor = System.Drawing.Color.Black;
            this.label4Y.Location = new System.Drawing.Point(30, 90);
            this.label4Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4Y.Name = "label4Y";
            this.label4Y.Size = new System.Drawing.Size(25, 20);
            this.label4Y.TabIndex = 7;
            this.label4Y.Text = "y:";
            this.label4Y.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1X
            // 
            this.textBox1X.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1X.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1X.ForeColor = System.Drawing.Color.Black;
            this.textBox1X.Location = new System.Drawing.Point(60, 61);
            this.textBox1X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1X.Name = "textBox1X";
            this.textBox1X.Size = new System.Drawing.Size(100, 20);
            this.textBox1X.TabIndex = 1;
            // 
            // label3X
            // 
            this.label3X.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3X.ForeColor = System.Drawing.Color.Black;
            this.label3X.Location = new System.Drawing.Point(30, 60);
            this.label3X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3X.Name = "label3X";
            this.label3X.Size = new System.Drawing.Size(25, 20);
            this.label3X.TabIndex = 6;
            this.label3X.Text = "x:";
            this.label3X.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2Exit
            // 
            this.button2Exit.BackColor = System.Drawing.Color.DarkGray;
            this.button2Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2Exit.FlatAppearance.BorderSize = 0;
            this.button2Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2Exit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2Exit.ForeColor = System.Drawing.Color.Black;
            this.button2Exit.Location = new System.Drawing.Point(440, 60);
            this.button2Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button2Exit.Name = "button2Exit";
            this.button2Exit.Size = new System.Drawing.Size(110, 50);
            this.button2Exit.TabIndex = 5;
            this.button2Exit.Text = "Выход";
            this.button2Exit.UseVisualStyleBackColor = false;
            this.button2Exit.Click += new System.EventHandler(this.button2Exit_Click);
            // 
            // textBox4B
            // 
            this.textBox4B.BackColor = System.Drawing.Color.DarkGray;
            this.textBox4B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4B.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4B.ForeColor = System.Drawing.Color.Black;
            this.textBox4B.Location = new System.Drawing.Point(200, 90);
            this.textBox4B.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4B.Name = "textBox4B";
            this.textBox4B.Size = new System.Drawing.Size(100, 20);
            this.textBox4B.TabIndex = 11;
            // 
            // label6B
            // 
            this.label6B.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6B.ForeColor = System.Drawing.Color.Black;
            this.label6B.Location = new System.Drawing.Point(170, 90);
            this.label6B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6B.Name = "label6B";
            this.label6B.Size = new System.Drawing.Size(25, 20);
            this.label6B.TabIndex = 13;
            this.label6B.Text = "b:";
            this.label6B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3A
            // 
            this.textBox3A.BackColor = System.Drawing.Color.DarkGray;
            this.textBox3A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3A.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3A.ForeColor = System.Drawing.Color.Black;
            this.textBox3A.Location = new System.Drawing.Point(200, 60);
            this.textBox3A.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3A.Name = "textBox3A";
            this.textBox3A.Size = new System.Drawing.Size(100, 20);
            this.textBox3A.TabIndex = 12;
            // 
            // label5A
            // 
            this.label5A.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5A.ForeColor = System.Drawing.Color.Black;
            this.label5A.Location = new System.Drawing.Point(170, 60);
            this.label5A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5A.Name = "label5A";
            this.label5A.Size = new System.Drawing.Size(25, 20);
            this.label5A.TabIndex = 14;
            this.label5A.Text = "a:";
            this.label5A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.textBox4B);
            this.Controls.Add(this.label6B);
            this.Controls.Add(this.textBox3A);
            this.Controls.Add(this.label5A);
            this.Controls.Add(this.button2Exit);
            this.Controls.Add(this.textBox1X);
            this.Controls.Add(this.label3X);
            this.Controls.Add(this.textBox2Y);
            this.Controls.Add(this.label4Y);
            this.Controls.Add(this.label2Text);
            this.Controls.Add(this.label1Red);
            this.Controls.Add(this.button1Calculate);
            this.Controls.Add(this.textBox5Z);
            this.Controls.Add(this.label7Z);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormLab1";
            this.Text = "Тема 1.4 ЛБ «Программирование алгоритмов разветвляющихся структур»";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7Z;
        private System.Windows.Forms.TextBox textBox5Z;
        private System.Windows.Forms.Button button1Calculate;
        private System.Windows.Forms.Label label1Red;
        private System.Windows.Forms.Label label2Text;
        private System.Windows.Forms.TextBox textBox2Y;
        private System.Windows.Forms.Label label4Y;
        private System.Windows.Forms.TextBox textBox1X;
        private System.Windows.Forms.Label label3X;
        private System.Windows.Forms.Button button2Exit;
        private System.Windows.Forms.TextBox textBox4B;
        private System.Windows.Forms.Label label6B;
        private System.Windows.Forms.TextBox textBox3A;
        private System.Windows.Forms.Label label5A;
    }
}


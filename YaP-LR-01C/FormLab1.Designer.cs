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
            this.label5Y = new System.Windows.Forms.Label();
            this.textBox3Y = new System.Windows.Forms.TextBox();
            this.button1Calculate = new System.Windows.Forms.Button();
            this.label1Red = new System.Windows.Forms.Label();
            this.label2Text = new System.Windows.Forms.Label();
            this.textBox1X = new System.Windows.Forms.TextBox();
            this.label3X = new System.Windows.Forms.Label();
            this.button2Exit = new System.Windows.Forms.Button();
            this.textBox2A = new System.Windows.Forms.TextBox();
            this.label4A = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5Y
            // 
            this.label5Y.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5Y.ForeColor = System.Drawing.Color.Black;
            this.label5Y.Location = new System.Drawing.Point(100, 90);
            this.label5Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5Y.Name = "label5Y";
            this.label5Y.Size = new System.Drawing.Size(25, 20);
            this.label5Y.TabIndex = 8;
            this.label5Y.Text = "y:";
            this.label5Y.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3Y
            // 
            this.textBox3Y.BackColor = System.Drawing.Color.LightGray;
            this.textBox3Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3Y.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3Y.ForeColor = System.Drawing.Color.Black;
            this.textBox3Y.Location = new System.Drawing.Point(130, 90);
            this.textBox3Y.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3Y.Name = "textBox3Y";
            this.textBox3Y.ReadOnly = true;
            this.textBox3Y.Size = new System.Drawing.Size(100, 20);
            this.textBox3Y.TabIndex = 3;
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
            this.button1Calculate.Text = "Вычислить\r\ny=f(x, a)";
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
            this.label2Text.Size = new System.Drawing.Size(347, 19);
            this.label2Text.TabIndex = 10;
            this.label2Text.Text = "Вычислить значение условной функции y=f(x, a)";
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
            // textBox2A
            // 
            this.textBox2A.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2A.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2A.ForeColor = System.Drawing.Color.Black;
            this.textBox2A.Location = new System.Drawing.Point(200, 60);
            this.textBox2A.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2A.Name = "textBox2A";
            this.textBox2A.Size = new System.Drawing.Size(100, 20);
            this.textBox2A.TabIndex = 12;
            // 
            // label4A
            // 
            this.label4A.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4A.ForeColor = System.Drawing.Color.Black;
            this.label4A.Location = new System.Drawing.Point(170, 60);
            this.label4A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4A.Name = "label4A";
            this.label4A.Size = new System.Drawing.Size(25, 20);
            this.label4A.TabIndex = 14;
            this.label4A.Text = "a:";
            this.label4A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(574, 131);
            this.Controls.Add(this.textBox2A);
            this.Controls.Add(this.label4A);
            this.Controls.Add(this.button2Exit);
            this.Controls.Add(this.textBox1X);
            this.Controls.Add(this.label3X);
            this.Controls.Add(this.label2Text);
            this.Controls.Add(this.label1Red);
            this.Controls.Add(this.button1Calculate);
            this.Controls.Add(this.textBox3Y);
            this.Controls.Add(this.label5Y);
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

        private System.Windows.Forms.Label label5Y;
        private System.Windows.Forms.TextBox textBox3Y;
        private System.Windows.Forms.Button button1Calculate;
        private System.Windows.Forms.Label label1Red;
        private System.Windows.Forms.Label label2Text;
        private System.Windows.Forms.TextBox textBox1X;
        private System.Windows.Forms.Label label3X;
        private System.Windows.Forms.Button button2Exit;
        private System.Windows.Forms.TextBox textBox2A;
        private System.Windows.Forms.Label label4A;
    }
}


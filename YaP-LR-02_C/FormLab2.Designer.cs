﻿namespace YaP_LR_02_C
{
    partial class FormLab2
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
            this.listBox2FuncX = new System.Windows.Forms.ListBox();
            this.label8X = new System.Windows.Forms.Label();
            this.textBox1A = new System.Windows.Forms.TextBox();
            this.button1Calculate = new System.Windows.Forms.Button();
            this.button2Exit = new System.Windows.Forms.Button();
            this.label3A = new System.Windows.Forms.Label();
            this.label1TextBlue = new System.Windows.Forms.Label();
            this.label4B = new System.Windows.Forms.Label();
            this.textBox2B = new System.Windows.Forms.TextBox();
            this.label5H = new System.Windows.Forms.Label();
            this.textBox3H = new System.Windows.Forms.TextBox();
            this.label6N = new System.Windows.Forms.Label();
            this.textBox4N = new System.Windows.Forms.TextBox();
            this.label7M = new System.Windows.Forms.Label();
            this.textBox5Multiple = new System.Windows.Forms.TextBox();
            this.label9F = new System.Windows.Forms.Label();
            this.listBox1ArgX = new System.Windows.Forms.ListBox();
            this.label2Func = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox2FuncX
            // 
            this.listBox2FuncX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2FuncX.FormattingEnabled = true;
            this.listBox2FuncX.ItemHeight = 17;
            this.listBox2FuncX.Location = new System.Drawing.Point(215, 5);
            this.listBox2FuncX.Margin = new System.Windows.Forms.Padding(5);
            this.listBox2FuncX.Name = "listBox2FuncX";
            this.listBox2FuncX.Size = new System.Drawing.Size(200, 310);
            this.listBox2FuncX.TabIndex = 9;
            // 
            // label8X
            // 
            this.label8X.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8X.ForeColor = System.Drawing.Color.Green;
            this.label8X.Location = new System.Drawing.Point(15, 80);
            this.label8X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8X.Name = "label8X";
            this.label8X.Size = new System.Drawing.Size(100, 24);
            this.label8X.TabIndex = 18;
            this.label8X.Text = "Аргумент (x)";
            this.label8X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1A
            // 
            this.textBox1A.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1A.Location = new System.Drawing.Point(600, 25);
            this.textBox1A.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1A.Name = "textBox1A";
            this.textBox1A.Size = new System.Drawing.Size(155, 24);
            this.textBox1A.TabIndex = 1;
            // 
            // button1Calculate
            // 
            this.button1Calculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Calculate.Location = new System.Drawing.Point(490, 375);
            this.button1Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.button1Calculate.Name = "button1Calculate";
            this.button1Calculate.Size = new System.Drawing.Size(100, 50);
            this.button1Calculate.TabIndex = 4;
            this.button1Calculate.Text = "Вычислить";
            this.button1Calculate.UseVisualStyleBackColor = true;
            this.button1Calculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // button2Exit
            // 
            this.button2Exit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2Exit.Location = new System.Drawing.Point(595, 375);
            this.button2Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button2Exit.Name = "button2Exit";
            this.button2Exit.Size = new System.Drawing.Size(100, 50);
            this.button2Exit.TabIndex = 5;
            this.button2Exit.Text = "Выход";
            this.button2Exit.UseVisualStyleBackColor = true;
            this.button2Exit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label3A
            // 
            this.label3A.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3A.Location = new System.Drawing.Point(440, 25);
            this.label3A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3A.Name = "label3A";
            this.label3A.Size = new System.Drawing.Size(155, 24);
            this.label3A.TabIndex = 13;
            this.label3A.Text = "Начальное значение";
            this.label3A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1TextBlue
            // 
            this.label1TextBlue.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1TextBlue.ForeColor = System.Drawing.Color.Blue;
            this.label1TextBlue.Location = new System.Drawing.Point(10, 25);
            this.label1TextBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1TextBlue.Name = "label1TextBlue";
            this.label1TextBlue.Size = new System.Drawing.Size(275, 24);
            this.label1TextBlue.TabIndex = 10;
            this.label1TextBlue.Text = "Задание протабулировать функцию";
            this.label1TextBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4B
            // 
            this.label4B.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4B.Location = new System.Drawing.Point(440, 55);
            this.label4B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4B.Name = "label4B";
            this.label4B.Size = new System.Drawing.Size(155, 24);
            this.label4B.TabIndex = 14;
            this.label4B.Text = "Конечное значение";
            this.label4B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2B
            // 
            this.textBox2B.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2B.Location = new System.Drawing.Point(600, 55);
            this.textBox2B.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2B.Name = "textBox2B";
            this.textBox2B.Size = new System.Drawing.Size(155, 24);
            this.textBox2B.TabIndex = 2;
            // 
            // label5H
            // 
            this.label5H.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5H.Location = new System.Drawing.Point(440, 85);
            this.label5H.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5H.Name = "label5H";
            this.label5H.Size = new System.Drawing.Size(155, 24);
            this.label5H.TabIndex = 15;
            this.label5H.Text = "Шаг";
            this.label5H.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3H
            // 
            this.textBox3H.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3H.Location = new System.Drawing.Point(600, 85);
            this.textBox3H.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3H.Name = "textBox3H";
            this.textBox3H.Size = new System.Drawing.Size(155, 24);
            this.textBox3H.TabIndex = 3;
            // 
            // label6N
            // 
            this.label6N.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6N.Location = new System.Drawing.Point(440, 115);
            this.label6N.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6N.Name = "label6N";
            this.label6N.Size = new System.Drawing.Size(155, 24);
            this.label6N.TabIndex = 16;
            this.label6N.Text = "n =";
            this.label6N.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4N
            // 
            this.textBox4N.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4N.Location = new System.Drawing.Point(600, 115);
            this.textBox4N.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4N.Name = "textBox4N";
            this.textBox4N.ReadOnly = true;
            this.textBox4N.Size = new System.Drawing.Size(155, 24);
            this.textBox4N.TabIndex = 6;
            // 
            // label7M
            // 
            this.label7M.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7M.Location = new System.Drawing.Point(515, 260);
            this.label7M.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7M.Name = "label7M";
            this.label7M.Size = new System.Drawing.Size(155, 48);
            this.label7M.TabIndex = 17;
            this.label7M.Text = "Произведение\r\nзначений функций";
            this.label7M.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5Multiple
            // 
            this.textBox5Multiple.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5Multiple.Location = new System.Drawing.Point(515, 320);
            this.textBox5Multiple.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5Multiple.Name = "textBox5Multiple";
            this.textBox5Multiple.ReadOnly = true;
            this.textBox5Multiple.Size = new System.Drawing.Size(155, 24);
            this.textBox5Multiple.TabIndex = 7;
            // 
            // label9F
            // 
            this.label9F.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9F.ForeColor = System.Drawing.Color.Green;
            this.label9F.Location = new System.Drawing.Point(225, 80);
            this.label9F.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9F.Name = "label9F";
            this.label9F.Size = new System.Drawing.Size(100, 24);
            this.label9F.TabIndex = 19;
            this.label9F.Text = "Функция f(x)";
            this.label9F.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1ArgX
            // 
            this.listBox1ArgX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1ArgX.FormattingEnabled = true;
            this.listBox1ArgX.ItemHeight = 17;
            this.listBox1ArgX.Location = new System.Drawing.Point(5, 5);
            this.listBox1ArgX.Margin = new System.Windows.Forms.Padding(5);
            this.listBox1ArgX.Name = "listBox1ArgX";
            this.listBox1ArgX.Size = new System.Drawing.Size(200, 310);
            this.listBox1ArgX.TabIndex = 8;
            // 
            // label2Func
            // 
            this.label2Func.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Func.ForeColor = System.Drawing.Color.Red;
            this.label2Func.Location = new System.Drawing.Point(290, 0);
            this.label2Func.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2Func.Name = "label2Func";
            this.label2Func.Size = new System.Drawing.Size(130, 72);
            this.label2Func.TabIndex = 12;
            this.label2Func.Text = "y=x³-6x²+19.8";
            this.label2Func.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1ArgX);
            this.panel1.Controls.Add(this.listBox2FuncX);
            this.panel1.Location = new System.Drawing.Point(10, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 320);
            this.panel1.TabIndex = 20;
            // 
            // FormLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2Func);
            this.Controls.Add(this.label9F);
            this.Controls.Add(this.label7M);
            this.Controls.Add(this.textBox5Multiple);
            this.Controls.Add(this.label6N);
            this.Controls.Add(this.textBox4N);
            this.Controls.Add(this.label5H);
            this.Controls.Add(this.textBox3H);
            this.Controls.Add(this.label4B);
            this.Controls.Add(this.textBox2B);
            this.Controls.Add(this.label1TextBlue);
            this.Controls.Add(this.label3A);
            this.Controls.Add(this.button2Exit);
            this.Controls.Add(this.button1Calculate);
            this.Controls.Add(this.textBox1A);
            this.Controls.Add(this.label8X);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLab2";
            this.Text = "Тема 1.5. ЛР «Программирование алгоритмов регулярных циклических структур»";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2FuncX;
        private System.Windows.Forms.Label label8X;
        private System.Windows.Forms.TextBox textBox1A;
        private System.Windows.Forms.Button button1Calculate;
        private System.Windows.Forms.Button button2Exit;
        private System.Windows.Forms.Label label3A;
        private System.Windows.Forms.Label label1TextBlue;
        private System.Windows.Forms.Label label4B;
        private System.Windows.Forms.TextBox textBox2B;
        private System.Windows.Forms.Label label5H;
        private System.Windows.Forms.TextBox textBox3H;
        private System.Windows.Forms.Label label6N;
        private System.Windows.Forms.TextBox textBox4N;
        private System.Windows.Forms.Label label7M;
        private System.Windows.Forms.TextBox textBox5Multiple;
        private System.Windows.Forms.Label label9F;
        private System.Windows.Forms.ListBox listBox1ArgX;
        private System.Windows.Forms.Label label2Func;
        private System.Windows.Forms.Panel panel1;
    }
}


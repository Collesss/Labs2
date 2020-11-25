namespace YaP_LR_02_C
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
            this.labelText1T = new System.Windows.Forms.Label();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox2FuncX
            // 
            this.listBox2FuncX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2FuncX.FormattingEnabled = true;
            this.listBox2FuncX.ItemHeight = 17;
            this.listBox2FuncX.Location = new System.Drawing.Point(239, 4);
            this.listBox2FuncX.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2FuncX.Name = "listBox2FuncX";
            this.listBox2FuncX.Size = new System.Drawing.Size(227, 378);
            this.listBox2FuncX.TabIndex = 9;
            // 
            // label8X
            // 
            this.label8X.AutoSize = true;
            this.label8X.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8X.Location = new System.Drawing.Point(12, 93);
            this.label8X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8X.Name = "label8X";
            this.label8X.Size = new System.Drawing.Size(96, 19);
            this.label8X.TabIndex = 18;
            this.label8X.Text = "Аргумент (x)";
            // 
            // textBox1A
            // 
            this.textBox1A.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1A.Location = new System.Drawing.Point(662, 24);
            this.textBox1A.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1A.Name = "textBox1A";
            this.textBox1A.Size = new System.Drawing.Size(132, 24);
            this.textBox1A.TabIndex = 1;
            // 
            // button1Calculate
            // 
            this.button1Calculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Calculate.Location = new System.Drawing.Point(520, 357);
            this.button1Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.button1Calculate.Name = "button1Calculate";
            this.button1Calculate.Size = new System.Drawing.Size(133, 62);
            this.button1Calculate.TabIndex = 4;
            this.button1Calculate.Text = "Вычислить";
            this.button1Calculate.UseVisualStyleBackColor = true;
            this.button1Calculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // button2Exit
            // 
            this.button2Exit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2Exit.Location = new System.Drawing.Point(662, 357);
            this.button2Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button2Exit.Name = "button2Exit";
            this.button2Exit.Size = new System.Drawing.Size(133, 62);
            this.button2Exit.TabIndex = 5;
            this.button2Exit.Text = "Выход";
            this.button2Exit.UseVisualStyleBackColor = true;
            this.button2Exit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label3A
            // 
            this.label3A.AutoSize = true;
            this.label3A.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3A.Location = new System.Drawing.Point(499, 27);
            this.label3A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3A.Name = "label3A";
            this.label3A.Size = new System.Drawing.Size(155, 19);
            this.label3A.TabIndex = 13;
            this.label3A.Text = "Начальное значение";
            // 
            // labelText1T
            // 
            this.labelText1T.AutoSize = true;
            this.labelText1T.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText1T.Location = new System.Drawing.Point(12, 26);
            this.labelText1T.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText1T.Name = "labelText1T";
            this.labelText1T.Size = new System.Drawing.Size(271, 19);
            this.labelText1T.TabIndex = 10;
            this.labelText1T.Text = "Задание протабулировать функцию";
            // 
            // label4B
            // 
            this.label4B.AutoSize = true;
            this.label4B.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4B.Location = new System.Drawing.Point(510, 63);
            this.label4B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4B.Name = "label4B";
            this.label4B.Size = new System.Drawing.Size(144, 19);
            this.label4B.TabIndex = 14;
            this.label4B.Text = "Конечное значение";
            // 
            // textBox2B
            // 
            this.textBox2B.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2B.Location = new System.Drawing.Point(662, 60);
            this.textBox2B.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2B.Name = "textBox2B";
            this.textBox2B.Size = new System.Drawing.Size(132, 24);
            this.textBox2B.TabIndex = 2;
            // 
            // label5H
            // 
            this.label5H.AutoSize = true;
            this.label5H.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5H.Location = new System.Drawing.Point(616, 99);
            this.label5H.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5H.Name = "label5H";
            this.label5H.Size = new System.Drawing.Size(38, 19);
            this.label5H.TabIndex = 15;
            this.label5H.Text = "Шаг";
            // 
            // textBox3H
            // 
            this.textBox3H.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3H.Location = new System.Drawing.Point(662, 96);
            this.textBox3H.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3H.Name = "textBox3H";
            this.textBox3H.Size = new System.Drawing.Size(132, 24);
            this.textBox3H.TabIndex = 3;
            // 
            // label6N
            // 
            this.label6N.AutoSize = true;
            this.label6N.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6N.Location = new System.Drawing.Point(624, 134);
            this.label6N.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6N.Name = "label6N";
            this.label6N.Size = new System.Drawing.Size(30, 19);
            this.label6N.TabIndex = 16;
            this.label6N.Text = "n =";
            // 
            // textBox4N
            // 
            this.textBox4N.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4N.Location = new System.Drawing.Point(662, 131);
            this.textBox4N.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4N.Name = "textBox4N";
            this.textBox4N.ReadOnly = true;
            this.textBox4N.Size = new System.Drawing.Size(132, 24);
            this.textBox4N.TabIndex = 6;
            // 
            // label7M
            // 
            this.label7M.AutoSize = true;
            this.label7M.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7M.Location = new System.Drawing.Point(510, 211);
            this.label7M.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7M.Name = "label7M";
            this.label7M.Size = new System.Drawing.Size(250, 19);
            this.label7M.TabIndex = 17;
            this.label7M.Text = "Произведение значений функций";
            // 
            // textBox5Multiple
            // 
            this.textBox5Multiple.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5Multiple.Location = new System.Drawing.Point(575, 234);
            this.textBox5Multiple.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5Multiple.Name = "textBox5Multiple";
            this.textBox5Multiple.ReadOnly = true;
            this.textBox5Multiple.Size = new System.Drawing.Size(132, 24);
            this.textBox5Multiple.TabIndex = 7;
            // 
            // label9F
            // 
            this.label9F.AutoSize = true;
            this.label9F.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9F.Location = new System.Drawing.Point(247, 93);
            this.label9F.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9F.Name = "label9F";
            this.label9F.Size = new System.Drawing.Size(93, 19);
            this.label9F.TabIndex = 19;
            this.label9F.Text = "Функция f(x)";
            // 
            // listBox1ArgX
            // 
            this.listBox1ArgX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1ArgX.FormattingEnabled = true;
            this.listBox1ArgX.ItemHeight = 17;
            this.listBox1ArgX.Location = new System.Drawing.Point(4, 4);
            this.listBox1ArgX.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1ArgX.Name = "listBox1ArgX";
            this.listBox1ArgX.Size = new System.Drawing.Size(227, 378);
            this.listBox1ArgX.TabIndex = 8;
            // 
            // label2Func
            // 
            this.label2Func.AutoSize = true;
            this.label2Func.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Func.Location = new System.Drawing.Point(291, -2);
            this.label2Func.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2Func.Name = "label2Func";
            this.label2Func.Size = new System.Drawing.Size(126, 78);
            this.label2Func.TabIndex = 12;
            this.label2Func.Text = "y=x³-6x²+19.8";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.listBox1ArgX);
            this.flowLayoutPanel1.Controls.Add(this.listBox2FuncX);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 386);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // FormLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 513);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.Controls.Add(this.labelText1T);
            this.Controls.Add(this.label3A);
            this.Controls.Add(this.button2Exit);
            this.Controls.Add(this.button1Calculate);
            this.Controls.Add(this.textBox1A);
            this.Controls.Add(this.label8X);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLab2";
            this.Text = "Тема 1.5. ЛР «Программирование алгоритмов регулярных циклических структур»";
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelText1T;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}


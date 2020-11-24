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
            this.listBoxFuncX = new System.Windows.Forms.ListBox();
            this.labelText2X = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelText4A = new System.Windows.Forms.Label();
            this.labelText1T = new System.Windows.Forms.Label();
            this.labelText5B = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelText6H = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.labelText7N = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelText8M = new System.Windows.Forms.Label();
            this.textBoxMultiple = new System.Windows.Forms.TextBox();
            this.labelText3F = new System.Windows.Forms.Label();
            this.listBoxArgX = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFuncX
            // 
            this.listBoxFuncX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFuncX.FormattingEnabled = true;
            this.listBoxFuncX.ItemHeight = 17;
            this.listBoxFuncX.Location = new System.Drawing.Point(239, 4);
            this.listBoxFuncX.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFuncX.Name = "listBoxFuncX";
            this.listBoxFuncX.Size = new System.Drawing.Size(227, 378);
            this.listBoxFuncX.TabIndex = 8;
            // 
            // labelText2X
            // 
            this.labelText2X.AutoSize = true;
            this.labelText2X.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText2X.Location = new System.Drawing.Point(12, 208);
            this.labelText2X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText2X.Name = "labelText2X";
            this.labelText2X.Size = new System.Drawing.Size(96, 19);
            this.labelText2X.TabIndex = 10;
            this.labelText2X.Text = "Аргумент (x)";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(763, 23);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(132, 24);
            this.textBoxA.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(621, 500);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(133, 62);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(763, 500);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 62);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelText4A
            // 
            this.labelText4A.AutoSize = true;
            this.labelText4A.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText4A.Location = new System.Drawing.Point(600, 26);
            this.labelText4A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText4A.Name = "labelText4A";
            this.labelText4A.Size = new System.Drawing.Size(155, 19);
            this.labelText4A.TabIndex = 14;
            this.labelText4A.Text = "Начальное значение";
            // 
            // labelText1T
            // 
            this.labelText1T.AutoSize = true;
            this.labelText1T.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText1T.Location = new System.Drawing.Point(12, 26);
            this.labelText1T.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText1T.Name = "labelText1T";
            this.labelText1T.Size = new System.Drawing.Size(271, 19);
            this.labelText1T.TabIndex = 12;
            this.labelText1T.Text = "Задание протабулировать функцию";
            // 
            // labelText5B
            // 
            this.labelText5B.AutoSize = true;
            this.labelText5B.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText5B.Location = new System.Drawing.Point(611, 62);
            this.labelText5B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText5B.Name = "labelText5B";
            this.labelText5B.Size = new System.Drawing.Size(144, 19);
            this.labelText5B.TabIndex = 15;
            this.labelText5B.Text = "Конечное значение";
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(763, 59);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(132, 24);
            this.textBoxB.TabIndex = 2;
            // 
            // labelText6H
            // 
            this.labelText6H.AutoSize = true;
            this.labelText6H.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText6H.Location = new System.Drawing.Point(717, 98);
            this.labelText6H.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText6H.Name = "labelText6H";
            this.labelText6H.Size = new System.Drawing.Size(38, 19);
            this.labelText6H.TabIndex = 16;
            this.labelText6H.Text = "Шаг";
            // 
            // textBoxH
            // 
            this.textBoxH.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxH.Location = new System.Drawing.Point(763, 95);
            this.textBoxH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(132, 24);
            this.textBoxH.TabIndex = 3;
            // 
            // labelText7N
            // 
            this.labelText7N.AutoSize = true;
            this.labelText7N.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText7N.Location = new System.Drawing.Point(725, 133);
            this.labelText7N.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText7N.Name = "labelText7N";
            this.labelText7N.Size = new System.Drawing.Size(30, 19);
            this.labelText7N.TabIndex = 17;
            this.labelText7N.Text = "n =";
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(763, 130);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.ReadOnly = true;
            this.textBoxN.Size = new System.Drawing.Size(132, 24);
            this.textBoxN.TabIndex = 4;
            // 
            // labelText8M
            // 
            this.labelText8M.AutoSize = true;
            this.labelText8M.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText8M.Location = new System.Drawing.Point(611, 354);
            this.labelText8M.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText8M.Name = "labelText8M";
            this.labelText8M.Size = new System.Drawing.Size(250, 19);
            this.labelText8M.TabIndex = 13;
            this.labelText8M.Text = "Произведение значений функций";
            // 
            // textBoxMultiple
            // 
            this.textBoxMultiple.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMultiple.Location = new System.Drawing.Point(676, 377);
            this.textBoxMultiple.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMultiple.Name = "textBoxMultiple";
            this.textBoxMultiple.ReadOnly = true;
            this.textBoxMultiple.Size = new System.Drawing.Size(132, 24);
            this.textBoxMultiple.TabIndex = 7;
            // 
            // labelText3F
            // 
            this.labelText3F.AutoSize = true;
            this.labelText3F.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText3F.Location = new System.Drawing.Point(247, 208);
            this.labelText3F.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText3F.Name = "labelText3F";
            this.labelText3F.Size = new System.Drawing.Size(93, 19);
            this.labelText3F.TabIndex = 11;
            this.labelText3F.Text = "Функция f(x)";
            // 
            // listBoxArgX
            // 
            this.listBoxArgX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxArgX.FormattingEnabled = true;
            this.listBoxArgX.ItemHeight = 17;
            this.listBoxArgX.Location = new System.Drawing.Point(4, 4);
            this.listBoxArgX.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxArgX.Name = "listBoxArgX";
            this.listBoxArgX.Size = new System.Drawing.Size(227, 378);
            this.listBoxArgX.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 78);
            this.label1.TabIndex = 18;
            this.label1.Text = "y=x³-6x²+19.8";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listBoxArgX);
            this.flowLayoutPanel1.Controls.Add(this.listBoxFuncX);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 230);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(472, 389);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // FormLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 627);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelText3F);
            this.Controls.Add(this.labelText8M);
            this.Controls.Add(this.textBoxMultiple);
            this.Controls.Add(this.labelText7N);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelText6H);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.labelText5B);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelText1T);
            this.Controls.Add(this.labelText4A);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelText2X);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLab2";
            this.Text = "Тема 1.5. ЛР «Программирование алгоритмов регулярных циклических структур»";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFuncX;
        private System.Windows.Forms.Label labelText2X;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelText4A;
        private System.Windows.Forms.Label labelText1T;
        private System.Windows.Forms.Label labelText5B;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelText6H;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label labelText7N;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelText8M;
        private System.Windows.Forms.TextBox textBoxMultiple;
        private System.Windows.Forms.Label labelText3F;
        private System.Windows.Forms.ListBox listBoxArgX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}


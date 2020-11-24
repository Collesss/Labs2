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
            this.labelText5L = new System.Windows.Forms.Label();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelText1Red = new System.Windows.Forms.Label();
            this.labelText2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelText4A = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelText3X = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelText5L
            // 
            this.labelText5L.AutoSize = true;
            this.labelText5L.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText5L.Location = new System.Drawing.Point(50, 130);
            this.labelText5L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText5L.Name = "labelText5L";
            this.labelText5L.Size = new System.Drawing.Size(16, 19);
            this.labelText5L.TabIndex = 8;
            this.labelText5L.Text = "l:";
            // 
            // textBoxL
            // 
            this.textBoxL.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxL.Location = new System.Drawing.Point(80, 128);
            this.textBoxL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.ReadOnly = true;
            this.textBoxL.Size = new System.Drawing.Size(100, 24);
            this.textBoxL.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(280, 85);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(90, 50);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Вычислить\r\nl=f(x, a)";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelText1Red
            // 
            this.labelText1Red.AutoSize = true;
            this.labelText1Red.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText1Red.ForeColor = System.Drawing.Color.Red;
            this.labelText1Red.Location = new System.Drawing.Point(10, 10);
            this.labelText1Red.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText1Red.Name = "labelText1Red";
            this.labelText1Red.Size = new System.Drawing.Size(123, 28);
            this.labelText1Red.TabIndex = 9;
            this.labelText1Red.Text = "Задание:";
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText2.Location = new System.Drawing.Point(150, 15);
            this.labelText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(342, 19);
            this.labelText2.TabIndex = 10;
            this.labelText2.Text = "Вычислить значение условной функции l=f(x, a)";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(80, 98);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 24);
            this.textBoxA.TabIndex = 2;
            // 
            // labelText4A
            // 
            this.labelText4A.AutoSize = true;
            this.labelText4A.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText4A.Location = new System.Drawing.Point(50, 100);
            this.labelText4A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText4A.Name = "labelText4A";
            this.labelText4A.Size = new System.Drawing.Size(23, 19);
            this.labelText4A.TabIndex = 7;
            this.labelText4A.Text = "a:";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(80, 73);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 24);
            this.textBoxX.TabIndex = 1;
            // 
            // labelText3X
            // 
            this.labelText3X.AutoSize = true;
            this.labelText3X.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText3X.Location = new System.Drawing.Point(50, 75);
            this.labelText3X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText3X.Name = "labelText3X";
            this.labelText3X.Size = new System.Drawing.Size(20, 19);
            this.labelText3X.TabIndex = 6;
            this.labelText3X.Text = "x:";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(400, 85);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 50);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 186);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelText3X);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelText4A);
            this.Controls.Add(this.labelText2);
            this.Controls.Add(this.labelText1Red);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.labelText5L);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormLab1";
            this.Text = "ЛБ «Программирование алгоритмов разветвляющихся структур»";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText5L;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelText1Red;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelText4A;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelText3X;
        private System.Windows.Forms.Button buttonExit;
    }
}


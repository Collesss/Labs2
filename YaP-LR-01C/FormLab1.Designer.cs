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
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.labelText4Z = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelText3X = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelText5L
            // 
            this.labelText5L.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText5L.ForeColor = System.Drawing.Color.Black;
            this.labelText5L.Location = new System.Drawing.Point(73, 136);
            this.labelText5L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText5L.Name = "labelText5L";
            this.labelText5L.Size = new System.Drawing.Size(16, 20);
            this.labelText5L.TabIndex = 8;
            this.labelText5L.Text = "l:";
            // 
            // textBoxL
            // 
            this.textBoxL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxL.ForeColor = System.Drawing.Color.Black;
            this.textBoxL.Location = new System.Drawing.Point(105, 130);
            this.textBoxL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.ReadOnly = true;
            this.textBoxL.Size = new System.Drawing.Size(100, 27);
            this.textBoxL.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCalculate.FlatAppearance.BorderSize = 0;
            this.buttonCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(155)))));
            this.buttonCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(176)))), ((int)(((byte)(199)))));
            this.buttonCalculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCalculate.Location = new System.Drawing.Point(305, 85);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(90, 50);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Вычислить\r\nl=f(x, z)";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelText1Red
            // 
            this.labelText1Red.AutoSize = true;
            this.labelText1Red.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText1Red.ForeColor = System.Drawing.Color.Red;
            this.labelText1Red.Location = new System.Drawing.Point(35, 10);
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
            this.labelText2.ForeColor = System.Drawing.Color.Black;
            this.labelText2.Location = new System.Drawing.Point(175, 15);
            this.labelText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(338, 19);
            this.labelText2.TabIndex = 10;
            this.labelText2.Text = "Вычислить значение условной функции l=f(x, z)";
            // 
            // textBoxZ
            // 
            this.textBoxZ.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxZ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZ.ForeColor = System.Drawing.Color.Black;
            this.textBoxZ.Location = new System.Drawing.Point(105, 100);
            this.textBoxZ.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(100, 27);
            this.textBoxZ.TabIndex = 2;
            // 
            // labelText4Z
            // 
            this.labelText4Z.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText4Z.ForeColor = System.Drawing.Color.Black;
            this.labelText4Z.Location = new System.Drawing.Point(73, 102);
            this.labelText4Z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText4Z.Name = "labelText4Z";
            this.labelText4Z.Size = new System.Drawing.Size(23, 20);
            this.labelText4Z.TabIndex = 7;
            this.labelText4Z.Text = "z:";
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.ForeColor = System.Drawing.Color.Black;
            this.textBoxX.Location = new System.Drawing.Point(105, 68);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 27);
            this.textBoxX.TabIndex = 1;
            // 
            // labelText3X
            // 
            this.labelText3X.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText3X.ForeColor = System.Drawing.Color.Black;
            this.labelText3X.Location = new System.Drawing.Point(76, 68);
            this.labelText3X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText3X.Name = "labelText3X";
            this.labelText3X.Size = new System.Drawing.Size(20, 20);
            this.labelText3X.TabIndex = 6;
            this.labelText3X.Text = "x:";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(155)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(176)))), ((int)(((byte)(199)))));
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Location = new System.Drawing.Point(425, 85);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 50);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 186);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelText3X);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.labelText4Z);
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
            this.Text = "Тема 1.4 ЛБ «Программирование алгоритмов разветвляющихся структур»";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText5L;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelText1Red;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label labelText4Z;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelText3X;
        private System.Windows.Forms.Button buttonExit;
    }
}


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
            this.button2Exit = new System.Windows.Forms.Button();
            this.label8T = new System.Windows.Forms.Label();
            this.panel1ListBox = new System.Windows.Forms.Panel();
            this.label2DeltaX = new System.Windows.Forms.Label();
            this.textBox2DeltaX = new System.Windows.Forms.TextBox();
            this.label2ApproximateX = new System.Windows.Forms.Label();
            this.textBox2ApproximateX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1ListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1Calculate
            // 
            this.button1Calculate.BackColor = System.Drawing.Color.DarkGray;
            this.button1Calculate.FlatAppearance.BorderSize = 0;
            this.button1Calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1Calculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Calculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Calculate.Location = new System.Drawing.Point(30, 165);
            this.button1Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.button1Calculate.Name = "button1Calculate";
            this.button1Calculate.Size = new System.Drawing.Size(100, 50);
            this.button1Calculate.TabIndex = 3;
            this.button1Calculate.Text = "Вычислить";
            this.button1Calculate.UseVisualStyleBackColor = false;
            this.button1Calculate.Click += new System.EventHandler(this.button1Calculate_Click);
            // 
            // listBox1ApproximateRoot
            // 
            this.listBox1ApproximateRoot.BackColor = System.Drawing.Color.LightGray;
            this.listBox1ApproximateRoot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1ApproximateRoot.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1ApproximateRoot.FormattingEnabled = true;
            this.listBox1ApproximateRoot.ItemHeight = 17;
            this.listBox1ApproximateRoot.Location = new System.Drawing.Point(90, 5);
            this.listBox1ApproximateRoot.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1ApproximateRoot.Name = "listBox1ApproximateRoot";
            this.listBox1ApproximateRoot.Size = new System.Drawing.Size(200, 306);
            this.listBox1ApproximateRoot.TabIndex = 9;
            // 
            // label1ApproximateRoot
            // 
            this.label1ApproximateRoot.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1ApproximateRoot.Location = new System.Drawing.Point(425, 30);
            this.label1ApproximateRoot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1ApproximateRoot.Name = "label1ApproximateRoot";
            this.label1ApproximateRoot.Size = new System.Drawing.Size(175, 24);
            this.label1ApproximateRoot.TabIndex = 11;
            this.label1ApproximateRoot.Text = "Приближённый корень";
            this.label1ApproximateRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2Iteration
            // 
            this.label2Iteration.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Iteration.Location = new System.Drawing.Point(340, 30);
            this.label2Iteration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2Iteration.Name = "label2Iteration";
            this.label2Iteration.Size = new System.Drawing.Size(80, 24);
            this.label2Iteration.TabIndex = 10;
            this.label2Iteration.Text = "Итерация";
            this.label2Iteration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox2Iteration
            // 
            this.listBox2Iteration.BackColor = System.Drawing.Color.LightGray;
            this.listBox2Iteration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2Iteration.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2Iteration.FormattingEnabled = true;
            this.listBox2Iteration.ItemHeight = 17;
            this.listBox2Iteration.Location = new System.Drawing.Point(5, 5);
            this.listBox2Iteration.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2Iteration.Name = "listBox2Iteration";
            this.listBox2Iteration.Size = new System.Drawing.Size(80, 306);
            this.listBox2Iteration.TabIndex = 8;
            // 
            // textBox1E
            // 
            this.textBox1E.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1E.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1E.Location = new System.Drawing.Point(75, 73);
            this.textBox1E.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1E.Name = "textBox1E";
            this.textBox1E.Size = new System.Drawing.Size(155, 20);
            this.textBox1E.TabIndex = 1;
            // 
            // label3E
            // 
            this.label3E.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3E.Location = new System.Drawing.Point(50, 70);
            this.label3E.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3E.Name = "label3E";
            this.label3E.Size = new System.Drawing.Size(20, 24);
            this.label3E.TabIndex = 12;
            this.label3E.Text = "E";
            this.label3E.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2Exit
            // 
            this.button2Exit.BackColor = System.Drawing.Color.DarkGray;
            this.button2Exit.FlatAppearance.BorderSize = 0;
            this.button2Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2Exit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2Exit.Location = new System.Drawing.Point(140, 165);
            this.button2Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button2Exit.Name = "button2Exit";
            this.button2Exit.Size = new System.Drawing.Size(100, 50);
            this.button2Exit.TabIndex = 4;
            this.button2Exit.Text = "Выход";
            this.button2Exit.UseVisualStyleBackColor = false;
            this.button2Exit.Click += new System.EventHandler(this.button2Exit_Click);
            // 
            // label8T
            // 
            this.label8T.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8T.Location = new System.Drawing.Point(5, 5);
            this.label8T.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8T.Name = "label8T";
            this.label8T.Size = new System.Drawing.Size(640, 24);
            this.label8T.TabIndex = 17;
            this.label8T.Text = "Вычислить приближённое значение бесконечной суммы с точность до ε";
            this.label8T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1ListBox
            // 
            this.panel1ListBox.BackColor = System.Drawing.Color.Gray;
            this.panel1ListBox.Controls.Add(this.listBox2Iteration);
            this.panel1ListBox.Controls.Add(this.listBox1ApproximateRoot);
            this.panel1ListBox.Location = new System.Drawing.Point(335, 60);
            this.panel1ListBox.Name = "panel1ListBox";
            this.panel1ListBox.Size = new System.Drawing.Size(295, 316);
            this.panel1ListBox.TabIndex = 18;
            // 
            // label2DeltaX
            // 
            this.label2DeltaX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2DeltaX.Location = new System.Drawing.Point(40, 351);
            this.label2DeltaX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2DeltaX.Name = "label2DeltaX";
            this.label2DeltaX.Size = new System.Drawing.Size(30, 24);
            this.label2DeltaX.TabIndex = 22;
            this.label2DeltaX.Text = "ΔX";
            this.label2DeltaX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2DeltaX
            // 
            this.textBox2DeltaX.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2DeltaX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2DeltaX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2DeltaX.Location = new System.Drawing.Point(75, 351);
            this.textBox2DeltaX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2DeltaX.Name = "textBox2DeltaX";
            this.textBox2DeltaX.Size = new System.Drawing.Size(155, 20);
            this.textBox2DeltaX.TabIndex = 20;
            // 
            // label2ApproximateX
            // 
            this.label2ApproximateX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2ApproximateX.Location = new System.Drawing.Point(40, 317);
            this.label2ApproximateX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2ApproximateX.Name = "label2ApproximateX";
            this.label2ApproximateX.Size = new System.Drawing.Size(30, 24);
            this.label2ApproximateX.TabIndex = 21;
            this.label2ApproximateX.Text = "≈X";
            this.label2ApproximateX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2ApproximateX
            // 
            this.textBox2ApproximateX.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2ApproximateX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2ApproximateX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2ApproximateX.Location = new System.Drawing.Point(75, 321);
            this.textBox2ApproximateX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2ApproximateX.Name = "textBox2ApproximateX";
            this.textBox2ApproximateX.Size = new System.Drawing.Size(155, 20);
            this.textBox2ApproximateX.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(75, 293);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "1/3";
            // 
            // FormLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(649, 396);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2DeltaX);
            this.Controls.Add(this.textBox2DeltaX);
            this.Controls.Add(this.label2ApproximateX);
            this.Controls.Add(this.textBox2ApproximateX);
            this.Controls.Add(this.panel1ListBox);
            this.Controls.Add(this.label8T);
            this.Controls.Add(this.button2Exit);
            this.Controls.Add(this.label3E);
            this.Controls.Add(this.textBox1E);
            this.Controls.Add(this.label2Iteration);
            this.Controls.Add(this.label1ApproximateRoot);
            this.Controls.Add(this.button1Calculate);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLab3";
            this.Text = "Тема 1.6 ЛБ «Программирование алгоритмов итеративных циклических структур»";
            this.panel1ListBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2Exit;
        private System.Windows.Forms.Label label8T;
        private System.Windows.Forms.Panel panel1ListBox;
        private System.Windows.Forms.Label label2DeltaX;
        private System.Windows.Forms.TextBox textBox2DeltaX;
        private System.Windows.Forms.Label label2ApproximateX;
        private System.Windows.Forms.TextBox textBox2ApproximateX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}


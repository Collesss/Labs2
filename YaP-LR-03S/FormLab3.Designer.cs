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
            this.label8T = new System.Windows.Forms.Label();
            this.panel1ListBox = new System.Windows.Forms.Panel();
            this.panel1ListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1Calculate
            // 
            this.button1Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.button1Calculate.FlatAppearance.BorderSize = 0;
            this.button1Calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(155)))));
            this.button1Calculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(176)))), ((int)(((byte)(199)))));
            this.button1Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Calculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Calculate.Location = new System.Drawing.Point(25, 165);
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
            this.listBox1ApproximateRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.label1ApproximateRoot.Location = new System.Drawing.Point(420, 30);
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
            this.label2Iteration.Location = new System.Drawing.Point(335, 30);
            this.label2Iteration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2Iteration.Name = "label2Iteration";
            this.label2Iteration.Size = new System.Drawing.Size(80, 24);
            this.label2Iteration.TabIndex = 10;
            this.label2Iteration.Text = "Итерация";
            this.label2Iteration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox2Iteration
            // 
            this.listBox2Iteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.textBox1E.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.textBox1E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1E.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1E.Location = new System.Drawing.Point(70, 73);
            this.textBox1E.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1E.Name = "textBox1E";
            this.textBox1E.Size = new System.Drawing.Size(155, 20);
            this.textBox1E.TabIndex = 1;
            // 
            // label3E
            // 
            this.label3E.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3E.Location = new System.Drawing.Point(45, 70);
            this.label3E.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3E.Name = "label3E";
            this.label3E.Size = new System.Drawing.Size(20, 24);
            this.label3E.TabIndex = 12;
            this.label3E.Text = "E";
            this.label3E.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4X
            // 
            this.label4X.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4X.Location = new System.Drawing.Point(45, 100);
            this.label4X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4X.Name = "label4X";
            this.label4X.Size = new System.Drawing.Size(20, 24);
            this.label4X.TabIndex = 13;
            this.label4X.Text = "X";
            this.label4X.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2X
            // 
            this.textBox2X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.textBox2X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2X.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2X.Location = new System.Drawing.Point(70, 103);
            this.textBox2X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2X.Name = "textBox2X";
            this.textBox2X.Size = new System.Drawing.Size(155, 20);
            this.textBox2X.TabIndex = 2;
            // 
            // label5LogX
            // 
            this.label5LogX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5LogX.Location = new System.Drawing.Point(45, 295);
            this.label5LogX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5LogX.Name = "label5LogX";
            this.label5LogX.Size = new System.Drawing.Size(20, 24);
            this.label5LogX.TabIndex = 14;
            this.label5LogX.Text = "X";
            this.label5LogX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3LogX
            // 
            this.textBox3LogX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(177)))), ((int)(((byte)(238)))));
            this.textBox3LogX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3LogX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3LogX.Location = new System.Drawing.Point(70, 298);
            this.textBox3LogX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3LogX.Name = "textBox3LogX";
            this.textBox3LogX.ReadOnly = true;
            this.textBox3LogX.Size = new System.Drawing.Size(155, 20);
            this.textBox3LogX.TabIndex = 5;
            // 
            // button2Exit
            // 
            this.button2Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(156)))), ((int)(((byte)(177)))));
            this.button2Exit.FlatAppearance.BorderSize = 0;
            this.button2Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(155)))));
            this.button2Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(176)))), ((int)(((byte)(199)))));
            this.button2Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2Exit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2Exit.Location = new System.Drawing.Point(135, 165);
            this.button2Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button2Exit.Name = "button2Exit";
            this.button2Exit.Size = new System.Drawing.Size(100, 50);
            this.button2Exit.TabIndex = 4;
            this.button2Exit.Text = "Выход";
            this.button2Exit.UseVisualStyleBackColor = false;
            this.button2Exit.Click += new System.EventHandler(this.button2Exit_Click);
            // 
            // label6ApproximateX
            // 
            this.label6ApproximateX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6ApproximateX.Location = new System.Drawing.Point(35, 325);
            this.label6ApproximateX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6ApproximateX.Name = "label6ApproximateX";
            this.label6ApproximateX.Size = new System.Drawing.Size(30, 24);
            this.label6ApproximateX.TabIndex = 15;
            this.label6ApproximateX.Text = "≈X";
            this.label6ApproximateX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4ApproximateX
            // 
            this.textBox4ApproximateX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(177)))), ((int)(((byte)(238)))));
            this.textBox4ApproximateX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4ApproximateX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4ApproximateX.Location = new System.Drawing.Point(70, 328);
            this.textBox4ApproximateX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4ApproximateX.Name = "textBox4ApproximateX";
            this.textBox4ApproximateX.ReadOnly = true;
            this.textBox4ApproximateX.Size = new System.Drawing.Size(155, 20);
            this.textBox4ApproximateX.TabIndex = 6;
            // 
            // label7DeltaX
            // 
            this.label7DeltaX.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7DeltaX.Location = new System.Drawing.Point(35, 355);
            this.label7DeltaX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7DeltaX.Name = "label7DeltaX";
            this.label7DeltaX.Size = new System.Drawing.Size(30, 24);
            this.label7DeltaX.TabIndex = 16;
            this.label7DeltaX.Text = "ΔX";
            this.label7DeltaX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5DeltaX
            // 
            this.textBox5DeltaX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(177)))), ((int)(((byte)(238)))));
            this.textBox5DeltaX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5DeltaX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5DeltaX.Location = new System.Drawing.Point(70, 358);
            this.textBox5DeltaX.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5DeltaX.Name = "textBox5DeltaX";
            this.textBox5DeltaX.ReadOnly = true;
            this.textBox5DeltaX.Size = new System.Drawing.Size(155, 20);
            this.textBox5DeltaX.TabIndex = 7;
            // 
            // label8T
            // 
            this.label8T.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8T.Location = new System.Drawing.Point(5, 5);
            this.label8T.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8T.Name = "label8T";
            this.label8T.Size = new System.Drawing.Size(630, 24);
            this.label8T.TabIndex = 17;
            this.label8T.Text = "Вычисление приближенного корня ln(x+1) с точностью до ε используя разложение в ря" +
    "д";
            // 
            // panel1ListBox
            // 
            this.panel1ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.panel1ListBox.Controls.Add(this.listBox2Iteration);
            this.panel1ListBox.Controls.Add(this.listBox1ApproximateRoot);
            this.panel1ListBox.Location = new System.Drawing.Point(330, 60);
            this.panel1ListBox.Name = "panel1ListBox";
            this.panel1ListBox.Size = new System.Drawing.Size(295, 316);
            this.panel1ListBox.TabIndex = 18;
            // 
            // FormLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(208)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(639, 391);
            this.Controls.Add(this.panel1ListBox);
            this.Controls.Add(this.label8T);
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
        private System.Windows.Forms.Label label4X;
        private System.Windows.Forms.TextBox textBox2X;
        private System.Windows.Forms.Label label5LogX;
        private System.Windows.Forms.TextBox textBox3LogX;
        private System.Windows.Forms.Button button2Exit;
        private System.Windows.Forms.Label label6ApproximateX;
        private System.Windows.Forms.TextBox textBox4ApproximateX;
        private System.Windows.Forms.Label label7DeltaX;
        private System.Windows.Forms.TextBox textBox5DeltaX;
        private System.Windows.Forms.Label label8T;
        private System.Windows.Forms.Panel panel1ListBox;
    }
}


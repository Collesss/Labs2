
namespace YaP_Kursovaya_rabota_C
{
    partial class FormCourseWork
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
            this.listBox1Input = new System.Windows.Forms.ListBox();
            this.textBox1Num = new System.Windows.Forms.TextBox();
            this.label4Num = new System.Windows.Forms.Label();
            this.button3Calculate = new System.Windows.Forms.Button();
            this.listBox2Output = new System.Windows.Forms.ListBox();
            this.button4ClearList = new System.Windows.Forms.Button();
            this.button4Exit = new System.Windows.Forms.Button();
            this.label11Count = new System.Windows.Forms.Label();
            this.textBox4Count = new System.Windows.Forms.TextBox();
            this.button1Add = new System.Windows.Forms.Button();
            this.label1TextBlue = new System.Windows.Forms.Label();
            this.label2TextBlue = new System.Windows.Forms.Label();
            this.label3Text = new System.Windows.Forms.Label();
            this.label8InputArray = new System.Windows.Forms.Label();
            this.label9OutputArray = new System.Windows.Forms.Label();
            this.comboBox1SelectInput = new System.Windows.Forms.ComboBox();
            this.comboBox2SelectOutput = new System.Windows.Forms.ComboBox();
            this.label6SelectInput = new System.Windows.Forms.Label();
            this.label7SelectOutput = new System.Windows.Forms.Label();
            this.groupBox1InputKeyBoard = new System.Windows.Forms.GroupBox();
            this.groupBox2InputRand = new System.Windows.Forms.GroupBox();
            this.button2FillArrayRand = new System.Windows.Forms.Button();
            this.label5CountRand = new System.Windows.Forms.Label();
            this.textBox2CountRand = new System.Windows.Forms.TextBox();
            this.groupBox1InputKeyBoard.SuspendLayout();
            this.groupBox2InputRand.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1Input
            // 
            this.listBox1Input.BackColor = System.Drawing.Color.LightGray;
            this.listBox1Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1Input.ColumnWidth = 50;
            this.listBox1Input.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1Input.FormattingEnabled = true;
            this.listBox1Input.HorizontalScrollbar = true;
            this.listBox1Input.ItemHeight = 17;
            this.listBox1Input.Location = new System.Drawing.Point(210, 270);
            this.listBox1Input.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1Input.MultiColumn = true;
            this.listBox1Input.Name = "listBox1Input";
            this.listBox1Input.ScrollAlwaysVisible = true;
            this.listBox1Input.Size = new System.Drawing.Size(600, 34);
            this.listBox1Input.TabIndex = 0;
            // 
            // textBox1Num
            // 
            this.textBox1Num.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1Num.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Num.Location = new System.Drawing.Point(250, 31);
            this.textBox1Num.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1Num.Name = "textBox1Num";
            this.textBox1Num.Size = new System.Drawing.Size(155, 20);
            this.textBox1Num.TabIndex = 1;
            // 
            // label4Num
            // 
            this.label4Num.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4Num.Location = new System.Drawing.Point(10, 28);
            this.label4Num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4Num.Name = "label4Num";
            this.label4Num.Size = new System.Drawing.Size(235, 24);
            this.label4Num.TabIndex = 2;
            this.label4Num.Text = "Число для добавления в список";
            this.label4Num.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3Calculate
            // 
            this.button3Calculate.BackColor = System.Drawing.Color.DarkGray;
            this.button3Calculate.FlatAppearance.BorderSize = 0;
            this.button3Calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3Calculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3Calculate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3Calculate.Location = new System.Drawing.Point(580, 145);
            this.button3Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.button3Calculate.Name = "button3Calculate";
            this.button3Calculate.Size = new System.Drawing.Size(100, 50);
            this.button3Calculate.TabIndex = 3;
            this.button3Calculate.Text = "Вычислить";
            this.button3Calculate.UseVisualStyleBackColor = false;
            this.button3Calculate.Click += new System.EventHandler(this.button3Calculate_Click);
            // 
            // listBox2Output
            // 
            this.listBox2Output.BackColor = System.Drawing.Color.LightGray;
            this.listBox2Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2Output.ColumnWidth = 50;
            this.listBox2Output.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2Output.FormattingEnabled = true;
            this.listBox2Output.HorizontalScrollbar = true;
            this.listBox2Output.ItemHeight = 17;
            this.listBox2Output.Location = new System.Drawing.Point(210, 375);
            this.listBox2Output.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2Output.MultiColumn = true;
            this.listBox2Output.Name = "listBox2Output";
            this.listBox2Output.ScrollAlwaysVisible = true;
            this.listBox2Output.Size = new System.Drawing.Size(600, 34);
            this.listBox2Output.TabIndex = 4;
            // 
            // button4ClearList
            // 
            this.button4ClearList.BackColor = System.Drawing.Color.DarkGray;
            this.button4ClearList.FlatAppearance.BorderSize = 0;
            this.button4ClearList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button4ClearList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4ClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4ClearList.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4ClearList.Location = new System.Drawing.Point(685, 145);
            this.button4ClearList.Margin = new System.Windows.Forms.Padding(4);
            this.button4ClearList.Name = "button4ClearList";
            this.button4ClearList.Size = new System.Drawing.Size(100, 50);
            this.button4ClearList.TabIndex = 5;
            this.button4ClearList.Text = "Очистить список";
            this.button4ClearList.UseVisualStyleBackColor = false;
            this.button4ClearList.Click += new System.EventHandler(this.button4ClearList_Click);
            // 
            // button4Exit
            // 
            this.button4Exit.BackColor = System.Drawing.Color.DarkGray;
            this.button4Exit.FlatAppearance.BorderSize = 0;
            this.button4Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button4Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4Exit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4Exit.Location = new System.Drawing.Point(790, 145);
            this.button4Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button4Exit.Name = "button4Exit";
            this.button4Exit.Size = new System.Drawing.Size(100, 50);
            this.button4Exit.TabIndex = 6;
            this.button4Exit.Text = "Выход";
            this.button4Exit.UseVisualStyleBackColor = false;
            this.button4Exit.Click += new System.EventHandler(this.button5Exit_Click);
            // 
            // label11Count
            // 
            this.label11Count.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11Count.Location = new System.Drawing.Point(255, 414);
            this.label11Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11Count.Name = "label11Count";
            this.label11Count.Size = new System.Drawing.Size(310, 38);
            this.label11Count.TabIndex = 10;
            this.label11Count.Text = "Количество  элементов в новом массиве";
            this.label11Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4Count
            // 
            this.textBox4Count.BackColor = System.Drawing.Color.LightGray;
            this.textBox4Count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4Count.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4Count.Location = new System.Drawing.Point(570, 421);
            this.textBox4Count.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4Count.Name = "textBox4Count";
            this.textBox4Count.ReadOnly = true;
            this.textBox4Count.Size = new System.Drawing.Size(155, 20);
            this.textBox4Count.TabIndex = 9;
            // 
            // button1Add
            // 
            this.button1Add.BackColor = System.Drawing.Color.DarkGray;
            this.button1Add.FlatAppearance.BorderSize = 0;
            this.button1Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Add.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Add.Location = new System.Drawing.Point(415, 15);
            this.button1Add.Margin = new System.Windows.Forms.Padding(4);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(100, 50);
            this.button1Add.TabIndex = 11;
            this.button1Add.Text = "Добавить в список";
            this.button1Add.UseVisualStyleBackColor = false;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // label1TextBlue
            // 
            this.label1TextBlue.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1TextBlue.ForeColor = System.Drawing.Color.Blue;
            this.label1TextBlue.Location = new System.Drawing.Point(285, 15);
            this.label1TextBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1TextBlue.Name = "label1TextBlue";
            this.label1TextBlue.Size = new System.Drawing.Size(350, 23);
            this.label1TextBlue.TabIndex = 12;
            this.label1TextBlue.Text = "Изучение одномерных массивов";
            this.label1TextBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2TextBlue
            // 
            this.label2TextBlue.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2TextBlue.ForeColor = System.Drawing.Color.Blue;
            this.label2TextBlue.Location = new System.Drawing.Point(70, 70);
            this.label2TextBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2TextBlue.Name = "label2TextBlue";
            this.label2TextBlue.Size = new System.Drawing.Size(145, 33);
            this.label2TextBlue.TabIndex = 13;
            this.label2TextBlue.Text = "Задание:";
            this.label2TextBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3Text
            // 
            this.label3Text.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3Text.Location = new System.Drawing.Point(220, 55);
            this.label3Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3Text.Name = "label3Text";
            this.label3Text.Size = new System.Drawing.Size(700, 60);
            this.label3Text.TabIndex = 14;
            this.label3Text.Text = "Ввести одномерный массив и сформировать из него новый массив, элементами которого" +
    " будут являться отрицательные элементы исходного массива, и упорядочить его по в" +
    "озрастанию.";
            this.label3Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8InputArray
            // 
            this.label8InputArray.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8InputArray.Location = new System.Drawing.Point(105, 270);
            this.label8InputArray.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8InputArray.Name = "label8InputArray";
            this.label8InputArray.Size = new System.Drawing.Size(100, 38);
            this.label8InputArray.TabIndex = 15;
            this.label8InputArray.Text = "Исходный\r\nмассив";
            this.label8InputArray.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9OutputArray
            // 
            this.label9OutputArray.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9OutputArray.Location = new System.Drawing.Point(105, 375);
            this.label9OutputArray.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9OutputArray.Name = "label9OutputArray";
            this.label9OutputArray.Size = new System.Drawing.Size(100, 38);
            this.label9OutputArray.TabIndex = 16;
            this.label9OutputArray.Text = "Полученный\r\nмассив";
            this.label9OutputArray.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1SelectInput
            // 
            this.comboBox1SelectInput.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox1SelectInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1SelectInput.DropDownWidth = 350;
            this.comboBox1SelectInput.FormattingEnabled = true;
            this.comboBox1SelectInput.Items.AddRange(new object[] {
            "Ввод массива с клавиатуры",
            "Ввод массива генератором случайных чисел"});
            this.comboBox1SelectInput.Location = new System.Drawing.Point(295, 240);
            this.comboBox1SelectInput.Name = "comboBox1SelectInput";
            this.comboBox1SelectInput.Size = new System.Drawing.Size(350, 25);
            this.comboBox1SelectInput.TabIndex = 17;
            this.comboBox1SelectInput.SelectedIndexChanged += new System.EventHandler(this.comboBox1SelectInput_SelectedIndexChanged);
            // 
            // comboBox2SelectOutput
            // 
            this.comboBox2SelectOutput.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox2SelectOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2SelectOutput.FormattingEnabled = true;
            this.comboBox2SelectOutput.Items.AddRange(new object[] {
            "Сортировка по убыванию методом выбора",
            "Сортировка по возрастанию методом пузырька"});
            this.comboBox2SelectOutput.Location = new System.Drawing.Point(295, 345);
            this.comboBox2SelectOutput.Name = "comboBox2SelectOutput";
            this.comboBox2SelectOutput.Size = new System.Drawing.Size(350, 25);
            this.comboBox2SelectOutput.TabIndex = 18;
            // 
            // label6SelectInput
            // 
            this.label6SelectInput.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6SelectInput.Location = new System.Drawing.Point(385, 210);
            this.label6SelectInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6SelectInput.Name = "label6SelectInput";
            this.label6SelectInput.Size = new System.Drawing.Size(170, 24);
            this.label6SelectInput.TabIndex = 19;
            this.label6SelectInput.Text = "Заполнение массива";
            this.label6SelectInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7SelectOutput
            // 
            this.label7SelectOutput.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7SelectOutput.Location = new System.Drawing.Point(365, 315);
            this.label7SelectOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7SelectOutput.Name = "label7SelectOutput";
            this.label7SelectOutput.Size = new System.Drawing.Size(210, 24);
            this.label7SelectOutput.TabIndex = 20;
            this.label7SelectOutput.Text = "Преобразование массива";
            this.label7SelectOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1InputKeyBoard
            // 
            this.groupBox1InputKeyBoard.Controls.Add(this.button1Add);
            this.groupBox1InputKeyBoard.Controls.Add(this.label4Num);
            this.groupBox1InputKeyBoard.Controls.Add(this.textBox1Num);
            this.groupBox1InputKeyBoard.Location = new System.Drawing.Point(50, 130);
            this.groupBox1InputKeyBoard.Name = "groupBox1InputKeyBoard";
            this.groupBox1InputKeyBoard.Size = new System.Drawing.Size(525, 75);
            this.groupBox1InputKeyBoard.TabIndex = 21;
            this.groupBox1InputKeyBoard.TabStop = false;
            this.groupBox1InputKeyBoard.Text = "Ввод с клавиатуры";
            // 
            // groupBox2InputRand
            // 
            this.groupBox2InputRand.Controls.Add(this.button2FillArrayRand);
            this.groupBox2InputRand.Controls.Add(this.label5CountRand);
            this.groupBox2InputRand.Controls.Add(this.textBox2CountRand);
            this.groupBox2InputRand.Location = new System.Drawing.Point(50, 130);
            this.groupBox2InputRand.Name = "groupBox2InputRand";
            this.groupBox2InputRand.Size = new System.Drawing.Size(525, 75);
            this.groupBox2InputRand.TabIndex = 22;
            this.groupBox2InputRand.TabStop = false;
            this.groupBox2InputRand.Text = "Ввод генератором случайных чисел";
            this.groupBox2InputRand.Visible = false;
            // 
            // button2FillArrayRand
            // 
            this.button2FillArrayRand.BackColor = System.Drawing.Color.DarkGray;
            this.button2FillArrayRand.FlatAppearance.BorderSize = 0;
            this.button2FillArrayRand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2FillArrayRand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2FillArrayRand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2FillArrayRand.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2FillArrayRand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2FillArrayRand.Location = new System.Drawing.Point(415, 15);
            this.button2FillArrayRand.Margin = new System.Windows.Forms.Padding(4);
            this.button2FillArrayRand.Name = "button2FillArrayRand";
            this.button2FillArrayRand.Size = new System.Drawing.Size(100, 50);
            this.button2FillArrayRand.TabIndex = 11;
            this.button2FillArrayRand.Text = "Заполнить список";
            this.button2FillArrayRand.UseVisualStyleBackColor = false;
            this.button2FillArrayRand.Click += new System.EventHandler(this.button2FillArrayRand_Click);
            // 
            // label5CountRand
            // 
            this.label5CountRand.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5CountRand.Location = new System.Drawing.Point(75, 28);
            this.label5CountRand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5CountRand.Name = "label5CountRand";
            this.label5CountRand.Size = new System.Drawing.Size(170, 24);
            this.label5CountRand.TabIndex = 2;
            this.label5CountRand.Text = "Количество элементов";
            this.label5CountRand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2CountRand
            // 
            this.textBox2CountRand.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2CountRand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2CountRand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2CountRand.Location = new System.Drawing.Point(250, 31);
            this.textBox2CountRand.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2CountRand.Name = "textBox2CountRand";
            this.textBox2CountRand.Size = new System.Drawing.Size(155, 20);
            this.textBox2CountRand.TabIndex = 1;
            // 
            // FormCourseWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.groupBox2InputRand);
            this.Controls.Add(this.groupBox1InputKeyBoard);
            this.Controls.Add(this.label7SelectOutput);
            this.Controls.Add(this.label6SelectInput);
            this.Controls.Add(this.comboBox2SelectOutput);
            this.Controls.Add(this.comboBox1SelectInput);
            this.Controls.Add(this.label9OutputArray);
            this.Controls.Add(this.label8InputArray);
            this.Controls.Add(this.label3Text);
            this.Controls.Add(this.label2TextBlue);
            this.Controls.Add(this.label1TextBlue);
            this.Controls.Add(this.label11Count);
            this.Controls.Add(this.textBox4Count);
            this.Controls.Add(this.button4Exit);
            this.Controls.Add(this.button4ClearList);
            this.Controls.Add(this.listBox2Output);
            this.Controls.Add(this.button3Calculate);
            this.Controls.Add(this.listBox1Input);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormCourseWork";
            this.Text = "КР «Программирование алгоритмов формирования и обработки одномерных массивов»";
            this.Load += new System.EventHandler(this.FormCourseWork_Load);
            this.groupBox1InputKeyBoard.ResumeLayout(false);
            this.groupBox1InputKeyBoard.PerformLayout();
            this.groupBox2InputRand.ResumeLayout(false);
            this.groupBox2InputRand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1Input;
        private System.Windows.Forms.TextBox textBox1Num;
        private System.Windows.Forms.Label label4Num;
        private System.Windows.Forms.Button button3Calculate;
        private System.Windows.Forms.ListBox listBox2Output;
        private System.Windows.Forms.Button button4ClearList;
        private System.Windows.Forms.Button button4Exit;
        private System.Windows.Forms.Label label11Count;
        private System.Windows.Forms.TextBox textBox4Count;
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Label label1TextBlue;
        private System.Windows.Forms.Label label2TextBlue;
        private System.Windows.Forms.Label label3Text;
        private System.Windows.Forms.Label label8InputArray;
        private System.Windows.Forms.Label label9OutputArray;
        private System.Windows.Forms.ComboBox comboBox1SelectInput;
        private System.Windows.Forms.ComboBox comboBox2SelectOutput;
        private System.Windows.Forms.Label label6SelectInput;
        private System.Windows.Forms.Label label7SelectOutput;
        private System.Windows.Forms.GroupBox groupBox1InputKeyBoard;
        private System.Windows.Forms.GroupBox groupBox2InputRand;
        private System.Windows.Forms.Button button2FillArrayRand;
        private System.Windows.Forms.Label label5CountRand;
        private System.Windows.Forms.TextBox textBox2CountRand;
    }
}



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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 50;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "412",
            "421",
            "4",
            "124",
            "5351",
            "136",
            "1236",
            "246",
            "234636",
            "347",
            "37",
            "125",
            "1",
            "25",
            "165",
            "2",
            "15",
            "521512",
            "6512",
            "5",
            "15245624626236",
            "263236",
            "26236263236",
            "236",
            "623263",
            "1235",
            "25",
            "261",
            "61",
            "6",
            "1",
            "36",
            "13",
            "61",
            "36",
            "1",
            "36"});
            this.listBox1.Location = new System.Drawing.Point(164, 248);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(454, 38);
            this.listBox1.TabIndex = 0;
            // 
            // FormCourseWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Name = "FormCourseWork";
            this.Text = "КР «Программирование алгоритмов формирования и обработки одномерных массивов»";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}


using System;
using System.Windows.Forms;

namespace YaP_LR_03S
{
    public partial class FormLab3 : Form
    {
        public FormLab3()
        {
            InitializeComponent();
        }

        //функция вызываемая при нажатии на кнопку
        private void button1Calculate_Click(object sender, EventArgs e)
        {
            double E = Input();

            Calculate(E);
        }

        //функция вывода X вычисленного стандартной функцией C# и приближённой рекуретной формулой, а так же разницы между этими значениями
        public void Output(double ApproximateX)
        {
            textBox3ApproximateX.Text = ApproximateX.ToString("F9");
            textBox4DeltaX.Text = Math.Abs(0.75 - ApproximateX).ToString("F9");
        }

        //функция вывода номера итерации и значения приближённого корня в два ListBox
        public void OutputListBox(int iteration, double root)
        {
            listBox2Iteration.Items.Add(iteration.ToString());
            listBox1ApproximateRoot.Items.Add(root.ToString("F9"));
        }

        //функция ввода начального x и точности e
        public double Input()
        {
            return double.Parse(textBox1E.Text);
        }

        //функция очистки списков
        private void Clear()
        {
            listBox2Iteration.Items.Clear();
            listBox1ApproximateRoot.Items.Clear();
        }

        //функция вычисления суммы значений рекурентной формулы с точностью e
        private void Calculate(double e)
        {
            Clear();

            int n = 1;

            double Root = 1 / (double)3;

            double ApproximateRoot = 0;

            do
            {
                ApproximateRoot += Root;

                OutputListBox(n, Root);

                n++;

                Root = 1 / (double)(n * (n + 2));
            }
            while (Math.Abs(Root) > e);

            Output(ApproximateRoot);
        }

        //функция вызываемая при нажатии на кнопку выхода
        private void button2Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

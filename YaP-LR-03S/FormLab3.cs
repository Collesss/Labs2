using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void button1_Click(object sender, EventArgs e)
        {
            double E, X;

            Input(out X, out E);

            Calculate(X, E);
        }

        //функция вывода X вычисленного стандартной функцией C# и приближённой рекуретной формулой, а так же разницы между этими значениями
        public void Output(double X, double ApproximateX)
        {
            textBox3LogX.Text = X.ToString("F2");
            textBox4ApproximateX.Text = ApproximateX.ToString("F5");
            textBox5DeltaX.Text = Math.Abs(X - ApproximateX).ToString("F5");
        }

        //функция вывода номера итерации и значения приближённого корня в два ListBox
        public void OutputListBox(int iteration, double approximateRoot)
        {
            listBox2Iteration.Items.Add(iteration.ToString());
            listBox1ApproximateRoot.Items.Add(approximateRoot.ToString("F5"));
        }

        //функция ввода начального x и точности e
        public void Input(out double x, out double e)
        {
            x = double.Parse(textBox2X.Text);
            e = double.Parse(textBox1E.Text);
        }

        //функция очистки списков
        private void Clear()
        {
            listBox2Iteration.Items.Clear();
            listBox1ApproximateRoot.Items.Clear();
        }

        //функция вычисления суммы значений рекурентной формулы с точностью e
        private void Calculate(double x, double e)
        {
            Clear();

            double ResX = Math.Log(1 + x);

            double ApproximateX = x;

            int n = 1;

            double Root = 0;

            do
            {
                ApproximateX += Root;

                OutputListBox(n, ApproximateX);

                Root = Math.Pow(-1, n) * (Math.Pow(x, n + 1) / (n + 1));

                n++;
            }
            while (Math.Abs(Root) > e);

            Output(ResX, ApproximateX);
        }

        //функция вызываемая при нажатии на кнопку выхода
        private void button2Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

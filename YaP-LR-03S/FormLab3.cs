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
        private void button1Calculate_Click(object sender, EventArgs e)
        {
            double E;

            E = InputE();

            Calculate(E);
        }

        //функция вывода X вычисленного стандартной функцией C# и приближённой рекуретной формулой, а так же разницы между этими значениями
        public void Output(double X, double ApproximateX)
        {
            textBox3LogX.Text = X.ToString("F9");
            textBox4ApproximateX.Text = ApproximateX.ToString("F9");
            textBox5DeltaX.Text = Math.Abs(X - ApproximateX).ToString("F9");
        }

        //функция вывода номера итерации и значения приближённого корня в два ListBox
        public void OutputListBox(int iteration, double approximateRoot)
        {
            listBox2Iteration.Items.Add(iteration.ToString());
            listBox1ApproximateRoot.Items.Add(approximateRoot.ToString("F9"));
        }

        //функция ввода начального x и точности e
        public double InputE()
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

            double ResX = Math.Log(2);

            double ApproximateX = 1;

            int n = 1;

            double Root = 0;

            do
            {
                ApproximateX += Root;

                OutputListBox(n, ApproximateX);

                Root = Math.Pow(-1, n) * ((double)1 / (n + 1));

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

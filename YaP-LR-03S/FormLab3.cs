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
            double E, X;

            Input(out X, out E);

            Calculate(X, E);
        }

        //функция вывода номера итерации и значения приближённого корня в два ListBox
        public void OutputListBox(int iteration, double root)
        {
            listBox2Iteration.Items.Add(iteration.ToString());
            listBox1ApproximateRoot.Items.Add(root.ToString("F9"));
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

            int n = 1;

            double Root = x;

            do
            {
                OutputListBox(n, Root);

                n++;

                Root = Func(x, n);
            }
            while (Math.Abs(Root) > e);

        }

        //
        private double Func(double x, int n)
        {
            return Math.Pow(x, n)/Fac(n);
        }

        //функция вычисляющая факториал
        private int Fac(int n)
        {
            int N = 1;

            for (int i = 2; i <= n; i++)
                N *= i;

            return N;
        }

        //функция вызываемая при нажатии на кнопку выхода
        private void button2Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

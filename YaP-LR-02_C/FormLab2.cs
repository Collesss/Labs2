using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaP_LR_02_C
{
    public partial class FormLab2 : Form
    {
        public FormLab2()
        {
            InitializeComponent();
        }

        //функция вызываемая при нажатии на кнопку
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double a, b, h, max;
            int n;

            Input(out a, out b, out h);

            Calculate(a, b, h, out n, out max);

            Output(n, max);
        }

        //функция ввода начального, конечного и шага
        private void Input(out double a, out double b, out double h)
        {
            a = double.Parse(textBox1A.Text);
            b = double.Parse(textBox2B.Text);
            h = double.Parse(textBox3H.Text);
        }

        //функция вывода количества итераций и произведения положительных значений функции
        private void Output(int n, double max)
        {
            textBox4N.Text = n.ToString();
            textBox5Max.Text = max.ToString("F2");
        }

        //функция вывода аргумента и значения функции в два ListBox
        private void OutputListBox(double ArgX, double FuncX)
        {
            listBox1ArgX.Items.Add(ArgX.ToString("F2"));
            listBox2FuncX.Items.Add(FuncX.ToString("F2"));
        }

        //функция очистки списков
        private void Clear()
        {
            listBox1ArgX.Items.Clear();
            listBox2FuncX.Items.Clear();
        }

        //функция вычисления значений функции в промежутке от a до b с шагом h с выводом в ListBox и расчётом количества итераций и произведения положительных значений функции
        private void Calculate(double a, double b, double h, out int n, out double max)
        {
            Clear();

            n = (int)((b - a) / h) + 1;

            max = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double x = a + i * h;
                double func = Func(x);

                if (func > max)
                    max = func;

                OutputListBox(x, func);
            }

        }

        //функция расчёта значения функции по указанному аргументу x
        private double Func(double x)
        {
            return 3 * Math.Pow(Math.Cos(2 * x + 1), 2);
        }

        //функция вызываемая при нажатии на кнопку выхода
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

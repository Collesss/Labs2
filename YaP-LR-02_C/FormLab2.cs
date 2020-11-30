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
            double a, b, h, multiple;
            int n;

            Input(out a, out b, out h);

            Calculate(a, b, h, out n, out multiple);

            Output(n, multiple);
        }

        //функция ввода начального, конечного и шага
        private void Input(out double a, out double b, out double h)
        {
            a = double.Parse(textBox1A.Text);
            b = double.Parse(textBox2B.Text);
            h = double.Parse(textBox3H.Text);
        }

        //функция вывода количества итераций и произведения положительных значений функции
        private void Output(int n, double Multiple)
        {
            textBox4N.Text = n.ToString();
            textBox5Multiple.Text = Multiple.ToString("F2");
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
        private void Calculate(double a, double b, double h, out int n, out double multiple)
        {
            Clear();

            int N = (int)((b - a) / h) + 1;

            double m = 1;

            for (int i = 0; i < N; i++)
            {
                double x = a + i * h;
                double func = Func(x);

                if (func > 0)
                    m *= func;

                OutputListBox(x, func);
            }

            n = N;
            multiple = m;
        }

        //функция расчёта значения функции по указанному аргументу x
        private double Func(double x)
        {
            return Math.Pow(x, 3) + 6 * Math.Pow(x, 2) + 19.8;
        }

        //функция вызываемая при нажатии на кнопку выхода
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

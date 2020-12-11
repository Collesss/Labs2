using System;
using System.Windows.Forms;

namespace YaP_LR_01C
{
    public partial class FormLab1 : Form
    {
        public FormLab1()
        {
            InitializeComponent();
        }

        //функция вызываемая при нажатии на кнопку расчёта
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double a, l;

            int x;

            x = InputX();
            a = InputA();

            l = Calculate(x, a);

            Output(l);
        }

        //функция ввода X
        private int InputX()
        {
            return int.Parse(textBoxX.Text);
        }

        //функция ввода a
        private double InputA()
        {
            return double.Parse(textBoxA.Text);
        }

        //функция вывода
        private void Output(double l)
        {
            textBoxL.Text = l.ToString();
        }

        //функция расчёта условной функции
        private double Calculate(int x, double a)
        {
            double l;

            if (x < 0)
            {
                double ax = Math.Pow(a, x);

                if (x > ax)
                    l = x;
                else
                    l = ax;
            }
            else if (x > 1)
                l = 0;
            else
            {
                double min1, min2, min3, min;
                min1 = (x - a) / x;
                min2 = Math.Sqrt(a) + x;
                min3 = Math.Pow(Math.Sin(x), 2);

                if (min1 < min2)
                    min = min1;
                else
                    min = min2;

                if (min < min3)
                    l = min;
                else
                    l = min3;
            }

            return l;
        }

        //функция вызываемая при нажатии на кнопку выхода
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
            double x, y, a, b, z;

            x = InputX();
            y = InputY();
            a = InputA();
            b = InputB();

            z = Calculate(x, y, a, b);

            Output(z);
        }

        //функция ввода X
        private double InputX()
        {
            return double.Parse(textBox1X.Text);
        }

        //функция ввода Y
        private double InputY()
        {
            return double.Parse(textBox2Y .Text);
        }

        //функция ввода A
        private double InputA()
        {
            return double.Parse(textBox3A.Text);
        }

        //функция ввода B
        private double InputB()
        {
            return double.Parse(textBox4B.Text);
        }

        //функция вывода
        private void Output(double z)
        {
            textBox5Z.Text = z.ToString();
        }

        //функция расчёта условной функции
        private double Calculate(double x, double y, double a, double b)
        {
            double z;

            double xy = x * y;

            if (xy > 0)
                z = 1 - Math.Pow(Math.E, xy + a * b);
            else if (xy < 0)
            {
                double x3, ey, sqrtAbsLnY2;

                x3 = Math.Pow(x, 3);

                ey = Math.Pow(Math.E, y);

                sqrtAbsLnY2 = Math.Sqrt(Math.Abs(Math.Log(Math.Pow(y, 2))));

                double max;

                if (x3 > ey)
                    max = x3;
                else
                    max = ey;

                if (max > sqrtAbsLnY2)
                    z = max;
                else
                    z = sqrtAbsLnY2;
            }
            else
            {
                double min, ax;

                ax = a * x;

                if (ax < y)
                    min = ax;
                else
                    min = y;

                z = b - min;
            }

            return z;
        }

        //функция вызываемая при нажатии на кнопку выхода
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

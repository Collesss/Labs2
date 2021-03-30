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
        private void button1Calculate_Click(object sender, EventArgs e)
        {
            double x, a, y;

            x = InputX();
            a = InputA();

            y = Calculate(x, a);

            Output(y);
        }

        //функция ввода X
        private double InputX()
        {
            return double.Parse(textBox1X.Text);
        }

        //функция ввода A
        private double InputA()
        {
            return double.Parse(textBox3A.Text);
        }

        //функция вывода
        private void Output(double y)
        {
            textBox5Z.Text = y.ToString();
        }

        //функция расчёта условной функции
        private double Calculate(double x, double a)
        {
            double y;

            if (a > x)
            {
                double sqrtAbsCosax, sin2x;

                sqrtAbsCosax = Math.Sqrt(Math.Abs(Math.Cos(a * x)));
                sin2x = Math.Pow(Math.Sin(x), 2);

                if (sqrtAbsCosax < sin2x)
                    y = sqrtAbsCosax;
                else
                    y = sin2x;

            }
            else if (a < x)
                y = Math.Pow(Math.E, x + a);
            else
            {
                double aPx, sqrtAbsx, ax, max;

                aPx = a + x;
                sqrtAbsx = Math.Sqrt(Math.Abs(x));
                ax = a * x;

                if (aPx > ax)
                    max = aPx;
                else
                    max = ax;

                if (max > sqrtAbsx)
                    y = max;
                else
                    y = sqrtAbsx;
            }

            return y;
        }

        //функция вызываемая при нажатии на кнопку выхода
        private void button2Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

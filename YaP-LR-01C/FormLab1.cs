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
            double x, z, l;

            x = InputX();
            z = InputZ();

            l = Calculate(x, z);

            Output(l);
        }

        //функция ввода X
        private double InputX()
        {
            return double.Parse(textBoxX.Text);
        }

        //функция ввода z
        private double InputZ()
        {
            return double.Parse(textBoxZ.Text);
        }

        //функция вывода
        private void Output(double l)
        {
            textBoxL.Text = l.ToString();
        }

        //функция расчёта условной функции
        private double Calculate(double x, double z)
        {
            double l;

            if (z < 0 && x < 0)
            {
                if (x > z)
                    l = z;
                else
                    l = x;
            }
            else if (z > 0 && x > 0)
            {
                double x3, sqrtXplusZ, cosXZ, max;

                x3 = Math.Pow(x, 3);
                sqrtXplusZ = Math.Sqrt(x + z);
                cosXZ = Math.Cos(x * z);

                if (x3 > sqrtXplusZ)
                    max = x3;
                else
                    max = sqrtXplusZ;

                if (max > cosXZ)
                    l = max;
                else
                    l = cosXZ;
            }
            else
                l = x * z;

            return l;
        }

        //функция вызываемая при нажатии на кнопку выхода
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

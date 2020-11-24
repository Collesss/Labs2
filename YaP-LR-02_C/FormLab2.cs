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



        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Calculate(double.Parse(textBoxA.Text), double.Parse(textBoxB.Text), double.Parse(textBoxH.Text));
        }

        private void Calculate(double a, double b, double h)
        {
            listBoxArgX.Items.Clear();
            listBoxFuncX.Items.Clear();

            int n = (int)((b - a) / h) + 1;

            double p = 1;

            for (int i = 0; i < n; i++)
            {
                double x = a + i * h;
                double func = Func(x);

                if (func > 0)
                    p *= func;
                
                listBoxArgX.Items.Add(x.ToString("F2"));
                listBoxFuncX.Items.Add(func.ToString("F2"));
            }

            textBoxN.Text = (n - 1).ToString();
            textBoxMultiple.Text = p.ToString();

        }

        private double Func(double x)
        {
            return Math.Pow(x, 3) + 6 * Math.Pow(x, 2) + 19.8;
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

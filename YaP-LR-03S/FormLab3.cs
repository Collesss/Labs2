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

        private void button1_Click(object sender, EventArgs e)
        {
            double E, X;

            Input(out X, out E);

            Calculate(X, E);



        }


        public void Output(double X)
        {
            textBox3ApproximateX.Text = X.ToString("F2");
        }

        public void OutputListBox(int iteration, double approximateRoot)
        {
            listBox2Iteration.Items.Add(iteration.ToString());
            listBox1ApproximateRoot.Items.Add(approximateRoot.ToString("F5"));
        }

        public void Input(out double x, out double e)
        {
            x = double.Parse(textBox2X.Text);
            e = double.Parse(textBox1E.Text);
        }

        private void Clear()
        {
            listBox2Iteration.Items.Clear();
            listBox1ApproximateRoot.Items.Clear();
        }

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

                /*
                listBox1ApproximateRoot.Items.Add(ApproximateX.ToString());

                listBox2Iteration.Items.Add(n.ToString());
                */
                Root = Math.Pow(-1, n) * (Math.Pow(x, n + 1) / (n + 1));

                n++;
            }
            while (Math.Abs(Root) > e);

            
        }

        private void button2Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

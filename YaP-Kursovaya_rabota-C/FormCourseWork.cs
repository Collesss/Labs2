using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaP_Kursovaya_rabota_C
{
    public partial class FormCourseWork : Form
    {
        public FormCourseWork()
        {
            InitializeComponent();
        }

        
        //функция вызываемая при нажатии на кнопку
        private void button3Calculate_Click(object sender, EventArgs e)
        {
            double[] nums = Input();

            switch (comboBox2SelectOutput.SelectedIndex)
            {
                case 0:
                    SortSelectDown(nums);
                    break;
                case 1:
                    SortBubbleUp(nums);
                    break;
            }

            double avg;
            int countReplace;

            Calculate(nums, out avg, out countReplace);

            Output(avg, countReplace);
        }


        //функция расчитывающая среднее арифметическое массива и выводящая элементы массива которые меньше среднего арифметического в ListBox
        private void Calculate(double[] nums, out double avgPositive, out int countReplace)
        {
            listBox2Output.Items.Clear();

            avgPositive = 0;
            countReplace = 0;

            int countAvgPositive = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > 0)
                {
                    avgPositive += nums[i];
                    countAvgPositive++;
                }

            avgPositive /= countAvgPositive;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > avgPositive)
                {
                    listBox2Output.Items.Add(avgPositive.ToString("F2"));
                    countReplace++;
                }
                else
                    listBox2Output.Items.Add(nums[i].ToString("F2"));
        }

        //функция ввода
        private double[] Input()
        {
            double[] nums = new double[listBox1Input.Items.Count];

            for (int i = 0; i < nums.Length; i++)
                nums[i] = double.Parse(listBox1Input.Items[i].ToString());

            return nums;
        }

        //функция вывода
        private void Output(double avg, int countReplace)
        {
            textBox3Avg.Text = avg.ToString("F2");
            textBox4Count.Text = countReplace.ToString();
        }

        //функция вызываемая при загрузке формы
        private void FormCourseWork_Load(object sender, EventArgs e)
        {
            comboBox1SelectInput.SelectedIndex = comboBox2SelectOutput.SelectedIndex = 0;
        }

        //функция вызываемая при выборе метода ввода. Нужна для переключения панелей которые отвечают за соответствующий тип ввода 
        private void comboBox1SelectInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1SelectInput.SelectedIndex)
            {
                case 0:
                    groupBox1InputKeyBoard.Visible = true;
                    groupBox2InputRand.Visible = false;
                    break;
                case 1:
                    groupBox1InputKeyBoard.Visible = false;
                    groupBox2InputRand.Visible = true;
                    break;
            }
        }

        //функция сортировки пузырьком по возрастанию
        private void SortBubbleUp(double[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = 0; j < nums.Length - 1 - i; j++)
                    if (nums[j] > nums[j + 1])
                    {
                        double k = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = k;
                    }
        }

        //функция сортировки выбором по убыванию
        private void SortSelectDown(double[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int max = i;

                for(int j = i + 1; j < nums.Length; j++)
                    if (nums[max] < nums[j])
                        max = j;

                if (max != i)
                {
                    double k = nums[i];
                    nums[i] = nums[max];
                    nums[max] = k;
                }
            }
        }

        //функция вызываемая при нажатии на кнопку добаления случайный чисел в список
        private void button2FillArrayRand_Click(object sender, EventArgs e)
        {
            int countRand = int.Parse(textBox2CountRand.Text);

            Random random = new Random();

            for (int i = 0; i < countRand; i++)
            {
                double numAdd = (random.NextDouble() - 0.5) * 100;
                listBox1Input.Items.Add(numAdd.ToString("F2"));
            }
        }
        
        //функция вызываемая при нажатии на кнопку очистки списка
        private void button4ClearList_Click(object sender, EventArgs e)
        {
            listBox1Input.Items.Clear();
        }

        //функция вызываемая при нажатии на кнопку добавления элемента в список
        private void button1Add_Click(object sender, EventArgs e)
        {
            listBox1Input.Items.Add(textBox1Num.Text);
            textBox1Num.Text = "";
        }
        
        //функция вызываемая при нажатии на кнопку выхода
        private void button5Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
            int[] numsInput, numsOutput;

            int sum, count;

            numsInput = Input();

            numsOutput = Calculate(numsInput, out sum, out count);

            switch (comboBox2SelectOutput.SelectedIndex)
            {
                case 0:
                    SortSelectDown(numsOutput);
                    break;
                case 1:
                    SortBubbleUp(numsOutput);
                    break;
            }

            Output(numsOutput, count, sum);
        }


        //функция расчитывающая сумму элементов массива находящихся между первым положительным и последним положительным элементов массива и возвращающая массив который содержит элемнты между первым и последним положительным элементов входного массива
        private int[] Calculate(int[] nums, out int sum, out int countElNewArr)
        {
            listBox2Output.Items.Clear();

            sum = 0;

            int indexFirstPositive, indexLastPositive;

            indexFirstPositive = -1;
            indexLastPositive = -1;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > 0)
                {
                    if (indexFirstPositive == -1)
                        indexFirstPositive = i;
                    indexLastPositive = i;
                }

            for (int i = indexFirstPositive + 1; i < indexLastPositive; i++)
                sum += nums[i];

            countElNewArr = indexLastPositive - indexFirstPositive - 1;

            int[] outputArr = new int[countElNewArr];

            Array.Copy(nums, indexFirstPositive + 1, outputArr, 0, countElNewArr);

            return outputArr;
        }

        //функция ввода
        private int[] Input()
        {
            int[] nums = new int[listBox1Input.Items.Count];

            for (int i = 0; i < nums.Length; i++)
                nums[i] = int.Parse(listBox1Input.Items[i].ToString());

            return nums;
        }

        //функция вывода
        private void Output(int[] nums, int count, int sum)
        {
            textBox3Sum.Text = sum.ToString();
            textBox4Count.Text = count.ToString();

            for(int i = 0; i < nums.Length; i++)
                listBox2Output.Items.Add(nums[i].ToString());
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
        private void SortBubbleUp(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = 0; j < nums.Length - 1 - i; j++)
                    if (nums[j] > nums[j + 1])
                    {
                        int k = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = k;
                    }
        }

        //функция сортировки выбором по убыванию
        private void SortSelectDown(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int max = i;

                for(int j = i + 1; j < nums.Length; j++)
                    if (nums[max] < nums[j])
                        max = j;

                if (max != i)
                {
                    int k = nums[i];
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
                int numAdd = (int)((random.NextDouble() - 0.5) * 30);
                listBox1Input.Items.Add(numAdd.ToString());
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
        }
        
        //функция вызываемая при нажатии на кнопку выхода
        private void button5Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

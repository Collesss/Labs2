﻿using System;
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

        //функция расчитывающая среднее арифметическое массива и выводящая элементы массива которые мень меньше среднего арифметического в ListBox
        private void Calculate(double[] nums, out double avg, out int countLessAvg)
        {
            listBox2Output.Items.Clear();

            countLessAvg = 0;
            avg = 0;

            for (int i = 0; i < nums.Length; i++)
                avg += nums[i];

            avg /= nums.Length;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] < avg)
                {
                    countLessAvg++;
                    listBox2Output.Items.Add(nums[i].ToString("F2"));
                }
        }

        //функция вызываемая при нажатии на кнопку выхода
        private void button3Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //функция вызываемая при нажатии на кнопку
        private void button1Calculate_Click(object sender, EventArgs e)
        {
            double[] nums = Input();

            double avg;
            int count;

            Calculate(nums, out avg, out count);

            Output(count, avg);
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
        private void Output(int count, double avg)
        {
            textBox2Avg.Text = avg.ToString("F2");
            textBox3Count.Text = count.ToString();
        }

        //функция вызываемая при нажатии на кнопку очистки списка
        private void button2ClearList_Click(object sender, EventArgs e)
        {
            listBox1Input.Items.Clear();
        }

        //функция вызываемая при нажатии на кнопку добавления элемента в список
        private void button1Add_Click(object sender, EventArgs e)
        {
            listBox1Input.Items.Add(textBox1Num.Text);
        }

        private void FormCourseWork_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                    break;
                case 1:
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    break;
            }
        }

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
    }
}
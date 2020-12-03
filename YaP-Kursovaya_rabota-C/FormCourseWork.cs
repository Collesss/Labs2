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


        private void Calculate(double[] nums, out double avg, out int countLessAvg)
        {
            countLessAvg = 0;

            avg = 0;

            for (int i = 0; i < nums.Length; i++)
                avg += nums[i];

            avg /= nums.Length;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] < avg)
                    countLessAvg++;
        }

        private double[] CalculateV2(double[] nums, out double avg)
        {
            double[] numsLessAvg = new double[nums.Length];

            int countLessAvg = 0;

            avg = 0;

            for (int i = 0; i < nums.Length; i++)
                avg += nums[i];

            avg /= nums.Length;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] < avg)
                {
                    numsLessAvg[countLessAvg] = nums[i];
                    countLessAvg++;
                }

            double[] returnArray = new double[countLessAvg];

            Array.Copy(numsLessAvg, 0, returnArray, 0, countLessAvg);

            return returnArray;
        }

    }
}

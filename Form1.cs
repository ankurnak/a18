using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] arr = textBox1.Text.Split(' ').Select(Double.Parse).ToArray();

            // Сортуємо масив за нашою умовою
            Array.Sort(arr, (x, y) => (int)((x % 1 - y % 1) * 100));

            // Знаходимо номер максимального за модулем елемента
            int maxIndex = 0;
            double maxAbsValue = Math.Abs(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                double absValue = Math.Abs(arr[i]);
                if (absValue > maxAbsValue)
                {
                    maxIndex = i;
                    maxAbsValue = absValue;
                }
            }
            textBox2.Text = $"Номер максимального за модулем елемента: {maxIndex}";

            // Знаходимо суму елементів після першого додатнього
            double sum = 0;
            bool foundPositive = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (foundPositive)
                {
                    sum += arr[i];
                }
                else if (arr[i] > 0)
                {
                    foundPositive = true;
                }
            }
            textBox3.Text = $"Сума елементів після першого додатнього: {sum}";
        }

      
    }
}

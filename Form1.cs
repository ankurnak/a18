using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        private int[,] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = (int)numericUpDown1.Value;
            int columns = (int)numericUpDown2.Value;

            array = new int[rows, columns];

            Random random = new Random();

            // Заповнення масиву випадковими числами в діапазоні від -100 до 100
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }

            // Виведення масиву в текстове поле
            textBox1.Text = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    textBox1.Text += array[i, j] + "\t";
                }
                textBox1.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            // Обчислення суми елементів у верхньому лівому та нижньому правому кутах
            int sumCorners = array[0, 0] + array[rows - 1, columns - 1];

            // Обчислення середнього арифметичного елементів у чотирьох кутах
            double averageCorners = (array[0, 0] + array[0, columns - 1] + array[rows - 1, 0] + array[rows - 1, columns - 1]) / 4.0;

            textBox2.Text = sumCorners.ToString();
            textBox3.Text = averageCorners.ToString();
        }
    }
}

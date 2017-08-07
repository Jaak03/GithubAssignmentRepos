using ITRW324___Github_Assignment___Group_17;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("My name is Timohty Barnardo \nI study Bsc. IT \nI am currently a 4th year at the NWU Pukke campus \nEmail address: barnardotimothy@gmail.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arrNumbers = { 22, 15, 30, 60, 87, 779, 11 };
            label1.Text = "22, 15, 30, 60, 87, 779, 11";
            MessageBox.Show(arrNumbers.Max().ToString());
            //int txt1 = Convert.ToInt32(textBox1.Text);
            //Random rand = new Random();

            //int[] rn = new int[txt1];
            //int tot = 0;
            //string arr = "";

            //for (int i = 0; i < txt1; i++)
            //{
            //    int num = rand.Next(0, 100);
            //    rn[i] = num;
            //    tot += num;
            //    arr += Convert.ToString(num) + " ";
            //}
            //label1.Text = arr;

            //int max = arr[0];
            //for (int k = 1; k < arr.Length; k++)
            //{                               

            //    if (max < arr[k]) max = arr[k];

            //}
            //MessageBox.Show("max value is" + max);




        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedianFunctions med = new MedianFunctions();
            int[] arrNumbers = { 22, 15, 30, 60, 87, 779, 11 };
            med.sortArray(arrNumbers);
            
            label3.Text = med.calcMedian(arrNumbers).ToString();

        }
    }
}

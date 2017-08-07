using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace salman
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("salman dukanwala \nstudNo: 25779613 \n3rd year student at NWU");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                sD standardDeviation = new sD(n, label2);
                textBox1.Clear();
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("salman dukanwala \nstudNo: 25779613 \n3rd year student at NWU");
        }
    }






    public class sD
    {
        Random rnd = new Random();
        double standardDeviation = 0;

        public sD(int x, Label label2)
        {
            int[] numbers = new int[x];
            double sum = 0;
            for (int i = 0; i <numbers.Length;i++)
            {
                numbers[i] = rnd.Next(0, 100);
                sum = sum + numbers[i];
                label2.Text = label2.Text + " " + numbers[i];
            }
           

                double avg = sum / numbers.Length;
            double[] arrDiff = new double[x];
            for (int i = 0; i < arrDiff.Length; i++)
            {
                double diff = numbers[i] - avg;
                arrDiff[i] = diff;
            }

            double[] arrSquare = new double[x];
            double sumSq = 0;
            for (int i = 0; i < arrSquare.Length; i++)
            {
                double sq = arrDiff[i] * arrDiff[i];
                arrSquare[i] = sq;
                sumSq = sumSq + arrSquare[i];
            }


            double result = sumSq / (x - 1);

            standardDeviation = Math.Sqrt(result);
            MessageBox.Show("Standard deviation is : "+standardDeviation);
            
            
        
        }

        
       
    }
}

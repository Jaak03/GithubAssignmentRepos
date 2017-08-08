using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Hallo my name is Ruan + " + "\n"
                + "My feild of studie is BSC IT" + " \n" + "I am a outdoor person, I love to participate in sport" + "\n" + "This is my ITRW324 project");
        }
        Random R = new Random();
        int Tot = 0;
        string array = "";
       

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void GenerateRandom()
        {
            int t1 = Convert.ToInt32(textBox1.Text);

            int[] RN = new int[t1];

            for (int k = 0; k < t1; k++)
            {
                int random = R.Next(1, 100);
                RN[k] = random;
                Tot += random;
                array += Convert.ToString(random) + " ";

            }

            label2.Text = array;

            // Calculate MIn
            // int min = array[0];

            /* for (int i = 0; i < array.Length; i++)
             {
                 if (min > array[i])
                     min = array[i];


             }
             */

            MessageBox.Show( array.Min().ToString);
        

    }
        private void button1_Click(object sender, EventArgs e)
        {

            GenerateRandom();
           
            
            }
        public void Min()
        {
           


    }

}

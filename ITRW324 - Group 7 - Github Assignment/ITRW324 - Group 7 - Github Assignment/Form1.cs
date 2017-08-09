using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRW324___Group_7___Github_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] populate(int Array_Lenght)
        {
            Random rand = new Random();
            int[] arrPopulate = new int[Array_Lenght];
            for (int i = 0; i < Array_Lenght; i++)
            {
                arrPopulate[i] = rand.Next(0, 100);
            }
            return arrPopulate;
        }

        Stat method = new Stat();


        private void btnChristo_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(null, "My name is Christo du Plessis.\nI am studying BScIT," +
                          "currently busy with my final year at NWU - Potchefstroom Campus." +
                          "\nEmail:duplessis.christo3616@gmail.com", "Member Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tbNumber.TextLength > 0)
                {
                    int number = Convert.ToInt32(tbNumber.Text);
                    if (method.testNumber(number))
                    {
                        int[] arrData = populate(number);
                        method.sortArray(arrData);
                        int median = method.calcMedian(arrData);
                        rtbDisplay.Clear();
                        rtbDisplay.AppendText("Array of numbers generated(sorted): \n");
                        for (int i = 0; i < number; i++)
                        {
                            rtbDisplay.AppendText(arrData[i].ToString() + "\n");
                        }
                        rtbDisplay.AppendText("Median: " + median);
                    }
                    else
                        MessageBox.Show(null, "Please enter a value between 5 and 20.", "Incorrect input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(null, "Please enter a value for to generate the data with.", "Missing input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//christo end
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbNumber.Clear();
            }
        }

        private void btnTimothy_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("My name is Timohty Barnardo \nI study Bsc. IT \nI am currently doing my final year at the NWU Pukke campus \nEmail address: barnardotimothy@gmail.com");
                if (tbNumber.TextLength > 0)
                {
                    int number = Convert.ToInt32(tbNumber.Text);
                    if (method.testNumber(number))
                    {
                        int[] arrData = populate(number);
                        method.sortArray(arrData);
                        int max = method.Max(arrData);
                        rtbDisplay.Clear();
                        rtbDisplay.AppendText("Array of numbers generated(sorted): \n");
                        for (int i = 0; i < number; i++)
                        {
                            rtbDisplay.AppendText(arrData[i].ToString() + "\n");
                        }
                        rtbDisplay.AppendText("Max: " + max);
                    }
                    else
                        MessageBox.Show(null, "Please enter a value between 5 and 20.", "Incorrect input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(null, "Please enter a value for to generate the data with.", "Missing input.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//timothy end
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbNumber.Clear();
            }
        }

        private void btnSalman_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("My name is Salman Dukanwala \nI study Bsc. IT \nI am currently doing my final year at the NWU Pukke campus \nEmail address: duk.sal01@gmail.com");
                if (tbNumber.TextLength > 0)
                {
                    int number = Convert.ToInt32(tbNumber.Text);
                    rtbDisplay.Clear();
                    if (method.testNumber(number))
                    {
                        rtbDisplay.AppendText("Array of numbers generated(sorted): \n");
                        double result = method.standardDeviation(number, rtbDisplay);
                        rtbDisplay.AppendText("Standard deviation: " + result.ToString());
                    }
                    else
                        MessageBox.Show(null, "Please enter a value between 5 and 20.", "Incorrect input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(null, "Please enter a value for to generate the data with.", "Missing input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbNumber.Clear();
            }
        }
        //salman end
        private void btnLeandri_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("My name is Leandri  \nI study Bsc. IT \nI am currently doing my final year at the NWU Pukke campus \nEmail address: leandri@gmail.com");
              
                if (tbNumber.TextLength > 0)
                {
                    int number = Convert.ToInt32(tbNumber.Text); 
                    rtbDisplay.Clear();
                    if (method.testNumber(number))
                    {
                        rtbDisplay.AppendText("Array of numbers generated(sorted): \n");
                        double result = method.calcMean(number,rtbDisplay);
                        rtbDisplay.AppendText("Mean: " + result.ToString());
                    }
                    else
                        MessageBox.Show(null, "Please enter a value between 5 and 20.", "Incorrect input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(null, "Please enter a value for to generate the data with.", "Missing input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbNumber.Clear();
            }
        }
        // leandri end
        private void btnRuben_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("My name is Ruben \nI study Bsc. IT \nI am currently doing my final year at the NWU Pukke campus \nEmail address:ruben@gmail.com");
               
                if (tbNumber.TextLength > 0)
                {
                    int number = Convert.ToInt32(tbNumber.Text);
                    rtbDisplay.Clear();
                    if (method.testNumber(number))
                    {

                        rtbDisplay.AppendText("Array of numbers generated(sorted): \n");
                        double result = method.calcGCD(number, rtbDisplay);
                        rtbDisplay.AppendText("GCD: " + result.ToString());

                    }
                    else
                        MessageBox.Show(null, "Please enter a value between 5 and 20.", "Incorrect input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(null, "Please enter a value for to generate the data with.", "Missing input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbNumber.Clear();
            }
        }
        // Ruben end
        private void btnRuan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("My name is Ruan \nI study Bsc. IT \nI am currently doing my final year at the NWU Pukke campus \nEmail address: ruan@gmail.com");
                
                if (tbNumber.TextLength > 0)
                {
                    int number = Convert.ToInt32(tbNumber.Text);
                    rtbDisplay.Clear();
                    if (method.testNumber(number))
                    {
                        rtbDisplay.AppendText("Array of numbers generated(sorted): \n");
                        double result = method.minFunction(number, rtbDisplay);
                        rtbDisplay.AppendText("Minimum: " + result.ToString());
                    }
                    else
                        MessageBox.Show(null, "Please enter a value between 5 and 20.", "Incorrect input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(null, "Please enter a value for to generate the data with.", "Missing input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbNumber.Clear();
            }
        }
        //Ruan end
    }
}
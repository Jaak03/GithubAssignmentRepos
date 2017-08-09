using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRW324___Group_7___Github_Assignment
{
    class Stat
    {
        public double calcMean(int number,RichTextBox rtbButton)
        {
            int num = number;
            Random random = new Random();

            int[] numbers = new int[(int)num];
            double sum = 0;
            int randomNum;
            string array = "";

            for (int k = 0; k < num; k++)
            {
                randomNum = random.Next(0, 100);
                numbers[k] = randomNum;
                sum += randomNum;
                rtbButton.Text = rtbButton.Text+randomNum + "\n";
                array += Convert.ToString(randomNum) + " ";
            }

            return( sum / num);
           // MessageBox.Show("Numbers: " + array + "\n" + "Mean: " + mean);

        }//calcMean end

        public int[] sortArray(int[] arrReceived)
        {
            Array.Sort<int>(arrReceived);
            return arrReceived;
        }//sortArray end 

        public int calcMedian(int[] SortedArray)
        {
            int median = 0;
            if (SortedArray.Length % 2 == 0)
            {
                int element1 = SortedArray[(SortedArray.Length / 2) - 1];
                int element2 = SortedArray[(SortedArray.Length / 2)];
                median = (element1 + element2) / 2;
            }
            else
                median = SortedArray[(SortedArray.Length / 2)];


            return median;
        }//calcMedian end

        public bool testNumber(int number)
        {
            bool isValid = true;

            if (number < 5 || number > 20)
                isValid = false;
            
            return isValid;
        }//test end

        public int Max(int [] arrData)
        {
            return arrData.Max();
        }


        public double standardDeviation(int x, RichTextBox label2)
        {
            int[] numbers = new int[x];
            double sum = 0;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 100);
                sum = sum + numbers[i];
                label2.Text = label2.Text  + numbers[i] + "\n";
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

            return( Math.Sqrt(result));
        }
        public double minFunction(int num , RichTextBox rtbDisplay)
        {

            double[] minValues = new double[num];
            Random random = new Random();
            double minimum = 0;
            for(int i =0;i<minValues.Length;i++)
            {
                minValues[i] = random.Next(0, 100);
                rtbDisplay.Text = rtbDisplay.Text + minValues[i] + "\n";
                
            }
            minimum = minValues[0];
            for (int i = 0; i < minValues.Length; i++)
            {
                int j = i + 1;
                if(minimum>minValues[i])
                {
                    minimum = minValues[i];
                }
            }

            return minimum;
        }
        }
}

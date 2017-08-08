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
        public void calcMean(int number)
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

                array += Convert.ToString(randomNum) + " ";
            }

            double mean = sum / num;
            MessageBox.Show("Numbers: " + array + "\n" + "Mean: " + mean);

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
    }
}

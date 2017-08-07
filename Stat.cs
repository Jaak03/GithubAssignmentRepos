using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        }
    }
}
}

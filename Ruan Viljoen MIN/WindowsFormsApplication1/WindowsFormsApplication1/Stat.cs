using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Stat
    {
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
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];


            }
            MessageBox.Show("The minimum value is :" + min);

        }
    }

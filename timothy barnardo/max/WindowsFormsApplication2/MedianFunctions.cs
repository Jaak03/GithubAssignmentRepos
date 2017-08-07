using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRW324___Github_Assignment___Group_17
{
    class MedianFunctions
    {
        public int[] sortArray(int[] arrReceived)
        {
            Array.Sort<int>(arrReceived);

            //int arrlenght = arrreceived.length;
            //int temp = 0;
            ////actual sorting
            //for (int i = 0; i < arrreceived.length; i++)
            //{
            //    for (int j = 0; j < arrreceived.length - 1; j++)
            //    {
            //        if (arrreceived[j] > arrreceived[j + 1])
            //        {
            //            temp = arrreceived[j + 1];
            //            arrreceived[j + 1] = arrreceived[j];
            //            arrreceived[j] = temp;
            //        }//if end
            //    }//j for end

            //}//i for end
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
            }
        }//class end
    }//namespace end

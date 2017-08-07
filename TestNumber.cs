using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class TestNumber
    {

        public TestNumber()
        {
        }

        public bool test(double number)
        {
            bool isValid = true;

            if(number < 5 || number > 20)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_1
{
    public class Zero
    {
        public static void ZeroOutput()
        {
            int counter = 0;
            int[] ints = { 0, 1, 0, 3, 12 };

            foreach (int i in ints)
            {
                if (ints[i] == 0)
                {
                    counter++;
                }
                else
                {
                    int temp = ints[i];
                    ints[i] = ints[i] - counter;
                    ints[i-counter] = temp;
                }

            }


        }






    }
}

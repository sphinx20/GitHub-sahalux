using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class BinaryConversion
    {
         public void New()
        {

            var N = Convert.ToInt32(Console.ReadLine());
            var f = N;

            int counter = 1;
            int prev = 0;

            while ((f != 0) || (f != 1))
            {
                if (((f % 2) == 1) && (prev == 1))
                {

                    counter++;
                    prev = 1;
                }
                else
                {
                    prev = 0;
                }
            }
            if (f == 1)
            {
                counter++;
            }

        }
    }
}

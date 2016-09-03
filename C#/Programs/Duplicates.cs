using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class Duplicates
    {
        public void Start()
        {
            int[] arr = new[] { 3, 6, 7, 9, 9, 10, 12, 13, 13, 13, 16, 19, 21, 34 };

            int previous = -9999;

            for (int i = 0; i < arr.Length; i++)
            {
                if (previous != arr[i])
               {
                    Console.WriteLine(arr[i]);
                }

                previous = arr[i];
            }

            Console.ReadLine();
        }

        

    }
}

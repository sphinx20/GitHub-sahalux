using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class AppleStock
    {
        public void Start()
        {
            //int[] arr = new[] { 9, 5, 6, 3, 11, 10 };
            int[] arr =  {10, 9,8,7,6,5 };
           int hi = arr.Length - 1;

            for (int i = (arr.Length - 1); i >= 0; i--)
            {
                if (arr[hi] < arr[i])
                    hi = i;
            }

           int lo = 0;

           for (var j = 0; j <= hi; j++)
           {
               if (arr[lo] > arr[j])
                   lo = j;
           }

           if (arr[lo] <= arr[hi])
           {
               Console.WriteLine(arr[hi] - arr[lo]);
           }
            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class InsertionSort
    {
        public void Start()
        {

            int[] arr = {10,4,56,7,34,29};
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}

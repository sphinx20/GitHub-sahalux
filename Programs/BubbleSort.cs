using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class BubbleSort
    {
        public void Start()
        {
            var arr = new[] {10, 45, 32, 78, 3, 89, 34, 22};
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            DisplayList(arr);
           
        }

        public void DisplayList(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {

                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
            Console.Clear();

        }
    }
}

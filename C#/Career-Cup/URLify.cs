using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class URLify
    {
        public void Start()
        {
            var str = Console.ReadLine();
            var l = Convert.ToInt32(Console.ReadLine());

            if (str.Length < l)
            {
                Console.WriteLine("Size of string is not big enough to fit the characters.");
                Environment.Exit(-1);
            }

            char[] arr = str.ToCharArray();

            for (int i = arr.Length-1, j = l-1; i >=0 && j>=0; i--, j--)
            {
                if (arr[j] == ' ')
                {
                    arr[i--] = '0';
                    arr[i--] = '2';
                    arr[i] = '%';
                }
                else
                {
                arr[i] = arr[j];
                }
            }
            Console.WriteLine(new string(arr));
            Console.ReadLine();
        }
    }
}

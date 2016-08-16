using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class Permutation
    {
        public void Start()
        {
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Strings are not permutation.");
                Environment.Exit(0);
            }
            int[] arr1 = new int[26];
            int[] arr2 = new int[26];

            for (int i = 0; i < 26; i++)
            {
                arr1[i] = arr2[i] = 0;
            }

            for (int i = 0; i < str1.Length; i++)
            {
                int c = str1[i] - 97;
                arr1[c] = arr1[c] + 1;

                c = str2[i] - 97;
                arr2[c] = arr2[c] + 1;

            }
            var check = true;
            for (int i = 0; i < 26; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    check = false;
                   
                }
            }
            Console.WriteLine(check ? "Strings are permutation." : "Strings are not permutation.");

            Console.ReadLine();
        }
    }
}

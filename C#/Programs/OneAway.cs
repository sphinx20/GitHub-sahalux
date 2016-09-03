using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class OneAway
    {
        public void Start()
        {
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                Console.WriteLine("String is null");
                Environment.Exit(-1);
            }

            str1 = str1.ToLower();
            str2 = str2.ToLower();

            if ((str1.Length != str2.Length) && (Math.Abs(str1.Length - str2.Length) != 1))
            {
                Console.WriteLine("Strings are not one edit");
                Console.Read();
                Environment.Exit(-1);
            }

            int[] arr1 = new int[26];

            for (int i = 0; i < 26; i++)
            {
                arr1[i] = 0;
            }

            string strL = String.Empty;
            string strS = String.Empty;

            if (str1.Length > str2.Length)
            {
                strL = str1;
                strS = str2;

            }
            else
            {
                strL = str2;
                strS = str1;
            }

            for (int i = 0; i < strL.Length; i++)
            {
                if (strL[i] != ' ')
                {
                    int c = strL[i] - 97;
                    arr1[c] = arr1[c] + 1;
                }
            }

            foreach (var ch in strS)
            {
                arr1[ch - 97] = arr1[ch - 97] - 1;
                //if (arr1[ch - 97] != 0)
                //{
                    
                //}
            }

            int counterPlusOne = 0;
            int counterMinusOne = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == 1)
                {
                    counterPlusOne++;
                }
                if (arr1[i] == -1)
                {
                    counterMinusOne++;
                }
                if (arr1[i] < -1)
                {
                    counterMinusOne++;
                }
            }

            if ((counterPlusOne == 1 && counterMinusOne == 1) ||
                (counterPlusOne == 0 && counterMinusOne == 1) ||
                (counterPlusOne == 1 && counterMinusOne == 0) ||
                (counterPlusOne == 0 && counterMinusOne == 0))
            {
                Console.WriteLine("One Away");
            }
            else
            {
                Console.WriteLine("Not One Away");
            }

        }
    }
}

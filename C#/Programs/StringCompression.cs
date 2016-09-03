using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class StringCompression
    {
        public void Start()
        {
            var str = Console.ReadLine();

            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is empty.");
                Environment.Exit(-1);
            }

            var start = str[0];
            int counter = 1;
            bool original = true;
            string newStr = str[0].ToString();
            for (int i = 1; i < str.Length; i++)
            {
                var end = str[i];
                if (start == end)
                {
                    counter++;
                }
                else
                {
                    newStr += counter;
                    newStr += end;
                    counter = 1;
                }

                start = end;

                if (counter > 1 && original)
                {
                    original = false;
                }

                
            }

            newStr += counter;

            Console.WriteLine(original ? str : newStr);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class UniqueChar
    {
        public void Start()
        {
            var str = Console.ReadLine();

            var check = SolutionFromBook(str);

            Console.WriteLine(check ? "All characters are unique" : "All characters are not unique");

            Console.ReadLine();

        }

        private void UniqueWithDataStructure(string str)
        {
            var arr = new Hashtable();
            foreach (var ch in str)
            {
                if (arr.ContainsKey(ch))
                {
                    arr[ch] = false;
                }
                else
                {
                    arr.Add(ch, true);
                }
            }
            foreach (var ch in str)
            {
                if ((bool)arr[ch])
                {
                    Console.WriteLine($"{ch}: Value is unique.");
                }
                else
                {
                    Console.WriteLine($"{ch}: Value is not unique.");
                }
            }
        }

        private bool SolutionFromBook(string str)
        {
            int checker = 0;
            foreach (var val in str)
            {
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker = (checker | (1 << val));
            }

            return true;

        }
    }
}

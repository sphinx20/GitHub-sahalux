using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class StringReverse
    {
        public void Start()
        {
            var str = Console.ReadLine();
            var len = str.Length;
            for(int i = len-1; i>=0; i--)
            {
                Console.Write(str[i]);
            }

            Console.ReadLine();
           
        }
    }
}

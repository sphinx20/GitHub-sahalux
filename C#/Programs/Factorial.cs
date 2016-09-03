using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Numerics;

namespace My_Personal_Projects
{
    class Factorial
    {
        static void New(String[] args)
        {

            Int32 N = Convert.ToInt32(Console.ReadLine());
            if (N < 2 || N > 12)
            {
                Environment.Exit(0);
            }
            UInt64 fact = factorial(N);
            Console.WriteLine(fact);
            Console.ReadLine();

        }

        public static UInt64 factorial(Int64 num)
        {
            if ((num == 0) || (num == 1))
            {
                return 1;
            }
            else
            {
                return (UInt64)num * factorial(num - 1);
            }
        }
    }
}

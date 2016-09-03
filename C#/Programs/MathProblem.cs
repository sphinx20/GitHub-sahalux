using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Numerics;

namespace My_Personal_Projects
{
    class MathProblem
    {
        static void New(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            //var ns = Console.ReadLine();
            //int N = Convert.ToInt32(ns);

            //List<Tuple<BigInteger, BigInteger, BigInteger>> list = new List<Tuple<BigInteger, BigInteger, BigInteger>>();

            //BigInteger ac = 10;

            //BigInteger bc = 2;

            //BigInteger xc = 77;
            //long z;


            //for (int i = 0; i < 100000; i++)
            //{

            //    try
            //    {

            //            list.Add(new Tuple<BigInteger, BigInteger, BigInteger>(ac+i, bc+i, xc));


            //    }
            //    catch (Exception)
            //    {
            //        continue;
            //    }
            //}
            var ns = Console.ReadLine();
            int N = Convert.ToInt32(ns);

            List<Tuple<BigInteger, BigInteger, BigInteger>> list = new List<Tuple<BigInteger, BigInteger, BigInteger>>();

            for (int i = 0; i < N; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                try
                {
                    if (tokens.Length == 3)
                    {

                        BigInteger a;
                        BigInteger.TryParse(tokens[0].Trim(), out a);
                        BigInteger b;
                        BigInteger.TryParse(tokens[1].Trim(), out b);
                        BigInteger x;
                        BigInteger.TryParse(tokens[2].Trim(), out x);

                        //var t = new Tuple<BigInteger, BigInteger, BigInteger>(a,b,x);

                        list.Add(new Tuple<BigInteger, BigInteger, BigInteger>(a, b, x));

                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }


            foreach (Tuple<BigInteger, BigInteger, BigInteger> t in list)
            {
                var a = (double)t.Item1;
                var b = (double)t.Item2;
                var x = t.Item3;

                //BigInteger p = (BigInteger)Math.Log((double)a, (double)b);
                BigInteger p = (BigInteger)Math.Exp(b * Math.Log(a));

                // Console.WriteLine(p);

                if (p < x)
                {
                    Console.ReadLine();
                    Console.WriteLine("0");
                    Environment.Exit(0);
                }

                for (BigInteger n = p; n >= 0; n--)
                {
                    if (n == 0)
                    {
                        Console.WriteLine(n);
                        break;
                    }
                    if (n % x == 0)
                    {
                        Console.WriteLine(n);
                        break;

                    }
                }
            }
            Console.ReadLine();

        }
    }
}

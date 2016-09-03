using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace My_Personal_Projects
{
    class PhoneBookDict
    {
        static void New(String[] args)
        {

            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            var ns = Console.ReadLine();
            int N = Convert.ToInt32(ns.Trim());

            //var phoneBook = new PhoneBook();

            Dictionary<string, Int32> Records = new Dictionary<string, Int32>();

            for (int i = 0; i < N; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                if (tokens.Length == 2)
                {
                    string name = tokens[0].ToLower().Trim();
                    Int32 num = 0;
                    try
                    {
                        num = Convert.ToInt32(tokens[1].Trim());
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    var digits = num <= 0 ? 1 : Math.Floor(Math.Log10(Math.Abs(num)) + 1);
                    if (digits == 8)
                        Records.Add(name, num);

                }
            }

            //foreach(Record r in phoneBook.Records){
            //    Console.WriteLine(r.Name + " = " +r.Phonenum);
            // }

            string inc;
            var inp = new List<string>();
            do
            {
                inc = Console.ReadLine();
                if (!string.IsNullOrEmpty(inc))
                {
                    inp.Add(inc.ToLower().Trim());
                }
            } while (!string.IsNullOrEmpty(inc));

            foreach (string s in inp)
            {
                if (Records.ContainsKey(s))
                {
                    Int32 num = 0;
                    Records.TryGetValue(s, out num);
                    Console.WriteLine(s + "=" + num);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            Console.ReadLine();

        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class Anagrams
    {
        public void Start()
        {
            var n = Convert.ToInt32(Console.ReadLine());

            var arr = new ArrayList ();

            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                if (!string.IsNullOrEmpty(s))
                {
                    arr.Add(s);
                }
            }

            foreach (string str in arr)
                {
                    int counter = 0;
                    if (str.Length%2 != 0)
                    {
                        counter = -1;
                    }
                    else
                    {
                        var s1 = (str.Substring(0, str.Length / 2)).ToCharArray();
                        var s2 = (str.Substring(str.Length / 2, str.Length / 2)).ToCharArray();

                        Array.Sort(s1);
                        Array.Sort(s2);


                        for (int j = 0; j < s1.Length; j++)
                        {
                            if (s1[j] != s2[j])
                            {
                                counter++;
                            }

                        } 
                    }
                   
                    Console.WriteLine(counter);
                }

                Console.ReadLine();
            

        }
    }
    
}

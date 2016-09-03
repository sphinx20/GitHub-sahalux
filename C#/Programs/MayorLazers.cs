using System;
using System.Linq;

namespace My_Personal_Projects
{
    public class MayorLazers
    {
        public void Start()
        {
            var j = UInt64.MaxValue;
            var k = ulong.MaxValue;
            var n = Convert.ToUInt32(Console.ReadLine());
            var heights = Console.ReadLine();
            var h = heights.Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
            if (n != h.Length)
            {
                Environment.Exit(-1);
            }

            var m = Convert.ToUInt32(Console.ReadLine());
            var xp = Console.ReadLine();
            var xm = xp.Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
            if (m != xm.Length)
            {
                Environment.Exit(-1);
            }

            Array.Sort(xm);

            UInt64 consolHeight = 0;

            int startx = 1;
            int endx = 0;

            foreach (var x in xm)
            {
                endx = x;
                for (int i = startx; i < endx; i++)
                {
                    if (i <= h.Length)
                    {
                        if (h[i-1] >= (endx - i))
                        {
                            consolHeight += (ulong) (endx - i);
                        }
                        else
                        {
                            consolHeight += (ulong) h[i-1];
                        }
                    }
                    else if (i == h.Length)
                        {
                            consolHeight += (ulong) h[i-1];
                        }
                    
                    else
                    {
                        break;
                    }

                }

               
               

                startx = x;
            }

            if (endx <= h.Length)
            {
                for (int i = endx; i <= h.Length; i++)
                {
                consolHeight += (ulong)h[h.Length - 1];

                }
            }



            Console.WriteLine(consolHeight);

        }
    }
}

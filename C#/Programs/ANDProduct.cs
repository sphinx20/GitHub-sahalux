using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class ANDProduct
    {
        public void Start()
        {
            var T = Convert.ToInt32(Console.ReadLine());
            var arr = new ArrayList();
            for (int i = 0; i < T; i++)
            {
                String s = Console.ReadLine();
                var n = new List<UInt64>();
                if (s != null)
                {
                    n = s.Split(' ').Select(UInt64.Parse).ToList();
                }
                if ((n.Count == 2) && (n[0] <= n[1]) && (n[0] >= 0) && (n[1] >= 0))
                {
                    arr.Add(new Tuple<UInt64, UInt64>(n[0], n[1]));
                }
            }

            foreach (Tuple<UInt64, UInt64> t in arr)
            {
                var a = t.Item1;
                var b = t.Item2;


                UInt64 pro = 0xffffffff;


                for (UInt64 i = a, j = b; i <= b && i < j; i = i + 2, j = j - 2)
                {
                    if (j - i == 0)
                        pro = pro & i;
                    if (j - i == 1)
                        pro = pro & i & j;
                    if (j - 1 == 2)
                        pro = pro & i & (i + 1) & j;

                    pro = pro & i & (i + 1) & j & (j - 1);

                }

                Console.WriteLine(pro);
            }

            Console.ReadLine();
        }
    }
}

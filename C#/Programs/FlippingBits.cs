/*Flipping bits
You will be given a list of 32 bits unsigned integers. You are required to output the list of the unsigned
integers you get by flipping bits in its binary representation (i.e. unset bits must be set, and set bits must be
unset).
Input Format
The first line of the input contains the list size , which is followed by lines, each line having an integer
from the list.
Constraints
Output Format
Output one line per element from the list with the requested result.
Sample Input
3
2147483647
1
0
Sample Output
2147483648
4294967294
4294967295
Explanation
Take 1 for example, as unsigned 32-bits is 00000000000000000000000000000001 and doing the flipping we
get 11111111111111111111111111111110 which in turn is 4294967294.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class FlippingBits
    {

        public static void Main()
        {
            var T = Convert.ToInt32(Console.ReadLine());
            var arr = new ArrayList();

            var max = UInt32.MaxValue;

            for (int i = 0; i < T; i++)
            {
                var n = Convert.ToUInt32(Console.ReadLine());
                arr.Add(n);
            }

            foreach (UInt32 us in arr)
            {
                Console.WriteLine(max - us);
            }

            Console.ReadLine();
        }
    }
}

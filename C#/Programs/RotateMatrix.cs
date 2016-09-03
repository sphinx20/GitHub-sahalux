using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Personal_Projects
{
    public class RotateMatrix
    {
        public void Start()
        {

            Console.WriteLine("Enter matrix size: M");
            var M = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter matrix size: N");
            var N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter matrix input?");

            var arr = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine($"Enter matrix input {i} * {j}");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int I = -1;
            int J = -1;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (arr[i,j] == 0)
                    {
                        I = i;
                        J = j;
                        break;
                    }
                }
            }

            if (I != -1 && J != -1)
            {
                for (int i = 0; i < M; i++)
                {
                    arr[i, J] = 0;
                }
                for (int j = 0; j < N; j++)
                {
                    arr[I, j] = 0;
                }
            }

            Console.WriteLine("New Matrix is:");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.Write("\n");
            }

        }
    }
}

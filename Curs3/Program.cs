using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    class Program
    {
        static void Main(string[] args)
        {
            //MatricePatratica();

        }

        private static void MatricePatratica()
        {
            int n = 5;
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i < j) && (i + j < n - 1))
                    {
                        a[i, j] = 1;
                    }
                    if ((i < j) && (i + j > n - 1))
                    {
                        a[i, j] = 2;
                    }
                    if ((i > j) && (i + j < n - 1))
                    {
                        a[i, j] = 3;
                    }
                    if ((i > j) && (i + j > n - 1))
                    {
                        a[i, j] = 4;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

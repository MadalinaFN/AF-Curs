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
            //PatratConcentric();
            //ValoriMinime();
        }

        private static void ValoriMinime()
        {
            int n = 5, m = 7, max = 0;
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                int min = a[i, 0];
                for (int j = 1; j < m; j++)
                {
                    if (a[i,j] < min)
                    {
                        min = a[i, j];
                    }
                }
                if (min > max)
                {
                    max = min;
                }
            }
            Console.WriteLine(max);
        }

        static Random rnd = new Random();

        private static void PatratConcentric()
        {
            int n = 8, k = 1, m = 7;
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = k;
                    k++;
                    if (k == 10)
                    {
                        k = 1;
                    }
                }
            }
            for (int i = 0; i < m - 1; i++)
            {
                Console.Write(a[0,i] + " ");
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(a[i, m - 1] + " ");
            }
            for (int i = m - 1; i >= 0; i--)
            {
                Console.Write(a[n - 1, i] + " ");
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(a[i, 0] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
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

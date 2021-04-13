using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs7
{
    class Program
    {
        static void Main(string[] args)
        {
            Backtracking();
        }

        static void back(int k, int n, int[] sol)
        {
            if (k >= n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(sol[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    sol[k] = i;
                    back(k + 1, n, sol);
                }
            }
        }

        private static void Backtracking()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            back(0, n, v);
        }
    }
}

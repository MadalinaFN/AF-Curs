using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci();

        }

        private static void Fibonacci()
        {
            Console.WriteLine(fib(6));
        }

        static int fibt (int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int[] v = new int[n + 1];
                v[0] = 0;
                v[1] = 1;
                for (int i = 2; i < n; i++)
                {
                    v[i] = v[i - 1] + v[i - 2];
                }
                return v[n];
            }
        }

        static int fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return fib(n - 1) + fib(n - 2);
        }
    }
}

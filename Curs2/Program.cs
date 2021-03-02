using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs2
{
    class Program
    {
        static void Main(string[] args)
        {
            kvalori();
        }

        static Random rnd = new Random();

        private static void kvalori()
        {
            int n = 5000, k = 7, contor = 0, contor2 = 0;

            int[] v = new int[n];
            bool[] vn = new bool[1000];

            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(-10000, 10001);
            }

            for (int i = 0; i < n; i++)
            {
                if (v[i] >= 0 && v[i] <= 999)
                {
                    if (!vn[v[i]])
                    {
                        vn[v[i]] = true;
                        contor2++;
                    }
                }
            }

            for (int i = 0; i < 1000; i++)
            {
                Console.Write($"{vn[i]} ");
            }
            Console.WriteLine();

            if (900 - contor2 >= k)
            {
                for (int i = 999; i >= 100; i--)
                {
                    if (!vn[i])
                    {
                        Console.Write(i + " ");
                        contor++;
                        if (contor == k)
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Nu exista");
            }
            Console.WriteLine();
        }
    }
}

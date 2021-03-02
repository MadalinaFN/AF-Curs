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
            //kvalori();
            //CifreComune();
            CelMaiMareSiCelMaiMic();
        }

        private static void CelMaiMareSiCelMaiMic()
        {
            ulong n = 828952000111;
            int[] v = new int[10];

            while (n != 0)
            {
                v[n % 10]++;
                n /= 10;
            }

            ulong torMax = 0;
            for (int i = 9; i >= 0; i--)
            {
                if (v[i] != 0)
                {
                    for (int j = 0; j < v[i]; j++)
                    {
                        torMax = torMax * 10 + (ulong)i;
                    }
                }
            }
            Console.Write(torMax);
            Console.WriteLine();

            ulong torMin = 0;

            if (v[0] != 0)
            {
                int idx = 1;
                while (v[idx] == 0)
                {
                    idx++;
                }
                torMin = (ulong)idx;
                v[idx]--;
            }
            
            for (int i = 0; i <= 9; i++)
            {
                if (v[i] != 0)
                {
                    for (int j = 0; j < v[i]; j++)
                    {
                        torMin = torMin * 10 + (ulong)i;
                    }
                }
            }
            Console.Write(torMin);
            Console.WriteLine();
        }

        private static void CifreComune()
        {
            int n1 = 2777134, n2 = 1115727789;

            bool[] v1 = new bool[10];
            bool[] v2 = new bool[10];

            while (n1 != 0)
            {
                v1[n1 % 10] = true;
                n1 /= 10;
            }

            while (n2 != 0)
            {
                v2[n2 % 10] = true;
                n2 /= 10;
            }

            for (int i = 0; i < 10; i++)
            {
                if (v1[i] && v2[i])
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
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

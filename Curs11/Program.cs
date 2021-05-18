using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Curs11
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumereMaiMariPanaLa100();
            ProblemaMatrice();
            NumereDivizibileCu5();
        }

        private static void NumereDivizibileCu5()
        {
            
        }

        private static void ProblemaMatrice()
        {
            int n1 = int.Parse(Console.ReadLine());
            bool[] v1 = new bool[21];

            int n2 = int.Parse(Console.ReadLine());
            bool[] v2 = new bool[21];

            int[,] a = new int[n1, n2];

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 1; i < n1; i++)
            {
                v2[a[i, n2 - 1]] = true;
            }
            for (int i = 0; i < n2 - 1; i++)
            {
                v1[a[0, i]] = true;
            }
            for (int i = 0; i < 21; i++)
            {
                if (v1[i] && v2[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static void NumereMaiMariPanaLa100()
        {
            bool[] v = new bool[100];

            TextReader load = new StreamReader(@"..\..\TextFile1.txt");
            string[] buffer = load.ReadLine().Split(' ');

            int nr = 0;
            foreach (string s in buffer)
            {
                int t = int.Parse(s);
                if (t >= 10 && t < 100)
                {
                    if ((t % 10) != (t / 10))
                    {
                        if (!v[t])
                        {
                            nr++;
                        }
                        v[t] = true;
                    }
                }
            }

            int k = 0, nrv = 2;

            if (90 - nr >= nrv)
            {
                for (int i = 99; i >= 10; i--)
                {
                    if (!v[i])
                    {
                        Console.Write(i + " ");
                        k++;
                        if (k == nrv)
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.Write("Nu exista");
            }
            Console.WriteLine();
        }
    }
}

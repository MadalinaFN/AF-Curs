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
            NumereMaiMariPanaLa100();
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

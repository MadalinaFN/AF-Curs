using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs10
{
    class Program
    {
        static void Main(string[] args)
        {
            //FactoriPrimi();
            //FactoriPrimi1();

        }

        private static void FactoriPrimi1()
        {
            Console.Write(nrfp(90));
            Console.WriteLine();
        }
        static int nrfp(int n)
        {
            int max = 0;
            int poz = 0;
            for (int i = 1; i <= n; i++)
            {
                int tmp = fp(i);
                if (max < tmp)
                {
                    max = tmp;
                    poz = i;
                }
            }
            return poz;
        }

        private static void FactoriPrimi()
        {
            Console.Write("= " + fp(90));
            Console.WriteLine();
        }
        static int fp(int x)
        {
            int d = 2;
            int nr = 0;
            while (x != 1)
            {
                if (x % d == 0)
                {
                    nr++;
                }
                while (x % d == 0)
                {
                    x /= d;
                    //Console.Write(d + " ");
                }
                if (d == 2)
                {
                    d++;
                }
                else
                    d += 2;
            }
            return nr;
        }
    }
}

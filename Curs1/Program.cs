using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Palindrom();
            //SumaCifre();
            DeCateOriApare();
            PuteriNrPerfectePrime();
            KValoriMari();
        }

        private static void KValoriMari()
        {
            
        }

        private static void PuteriNrPerfectePrime()
        {
            
        }

        private static void DeCateOriApare()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                //v[i] = rnd.Next(100);
            }

            int x = v[0];
            int k = 1;

            for (int i = 1; i < n; i++)
            {
                if (v[i] == x)
                    k++;
                else
                {
                    Console.Write(x + "[" + k + "]" + " ");
                    k = 1;
                }
                x = v[i];
            }
            Console.WriteLine();
        }

        private static void SumaCifre()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] r = new int[2 * n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                //v[i] = rnd.Next(100);
            }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                r[k] = v[i];
                k++;
                if (prime (v[i]))
                {
                    r[k] = sumacif(v[i]);
                    k++;
                }
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(r[i] + " ");
            }
            Console.WriteLine();
        }

        static int sumacif (int n)
        {
            int tor = 0;
            while (n != 0)
            {
                tor += n % 10;
                n /= 10;
            }
            return tor;
        }

        static bool prime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Palindrom()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                //v[i] = rnd.Next(100);
            }

            bool ok = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (v[i] != v[n - 1 - i])
                {
                    ok = false;
                    break;
                }
            }
            if (ok == true)
                Console.WriteLine("Este palindrom");
            else
                Console.WriteLine("Nu este palindrom");
        }
    }
}

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
            Palindrom();
            SumaCifre();
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
            
        }

        private static void SumaCifre()
        {
            
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

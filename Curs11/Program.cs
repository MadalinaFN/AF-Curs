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
            //ProblemaMatrice();
            NumereDivizibileCu5();
        }

        private static void NumereDivizibileCu5()
        {
            TextReader load1 = new StreamReader(@"..\..\TextFile2.txt");
            string[] buffer1 = load1.ReadLine().Split(' ');

            int[] v1 = new int[buffer1.Length];
            int n1 = 0;

            foreach (string s in buffer1)
            {
                v1[n1] = int.Parse(buffer1[n1]);
                n1++;
            }

            TextReader load2 = new StreamReader(@"..\..\TextFile3.txt");
            string[] buffer2 = load2.ReadLine().Split(' ');

            int[] v2 = new int[buffer2.Length];
            int n2 = 0;

            foreach (string s in buffer2)
            {
                v2[n2] = int.Parse(buffer2[n2]);
                n2++;
            }

            int[] v3 = new int[n1 + n2];
            int k1 = 0;
            int k2 = 0;
            int k3 = 0;

            while (k1 < n1 && k2 < n2)
            {
                if (v1[k1] < v2[k2])
                {
                    if (v1[k1] % 5 == 0 && !isf(v1[k1], v2))
                    {
                        v3[k3] = v1[k1];
                        k3++;
                    }
                    k1++;
                }
                else
                {
                    if (v2[k2] % 5 == 0 && !isf(v2[k2], v1))
                    {
                        v3[k3] = v2[k2];
                        k3++;
                    }
                    k2++;
                }
            }
            while (k1 < n1)
            {
                if (v1[k1] % 5 == 0 && !isf(v1[k1], v2))
                {
                    v3[k3] = v1[k1];
                    k3++;
                }
                k1++;
            }
            while (k2 < n2 && !isf(v2[k2], v1))
            {
                if (v2[k2] % 5 == 0)
                {
                    v3[k3] = v2[k2];
                    k3++;
                }
                k2++;
            }

            /*for (int i = 0; i < n1; i++)
            {
                v3[i] = v1[i];
            }
            for (int i = 0; i < n2; i++)
            {
                v3[n1 + i] = v2[i];
            }
            for (int i = 0; i < n1 + n2 - 1; i++)
            {
                for (int j = i + 1; j < n1 + n2; j++)
                {
                    if (v3[i] > v3[j])
                    {
                        int aux = v3[i];
                        v3[i] = v3[j];
                        v3[j] = aux;
                    }
                }
            }*/

            for (int i = 0; i < k3; i++)
            {
                Console.Write(v3[i] + " ");
            }
            Console.WriteLine();
        }
        private static bool isf(int x, int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (x == v[i])
                {
                    return true;
                }
            }
            return false;
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

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

        static void back1(int k, int n, int[] sol)
        {
            if (k >= n)
            {
                bool ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (sol[i] == sol[j])
                        {
                            ok = false;
                            break;
                        }
                    }
                }
                if (ok)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(sol[i]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    sol[k] = i + 1;
                    back1(k + 1, n, sol);
                }
            }
        }

        static void permutari(int k, int n, int[] sol, bool[] vis)
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
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i + 1;
                        permutari(k + 1, n, sol, vis);
                        vis[i] = false;
                    }
                }
            }
        }

        static void aranjamente(int k, int n, int p, int[] sol, bool[] vis)
        {
            if (k >= p)
            {
                for (int i = 0; i < p; i++)
                {
                    Console.Write(sol[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i + 1;
                        aranjamente(k + 1, n, p, sol, vis);
                        vis[i] = false;
                    }
                }
            }
        }

        private static void Backtracking()
        {
            int p = 4;
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            bool[] vis = new bool[n];
            //back(0, n, v);
            //back1(0, n, v);
            for (int i = 0; i < n; i++)
            {
                vis[i] = false;
            }
            //permutari(0, n, v, vis);
            aranjamente(0, n, p, v, vis);
        }
    }
}

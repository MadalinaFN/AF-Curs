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
            //Backtracking();
            ProblemaMatrice();
        }

        private static void ProblemaMatrice()
        {
            int interc = 0;
            init();
            do
            {
                interchange();
                interc++;
            } while (!verify());
            view();
            Console.WriteLine(interc);
            Console.WriteLine();

            int[] v = new int[9];
            bool[] vis = new bool[9];
            permutari_pmag(0, 9, v, vis);
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

        static void combinari(int k, int n, int p, int[] sol, bool[] vis)
        {
            if (k >= p)
            {
                bool ok = true;
                for (int i = 0; i < p - 1; i++)
                {
                    if (sol[i] > sol[i+1])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    for (int i = 0; i < p; i++)
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
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i + 1;
                        combinari(k + 1, n, p, sol, vis);
                        vis[i] = false;
                    }
                }
            }
        }

        static void combinari1(int k, int n, int p, int[] sol)
        {
            if (k > p)
            {
                for (int i = 1; i <= p; i++)
                {
                    Console.Write(sol[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = sol[k - 1] + 1; i <= n; i++)
                {
                    sol[k] = i;
                    combinari1(k + 1, n, p, sol);
                }
            }
        }

        //Se da o matrice de 3x3 cu valori distincte in multimea[1...9]. O solutie
        //presupune suma pe fiecare linie sa fie egala cu suma pe fiecare coloana si
        //cu suma pe fiecare diagonala. Afisati o solutie daca exista.
        static int[,] m = new int[3, 3];
        static Random rnd = new Random();
        static void init()
        {
            int k = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m[i, j] = k;
                    k++;
                }
            }
        }
        static void interchange()
        {
            int l1 = rnd.Next(3);
            int c1 = rnd.Next(3);
            int l2 = rnd.Next(3);
            int c2 = rnd.Next(3);

            int aux = m[l1, c1];
            m[l1, c1] = m[l2, c2];
            m[l2, c2] = aux;
        }
        static bool verify()
        {
            int sl1 = m[0, 0] + m[0, 1] + m[0, 2];
            int sl2 = m[1, 0] + m[1, 1] + m[1, 2];
            int sl3 = m[2, 0] + m[2, 1] + m[2, 2];

            int sc1 = m[0, 0] + m[1, 0] + m[2, 0];
            int sc2 = m[0, 1] + m[1, 1] + m[2, 1];
            int sc3 = m[0, 2] + m[1, 2] + m[2, 2];

            int sd1 = m[0, 0] + m[1, 1] + m[2, 2];
            int sd2 = m[0, 2] + m[1, 1] + m[2, 0];

            if (sl1 == sl2 && sl1 == sl3 && sl1 == sc1 && sl1 == sc2 && sl1 == sc3 && sl1 == sd1 && sl1 == sd2)
            {
                return true;
            }
            return false;
        }
        static void view()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void permutari_pmag(int k, int n, int[] sol, bool[] vis)
        {
            if (k >= n)
            {
                m[0, 0] = sol[0];
                m[0, 1] = sol[1];
                m[0, 2] = sol[2];
                m[1, 0] = sol[3];
                m[1, 1] = sol[4];
                m[1, 2] = sol[5];
                m[2, 0] = sol[6];
                m[2, 1] = sol[7];
                m[2, 2] = sol[8];
                if (verify())
                {
                    view();
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i + 1;
                        permutari_pmag(k + 1, n, sol, vis);
                        vis[i] = false;
                    }
                }
            }
        }

        private static void Backtracking()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            //int[] v = new int[n];
            bool[] vis = new bool[n];

            //back(0, n, v);
            //back1(0, n, v);

            for (int i = 0; i < n; i++)
            {
                vis[i] = false;
            }
            //permutari(0, n, v, vis);
            //aranjamente(0, n, p, v, vis);
            //combinari(0, n, p, v, vis);
            int[] v = new int[n + 1];
            v[0] = 0;
            //combinari1(1, n, p, v);
        }
    }
}

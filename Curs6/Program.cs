using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Curs6
{
    class Program
    {
        static int n, m;
        static int[,] a;
        static bool[,] b;
        static void load(string filename)
        {
            TextReader data_load = new StreamReader(filename);
            List<string> data = new List<string>();
            string buffer;

            while ((buffer = data_load.ReadLine()) != null)
            {
                data.Add(buffer);
            }

            n = data.Count;
            m = data[0].Length;
            a = new int[n, m];
            b = new bool[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = (data[i])[j] - '0';
                    b[i, j] = false;
                }
            }
        }

        static void view()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }

        static bool ok;
        static void pa(int i, int j)
        {
            if (i >= 0 && j >= 0 && i < n && j < m && !b[i,j] && a[i, j] == 1)
            {
                //Console.Write("(" + i + " " + j + " " + a[i, j] + ")");
                if (j == m - 1)
                {
                    ok = true;
                }
                b[i, j] = true;
                pa(i - 1, j);
                pa(i, j + 1);
                pa(i + 1, j);
                pa(i, j - 1);
            }
        }

        static void Main(string[] args)
        {
            DrumDe1();
        }

        private static void DrumDe1()
        {
            load(@"..\..\TextFile1.txt");
            view();
            ok = false;
            for (int i = 0; i < n; i++)
            {
                if (a[i, 0] == 1)
                {
                    pa(i, 0);
                    //Console.WriteLine();
                }
            }
            if (ok)
            {
                Console.WriteLine("Exista drum de 1");
            }
            else
            {
                Console.WriteLine("Nu exista drum de 1");
            }
        }
    }
}

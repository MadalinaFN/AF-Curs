using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdusMatrici();
        }

        static Random rnd = new Random();

        private static void ProdusMatrici()
        {
            Matrix A = new Matrix(@"..\..\TextFile1.txt", true);
            foreach (string s in A.view())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Matrix B = new Matrix(@"..\..\TextFile2.txt", false);
            foreach (string s in B.view())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Matrix C = A.Add(B);
            foreach (string s in C.view())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Matrix D = A.Add(B);
            foreach (string s in D.view())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Matrix E = A.Substract(B);
            foreach (string s in E.view())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
}

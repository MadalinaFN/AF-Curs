using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Curs12
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProblemaMatrice();
            TermenPrecedent();
        }

        private static void TermenPrecedent()
        {
            string n = "2";
            string k = "3";
            string result = load(@"..\..\TextFile1.txt");
            Console.Write(n + " " + k + " ");
            for (int i = 1; i <= 5; i++)
            {
                string aux = k + n;
                if (aux == result)
                {
                    break;
                }
                Console.Write(aux + " ");
                n = k;
                k = aux;
            }
            Console.WriteLine();
        }
        static string load (string filename)
        {
            using(StreamReader sr = new StreamReader(filename))
            {
                string buffer = sr.ReadLine();
                return buffer;
            }
        }

        private static void ProblemaMatrice()
        {
            // metoda 1 cand avem un nr maxim de 1000
            int[] v = { 2, 3, 3, 4, 4, 4, 3 };
            //int[] n = ArrayPower(v);
            //for (int i = 0; i < n.Length && n[i] != 0; i++)
            //    Console.Write(ArrayPower(v)[i] + " ");
            //Console.WriteLine();
            //Console.WriteLine(IsBigger(v,m));
            // metoda 2 cu sortare
            int[] m = SortMyArray(v);
            //for (int i = 0; i < m.Length; i++)
            //    Console.Write(m[i] + " ");
            int[] solution = CountArray(m);
            for (int i = 0; i < solution.Length; i++)
                Console.Write(solution[i] + " ");
        }
        public static int[] CountArray(int[] myArr)
        {
            int size = 1;
            int counter = 1;
            for (int i = 1; i < myArr.Length; i++)
            {
                if (myArr[i] != myArr[i - 1])
                    size++;
            }
            int[] toReturn = new int[size];
            int j = 0;
            for (int i = 1; i < myArr.Length; i++)
            {
                if (myArr[i] == myArr[i - 1])
                    counter++;
                else
                {
                    toReturn[j] = counter;
                    j++;
                    counter = 1;
                }
            }
            toReturn[j] = counter;
            return toReturn;
        }
        public static int[] SortMyArray(int[] toBeSorted)
        {
            for (int i = 0; i < toBeSorted.Length - 1; i++)
                for (int j = i + 1; j < toBeSorted.Length; j++)
                    if (toBeSorted[i] < toBeSorted[j])
                    {
                        int aux = toBeSorted[i];
                        toBeSorted[i] = toBeSorted[j];
                        toBeSorted[j] = aux;
                    }
            return toBeSorted;
        }
        public static int[] ArrayPower(int[] arr)
        {
            int[] frecv = new int[1000];
            int[] save = new int[1000];
            int size = 0;
            for (int i = 0; i < arr.Length; i++)
                frecv[arr[i]]++;
            for (int i = 999; i >= 0; i--)
                if (frecv[i] != 0)
                {
                    save[size] = frecv[i];
                    size++;
                }
            int[] toReturn = new int[size];
            for (int i = 0; i < save.Length && save[i] != 0; i++)
                toReturn[i] = save[i];
            return toReturn;
        }
        public static int IsBigger(int[] v1, int[] v2)
        {
            v1 = ArrayPower(v1);
            v2 = ArrayPower(v2);
            int i = 0;
            while (i < v1.Length && i < v2.Length)
            {
                if (v1[i] > v2[i])
                    return -1;
                else if (v1[i] < v2[i])
                    return 1;
                i++;
            }
            if (i < v1.Length)
                return -1;
            if (i < v2.Length)
                return 1;
            return 0;
        }
    }
}

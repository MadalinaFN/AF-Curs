using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Curs8
{
    public class Queue
    {
        nod[] v;
        public int n;
        
        public Queue()
        {
            n = 0;
        }

        public void push(nod value)
        {
            n++;
            nod[] t = new nod[n];
            for (int i = 0; i < n - 1; i++)
            {
                t[i + 1] = v[i];
            }
            t[0] = value;
            v = t;
        }

        public nod pop()
        {
            nod tor = v[n - 1];
            n--;
            nod[] t = new nod[n];
            for (int i = 0; i < n; i++)
            {
                t[i] = v[i];
            }
            v = t;
            return tor;
        }

        public void view()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        public void viewLine()
        {
            view();
            Console.WriteLine();
        }
    }
    public class Stack
    {
        public int[] v;
        public int n;

        public Stack()
        {
            n = 0;
        }

        public void push(int value)
        {
            n++;
            int[] t = new int[n];
            for (int i = 0; i < n - 1; i++)
            {
                t[i + 1] = v[i];
            }
            t[0] = value;
            v = t;
        }

        public int pop()
        {
            int tor = v[0];
            n--;
            int[] t = new int[n];
            for (int i = 0; i < n; i++)
            {
                t[i] = v[i + 1];
            }
            v = t;
            return tor;
        }

        public void view()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        public void viewLine()
        {
            view();
            Console.WriteLine();
        }
    }
    public class Stack1
    {
        public float[] v;
        public float n;

        public Stack1()
        {
            n = 0;
        }

        public void push(float value)
        {
            n++;
            float[] t = new float[(int)n];
            for (int i = 0; i < n - 1; i++)
            {
                t[i + 1] = v[i];
            }
            t[0] = value;
            v = t;
        }

        public float pop()
        {
            float tor = v[0];
            n--;
            float[] t = new float[(int)n];
            for (int i = 0; i < n; i++)
            {
                t[i] = v[i + 1];
            }
            v = t;
            return tor;
        }

        public void view()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        public void viewLine()
        {
            view();
            Console.WriteLine();
        }
    }
    public class nod
    {
        public int l, c, v;

        public nod(int l, int c, int v)
        {
            this.l = l;
            this.v = v;
            this.c = c;
        }
        public void view()
        {
            Console.Write(l + " " + c + " " + v + " ");
        }
    }
    public class Program
    {
        static int[,] a;
        static int n, m;

        static void load()
        {
            TextReader load = new StreamReader(@"..\..\matrix.in");
            string buffer = load.ReadLine();
            n = int.Parse(buffer.Split(' ')[0]);
            m = int.Parse(buffer.Split(' ')[1]);
            a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] local_s = (load.ReadLine()).Split(' ');
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(local_s[j]);
                }
            }
        }
        static void view()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Lee()
        {
            Queue D = new Queue();
            a[0, 0] = 1;
            D.push(new nod(0, 0, 1));

            while (D.n != 0)
            {
                nod t = D.pop();
                if (t.l - 1 >= 0)
                {
                    if (a[t.l - 1, t.c] == 0)
                    {
                        a[t.l - 1, t.c] = t.v + 1;
                        D.push(new nod(t.l - 1, t.c, t.v + 1));
                    }
                }
                if (t.c + 1 < m)
                {
                    if (a[t.l, t.c + 1] == 0)
                    {
                        a[t.l, t.c + 1] = t.v + 1;
                        D.push(new nod(t.l, t.c + 1, t.v + 1));
                    }
                }
                if (t.l + 1 < n)
                {
                    if (a[t.l + 1, t.c] == 0)
                    {
                        a[t.l + 1, t.c] = t.v + 1;
                        D.push(new nod(t.l + 1, t.c, t.v + 1));
                    }
                }
                if (t.c - 1 >= 0)
                {
                    if (a[t.l, t.c - 1] == 0)
                    {
                        a[t.l, t.c - 1] = t.v + 1;
                        D.push(new nod(t.l, t.c - 1, t.v + 1));
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            /*Queue A = new Queue();
            A.push(1);
            A.push(2);
            A.push(3);
            A.push(4);
            A.view();
            int t = A.pop();
            A.viewLine();
            Console.WriteLine($"Pop = {t}");
            Console.WriteLine();

            Stack B = new Stack();
            B.push(1);
            B.push(2);
            B.push(3);
            B.push(4);
            B.viewLine();
            int tt = B.pop();
            B.push(5);
            B.viewLine();
            Console.WriteLine($"Pop = {tt}");
            Console.WriteLine();

            Stack1 C = new Stack1();
            string s = "2 3 + 5 1 + 2 * - 1 3 - + 2 2 * 1 + +";
            string[] local_S = s.Split(' ');
            foreach (string str in local_S)
            {
                if (str[0] >= '0' && str[0] <= '9')
                {
                    C.push(float.Parse(str));
                }
                else
                {
                    float t1 = C.pop();
                    float t2 = C.pop();
                    switch(str[0])
                    {
                        case '+':
                            C.push(t2 + t1);
                            break;
                        case '-':
                            C.push(t2 - t1);
                            break;
                        case '*':
                            C.push(t2 * t1);
                            break;
                        case ':':
                            C.push(t2 / t1);
                            break;
                    }
                }
            }
            C.viewLine();*/

            load();
            view();
            Console.WriteLine();
            Lee();
            view();
        }
    }
}

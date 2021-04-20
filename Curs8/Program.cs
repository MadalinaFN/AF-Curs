using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs8
{
    public class Queue
    {
        public int[] v;
        public int n;
        
        public Queue()
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
            int tor = v[n - 1];
            n--;
            int[] t = new int[n];
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
    public class Program
    {
        static void Main(string[] args)
        {
            Queue A = new Queue();
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
            C.viewLine();
        }
    }
}

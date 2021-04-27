using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs9
{
    class Complex
    {
        public double parteReala, parteImaginara;
        public Complex(double parteReala = 0, double parteImaginara = 0)
        {
            this.parteReala = parteReala;
            this.parteImaginara = parteImaginara;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (parteImaginara > 0)
            {
                sb.AppendFormat("{0:0.00} + {1:0.00} i", parteReala, parteImaginara);
            }
            else if (parteImaginara < 0)
            {
                sb.AppendFormat("{0:0.00} - {1:0.00} i", parteReala, (-1) * parteImaginara);
            }
            else
            {
                sb.AppendFormat("{0:0.00} ", parteReala);
            }
            return sb.ToString();
        }

        public static Complex operator +(Complex nr1, Complex nr2)
        {
            Complex rezultat = new Complex();
            rezultat.parteReala = nr1.parteReala + nr2.parteReala;
            rezultat.parteImaginara = nr1.parteImaginara + nr2.parteImaginara;
            return rezultat;
        }

        public static Complex operator -(Complex nr1, Complex nr2)
        {
            Complex rezultat = new Complex();
            rezultat.parteReala = nr1.parteReala - nr2.parteReala;
            rezultat.parteImaginara = nr1.parteImaginara - nr2.parteImaginara;
            return rezultat;
        }

        public static Complex operator *(Complex nr1, Complex nr2)
        {
            Complex rezultat = new Complex();
            rezultat.parteReala = nr1.parteReala * nr2.parteReala - nr1.parteImaginara * nr2.parteImaginara;
            rezultat.parteImaginara = nr1.parteReala * nr2.parteImaginara + nr1.parteImaginara * nr2.parteReala;
            return rezultat;
        }

        public static Complex Conjugat(Complex nr)
        {
            return new Complex(nr.parteReala, (-1) * nr.parteImaginara);
        }

        public static Complex operator /(Complex nr1, Complex nr2)
        {
            Complex conjNr2 = Conjugat(nr2);
            Complex numarator = nr1 * conjNr2;
            Complex numitor = nr2 * conjNr2;
            return new Complex(numarator.parteReala / numitor.parteReala, numarator.parteImaginara / numitor.parteReala);
        }

        public static bool operator ==(Complex nr1, Complex nr2)
        {
            if (nr1.parteReala == nr2.parteReala && nr1.parteImaginara == nr2.parteImaginara)
                return true;
            return false;
        }

        public static bool operator !=(Complex nr1, Complex nr2)
        {
            if (nr1 == nr2)
                return false;
            return true;
        }

        public double Modul()
        {
            return Math.Sqrt(parteReala * parteReala + parteImaginara * parteImaginara);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(4);
            Complex d = new Complex(4);

            Console.WriteLine("{0}", c);
            Console.WriteLine("{0}", d);
            Console.WriteLine("c+d: {0}", c + d);
            Console.WriteLine("c-d: {0}", c - d);
            Console.WriteLine("c*d: {0}", c * d);
            Console.WriteLine("c/d: {0}", c / d);
            Console.WriteLine("|c|: {0}", c.Modul());
            if (c == d)
                Console.WriteLine("c=d");
            else
                Console.WriteLine("c!=d");
            Console.ReadKey();
        }
    }
}

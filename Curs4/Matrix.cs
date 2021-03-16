using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4
{
    public class Matrix
    {
        public float[,] values;
        public static Matrix Empty;
        //public int n { get { return values.GetLength(0); } set { n = value; } }
        //public int m { get { return values.GetLength(1); } set { m = value; } }
        public int n, m;

        public Matrix () { }
        public Matrix (int n, int m)
        {
            this.n = n;
            this.m = m;
            values = new float[n, m];
        }

        public Matrix (string fileName, bool existD)
        {
            TextReader load = new StreamReader(fileName);
            if (existD)
            {
                string buffer = load.ReadLine();
                n = int.Parse(buffer.Split(' ')[0]);
                m = int.Parse(buffer.Split(' ')[1]);
                values = new float[n, m];

                for (int i = 0; i < n; i++)
                {
                    string [] T = load.ReadLine().Split (' ');
                    for (int j = 0; j < m; j++)
                    {
                        values[i, j] = int.Parse(T[j]);
                    }
                }
            }
            else
            {
                List<string> localData = new List<string>();
                string buffer;
                while ((buffer = load.ReadLine()) != null)
                {
                    localData.Add(buffer);
                }
                n = localData.Count;
                m = localData[0].Split(' ').Length;
                values = new float[n, m];

                for (int i = 0; i < n; i++)
                {
                    string[] T = localData[i].Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        values[i, j] = int.Parse(T[j]);
                    }
                }
            }
        }

        public Matrix multiply (Matrix toMulty)
        {
            if (this.m != toMulty.n)
            {
                return Empty;
            }
            else
            {
                Matrix toReturn = new Matrix(this.n, toMulty.m);
                for (int i = 0; i < this.n; i++)
                {
                    for (int j = 0; j < toMulty.m; j++)
                    {
                        toReturn.values[i, j] = 0;
                        for (int k = 0; k < this.m; k++)
                        {
                            toReturn.values[i, j] += this.values [i, k] * toMulty.values[k, j];
                        }
                    }
                }
                return toReturn;
            }
        }
        public Matrix Add(Matrix toAdd)
        {
            if (this.n != toAdd.n || this.m != toAdd.m)
            {
                return Empty;
            }
            else
            {
                Matrix toReturn = new Matrix(this.n, this.m);
                for (int i = 0; i < this.n; i++)
                {
                    for (int j = 0; j < this.m; j++)
                    {
                        toReturn.values[i, j] = this.values[i, j] + toAdd.values[i, j];
                    }
                }
                return toReturn;
            }
        }

        public Matrix Substract(Matrix toSubstract)
        {
            if (this.n != toSubstract.n || this.m != toSubstract.m)
            {
                return Empty;
            }
            else
            {
                Matrix toReturn = new Matrix(this.n, this.m);
                for (int i = 0; i < this.n; i++)
                {
                    for (int j = 0; j < this.m; j++)
                    {
                        toReturn.values[i, j] = this.values[i, j] - toSubstract.values[i, j];
                    }
                }
                return toReturn;
            }
        }

        public List<string> view ()
        {
            List<string> toReturn = new List<string>();
            string buffer;
            for (int i = 0; i < n; i++)
            {
                buffer = "";
                for (int j = 0; j < m; j++)
                {
                    buffer += values[i, j] + " ";
                }
                toReturn.Add(buffer);
            }
            return toReturn;
        }
    }
}

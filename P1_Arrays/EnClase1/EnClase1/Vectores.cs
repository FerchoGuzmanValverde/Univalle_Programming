using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnClase1
{
    class Vectores
    {
        Random num = new Random();
        public int[] crear(int[] X)
        {
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = num.Next(1, 50);
            }
            return X;
        }

        public int[] nor(int[] X)
        {
            int a, e = 0, o = 0;
            for (int i = 0; i < X.Length; i++)
            {
                a = 0;
                for (int j = 0 + o; j < X.Length; j++)
                {
                    if (X[i] == X[i])
                    {
                        a = 1;
                    }
                }
                if (a == 0)
                {
                    e++;
                }
                o++;
            }
            int[] Z = new int[e];
            e = 0; o = 0;
            for (int i = 0; i < X.Length; i++)
            {
                a = 0;
                for (int j = 0 + o; j < X.Length; j++)
                {
                    if(X[i] == X[i])
                    {
                        a = 1;
                    }
                }
                if(a == 0)
                {
                    Z[e] = X[i];
                    e++;
                }
                o++;
            }
            return Z;
        }

        public int[] contador(int[] x)
        {
            int a, e = 0, o = 0;
            for (int i = 0; i < x.Length; i++)
            {
                a = 0;
                for (int j = 0 + e; j < x.Length; j++)
                {
                    if (x[i] == x[e])
                    {
                        a = 1;
                    }
                }
                if (a == 0)
                {
                    o++;
                }
                e++;
            }
            int[] Z = new int[o];
            e = 0;
            for (int i = 0; i < x.Length; i++)
            {
                a = 0;
                for (int j = 0 + e; j < x.Length; j++)
                {
                    if(x[i] == x[e])
                    {
                        a = 1;
                    }
                }
                if(a == 0)
                {
                    Z[i] = Z[i]++;
                }
                e++;
            }
            return Z;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosVectores
{
    class Mi_clase
    {
        Random num = new Random();
        public int[] crear(int[] X)
        {
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = num.Next(1, 100);
            }
            return X;
        }

        public int[] burbuja(int[] X)
        {
            int aux;
            for (int i = 0; i < (X.Length-1); i++)
            {
                if(X[i] > X[i+1])
                {
                    aux = X[i];
                    X[i] = X[i + 1];
                    X[i + 1] = aux;
                }
            }
            return X;
        }

        public int[] suma(int[] X, int[] Y, int[] S)
        {
            for (int i = 0; i < X.Length; i++)
            {
                S[i] = X[i] + Y[i];
            }
            return S;
        }

        public int promedio(int[] X)
        {
            int aux = 0;
            for (int i = 0; i < X.Length; i++)
            {
                aux = aux + X[i];
            }
            return aux / X.Length;
        }

        public int Max(int[] X)
        {
            int aux = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if(X[i] > aux)
                { aux = X[i]; }
            }
            return aux;
        }

        public int Min(int[] X)
        {
            int aux = X[0];
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] < aux)
                { aux = X[i]; }
            }
            return aux;
        }

        public int[] Interseccion(int[] X, int[] Y)
        {
            int a, e = 0;
            for (int i = 0; i < X.Length; i++)
            {
                a = 0;
                for (int j = 0; j < Y.Length; j++)
                {
                    if (X[i] == Y[j])
                    { a = 1; }
                }
                if (a == 1)
                { e++; }
            }
            int[] Z = new int[e];
            a = 0;
            for (int i = 0; i < Y.Length; i++)
            {
                e = 0;
                for (int j = 0; j < X.Length; j++)
                {
                    if (Y[i] == X[j])
                    { e = 1; }
                }
                if (e == 1)
                {
                    Z[a] = Y[i];
                    a++;
                }
            }
            return Z;
        }

        public int[] Union(int[] X, int[] Y)
        {
            int a, e = X.Length;
            for (int i = 0; i < X.Length; i++)
            {
                a = 0;
                for (int j = 0; j < Y.Length; j++)
                {
                    if(X[i] == Y[j])
                    { a = 1; }
                }
                if(a == 0)
                { e++; }
            }
            int[] Z = new int[e];
            for (int i = 0; i < X.Length; i++)
            {
                Z[i] = X[i];
            }
            a = X.Length;
            for (int i = 0; i < Y.Length; i++)
            {
                e = 0;
                for (int j = 0; j < X.Length; j++)
                {
                    if(Y[i] == X[j])
                    { e = 1; }
                }
                if(e == 0)
                {
                    Z[a] = Y[i];
                    a++;
                }
            }
            return Z;
        }

        public int[] diferencia(int[] X, int[] Y)
        {
            int a, e = 0;
            for (int i = 0; i < X.Length; i++)
            {
                a = 0;
                for (int j = 0; j < Y.Length; j++)
                {
                    if (X[i] == Y[j])
                    { a = 1; }
                }
                if (a == 0)
                { e++; }
            }
            int[] Z = new int[e];
            e = 0;
            for (int i = 0; i < X.Length; i++)
            {
                a = 0;
                for (int j = 0; j < Y.Length; j++)
                {
                    if (X[i] == Y[j])
                    {
                        a = 1;
                    }
                }
                if (a == 0)
                {
                    Z[e] = X[i];
                    e++;
                }
            }
            return Z;
        }
    }
}

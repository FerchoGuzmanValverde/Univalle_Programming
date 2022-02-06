using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverticiones
{
    class Operaciones
    {
        Random num = new Random();
        public int[] generar(int[] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = num.Next(1, 51);
            }
            return vec;
        }

        public void intercambiar1(int[] X, int[] y)
        {
            int aux;
            for (int i = 0; i < X.Length; i++)
            {
                aux = X[i];
                X[i] = y[i];
                y[i] = aux;
            }
        }

        public int[] invertir(int[] X)
        {
            int aux;
            for (int i = 0, j = X.Length - 1; i < (X.Length / 2); i++, j--)
            {
                aux = X[i];
                X[i] = X[j];
                X[j] = aux;
            }
            return X;
        }
    }
}

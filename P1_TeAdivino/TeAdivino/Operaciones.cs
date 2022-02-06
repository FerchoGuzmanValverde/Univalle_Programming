using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeAdivino
{
    class Operaciones
    {
        public double aDecimal(int num)
        {
            double result = 0;
            int[] vector = new int[num];
            valor(vector);
            for (int i = vector.Length - 1; i >= 0; i--)
            {
                result = result + (vector[i] * Math.Pow(2, i));
            }
            return result;
        }

        public double Adecimal(int[] vec)
        {
            double result1 = 0;
            for (int i = vec.Length - 1; i >= 0; i--)
            {
                result1 = result1 + (vec[i] * Math.Pow(2, i));
            }
            return result1;
        }

        private void valor(int[] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = 1;
            }
        }

        public int[] aBinario(int tam, int numero)
        {
            int[] result;
            result = new int[tam];
            int i = tam - 1;
            do
            {
                result[i] = numero % 2;
                i--;
                numero = numero / 2;
            }
            while (numero > 0);
            return result;
        }
    }
}

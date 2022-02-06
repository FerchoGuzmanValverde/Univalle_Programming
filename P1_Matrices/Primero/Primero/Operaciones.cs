using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primero
{
    class Operaciones
    {
        Random N = new Random();
        public void generar(int[,] ma1, int[,] ma2)
        {
            for (int i = 0; i < ma1.GetLength(0); i++)
            {
                for (int j = 0; j < ma1.GetLength(1); j++)
                {
                    ma1[i, j] = N.Next(1, 20);
                    ma2[i, j] = N.Next(1, 20);
                }
            }
        }

        public void sumar(int[,] m1, int[,] m2, int[,] suma)
        {
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    suma[i, j] = m1[i, j] + m2[i, j];
                }
            }
        }

        public void diagonales(int[,] m1, int[,] m2, int[] todo)
        {
            for (int i = 0, j = 0; i < m1.GetLength(0); i++, j++)
            {
                todo[0] = todo[0] + m1[i, j];
            }
            for (int i = m1.GetLength(0) - 1, j = 0; i >= 0; i--, j++)
            {
                todo[1] = todo[1] + m1[i, j];
            }
            for (int i = 0, j = 0; i < m2.GetLength(0); i++, j++)
            {
                todo[2] = todo[2] + m2[i, j];
            }
            for (int i = m2.GetLength(0) - 1, j = 0; i >= 0; i--, j++)
            {
                todo[3] = todo[3] + m2[i, j];
            }
        }

        public void columnas(int[,] ma, int[] sumado)
        {
            for (int i = 0; i < sumado.Length; i++)
            {
                sumado[i] = 0;
            }
            for (int i = 0; i < ma.GetLength(1); i++)
            {
                for (int j = 0; j < ma.GetLength(0); j++)
                {
                    sumado[i] = sumado[i] + ma[i, j];
                }
            }
        }

        public void filas(int[,] ma, int[] suma)
        {
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    suma[i] =  suma[i] + ma[j, i];
                }
            }
        }
    }
}

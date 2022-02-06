using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnClases
{
    class Vectores
    {
        Random num = new Random();
        int cont;
        string mensaje;

        public int[] crear(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = num.Next(1, 50);
            }
            return vector;
        }
        
        public int pares(int[] Y)
        {
            cont = 0;
            for (int i = 0; i < Y.Length; i++)
            {
                if(Y[i] % 2 == 0)
                { cont++; }
            }
            return cont;
        }

        public int impares(int[] X)
        {
            cont = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 != 0)
                { cont++; }
            }
            return cont;
        }

        public int promedio(int[] Y)
        {
            int suma = 0, resp;
            for (int i = 0; i < Y.Length; i++)
            {
                suma = suma + Y[i];
            }
            return resp = suma / Y.Length;
        }

        public string comparacion(int[] X, int[] Y)
        {
            for (int i = 0; i < X.Length; i++)
            {
                if(X[i] == Y[i])
                { mensaje = "Los vectores son iguales"; }
                else
                { mensaje = "Los vectores no son iguales"; break; }
            }
            return mensaje;
        }

        public int[] generar(int[] vect)
        {
            for (int i = 0; i < vect.Length; i++)
            {
                vect[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor: "));
            }
            return vect;
        }

        public int mayores(int[] X)
        {
            cont = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] > promedio(X))
                    cont++;
            }
            return cont;
        }
    }
}

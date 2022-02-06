using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40en1
{
    class vectores
    {
        Random num = new Random();

        public void generar(int[] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = num.Next(1, 10);
            }
        }

        public int[] crear(int tam)
        {
            int[] vec = new int[tam];
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese valor"));
            }
            return vec;
        }

        public int[] crearaleatorio()
        {
            int[] creado = new int[10];
            int cont = 0, aux;
            bool aux2;
            while(cont < creado.Length)
            {
                aux = num.Next(1, 11);
                aux2 = comparar(creado, aux);
                if(aux2 == false)
                {
                    creado[cont] = aux;
                    cont++;
                }
            }
            return creado;
        }

        private bool comparar(int[] vec, int com)
        {
            bool result = false;
            for (int i = 0; i < vec.Length; i++)
            {
                if(com == vec[i])
                { result = true; }
            }
            return result;
        }

        public int[] crear2(int numero)
        {
            int[] vector = new int[numero];
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = num.Next(1, numero + 1);
            }
            return vector;
        }

        public string revisar(int[] vec)
        {
            string res = "";
            int pos1 = 0, pos2 = 1;
            while(pos2 < vec.Length)
            {
                if(vec[pos1] <= vec[pos2])
                {
                    res = "El vector esta en Orden";
                    pos1++;
                    pos2++;
                }
                else
                {
                    res = "El vector no esta en orden";
                    pos2 = vec.Length;
                }
            }
            return res;
        }

        public int promedio(int[] vec)
        {
            int pro = 0;
            for (int i = 0; i < vec.Length; i++)
            {
                pro += vec[i];
            }
            pro = pro / vec.Length;
            return pro;
        }

        public int[] MayoP(int[] vec, int pro)
        {
            int con = 0, aux = 0;
            for (int i = 0; i < vec.Length; i++)
            {
                if(vec[i] > pro)
                { con++; }
            }
            int[] newvec = new int[con];
            for (int i = 0; i < vec.Length; i++)
            {
                if(vec[i] > pro)
                {
                    newvec[aux] = vec[i];
                    aux++;
                }
            }
            return newvec;
        }
    }
}

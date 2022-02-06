using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    struct LlaveValor<llave, valor> //actua como clase generica
    {
        public llave L;
        public valor V;

        public LlaveValor(llave a, valor b) //constructor
        {
            L = a;
            V = b;
        }
    } 

    class ClassGen <T> //clase generica
    { 
        T obj = default(T); //valor por defecto

        public static string CopyInsert<T>(T e, int idx, T[] src, T[] target) //metodo generico
        {
            //verifica si el array target es lo suficientemente grande
            if (target.Length < src.Length + 1)
                return "No es lo suficientemente grande";
            //copia los elementos del array source al array target
            for (int i = 0, j = 0; i < src.Length; i++, j++)
            {
                if (i == idx)
                {
                    target[j] = e;
                    j++;
                }
                target[j] = src[i];
            }
            return "Los elementos han sido copiados";
        }
    }
}

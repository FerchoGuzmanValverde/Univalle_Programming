using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Numero
    {
        //Atributos
        private int Number;

        //Constructor
        public Numero(int N)
        { Number = N; }

        //Metodos
        public string Determinar_par_impar()
        {
            int aux = Number % 2;
            if (aux == 0)
                return "El numero es par";
            else
                return "El numero es impar";
        }

        public string Determinar_pos_neg_cero()
        {
            if (Number == 0)
                return "El numero es 0";
            else if (Number < 0)
                return "El numero es negativo";
            else
                return "El numero es positivo";
        }

        public string Determinar_primo()
        {
            int con = 1;
            for (int i = 2; i <= Number; i++)
            {
                if (Number % i == 0)
                    con++;
            }
            if (con == 2)
                return "El numero es primo";
            else
                return "El numero no es primo";
        }

        public void Determinar_perfecto()
        {
            //Que refiere con perfecto??
        }
    }
}

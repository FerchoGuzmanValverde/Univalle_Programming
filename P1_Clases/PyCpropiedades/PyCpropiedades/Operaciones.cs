using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyCpropiedades
{
    class Operaciones
    {
        int grupo; int poblacion;

        public int Grupo
        {
            set
            {
                grupo = value;
            }
        }

        public int Poblacion
        {
            set
            {
                poblacion = value;
            }
        }


        public int permutaciones()
        {
            return fac(poblacion) / fac(poblacion - grupo);
        }

        public int combinaciones()
        {
            return fac(poblacion) / (fac(poblacion - grupo) * fac(grupo));
        }

        int fac(int x)
        {
            int res = 1;
            for (int i = 1; i <= x; i++)
            {
                res = res * i;
            }
            return res;
        }
    }
}

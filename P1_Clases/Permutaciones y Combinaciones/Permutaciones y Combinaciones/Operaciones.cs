using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutaciones_y_Combinaciones
{
    class Operaciones
    {
        public int Combinaciones(int x, int y)
        {
            return fac(x) / (fac(x - y) * fac(y));
        }

        public int Permutaciones(int x, int y)
        {
            return fac(x) / fac(x - y);
        }

        int fac(int x)
        {
            int res = 1, a = 2;
            for (int i = 1; i < x; i++)
            {
                res = res * a;
                a++;
            }
            return res;
        }
    }
}

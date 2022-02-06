using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40en1
{
    class Secuenciales
    {
        public int salario(int dias, int pago)
        {
            int res = dias * pago;
            return res;
        }

        public float promedio(float n1, float n2, float n3)
        {
            float res = (((((n1 + n2))/2)*0.7f)+(n3 * 0.3f));
            return res;
        }

        public float[] reparto(float[] vec, int monto)
        {
            vec[0] = monto * 0.37f;
            vec[1] = monto * 0.42f;
            vec[2] = monto * 0.21f;
            return vec;
        }

        public void hijos(float[] vecto, int cap)
        {
            vecto[0] = cap * 0.4f;
            float rest = cap - vecto[0];
            vecto[1] = rest * 0.7f;
            vecto[2] = rest - vecto[1];
        }

        public float total(int vh, int ht, int an)
        {
            float res = (((vh * ht) + an) * 30);
            return res;
        }

        private double incrementar(double precio, double cuotai)
        {
            return (precio - cuotai) * 0.2; 
        }

        public double cuota(double precio, double cuotai)
        {
            return (precio + incrementar(precio, cuotai)) / 24;
        }

        public double final(double precio, double cuotai)
        {
            return (cuota(precio, cuotai) * 24) + cuotai;
        }
    }
}

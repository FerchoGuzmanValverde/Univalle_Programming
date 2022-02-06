using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5herencia
{
    class empleado : persona
    {
        private double sueldo;

        public empleado(string n, int a, double s) : base(n, a)
        {

            sueldo = s;
        }

        public override double Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = value;
            }
                }

       /* public override double calc_sueldo()
        {
            double st;
            st = sueldo - sueldo * 0.1271;
            return st;

        }*/
    }
}

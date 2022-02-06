using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6polimorfismo
{
    class circulo
    {
        protected double radio;

        public circulo(double r)
        {
            radio = r;
        }

        public virtual double calc_area()
        {
            return 3.1416 * radio * radio;

        }

        public virtual string mostrar()
        {
            return "Tiene un radio de:" + radio;
        }
    }
}

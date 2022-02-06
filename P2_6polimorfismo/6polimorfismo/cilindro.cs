using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6polimorfismo
{
    class cilindro : circulo
    {
        private double altura;

        public cilindro(double r, double a) : base(r)
        {
            altura = a;
        }

        public override double calc_area()
        {
            double x;
            //return  3.1416 * radio * radio * altura;
            x = base.calc_area();
            return base.calc_area() * altura;
        }

        public override string mostrar()
        {
            return base.mostrar()+"y su altura es"+altura;
        }

    }
}

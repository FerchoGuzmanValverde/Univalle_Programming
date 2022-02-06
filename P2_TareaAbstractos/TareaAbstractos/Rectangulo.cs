using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAbstractos
{
    class Rectangulo:Figura
    {
        double @base;
        double alto;

        public Rectangulo(string color, double Base, double Alto) : base(color)
        {
            @base = Base;
            alto = Alto;
        }

        public double Base
        {
            set { @base = value; }
            get { return @base; }
        }

        public double Alto
        {
            set { alto = value; }
            get { return alto; }
        }

        public override string CalcularArea()
        {
            return "El area es: " + (@base * alto);
        }

        public override string CalcularPerimetro()
        {
            return "El perimetro es: " + ((2 * alto) + (2 * @base));
        }
    }
}

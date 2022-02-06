using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAbstractos
{
    class Triangulo:Figura
    {
        double @base, altura;

        public Triangulo(string color, double Base, double Altura):base(color)
        {
            @base = Base; altura = Altura;
        }

        public double Base
        {
            set { @base = value; }
            get { return @base; }
        }
        public double Altura
        {
            set { altura = value; }
            get { return altura; }
        }

        public override string CalcularArea()
        {
            return "El area del triangulo es: " + (@base * altura);
        }

        public override string CalcularPerimetro()
        {
            return "El perimetro del triangulo es: " + (@base * 3);
        }
    }
}

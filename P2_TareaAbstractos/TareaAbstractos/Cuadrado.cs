using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAbstractos
{
    class Cuadrado:Figura
    {
        double lado;

        public Cuadrado(string color, double Lado):base(color)
        {
            lado = Lado;
        }

        public double Lado
        {
            set { lado = value; }
            get { return lado; }
        }

        public override string CalcularArea()
        {
            return "El area del cuadrado es: " + (Math.Pow(lado, 2));
        }

        public override string CalcularPerimetro()
        {
            return "El perimtro de un cuadrado es: " + (lado + lado);
        }
    }
}

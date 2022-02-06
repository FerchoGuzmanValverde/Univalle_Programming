using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAbstractos
{
    class Circulo: Figura,Dibujable
    {
        double radio;

        public Circulo(string color, double Radio):base(color)
        {
            radio = Radio;
        }

        public override string CalcularArea()
        {
            return "El area es " + (radio * 2);
        }
        public override string CalcularPerimetro()
        {
            return "Complemento";
        }
        public void dibujar()
        {

        }
    }
}

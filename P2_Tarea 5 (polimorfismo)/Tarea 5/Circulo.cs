using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    class Circulo:Punto
    {
        int radio;

        public Circulo(int X, int Y, int Radio):base(X, Y)
        {
            radio = Radio;
        }

        public int Radio
        {
            set { radio = value; }
            get { return radio; }
        }

        public override string mostrar()
        {
            return base.mostrar() + "  radio: " + radio;
        }
        public string calcularDiametro()
        {
            return "El diametro es: " + (radio * 2).ToString("N2");
        }
        public string calcularArea()
        {
            return "El area es: " + (Math.PI * Math.Pow(radio, 2)).ToString("N2");
        }
        public string calcularCircunferencia()
        {
            return "La circunferencia es: " + (2 * Math.PI * radio).ToString("N2");
        }
    }
}

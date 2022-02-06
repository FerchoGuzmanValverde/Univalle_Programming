using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Caja
    {
        protected double ancho;
        protected double alto;
        protected double largo;

        public Caja(double An, double Al, double La)
        {
            ancho = An;
            alto = Al;
            largo = La;
        }

        public double Ancho
        {
            get { return ancho; }
        }
        public double Alto
        {
            get { return alto; }
        }
        public double Largo
        {
            get { return largo; }
        }

        public string esCubo()
        {
            if (ancho == alto && alto == largo)
                return "Es un cubo";
            else
                return "No es un cubo";
        }
    }
}

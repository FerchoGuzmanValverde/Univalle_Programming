using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class CajaPeso:Caja
    {
        double peso;

        public CajaPeso(double An, double Al, double La, double Peso):base(An, Al, La)
        {
            peso = Peso;
        }

        public double Peso
        {
            get { return peso; }
        }

        public string calPesoTotal()
        {
            if (ancho == alto && alto == largo)
                return "El peso total es: " + (peso + (peso * 0.02));
            else
                return "El peso total es: " + (peso + (peso * 0.03));
        }
    }
}

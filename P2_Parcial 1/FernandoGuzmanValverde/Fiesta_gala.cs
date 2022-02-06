using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandoGuzmanValverde
{
    class Fiesta_gala:Fiesta
    {
        bool opcionSaludable;

        public Fiesta_gala(int nroP, double costoC, bool dec, bool opcion):base(nroP, costoC, dec)
        {
            opcionSaludable = opcion;
        }

        public bool OpcionSaludable
        {
            get { return opcionSaludable; }
            set { opcionSaludable = value; }
        }

        public override double CalcularCostoComida()
        {
            if(opcionSaludable == false)
                return base.CalcularCostoComida();
            else
                return (CostoComida + 40) * NroPersonas;
        }
    }
}

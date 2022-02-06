using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandoGuzmanValverde
{
    class Fiesta
    {
        int nroPersonas;
        double costoComidaPorPersona;
        bool decoracion;

        public Fiesta(int numeroP, double costoComida, bool deco)
        {
            nroPersonas = numeroP;
            costoComidaPorPersona = costoComida;
            decoracion = deco;
        }

        public int NroPersonas
        {
            get { return nroPersonas; }
            set { nroPersonas = value; }
        }
        public double CostoComida
        {
            get { return costoComidaPorPersona; }
            set { costoComidaPorPersona = value; }
        }
        public bool Decoracion
        {
            get { return decoracion; }
            set { decoracion = value; }
        }


        public virtual string CalcularCostoDecoracion()
        {
            if(decoracion==true)
            {
                double total = 160;
                if(nroPersonas > 20)
                { total = 220; }
                return "El costo de decoracion es: " + (total * nroPersonas);
            }
            else
            {
                return "No solicito decoracion";
            }
        }

        public virtual double CalcularCostoComida()
        {
            return (nroPersonas * costoComidaPorPersona);
        }
    }
}

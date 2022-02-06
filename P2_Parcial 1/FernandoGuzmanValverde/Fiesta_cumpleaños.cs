using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandoGuzmanValverde
{
    class Fiesta_cumpleaños:Fiesta
    {
        bool tamañoPastel;
        //No esta correcto colocar una fecha de cumpleaños y fecha actual y realizar una comparacion. Ya que la cotizacion se realiza 1 sola vez
        int restante;

        public Fiesta_cumpleaños(int nroP, double costoC, bool dec, bool pas, int res):base(nroP, costoC, dec)
        {
            tamañoPastel = pas;
            restante = res;
        }

        public bool Tamaño
        {
            get { return tamañoPastel; }
            set { tamañoPastel = value; }
        }
        public int Faltante
        {
            get { return restante; }
            set { restante = value; }
        }

        public string CalcularCostoPastel()
        {
            double porcion;
            if(tamañoPastel == false)
            {
                if(NroPersonas < 25)
                {
                    porcion = 20;
                }
                else if(NroPersonas >= 25 && NroPersonas <= 50)
                {
                    porcion = 15;
                }
                else
                {
                    porcion = 12;
                }
            }
            else
            {
                if(restante >= 30)
                {
                    porcion = 11;
                }
                else
                {
                    porcion = 17;
                }
            }
            return "El costo del paste es: " + (porcion * NroPersonas);
        }
    }
}

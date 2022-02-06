using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Usuario
    {
        string nombreID;
        int numeroPIN;

        public Usuario(string nom, int pin)
        {
            if(nom.Length < 6)
            {
                throw new Exception("No se puede ingresar nombre id menores a 6 caracteres");
            }
            else
            {
                nombreID = nom;
            }
            if(pin < 1)
            {
                throw new Exception("Debe ingresar un valor mayor a 0 como pin");
            }
            else
            {
                numeroPIN = pin;
            }
        }

        public string NombreID
        {
            get { return nombreID; }
            set
            {
                if(value.Length < 6)
                {
                    throw new Exception("No puede asignar nombre de menos de 6 caracteres");
                }
                else
                {
                    nombreID = value;
                }
            }
        }

        public int NumeroPin
        {
            get { return numeroPIN; }
            set
            {
                if(value < 1)
                {
                    throw new Exception("Solo se puede asignar valores mayores a 0 como pin");
                }
                else
                {
                    numeroPIN = value;
                }
            }
        }
    }
}

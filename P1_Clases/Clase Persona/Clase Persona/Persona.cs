using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Persona
{
    class Persona
    {
        string nombre;
        byte edad;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public byte Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public string registrar()
        {
            return nombre + "\t" + edad;
        }
    }
}

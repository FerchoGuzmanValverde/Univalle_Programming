using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEventos2
{
    class Persona
    {
        string nombre;
        int ci, edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public int CI
        {
            get { return ci; }
            set { ci = value; }
        }
    }
}

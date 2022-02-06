using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasDeObjetos
{
    class persona
    {
        private string nombre;
        private int carnet;

        public persona(string n, int c)
        {
            nombre = n;
            carnet = c;
        }

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

        public int Carnet
        {
            get
            {
                return carnet;
            }
            set
            {
                carnet = value;
            }
            
    }
}
}

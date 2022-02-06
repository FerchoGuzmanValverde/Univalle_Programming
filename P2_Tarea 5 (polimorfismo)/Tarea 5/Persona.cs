using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    class Persona
    {
        protected string nombre;
        protected int edad;
        protected double peso;

        public Persona(string Nombre, int Edad, double Peso)
        {
            nombre = Nombre; edad = Edad; peso = Peso;
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Edad
        {
            set { edad = value; }
            get { return edad; }
        }
        public double Peso
        {
            set { peso = value; }
            get { return peso; }
        }

        public virtual string mostrar()
        {
            return "Nombre: " + nombre + "\nEdad: " + edad + "\nPeso: " + peso;
        }
    }
}

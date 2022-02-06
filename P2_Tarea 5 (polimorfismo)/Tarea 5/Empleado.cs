using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    class Empleado:Persona
    {
        protected int aAntiguedad;
        protected int sueldo;
        protected string area;

        public Empleado(string nombre, int edad, double peso, int Antiguedad, int Sueldo, string Area):base(nombre, edad, peso)
        {
            aAntiguedad = Antiguedad; sueldo = Sueldo; area = Area;
        }

        public int Antiguedad
        {
            set { aAntiguedad = value; }
            get { return aAntiguedad; }
        }
        public int Sueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }
        public string Area
        {
            set { area = value; }
            get { return area; }
        }

        public override string mostrar()
        {
            return base.mostrar() + "\nAntiguedad: " + aAntiguedad + "\nSueldo: " + sueldo + "\nArea: " + area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    class Secretario:Empleado
    {
        int palabrasMinuto;
        string jefe;

        public Secretario(string nombre, int edad, double peso, int antiguedad, int sueldo, string area, int pM, string Jefe):base(nombre, edad, peso, antiguedad, sueldo, area)
        {
            palabrasMinuto = pM; jefe = Jefe;
        }

        public int PM
        {
            set { palabrasMinuto = value; }
            get { return palabrasMinuto; }
        }
        public string JEFE
        {
            set { jefe = value; }
            get { return jefe; }
        }

        public override string mostrar()
        {
            return base.mostrar() + "\nPalabra/Minuto: " + palabrasMinuto + "\nJefe: " + jefe;
        }
    }
}

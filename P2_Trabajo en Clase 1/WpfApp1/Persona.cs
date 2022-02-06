using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Persona
    {
        //Atributos
        private string nombre;
        private int Nacimiento;
        private int Edad;

        //Constructor
        public Persona(string name, int Fecha, int actual)
        {
            nombre = name;
            Nacimiento = Fecha;
            Edad = actual - Nacimiento;
        }

        //Metodos
        public string Calcular_edad()
        {
            return "Su edad es: " + Edad;
        }

        public string Determinar_mayor_edad()
        {
            if (Edad >= 18)
                return "Usted es mayor de edad";
            else
                return "Usted es menor de edad";
        }
    }
}

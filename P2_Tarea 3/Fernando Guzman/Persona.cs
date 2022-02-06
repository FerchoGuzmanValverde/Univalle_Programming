using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando_Guzman
{
    class Persona
    {
        string nombre;
        int añoNacimiento;
        int Edad;

        public Persona(string Nombre, int añoNacido)
        {
            nombre = Nombre;
            añoNacimiento = añoNacido;
        }

        public string calcularEdad(int añoActual)
        {
            Edad = añoActual - añoNacimiento;
            return "Su edad es: " + Edad;
        }

        public string determinarMayor()
        {
            if (Edad > 18)
                return "Es mayor de edad";
            else
                return "Es menos de edad";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscador
{
    class Acciones
    {
        int peso;
        double estatura;
        string nombre, apellido;

        public int Peso
        {   set { peso = value; }}
        public double Estatura
        { set { estatura = value; }}
        public string Nombre
        { set{ nombre = value; }}
        public string Apellido
        { set { apellido = value; } }

        public string Codigo()
        {
            string codigo = nombre[0].ToString() + apellido[0].ToString() + peso.ToString();
            return codigo;
        }

        public double IMC(double entero)
        {
            entero = (peso / (estatura * estatura));
            return entero;
        }

        public string observacion(double imc)
        {
            string observa = "";
            if(imc < 18)
            { observa = "Por debajo del peso"; }
            else if(imc > 17 && imc < 25)
            { observa = "Saludable"; }
            else if(imc > 24 && imc < 30)
            { observa = "Con sobrepeso"; }
            else if(imc > 29 && imc < 40)
            { observa = "Obeso"; }
            else if(imc > 39)
            { observa = "Obesidad extrema"; }
            return observa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando_Guzman
{
    class Numero
    {
        double numero;

        public Numero(double Nume)
        {
            numero = Nume;
        }

        public string valorAbsoluto()
        {
            if (numero < 0)
                return "El valor absoluto es: " + (- numero);
            else
                return "El valor absoluto es: " + numero;
        }
        public string potential(int potencia)
        {
            return "La potencia es: " + Math.Pow(numero, potencia);
        }
        public string raizCuadrada()
        {
            return "La raiz cuadrada es: " + Math.Sqrt(numero).ToString("N2");
        }
        public string seno()
        {
            return "El seno es: " + Math.Sin(numero).ToString("N2");
        }
        public string coseno()
        {
            return "El coseno es: " + Math.Cos(numero).ToString("N2");
        }
        public string numMax(int comparador)
        {
            if (comparador > numero)
                return "El numero mayor es: " + comparador;
            else
                return "El numero mayor es: " + numero;
        }
        public string numMin(int comparador)
        {
            if(comparador < numero)
                return "El numero mayor es: " + comparador;
            else
                return "El numero mayor es: " + numero;
        }
        public string parteEntera()
        {
            return "La parte entera es: " + Math.Truncate(numero);
        }
        public string redondeo()
        {
            return "El redondeo es: " + Math.Round(numero);
        }
    }
}

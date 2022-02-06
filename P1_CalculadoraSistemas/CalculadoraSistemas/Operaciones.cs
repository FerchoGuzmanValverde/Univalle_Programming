using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSistemas
{
    class Operaciones
    {
        public int numero;
        public virtual int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public virtual string ADecimal()
        {
            string binario = Numero.ToString();
            string result1 = "";
            for (int i = binario.Length - 1; i >= 0; i--)
            {
                result1 = result1 + (binario[i] * Math.Pow(2, i));
            }
            return result1;
        }

        public virtual string aBinario()
        {
            string binario = "0";
            while(numero > 0)
            {
                binario = Convert.ToString(numero % 2) + binario;
                numero = numero / 2;
            }
            return binario;
        }

        public virtual string aHexadecimal()
        {
            int modulo;
            string hexadecimal = "", aux;
            while(numero > 15)
            {
                modulo = numero % 16;
                aux = modulo.ToString();
                switch (modulo)
                {
                    
                    case 10:
                        aux = "A";
                        break;
                    case 11:
                        aux = "B";
                        break;
                    case 12:
                        aux = "C";
                        break;
                    case 13:
                        aux = "D";
                        break;
                    case 14:
                        aux = "E";
                        break;
                    case 15:
                        aux = "F";
                        break;
                }
                hexadecimal = aux + hexadecimal;
                numero = numero / 16;
            }
            aux = numero.ToString();
            switch (numero)
            {

                case 10:
                    aux = "A";
                    break;
                case 11:
                    aux = "B";
                    break;
                case 12:
                    aux = "C";
                    break;
                case 13:
                    aux = "D";
                    break;
                case 14:
                    aux = "E";
                    break;
                case 15:
                    aux = "F";
                    break;
            }
            hexadecimal = aux + hexadecimal;
            return hexadecimal;
        }

        public virtual string aOctal()
        {
            string octal = "";
            while(numero > 7)
            {
                octal = Convert.ToString(numero % 8) + octal;
                numero = numero / 8;
            }
            octal = numero + octal;
            return octal;
        }
    }
}

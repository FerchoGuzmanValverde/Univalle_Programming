using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSistemas
{
    class Hexadecimal:Operaciones
    {
        Operaciones ayuda = new Operaciones();
        Binarios Operar = new Binarios();
        private string hexade, apoyo;

        public string Hexade
        {
            set { hexade = value; }
            get { return hexade; }
        }

        public override string aBinario()
        {
            string binario = "";
            for (int i = 0; i < hexade.Length; i++)
            {
                binario += Bin(hexade[i].ToString());
            }
            return binario;
        }

        string Bin(string num)
        {
            switch(num)
            {
                case "0":
                    return "0000";
                case "1":
                    return "0001";
                case "2":
                    return "0010";
                case "3":
                    return "0011";
                case "4":
                    return "0100";
                case "5":
                    return "0101";
                case "6":
                    return "0110";
                case "7":
                    return "0111";
                case "8":
                    return "1000";
                case "9":
                    return "1001";
                case "A":
                    return "1010";
                case "B":
                    return "1011";
                case "C":
                    return "1100";
                case "D":
                    return "1101";
                case "E":
                    return "1110";
                case "F":
                    return "1111";
            }
            return "0";
        }

        public double aDecimal()
        {
            double deci = 0; string aux; int count = 0;
            for (int i = hexade.Length - 1; i >= 0; i--)
            {
                aux = hexade[i].ToString();
                switch (aux)
                {
                    case "A":
                        aux = "10";
                        break;
                    case "B":
                        aux = "11";
                        break;
                    case "C":
                        aux = "12";
                        break;
                    case "D":
                        aux = "13";
                        break;
                    case "E":
                        aux = "14";
                        break;
                    case "F":
                        aux = "15";
                        break;
                }
                deci += (int.Parse(aux) * Math.Pow(16, count));
                count++;
            }
            return deci;
        }

        public override string aOctal()
        {
            string binario = aBinario();
            Operar.binario = binario;
            return Operar.aOctal();
        }
    }
}

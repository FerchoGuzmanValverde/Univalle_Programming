using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSistemas
{
    class Octal:Operaciones
    {
        Binarios opera = new Binarios();
        string octa;

        public string Octa
        {
            set { octa = value; }
            get { return octa; }
        }

        public override string aBinario()
        {
            string binario = "";
            for (int i = 0; i < octa.Length; i++)
            {
                binario += Bin(octa[1].ToString());
            }
            return binario;
        }

        string Bin(string num)
        {
            switch(num)
            {
                case "0":
                    return "000";
                case "1":
                    return "001";
                case "2":
                    return "010";
                case "3":
                    return "011";
                case "4":
                    return "100";
                case "5":
                    return "101";
                case "6":
                    return "110";
                case "7":
                    return "111";
            }
            return "0";
        }

        public double aDecimal()
        {
            double deci = 0;
            int con = 0;
            for (int i = octa.Length; i >= 0; i--)
            {
                deci += (int.Parse(octa[i].ToString()) * Math.Pow(8, con));
                con++;
            }
            return deci;
        }

        public override string aHexadecimal()
        {
            string bin = aBinario();
            opera.binario = bin;
            return opera.aHexadecimal();
        }
    }
}

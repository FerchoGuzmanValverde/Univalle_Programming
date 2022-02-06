using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSistemas
{
    class Binarios : Operaciones
    {
        Operaciones transformar = new Operaciones();
        public string binario, apoyo;

        public string Binario
        {
            set { binario = value; }
            get { return binario; }
        }

        public override string ADecimal()
        {
            int result = 0, cont = 0;
            for (int i = binario.Length - 1; i >= 0; i--)
            {
                if(binario[i] == '1')
                {
                    result = result + (int)Math.Pow(2, cont);
                }
                cont++;
            }
            return result.ToString();
        }

        public override string aOctal()
        {
            string b = binario + "";
            string oct = "";
            int separaciones = binario.Length / 3;
            if(separaciones % 3 > 0)
            { separaciones++; }
            for (int i = binario.Length; i < separaciones * 3; ++i)
            { b = "0" + b; }
            for (int i = 0; i < separaciones; ++i)
            { oct = Oct(b.Substring((i * 3), 3)); }
            return oct;
        }

        private string Oct(string num)
        {
            if(num == "000")
            { return "0"; }
            else if(num == "001")
            { return "1"; }
            else if(num == "010")
            { return "2"; }
            else if(num == "011")
            { return "3"; }
            else if(num == "100")
            { return "4"; }
            else if(num == "101")
            { return "5"; }
            else if(num == "110")
            { return "6"; }
            else if(num == "111")
            { return "7"; }
            return 0.ToString();
        }
    
        public override string aHexadecimal()
        {
            string hexadecimal = "", b = binario + "";
            int separaciones = binario.Length / 4;
            if(separaciones % 4 > 0)
            { separaciones++; }
            for(int i = binario.Length; i < separaciones * 4; ++i)
            { b = "0" + b; }
            for(int i = 0; i < separaciones; ++i)
            { hexadecimal += Hexa(b.Substring((i * 4), 4)); }
            return hexadecimal;
        }

        string Hexa(string num)
        {
            if(num == "0000")
            { return "0"; }
            else if(num == "0001")
            { return "1"; }
            else if(num == "0010")
            { return "2"; }
            else if(num == "0011")
            { return "3"; }
            else if(num == "0100")
            { return "4"; }
            else if(num == "0101")
            { return "5"; }
            else if(num == "0110")
            { return "6"; }
            else if(num == "0111")
            { return "7"; }
            else if(num == "1000")
            { return "8"; }
            else if(num == "1001")
            { return "9"; }
            else if(num == "1010")
            { return "A"; }
            else if(num == "1011")
            { return "B"; }
            else if(num == "1100")
            { return "C"; }
            else if(num == "1101")
            { return "D"; }
            else if(num == "1110")
            { return "E"; }
            else if(num == "1111")
            { return "F"; }
            return 0.ToString();
        }
    }
}

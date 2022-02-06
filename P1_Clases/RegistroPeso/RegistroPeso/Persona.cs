using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPeso
{
    class Persona
    {
        int c1=0, c2=0, c3=0, c4=0, c5=0, c6=0, c7=0, c8=0;
        float peso, estatura, ideal;
        string categoria;

        public float Peso
        { set { peso = value; } }
        public float Estatura
        { set { estatura = value; } }

        public float Ideal()
        {
            ideal = peso / (estatura * estatura);
            return ideal;
        }
        public string categorizar()
        {
            if(ideal < 16)
            { categoria = "Criterio de ingreso en hospital \t C1"; c1++; }
            else if(ideal > 15 && ideal < 18)
            { categoria = "infrapeso \t C2"; c2++; }
            else if(ideal > 17 && ideal < 19)
            { categoria = "bajo peso \t C3"; c3++; }
            else if(ideal > 18 && ideal < 26)
            { categoria = "Peso normal (saludable) \t C4"; c4++; }
            else if(ideal > 25 && ideal < 31)
            { categoria = "Sobrepeso \t C5"; c5++; }
            else if(ideal > 30 && ideal < 36)
            { categoria = "Sobrepeso Cronico \t C6"; c6++; }
            else if(ideal > 35 && ideal < 41)
            { categoria = "Obesidad Pre-morbida \t C7"; c7++; }
            else if(ideal > 40)
            { categoria = "Obesidad Morbida \t C8"; c8++; }
            return categoria;
        }
        public int C1()
        { return c1; }
        public int C2()
        { return c2; }
        public int C3()
        { return c3; }
        public int C4()
        { return c4; }
        public int C5()
        { return c5; }
        public int C6()
        { return c6; }
        public int C7()
        { return c7; }
        public int C8()
        { return c8; }
    }
}

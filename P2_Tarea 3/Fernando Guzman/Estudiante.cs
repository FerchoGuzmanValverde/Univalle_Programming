using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando_Guzman
{
    class Estudiante
    {
        string nombre;
        double parcial1, parcial2, examenFinal;
        double Nota;

        public Estudiante(string Nombre, double par1, double par2, double examenfinal)
        {
            nombre = Nombre;
            parcial1 = par1;
            parcial2 = par2;
            examenFinal = examenfinal;
        }

        public string calcularNotaFinal(int pP1, int pP2, int pP3)
        {
            Nota = ((parcial1 * pP1) / 100) + ((parcial2 * pP2) / 100) + ((examenFinal * pP3) / 100);
            return "Su nota es: " + Nota;
        }

        public string detApRep()
        {
            if (Nota > 50)
                return "Ustede Aprovo";
            else
                return "Usted Reprovo";
        }
    }
}

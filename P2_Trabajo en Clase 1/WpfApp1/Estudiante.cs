using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Estudiante
    {
        //Atributos
        private string Nombre;
        private int parcial_1;
        private int parcial_2;
        private int Examen_final;

        //Constructor
        public Estudiante(string name, int n1, int n2, int final)
        {
            Nombre = name;
            parcial_1 = n1;
            parcial_2 = n2;
            Examen_final = final;
        }

        //Metodos
        public string Nota_Final()
        {
            return "Su nota final es: " + ((((parcial_1 + parcial_2) / 2) * 0.7) + (Examen_final * 0.3));
        }

        public string Aprivado_Reprovado()
        {
            float nota = ((((parcial_1 + parcial_2) / 2f) * 0.7f) + (Examen_final * 0.3f));
            if (nota > 50)
                return "Usted aprovo";
            else
                return "Usted reprovo";
        }
    }
}

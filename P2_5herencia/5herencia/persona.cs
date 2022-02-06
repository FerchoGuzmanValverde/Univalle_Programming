using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5herencia
{
   abstract class persona
    {
        protected string nombre;
        protected int a_nacim;

         public persona(string n, int a)
         {
             nombre = n;
             a_nacim = a;
         }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int A_nacim
        {
            get
            {
                return a_nacim;
            }
            set
            {
                a_nacim = value;
            }
        }
        //propiedad abstracta
        public abstract double Sueldo
        {
            get; set;
        }
        public int calcular_edad(int aa)
        {
            return aa - a_nacim;
        }
        //metodo abstracto
        public abstract double calc_sueldo();
  

    }
}

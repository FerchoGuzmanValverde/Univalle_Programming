using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAbstractos
{
    class Cuadrado2:Rotable,Dibujable
    {
        int lado;

        public string Area()
        {
            return "El area es " + (lado * 2);
        }

        public void rotar()
        {
            //Que significa rotar?
        }

        public void dibujar()
        {
            
        }
    }

}

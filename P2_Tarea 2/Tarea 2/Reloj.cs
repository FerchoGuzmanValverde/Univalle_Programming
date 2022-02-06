using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class Reloj
    {
        //Propiedades
        int hora, minuto, segundo;
        string aux = "am";

        //Metodo Propiedades
        public int Hora
        {
            set
            {
                if (value < 25)
                    hora = value;
            }
        }
        public int Minuto
        {
            set
            {
                if (value < 60)
                    minuto = value;
            }
        }
        public int Segundo
        {
            set
            {
                if (value < 60)
                    segundo = value;
            }
        }

        //Metodos
        public string mostrarHoraF12()
        {
            cambiar();
            return hora + ":" + minuto + ":" + segundo + " " + aux;
         }

        public string mostrarHoraF24()
        {
            return hora + ":" + minuto + ":" + segundo;
        }

        private void cambiar()
        {
            if(hora > 12)
            {
                aux = "pm";
                if (hora == 13)
                    hora = 1;
                else if (hora == 12)
                    hora = 2;
                else if (hora == 15)
                    hora = 3;
                else if (hora == 16)
                    hora = 4;
                else if (hora == 17)
                    hora = 5;
                else if (hora == 18)
                    hora = 6;
                else if (hora == 19)
                    hora = 7;
                else if (hora == 20)
                    hora = 8;
                else if (hora == 21)
                    hora = 9;
                else if (hora == 22)
                    hora = 10;
                else if (hora == 23)
                    hora = 11;
                else if (hora == 24)
                    hora = 12;
            }
        }
    }
}

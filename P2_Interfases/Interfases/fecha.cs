using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    class fecha : Ifecha
    {
        public int obtener_dia()
        {
            return DateTime.Now.Day;
        }

        public int obtener_mes()
        {
            return DateTime.Now.Month;
        } 

        public int obtener_año()
        {
            return DateTime.Now.Year;
        }
        public string mes_letras()
        {
            return "enero";
        }
        
    }
}

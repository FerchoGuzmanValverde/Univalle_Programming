using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Horas
    {
        DateTime horaEntrada, horaSalida, entradaEmpleado, salidaEmpleado;

        public Horas(DateTime he, DateTime hs)
        {
            if (he.Hour < 0 || he.Hour > 23 || hs.Hour < 0 || hs.Hour > 23)
                throw new Exception("Ninguna de las horas puede ser menor a 0 o mayor a 23");
            else if (he.Minute < 0 || he.Minute > 59 || hs.Minute < 0 || hs.Minute > 59)
                throw new Exception("Ninguno de los minutos puede ser menor a 0 o mayor a 59");
            else if (he.Second < 0 || he.Second > 59 || hs.Second < 0 || hs.Second > 59)
                throw new Exception("Ninguno de los segundos puede ser menor a 0 o mayor a 59");
            else
            {
                horaEntrada = he;
                horaSalida = hs;
            }
        }

        public DateTime EntradaEmpleado
        {
            set
            {
                if (value.Hour < 0 || value.Hour > 23 || value.Hour < 0 || value.Hour > 23)
                    throw new Exception("Ninguna de las horas puede ser menor a 0 o mayor a 23");
                else if (value.Minute < 0 || value.Minute > 59 || value.Minute < 0 || value.Minute > 59)
                    throw new Exception("Ninguno de los minutos puede ser menor a 0 o mayor a 59");
                else if (value.Second < 0 || value.Second > 59 || value.Second < 0 || value.Second > 59)
                    throw new Exception("Ninguno de los segundos puede ser menor a 0 o mayor a 59");
                else
                {
                    entradaEmpleado = value;
                }
            }
        }

        public DateTime SalidaEmpleado
        {
            set
            {
                if (value.Hour < 0 || value.Hour > 23 || value.Hour < 0 || value.Hour > 23)
                    throw new Exception("Ninguna de las horas puede ser menor a 0 o mayor a 23");
                else if (value.Minute < 0 || value.Minute > 59 || value.Minute < 0 || value.Minute > 59)
                    throw new Exception("Ninguno de los minutos puede ser menor a 0 o mayor a 59");
                else if (value.Second < 0 || value.Second > 59 || value.Second < 0 || value.Second > 59)
                    throw new Exception("Ninguno de los segundos puede ser menor a 0 o mayor a 59");
                else
                {
                    salidaEmpleado = value;
                }
            }
        }

        public string DeterminarEntrada()
        {
            if (horaEntrada.Hour < entradaEmpleado.Hour)
                return "Ha llegado temprano";
            else if (horaEntrada.Hour == entradaEmpleado.Hour)
                return "Ha llegado puntual";
            else
                return "Ha llegado tarde";
        }

        public string DeterminarSalida()
        {
            if (horaSalida.Hour < salidaEmpleado.Hour)
                return "Ha salido temprano";
            else if (horaSalida.Hour == salidaEmpleado.Hour)
                return "Ha salido puntual";
            else
                return "Ha salido tarde";
        }
    }
}

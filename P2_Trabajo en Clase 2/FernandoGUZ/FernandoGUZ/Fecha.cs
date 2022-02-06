using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandoGUZ
{
    class fecha
    {
        //propiedades
        int dia, mes, año;

        //metodo propiedades
        public int Dia
        {
            set
            {
                if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (value < 32 && value > 0)
                        dia = value;
                }
                else if(mes == 4|| mes == 6 || mes == 9 || mes == 11)
                {
                    if (value < 31 && value > 0)
                        dia = value;
                }
                else
                {
                    int aux = metodoaux();
                    if(aux == 1)
                    {
                        if (value < 30 && value > 0)
                            dia = value;
                    }
                    else
                    {
                        if (value < 29 && value > 0)
                            dia = value;
                    }
                }
            }
        }
        public int Mes
        {
            set
            {
                if (value <= 12 && value >= 1)
                    mes = value;
            }
        }
        public int Year
        {
            set
            {
                if (value > 0)
                    año = value;
            }
        }

        //Metodos
        public string MostrarFechaCorta()
        {
            return dia + "/" + mes + "/" + año;
        }

        public string MostrarFechaLarga()
        {
            string auxmes = auxmmetodo();
            return dia + " de " + auxmes + " de " + año;
        }

        public string MesLetras()
        {
            return auxmmetodo();
        }

        public string Bisiesto()
        {
            int bi = metodoaux();
            if (bi == 1)
                return "Es Biciesto";
            else
                return "No es Biciesto";
        }

        private int metodoaux()
        {
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                return 1;
            }
            else
                return 0;
        }

        private string auxmmetodo()
        {
            if (mes == 1)
                return "Enero";
            else if (mes == 2)
                return "Febrero";
            else if (mes == 3)
                return "Marzo";
            else if (mes == 4)
                return "Abril";
            else if (mes == 5)
                return "Mayo";
            else if (mes == 6)
                return "Junio";
            else if (mes == 7)
                return "Julio";
            else if (mes == 8)
                return "Agosto";
            else if (mes == 9)
                return "Septiembre";
            else if (mes == 10)
                return "Octubre";
            else if (mes == 11)
                return "Noviembre";
            else
                return "Diciembre";
        }
    }
}

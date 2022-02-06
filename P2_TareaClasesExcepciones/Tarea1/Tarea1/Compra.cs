using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Compra
    {
        byte cantidad;
        char tipo;
        bool tarjeta;

        public Compra(byte cant, char tip, bool tot)
        {
            if(cant < 1)
            {
                throw new Exception("No puede ingresar cantidades menores a 1");
            }
            else
            {
                cantidad = cant;
            }
            tipo = tip;
            tarjeta = tot;
        }

        public byte Cantidad
        {
            get { return cantidad; }
            set
            {
                if(value < 1)
                {
                    throw new Exception("No puede asignar valores menores a 1");
                }
                else
                {
                    cantidad = value;
                }
            }

        }
        
        public char Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double calcularPago()
        {
            double total;
            if(tipo == 'S')
            {
                total = cantidad * 20;
            }
            else if(tipo == 'D')
            {
                total = cantidad * 30;
            }
            else
            {
                total = cantidad * 35;
            }
            if(tarjeta == true)
            {
                total = total + (total * 0.05);
            }
            return total;
        }
    }
}

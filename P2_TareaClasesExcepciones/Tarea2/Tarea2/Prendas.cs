using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Prendas
    {
        char modelo;
        byte talla;
        int precioTela;
        byte cantidad;
        float precioFinal;
        float aux;

        public Prendas(char model, byte tall, int tela, byte cant)
        {
            modelo = model;
            talla = tall;
            precioTela = tela;
            cantidad = cant;
        }

        public char Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public byte Talla
        {
            get { return talla; }
            set { talla = value; }
        }

        public string calcularPrecio()
        {
            precioFinal = 0;
            if(modelo == 'A')
            {
                precioFinal = precioTela * (cantidad * 1.50f);
                precioFinal = precioFinal + (precioFinal * 0.8f);
                if(talla == 32 || talla == 36)
                {
                    precioFinal = precioFinal + (precioFinal * 0.04f);
                }
            }
            else
            {
                precioFinal = precioTela * (cantidad * 1.80f);
                precioFinal = precioFinal * (precioFinal * 0.95f);
                if (talla == 32 || talla == 36)
                {
                    precioFinal = precioFinal + (precioFinal * 0.04f);
                }
            }
            aux = precioFinal * 0.3f;
            precioFinal = precioFinal + aux;
            return precioFinal.ToString();
        }

        public string calcularGanancia()
        {
            return aux.ToString();
        }
    }
}

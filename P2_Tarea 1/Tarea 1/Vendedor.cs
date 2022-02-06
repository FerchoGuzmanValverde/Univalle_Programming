using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Vendedor
    {
        Random numero = new Random();

        //Atributos
        string Nombre;
        double[] ventas = new double[12];

        //Constructor
        public Vendedor(string nombre)
        {
            Nombre = nombre;
            Asignar_ventas();
        }

        //Metodos
        public string Sumar_ventas()
        {
            double suma = 0;
            for (int i = 0; i < ventas.Length; i++)
            {
                suma += ventas[i];
            }
            return "Total de ventas fue de: " + suma;
        }

        public string Mostrar_Nombre()
        {
            return "El operario fue: " + Nombre;
        }

        public double[] Mostrar_venta()
        {
            return ventas;
        }

        void Asignar_ventas()
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                ventas[i] = numero.Next(1, 1000);
            }
        }
    }
}

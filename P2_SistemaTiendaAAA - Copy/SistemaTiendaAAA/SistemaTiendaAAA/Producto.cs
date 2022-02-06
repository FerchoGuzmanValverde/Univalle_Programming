using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaTiendaAAA
{
    class Producto
    {
        byte numero;
        string precioUnitario;

        public Producto(string precio, byte nro)
        {
            precioUnitario = precio;
            numero = nro;
        }

        public string PrecioUnitario
        {
            get { return precioUnitario; }
            set
            {
                try
                { precioUnitario = value; }
                catch(Exception ex) { MessageBox.Show("Ingrese un precio de producto valido."); return; }
            }
        }
        public byte Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}

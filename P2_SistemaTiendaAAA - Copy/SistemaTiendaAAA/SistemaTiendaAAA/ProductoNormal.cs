using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaTiendaAAA
{
    class ProductoNormal:Producto
    {
        string nombreProducto;
        string tipoProducto;

        public ProductoNormal(string nombre, string tipo, float precio, byte numero) : base(precio.ToString(), numero)
        {
            nombreProducto = nombre;
            tipoProducto = tipo;
        }

        public string NombreProducto
        {
            get { return nombreProducto; }
            set
            {
                try
                { nombreProducto = value; }
                catch(Exception ex) { MessageBox.Show("Ingrese un nombre de producto valido."); return; }
            }
        }

        public string TipoProducto
        {
            get { return tipoProducto; }
            set { tipoProducto = value; }
        }
    }
}

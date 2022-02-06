using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaTiendaAAA
{
    class Detalle
    {
        string nombreProducto;
        float totalProducto;
        byte cantidadComprada;

        public Detalle(string nombre, byte cantidad)
        {
            cantidadComprada = cantidad; 
        }

        public string Nombre
        {
            get { return nombreProducto; }
            set
            {
                try
                { nombreProducto = value; }
                catch(Exception ex) { MessageBox.Show("Ingrese un nombre de producto valido."); }
            }
        }
        public byte Cantidad
        {
            get { return cantidadComprada; }
            set
            {
                try
                { cantidadComprada = value; }
                catch(Exception ex) { MessageBox.Show("Ingrese una cantidad valida."); return; }
            }
        }
        public float TotalProducto
        {
            get { return totalProducto; }
        }

        public void calcularTotal(float precio)
        {
            totalProducto = cantidadComprada * precio;
        }
    }
}

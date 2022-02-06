using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SistemaTiendaAAA
{
    class Cliente
    {
        string nombreCompleto = null;
        int telefono = 0;
        string tipoCliente;
        public Cliente(string ti)
        {
            tipoCliente = ti;
        }

        public string Nombre
        {
            get { return nombreCompleto; }
            set
            {
                try
                {
                    nombreCompleto = value;
                }
                catch(Exception ex) { MessageBox.Show("Ingrese un nombre valido de cliente."); return; }            
            }
        }
        public int Telefono
        {
            get { return telefono; }
            set
            {
                try
                { telefono = value; }
                catch(Exception ex) { MessageBox.Show("Ingrese un teléfono valido de cliente."); return; }
            }
        }
        public string Tipo
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }
    }
}

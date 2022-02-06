using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaTiendaAAA
{
    class Tarjetas:Producto
    {
        string nombreProducto;
        string tipoTarjeta;
        string valor;
        string codigo;
        float PrecioBs;
        float comision;

        public Tarjetas(string nombre, string tipoT, string precio, string cod, byte numero):base(precio, numero)
        {
            nombreProducto = nombre;
            tipoTarjeta = tipoT;
            valor = precio;
            codigo = cod;
        }

        public string Nombre
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }
        public string TipoTarjeta
        {
            get { return tipoTarjeta; }
            set { tipoTarjeta = value; }
        }
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public float PrecioBS
        {
            get { return PrecioBs; }
        }
        public float Comision
        {
            get { return comision; }
        }

        public void CalcularPrecioBs()
        {
            if(valor == "10$")
            { PrecioBs = 80; }
            else if(valor == "15$")
            { PrecioBs = 120; }
            else if (valor == "20$")
            { PrecioBs = 160; }
            else if(valor == "25$")
            { PrecioBs = 195; }
            else if (valor == "50$")
            { PrecioBs = 375; }
            else if (valor == "100$")
            { PrecioBs = 730; }
            else if (valor == "Plus 3 Meses")
            { PrecioBs = 195; }
            else if (valor == "Plus 12 Meses")
            { PrecioBs = 440; }
            else if (valor == "Gold 3 Meses")
            { PrecioBs = 195; }
            else if (valor == "Gold 12 Meses")
            { PrecioBs = 420; }
            else
            { PrecioBs = 200; }
        }

        public void CalcularComision()
        {
            if (valor == "10")
            { comision = 5; }
            else if (valor == "15")
            { comision = 7; }
            else if (valor == "20")
            { comision = 10; }
            else if (valor == "25")
            { comision = 10; }
            else if (valor == "50")
            { comision = 12; }
            else if (valor == "100")
            { comision = 20; }
            else if (valor == "Plus 3 Meses")
            { comision = 10; }
            else if (valor == "Plus 12 Meses")
            { comision = 20; }
            else if (valor == "Gold 3 Meses")
            { comision = 15; }
            else if (valor == "Gold 12 Meses")
            { comision = 20; }
            else
            { comision = 23; }
        }
    }
}

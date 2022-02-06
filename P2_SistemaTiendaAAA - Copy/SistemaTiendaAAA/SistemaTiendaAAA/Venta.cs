using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTiendaAAA
{
    class Venta
    {
        DateTime fechaVenta;
        float totalVenta;

        public Venta()
        {
            fechaVenta = DateTime.Now.Date;
        }

        public DateTime Fecha
        {
            get { return fechaVenta; }
            set { fechaVenta = value; }
        }
        public float Total
        {
            get { return totalVenta; }
            set { totalVenta = value; }
        }

        public void calcularTotal(float precio)
        {
            totalVenta += precio;
        }
    }
}

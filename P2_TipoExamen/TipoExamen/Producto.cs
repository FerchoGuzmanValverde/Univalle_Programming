using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoExamen
{
    class Producto
    {
        DateTime fechaCaducidad;
        int nroLote;

        public Producto(DateTime fechac, int nro)
        {
            fechaCaducidad = fechac;
            nroLote = nro;
        }

        public DateTime FechaCaducidad
        {
            get { return fechaCaducidad; }
            set { fechaCaducidad = value; }
        }

        public int NroLote
        {
            get { return nroLote; }
            set { nroLote = value; }
        }

        public virtual string mostrarInfo()
        {
            return "Fecha de Caducidad: " + fechaCaducidad + "\nNro de Lote: " + nroLote;
        }
    }
}

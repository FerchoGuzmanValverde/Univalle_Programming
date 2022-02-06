using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoExamen
{
    class ProductosFrescos:Producto
    {
        DateTime fechaEnvasado;
        string pais;

        public ProductosFrescos(DateTime fechaC, int nroL, DateTime fechaE, string p):base(fechaC, nroL)
        {
            fechaEnvasado = fechaE;
            pais = p;
        }

        public DateTime FechaEnvasado
        {
            get { return fechaEnvasado; }
            set { fechaEnvasado = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public override string mostrarInfo()
        {
            return base.mostrarInfo() + "\nFecha de Envasado: " + fechaEnvasado + "\nPais de Origen: " + pais;
        }
    }
}

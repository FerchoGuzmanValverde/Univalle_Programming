using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoExamen
{
    class ProductosRefrigerados:Producto
    {
        int codigoOSA;

        public ProductosRefrigerados(DateTime fechaC, int nroL, int codigo):base(fechaC, nroL)
        {
            codigoOSA = codigo;
        }

        public int CodigoOSA
        {
            get { return codigoOSA; }
            set { codigoOSA = value; }
        }

        public override string mostrarInfo()
        {
            return base.mostrarInfo() + "Codigo OSA: " + codigoOSA;
        }
    }
}

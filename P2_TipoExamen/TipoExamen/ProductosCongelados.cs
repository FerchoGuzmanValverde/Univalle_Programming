using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoExamen
{
    class ProductosCongelados:Producto
    {
        int temperaturaR;

        public ProductosCongelados(DateTime fechaC, int nroL, int temperatura):base(fechaC, nroL)
        {
            temperaturaR = temperatura;
        }

        public int TemperaturaR
        {
            get { return temperaturaR; }
            set { temperaturaR = value; }
        }

        public override string mostrarInfo()
        {
            return base.mostrarInfo() + "\nTemperatura recomendada: " + temperaturaR;
        }
    }
}

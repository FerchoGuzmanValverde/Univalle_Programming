using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Datagrid
{
    class Empleado
    {
        private string id;
        private string nombre;
        private bool boliviano;
        private Uri webside;
        private string imagen;
        public string ID
        {
            get;
            set;
        }
        public string Nombre
        {
            get;
            set;
        }
        public bool Boliviano 
        {
            get { return boliviano; }
            set { boliviano = value; }
        }

        public Uri Webside
        {
            get { return webside; }
            set { webside = value; }
        }
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

    }
}

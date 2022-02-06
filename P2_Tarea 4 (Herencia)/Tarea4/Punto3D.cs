using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Punto3D:Punto
    {
        int z;

        public Punto3D(int x, int y, int z):base(x,y)
        {
            this.z = z;
        }

        public int Z
        {
            get { return z; }
        }

        public string enEjeZ()
        {
            if (x == 0 && y == 0)
                return "Esta en eje Z";
            else
                return "No esta en eje Z";
        }
    }
}

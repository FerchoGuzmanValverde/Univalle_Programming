using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    class Punto
    {
        protected int x;
        protected int y;

        public Punto(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public virtual string mostrar()
        {
            return "X: " + x + "  Y: " + y;
        }
        public string determinarCuadrante()
        {
            if (x >= 0 && y >= 0)
                return "Se encuentra en el primer cuadrante";
            else if (x >= 0 && y < 0)
                return "Se encuentra en el segudo cuadrante";
            else if (x < 0 && y < 0)
                return "Se encuentra en el tercer cuadrante";
            else
                return "Se encuentra en el cuarto cuadrante";
        }
    }
}

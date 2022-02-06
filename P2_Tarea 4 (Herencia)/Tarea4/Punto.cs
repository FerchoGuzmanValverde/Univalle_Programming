using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Punto
    {
        protected int x;
        protected int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        public string enEjeX()
        {
            if (x == 0)
                return "Esta sobre el eje X";
            else
                return "No esta sobre el eje X";
        }

        public string enEjeY()
        {
            if (y == 0)
                return "Esta sobre eje Y";
            else
                return "No esta sobre eje Y";
        }
    }
}

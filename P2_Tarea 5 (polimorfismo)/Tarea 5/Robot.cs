using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    class Robot
    {
        protected double x = 0, y = 0;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public virtual string avanzar(int distancia)
        {
            x += distancia;
            y += distancia;
            return "X: " + x + "Y: " + y;
        }
    }
}

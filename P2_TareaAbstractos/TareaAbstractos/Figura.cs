using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAbstractos
{
    abstract class Figura
    {
        string color;

        public Figura(string Color)
        {
            color = Color;
        }

        public string Color
        {
            set { color = value; }
            get { return color; }
        }

        public abstract string CalcularArea();
        public abstract string CalcularPerimetro();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Promedio
    {
        float n1, n2, n3, x;

        public int Nota1
        {
            set
            {
                n1 = value;
            }
        }
        public int Nota2
        {
            set
            {
                n2 = value;
            }
        }
        public int Nota3
        {
            set
            {
                n3 = value;
            }
        }

        public float promedio()
        {
            x = (((n1 + n2)/2) * 0.7f) + (n3 * 0.3f);
            return (x);
        }

        public string definir()
        {
            if(x > 51)
            {
                return ("Aprobo");
            }
            else
            {
                return ("No aprobo");
            }
        }
    }
}

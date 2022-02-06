using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    class RobotConLimite:Robot
    {
        double xlimite, ylimite;

        public double Xlim
        {
            get { return xlimite; }
            set { xlimite = value; }
        }
        public double Ylim
        {
            get { return ylimite; }
            set { ylimite = value; }
        }

        public override string avanzar(int distancia)
        {
            string aux = base.avanzar(distancia);
            if (x <= xlimite && y <= ylimite)
            {
                return aux;
            }
            else
            {
                return "Limite";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Clase Car que hereda de la interface ICar
    /// </summary>
    public class Car : ICar
    {
        /// <summary>
        /// Metodo que retorna cuando usa el freno
        /// </summary>
        /// <returns></returns>
        public string Brake()
        {
            return "Uso el freno";
        }

        /// <summary>
        /// Metodo que usa cuando Acelera
        /// </summary>
        /// <returns></returns>
        public string Drive()
        {
            return "Acelero a una velocidad de 100 KM/H";
        }
    }
}

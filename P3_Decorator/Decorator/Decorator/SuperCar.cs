using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Clase que servira para decorar nuestra clase Car y volverla un SuperCar
    /// </summary>
    public class SuperCar : ICar
    {
        /// <summary>
        /// Creamos y recibimos un objeto del tipo interfaz ICar
        /// </summary>
        public ICar car;
        public SuperCar(ICar car)
        {
            this.car = car;
        }
            
        /// <summary>
        /// Modificamos el metodo Brake
        /// </summary>
        /// <returns></returns>
        public string Brake()
        {
            return car.Brake() + "Es un super freno";
        }

        /// <summary>
        /// Modificamos el metodo Drive
        /// </summary>
        /// <returns></returns>
        public string Drive()
        {
            return "The speed goes upto 300 Kmph";
        }


        /// <summary>
        /// Agregamos un nuevo metodo
        /// </summary>
        /// <returns></returns>
        public string Music()
        {
            return "Plays the Hi Fi music system";
        }
    }
}

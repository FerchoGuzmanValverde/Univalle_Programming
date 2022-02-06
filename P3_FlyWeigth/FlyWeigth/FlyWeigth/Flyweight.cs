using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlyWeigth
{
    /// <summary>
    /// Clase que nos ayudara a almacenar los objetos ya creados o crear nuevos para reducir la redundancia
    /// </summary>
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this._sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            MessageBox.Show("Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}

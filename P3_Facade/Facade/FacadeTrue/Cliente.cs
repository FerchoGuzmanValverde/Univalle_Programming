using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FacadeTrue
{
    /// <summary>
    /// Clase cliente que realizara la solicitud de las operaciones de los sistemas complejos a nuestro facade
    /// </summary>
    public class Cliente
    {
        // The client code works with complex subsystems through a simple
        // interface provided by the Facade. When a facade manages the lifecycle
        // of the subsystem, the client might not even know about the existence
        // of the subsystem. This approach lets you keep the complexity under
        // control.
        public static void ClientCode(Facade facade)
        {
            MessageBox.Show(facade.Operation());
        }
    }
}

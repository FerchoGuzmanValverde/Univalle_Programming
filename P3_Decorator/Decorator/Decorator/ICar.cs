using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Interfaz que heredara a la clase que queremos decorar y al decorador
    /// </summary>
    public interface ICar
    {
        string Drive();
        string Brake();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabMenu2
{
    public class BaseDatos
    {
        public Pizza[] Pizzas
        {
            get { return _pizzas; }
        }

        private static Pizza[] _pizzas = new Pizza[]
        {
            new Pizza { Descripcion = "Sobre la base estándar añadimos atún en aceite, olivas negras laminadas y anillas de cebolla cortada muy finita.", 
                        Precio = "10 $us", Nombre = "Pizza de Atún", imagen = "atun.jpg", Id = 1 },
            new Pizza { Nombre = "Pizza Catalana", Descripcion = "Con butifarra negra cortada en rodajas finas y cebolla caramelizada, que nos proporciona un contraste interesante.",
                        Precio = "10 $us", imagen = "catalana.jpg", Id = 2 },
            new Pizza { Nombre = "Pizza Rúcula", Descripcion = "Cocemos una pizza margarita, y al sacarla del horno le añadimos rúcula fresca y escamas de parmesano, una combinación perfecta de sabores y texturas.",
                        Precio = "18 $us", imagen = "rucula.jpg", Id = 3 }
        };
    }
}

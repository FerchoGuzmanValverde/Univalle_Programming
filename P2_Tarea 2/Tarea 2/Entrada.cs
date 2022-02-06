using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class Entrada
    {
        //Propiedades
        string pelicula;
        string genero;
        int edad;
        int precio = 0;

        //Propiedades Metodos
        public string Pelicula
        {
            set { pelicula = value; }
        }
        public string Genero
        {
            set { genero = value; }
        }
        public int Edad
        {
            set { edad = value; }
        }

        //Metodos
        public string calcularPrecio()
        {
            if (genero == "infantil" && edad <= 12 && edad < 61)
                precio += 5;
            else if (genero == "infantil" && edad > 12 && edad < 61)
                precio += 15;
            else if (genero == "comedia" && edad <= 12 && edad < 61)
                precio += 25;
            else if (genero == "comedia" && edad > 12 && edad < 61)
                precio += 45;
            else if (genero != "comedia" && genero != "infantil" && edad <= 12 && edad < 61)
                precio += 10;
            else if (genero != "comedia" && genero != "infantil" && edad > 12 && edad < 61)
                precio += 30;
            else if (edad > 60)
                precio += 5;
            return "El precio Total es: " + precio;
        } 
    }
}

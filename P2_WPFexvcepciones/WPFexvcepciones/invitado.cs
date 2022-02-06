using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFexvcepciones
{
    class invitado
    {
            private string nombre;
            private string apellido;
            private int edad;

            public invitado(String n, String ap, int ed)
            {
                nombre = n;
                apellido = ap;

                // Valida que el invitado no sea menor de 30 años.
                if (ed <= 30)
                {
                    throw new ArgumentOutOfRangeException("edad", "Los invitados deben ser mayores de 30.");
                }
                else
                {
                    edad = ed;
                }
            }

            // Muestra resumen del invitado:
            public override String ToString()
            {
                return String.Format("Nombre: {0} - Apellido: {1} - Edad: {2}", nombre, apellido, edad );
            }
        }
    }


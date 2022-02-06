using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando_GUZMAN
{
    class Correo_Electronico
    {
        //propiedades
        string id;
        string dominio;
        string password;
        string comprobante;

        //Metodo propiedades
        public string ID
        {
            set { id = value; }
        }
        public string Dominio
        {
            set { dominio = value; }
        }
        public string Password
        {
            set { password = value; }
        }
        public string Comprobante
        {
            set { comprobante = value; }
        }

        //Metodos
        public string correo()
        {
            return id + dominio;
        }

        public string Comprobar()
        {
            if(password == comprobante)
            {
                return "La contraseña son iguales";
            }
            else
            {
                return "Las contraseñas son diferentes";
            }
        }

        
    }
}

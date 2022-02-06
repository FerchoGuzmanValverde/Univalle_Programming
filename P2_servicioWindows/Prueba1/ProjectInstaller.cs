using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace Prueba1
{
    [RunInstaller(true)]   //importante agregar estos dos pasos para que se ejecute el instalador;
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();

            //Metodo inicializado ....

           

        }
    }
}

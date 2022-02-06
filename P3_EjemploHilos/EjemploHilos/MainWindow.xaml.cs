using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace EjemploHilos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tasks objeto1 = new tasks("hilo-1", 16); // a la clase tarea le estamos pasando los datos nombre y tiempo
            tasks objeto2 = new tasks("hilo-2", 24);

            Thread hilo1 = new Thread(objeto1.tasks1);// de esta forma llamamos a los metodos que tenemos en la clase tarea
            Thread hilo2 = new Thread(objeto2.tasks2);

            //para iniciar estos dos procesos o hilos
            hilo1.Start();
            hilo2.Start();
            Console.ReadKey(); //con esto estatodo listo para ejecutar nuestros hilos de la clase tasks
        }
    }
}

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

namespace FacadeTrue
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFacade_Click(object sender, RoutedEventArgs e)
        {
            //Creamos un objeto del sistema 1 y 2
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            //Creamos un objeto Facade que recibe como parametros los subsistemas que requiere para realizar una solicitud
            Facade facade = new Facade(subsystem1, subsystem2);
            //Cliente realiza una solicitud a facade y al mismo tiempo recibe la respuesta de facade
            Cliente.ClientCode(facade);
        }
    }
}

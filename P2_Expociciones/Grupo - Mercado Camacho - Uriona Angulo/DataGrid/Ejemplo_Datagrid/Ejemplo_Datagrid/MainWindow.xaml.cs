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

namespace Ejemplo_Datagrid
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

        private void btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            Empleado q = new Empleado();
            {
                q.ID = "9556884";
                q.Nombre = "Russel Ford";
                q.Boliviano = true;
                q.Webside = new Uri("http://www.razznil.com");
                q.Imagen = "imagen/acdc.png";
                Grid1.Items.Add(q);
            }
            Empleado p = new Empleado();
            {
                p.ID = "5633244";
                p.Nombre = "Pedro Casablanca";
                p.Boliviano = false;
                p.Webside = new Uri("http://www.textilar.com");
                p.Imagen = "imagen/foofighters.png";
                Grid1.Items.Add(p);
            }
        }
    }
}

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

namespace Decorator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Creamos un auto normal
        /// </summary>
        ICar traditionalCar = new Car();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(traditionalCar.Drive() + "\n" + traditionalCar.Brake());
        }

        private void btnSuperCar_Click(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// Creamos un super auto y le mandamos de parametro el auto tradicional para decorarlo
            /// </summary>
            SuperCar superCar = new SuperCar(traditionalCar);
            MessageBox.Show(superCar.Drive() + "\n" + superCar.Music() + "\n" + superCar.Brake());
        }
    }
}

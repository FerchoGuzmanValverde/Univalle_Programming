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

namespace EjercicioSliderGrupo1
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

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
            {
                progressbar.Value+=10;
            }
            if(slider.Value==10)
            {
                img1.Visibility = Visibility.Visible;
                img2.Visibility = Visibility.Visible;
                img3.Visibility = Visibility.Visible;
            }
            else
            {
                img1.Visibility = Visibility.Hidden;
                img2.Visibility = Visibility.Hidden;
                img3.Visibility = Visibility.Hidden;
            }
        }
    }
}

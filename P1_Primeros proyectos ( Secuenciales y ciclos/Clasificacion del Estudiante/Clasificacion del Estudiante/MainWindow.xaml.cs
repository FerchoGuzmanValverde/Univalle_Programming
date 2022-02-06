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

namespace Clasificacion_del_Estudiante
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            int promedio;
            string categoria;
            promedio = int.Parse(txtpromedio.Text);
            if (promedio == 100 || promedio > 90)
                categoria = "Excelente";
            else
            {
                if (promedio == 90 || promedio > 60)
                    categoria = "Bueno";
                else
                {
                    if (promedio == 60 || promedio > 50)
                        categoria = "Regular";
                    else
                    {
                        if (promedio == 50 || promedio > 20)
                            categoria = "Malo";
                        else
                            categoria = "Pesimo";
                    }
                }
            }
            lblrespuesta.Content = categoria;                                        
        }
    }
}

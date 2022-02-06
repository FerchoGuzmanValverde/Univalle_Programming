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

namespace Monto_Presupuestal
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double monto, urgencias, pediatria, traumatologia;
            monto = double.Parse(txtpresupuesto.Text);
            urgencias = (monto / 100) * 37;
            pediatria = (monto / 100) * 42;
            traumatologia = (monto / 100) * 21;
            lblurgencias.Content = urgencias;
            lblpediatria.Content = pediatria;
            lbltraumatologia.Content = traumatologia;


        }
    }
}

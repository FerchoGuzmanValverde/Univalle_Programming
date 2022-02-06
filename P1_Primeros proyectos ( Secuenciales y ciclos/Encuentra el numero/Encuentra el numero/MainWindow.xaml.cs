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

namespace Encuentra_el_numero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random npc = new Random();
        int num;
        int nm;
        int intentos;
        public MainWindow()
        {
            InitializeComponent();
            nm = 1;
            num = npc.Next(1, 21);
            lblrespuesta.Content = num;
            intentos = 10;
            lblintentos1.Content = intentos;
        }

        private void btnverificar_Click(object sender, RoutedEventArgs e)
        {
            int nump;
            nump = int.Parse(txtnumero.Text);
            lblintentos1.Content = intentos-1;
            if (nump < num)
                lblaviso.Content = "tu numero es muy bajo";
            if (nump > num)
                lblaviso.Content = "tu numero es muy alto";
            if (nm<11)
            {
                if (nm == 1 && nump == num)
                {
                    lblrespuesta.Content = "Tuviste suerte";
                }
                else
                {
                    if ((nm == 2 || nm == 3) && nump == num)
                    {
                        lblrespuesta.Content = "Muy bien";
                    }
                    else
                    {
                        if ((nm == 4 || nm == 5) && nump == num)
                        {
                            lblrespuesta.Content = "Aceptable";
                        }
                        else
                        {
                            if ((nm == 6 || nm == 7 || nm == 8) && nump == num)
                            {
                                lblrespuesta.Content = "Regular";
                            }
                            else
                            {
                                if (nump == num)
                                {
                                    lblrespuesta.Content = "Apenas";
                                }
                            }
                        }
                    }
                }
                nm++;
                intentos--;
            }
            else
            {
                MessageBox.Show("Perdiste");
            }
        }
    }
}

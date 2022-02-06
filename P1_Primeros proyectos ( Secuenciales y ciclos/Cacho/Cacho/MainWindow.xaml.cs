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

namespace Cacho
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random dado = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnjugar_Click(object sender, RoutedEventArgs e)
        {
            int jugador = int.Parse(txtijugador.Text);
            int pc = int.Parse(txtipc.Text);
            int apuesta = int.Parse(txtmapuesta.Text);
            int dao1 = dado.Next(1, 7);
            int dao2 = dado.Next(1, 7);
            lbldado1.Content = dao1;
            lbldado2.Content = dao2;
            int dados = dao1 + dao2;
            if (apuesta > jugador || apuesta < 1)
            {
                MessageBox.Show("Esta cantidad no es valida");
            }
            else
            {
                if (dados > 0 && dados < 7)
                {
                    if (rbtmenor.IsChecked == true)
                    {
                        lblresultado.Content = "Ganaste";
                        txtijugador.Clear();
                        txtipc.Clear();
                        txtijugador.AppendText(Convert.ToString(jugador + apuesta));
                        txtipc.AppendText(Convert.ToString(pc - apuesta));
                    }
                    else
                    {
                        if (rbtmayor.IsChecked == true)
                        {
                            lblresultado.Content = "Perdiste";
                            txtijugador.Clear();
                            txtipc.Clear();
                            txtijugador.AppendText(Convert.ToString(jugador - apuesta));
                            txtipc.AppendText(Convert.ToString(pc + apuesta));
                        }
                    }
                }
                else
                {
                    if (dados > 7 && dados <= 12)
                    {
                        if (rbtmenor.IsChecked == true)
                        {
                            lblresultado.Content = "Perdiste";
                            txtijugador.Clear();
                            txtipc.Clear();
                            txtijugador.AppendText(Convert.ToString(jugador - apuesta));
                            txtipc.AppendText(Convert.ToString(pc + apuesta));
                        }
                        else
                        {
                            if (rbtmayor.IsChecked == true)
                            {
                                lblresultado.Content = "Ganaste";
                                txtijugador.Clear();
                                txtipc.Clear();
                                txtijugador.AppendText(Convert.ToString(jugador + apuesta));
                                txtipc.AppendText(Convert.ToString(pc - apuesta));
                            }
                        }
                    }
                    else
                    {
                        lblresultado.Content = "Gana casa. perdiste";
                        txtijugador.Clear();
                        txtijugador.AppendText(Convert.ToString(jugador - apuesta));
                    }
                }
            }
        }
    }
}

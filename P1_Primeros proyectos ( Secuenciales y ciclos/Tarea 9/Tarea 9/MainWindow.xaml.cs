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

namespace Tarea_9
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

        private void btnDibujar_Click(object sender, RoutedEventArgs e)
        {
            int tam;
            tam = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa la talla de los dibujos"));
                for (int i = 1; i <= tam; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        txt1.AppendText("*");
                    }
                    txt1.AppendText("\n");
                }
                for (int i = tam; i >= 1; i--)
                {
                    for (int j = i; j >= 1; j--)
                    {
                        txt2.AppendText("*");
                    }
                    txt2.AppendText("\n");
                }
                for (int a = tam; a >= 1; a--)
                {
                    for (int s = 1; s <= a; s++)
                    {
                        txt3.AppendText(" ");
                    }
                    for (int d = 0; d <= (tam - a); d++)
                    {
                        txt3.AppendText("*");
                    }
                    txt3.AppendText("\n");
                }
                for (int i = 1; i <= tam; i++)
                {
                    if (i == 1 || i == tam)
                    {
                    for (int j = 1; j <= tam; j++)
                    {
                        txt4.AppendText("*");
                    }
                    txt4.AppendText("\n");
                    }
                else
                {
                    txt4.AppendText("*");
                    for (int a = 1; a <= tam - 2; a++)
                    {
                        txt4.AppendText(" ");

                    }
                    txt4.AppendText("*\n");
                }
                }
            if (tam % 2 == 0)
            {
                txt5.AppendText("El numero es par no puede dibujar");
                txt6.AppendText("El numero es par no puede dibujar");
                txt7.AppendText("El numero es par no puede dibujar");
            }
            else
            {
                int esp = tam / 2;
                for (int i = 1; i <= tam; i++)
                {
                    if (i != esp + 1)
                    {
                        for (int j = 1; j <= esp ; j++)
                        {
                            txt5.AppendText(" ");
                        }
                        txt5.AppendText("*");
                        for (int o = 1; o <= esp; o++)
                        {
                            txt5.AppendText(" ");
                        }
                        txt5.AppendText("\n");
                    }
                    else
                    {
                        for (int g = 1; g <= tam; g++)
                        {
                            txt5.AppendText("*");
                        }
                        txt5.AppendText("\n");
                    }
                }
                int con = 1;
                for (int a = (tam / 2) + 1; a >= 1; a--)
                {
                    for (int b = 1; b <= a - 1; b++)
                    {
                        txt6.AppendText(" ");
                    }
                    for (int c = 1; c <= con; c++)
                    {
                        txt6.AppendText("*");
                    }
                    txt6.AppendText("\n");
                    con += 2;
                }
                int con1 = 1;
                for (int a = (tam / 2) + 1; a >= 1; a--)
                {
                    for (int b = 1; b <= a - 1; b++)
                    {
                        txt7.AppendText(" ");
                    }
                    for (int c = 1; c <= con1; c++)
                    {
                        txt7.AppendText("*");
                    }
                    txt7.AppendText("\n");
                    con1 += 2;
                }
                int con2 = 1;
                int con3 = (tam / 2) + 1;
                for (int a = tam - 1; a >= 1; a-=2)
                {
                    for (int j = 1; j <= con2; j++)
                    {
                        txt7.AppendText(" ");
                    }
                    for (int c =1; c <= con3; c++)
                    {
                        txt7.AppendText("*");
                    }
                    txt7.AppendText("\n");
                    con2++;
                    con3 -= 2;
                }

            }
        }
    }
}

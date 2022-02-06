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

namespace T_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random num = new Random();
        int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult respuesta;
            respuesta = MessageBox.Show("Esta seguro de salir del juego?", "Juego de aritmetica", MessageBoxButton.YesNo);
            if (respuesta == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ingresa tus respuestas y la operacion", "Que hacer?");
            txtr1.Clear();
            txtr2.Clear();
            txtr3.Clear();
            txtr4.Clear();
            txtr5.Clear();
            txtr1.Background = new SolidColorBrush(Colors.White);
            txtr2.Background = new SolidColorBrush(Colors.White);
            txtr3.Background = new SolidColorBrush(Colors.White);
            txtr4.Background = new SolidColorBrush(Colors.White);
            txtr5.Background = new SolidColorBrush(Colors.White);
            n1 = num.Next(1, 10);
            n2 = num.Next(1, 10);
            n3 = num.Next(1, 10);
            n4 = num.Next(1, 10);
            n5 = num.Next(1, 10);
            n6 = num.Next(1, 10);
            n7 = num.Next(1, 10);
            n8 = num.Next(1, 10);
            n9 = num.Next(1, 10);
            n10 = num.Next(1, 10);
            lbl1.Content = n1;
            lbl2.Content = n2;
            lbl3.Content = n3;
            lbl4.Content = n4;
            lbl5.Content = n5;
            lbl6.Content = n6;
            lbl7.Content = n7;
            lbl8.Content = n8;
            lbl9.Content = n9;
            lbl10.Content = n10;

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(@"C:\Users\Fernando\Desktop\Programming Projects\Visual Studio\WPF C#\T 2\T 2\Resources\Music/Algún día el mundo sera así ♥ Reflexiones de Vida (1).mp3");
            var player = new MediaPlayer();
            player.Open(uri);
            player.Play();
            MessageBox.Show("Hola.." + "\n" + "Da click en nuevo para empezar a jugar" + "\n", "Instrucciones");
            MessageBox.Show("Luego ingresa tus respuestas y selecciona operacion"+"\n"+"Y da click en verificar para saber los resultados", "Instrucciones");
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            float r1, r2, r3, r4, r5;
            float re1, re2, re3, re4, re5;
            int correctas = 0, incorrectas = 0;
            r1 = float.Parse(txtr1.Text);
            r2 = float.Parse(txtr2.Text);
            r3 = float.Parse(txtr3.Text);
            r4 = float.Parse(txtr4.Text);
            r5 = float.Parse(txtr5.Text);
            if (rbtsuma.IsChecked == true)
            {
                re1 = n1 + n2;
                re2 = n3 + n4;
                re3 = n5 + n6;
                re4 = n7 + n8;
                re5 = n9 + n10;
                if (re1 == r1)
                {
                    correctas++;
                    txtr1.Background = Brushes.Green;
                }
                else
                {
                    incorrectas++;
                    txtr1.Background = Brushes.Red;
                }
                if (re2 == r2)
                {
                    correctas++;
                    txtr2.Background = Brushes.Green;
                }
                else
                {
                    incorrectas++;
                    txtr2.Background = Brushes.Red;
                }
                if (re3 == r3)
                {
                    correctas++;
                    txtr3.Background = Brushes.Green;
                }
                else
                {
                    incorrectas++;
                    txtr3.Background = Brushes.Red;
                }
                if (re4 == r4)
                {
                    correctas++;
                    txtr4.Background = Brushes.Green;
                }
                else
                {
                    incorrectas++;
                    txtr4.Background = Brushes.Red;
                }
                if (re5 == r5)
                {
                    correctas++;
                    txtr5.Background = Brushes.Green;
                }
                else
                {
                    incorrectas++;
                    txtr5.Background = Brushes.Red;
                }

                }
            else
            {
                if (rbtresta.IsChecked == true)
                {
                    re1 = n1 - n2;
                    re2 = n3 - n4;
                    re3 = n5 - n6;
                    re4 = n7 - n8;
                    re5 = n9 - n10;
                    if (re1 == r1)
                    {
                        correctas++;
                        txtr1.Background = Brushes.Green;
                    }
                    else
                    {
                        incorrectas++;
                        txtr1.Background = Brushes.Red;
                    }
                    if (re2 == r2)
                    {
                        correctas++;
                        txtr2.Background = Brushes.Green;
                    }
                    else
                    {
                        incorrectas++;
                        txtr2.Background = Brushes.Red;
                    }
                    if (re3 == r3)
                    {
                        correctas++;
                        txtr3.Background = Brushes.Green;
                    }
                    else
                    {
                        incorrectas++;
                        txtr3.Background = Brushes.Red;
                    }
                    if (re4 == r4)
                    {
                        correctas++;
                        txtr4.Background = Brushes.Green;
                    }
                    else
                    {
                        incorrectas++;
                        txtr4.Background = Brushes.Red;
                    }
                    if (re5 == r5)
                    {
                        correctas++;
                        txtr5.Background = Brushes.Green;
                    }
                    else
                    {
                        incorrectas++;
                        txtr5.Background = Brushes.Red;
                    }
                }
                else
                {
                    if (rbtproducto.IsChecked == true)
                    {
                        re1 = n1 * n2;
                        re2 = n3 * n4;
                        re3 = n5 * n6;
                        re4 = n7 * n8;
                        re5 = n9 * n10;
                        if (re1 == r1)
                        {
                            correctas++;
                            txtr1.Background = Brushes.Green;
                        }
                        else
                        {
                            incorrectas++;
                            txtr1.Background = Brushes.Red;
                        }
                        if (re2 == r2)
                        {
                            correctas++;
                            txtr2.Background = Brushes.Green;
                        }
                        else
                        {
                            incorrectas++;
                            txtr2.Background = Brushes.Red;
                        }
                        if (re3 == r3)
                        {
                            correctas++;
                            txtr3.Background = Brushes.Green;
                        }
                        else
                        {
                            incorrectas++;
                            txtr3.Background = Brushes.Red;
                        }
                        if (re4 == r4)
                        {
                            correctas++;
                            txtr4.Background = Brushes.Green;
                        }
                        else
                        {
                            incorrectas++;
                            txtr4.Background = Brushes.Red;
                        }
                        if (re5 == r5)
                        {
                            correctas++;
                            txtr5.Background = Brushes.Green;
                        }
                        else
                        {
                            incorrectas++;
                            txtr5.Background = Brushes.Red;
                        }

                    }
                    else
                    {
                        if (rbtdivision.IsChecked == true)
                        {
                            re1 = n1 / n2;
                            re2 = n3 / n4;
                            re3 = n5 / n6;
                            re4 = n7 / n8;
                            re5 = n9 / n10;
                            if (re1 == r1)
                            {
                                correctas++;
                                txtr1.Background = Brushes.Green;
                            }
                            else
                            {
                                incorrectas++;
                                txtr1.Background = Brushes.Red;
                            }
                            if (re2 == r2)
                            {
                                correctas++;
                                txtr2.Background = Brushes.Green;
                            }
                            else
                            {
                                incorrectas++;
                                txtr2.Background = Brushes.Red;
                            }
                            if (re3 == r3)
                            {
                                correctas++;
                                txtr3.Background = Brushes.Green;
                            }
                            else
                            {
                                incorrectas++;
                                txtr3.Background = Brushes.Red;
                            }
                            if (re4 == r4)
                            {
                                correctas++;
                                txtr4.Background = Brushes.Green;
                            }
                            else
                            {
                                incorrectas++;
                                txtr4.Background = Brushes.Red;
                            }
                            if (re5 == r5)
                            {
                                correctas++;
                                txtr5.Background = Brushes.Green;
                            }
                            else
                            {
                                incorrectas++;
                                txtr5.Background = Brushes.Red;
                            }
                        }
                        else
                            MessageBox.Show("Nesecitas seleccionar una operacion para jugar", "Error");
                    }
                }
            }
            lblcorrectos.Content = correctas;
            lblincorrectos.Content = incorrectas;
        }
    }
}

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

namespace FigurasPorClick
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Random ran = new Random();
            switch (ran.Next(4))
            {
                case (0):
                    {
                        Rectangle fig = new Rectangle();
                        fig.Width = 80; // Ancho.
                        fig.Height = 50;// Alto.
                        fig.Fill = Brushes.Red; // Color de relleno de la figura.
                        fig.Stroke = Brushes.Black; // Color del borde de la figura.
                        fig.StrokeThickness = 4; // Valor del grosor del borde de la figura.
                        fig.RadiusX = 5; // Valor a asignar a la curva de la figura en X.
                        fig.RadiusY = 5; // Valor a asignar a la curva de la figura en Y.
                        canvas.Children.Add(fig); // Añadimos la figura al canvas para poder asignale sus posiciones en X y en Y.
                        Point posic = e.GetPosition(canvas); // Obtenemos las coordenadas donde se efectuo el "Click".
                        Canvas.SetLeft(fig, posic.X); // Le asignamos el valor en X del "Click".
                        Canvas.SetTop(fig, posic.Y); // Le asignamos el valor en Y del "Click".
                    }
                    break;
                case (1):
                    {
                        Line fig = new Line();
                        fig.X1 = 0; //X1 y Y1 son los puntos de inicio de la línea.
                        fig.Y1 = 0;//X1 y Y1 son los puntos de inicio de la línea.
                        fig.X2 = ran.Next(20, 60); //X2 y Y2 son los puntos de finales de la línea.
                        fig.Y2 = ran.Next(20, 80); //X2 y Y2 son los puntos de finales de la línea.
                        fig.Stroke = Brushes.Black;
                        fig.StrokeThickness = 4;
                        canvas.Children.Add(fig);
                        Point posic = e.GetPosition(canvas);
                        Canvas.SetLeft(fig, posic.X);
                        Canvas.SetTop(fig, posic.Y);
                    }
                    break;
                case (2):
                    {
                        Ellipse fig = new Ellipse();
                        fig.Width = 80;
                        fig.Height = 50;
                        fig.Fill = Brushes.Purple;
                        fig.Stroke = Brushes.Black;
                        fig.StrokeThickness = 4;
                        canvas.Children.Add(fig);
                        Point posic = e.GetPosition(canvas);
                        Canvas.SetLeft(fig, posic.X);
                        Canvas.SetTop(fig, posic.Y);
                    }
                    break;
                case (3):
                    {
                        Polygon fig = new Polygon();
                        fig.Points.Add(new Point(0, 0)); //Punto de referencia de inicio. 
                        fig.Points.Add(new Point(0, 100)); // Largo de arriba para abajo.
                        fig.Points.Add(new Point(100, 0)); // Anchos de izquierda a derecha.
                        fig.Fill = Brushes.Blue;
                        fig.Stroke = Brushes.Black;
                        fig.StrokeThickness = 4;
                        fig.Stretch = Stretch.Fill;
                        fig.Width = ran.Next(25, 90);
                        fig.Height = ran.Next(25, 90);
                        canvas.Children.Add(fig);
                        Point posic = e.GetPosition(canvas);
                        Canvas.SetLeft(fig, posic.X);
                        Canvas.SetTop(fig, posic.Y);
                    }
                    break;
                default:
                    break;
            }
        }

        private void canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}

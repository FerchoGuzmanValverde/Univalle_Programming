using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace Cliente
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IPHostEntry ipHostInfo;
        IPAddress ipAddress;
        IPEndPoint epRemoto;
        Socket enviador;

        bool conexion = false;
        public MainWindow()
        {
            InitializeComponent();
            label1.Content = "Estado: Sin Conexion...";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ipHostInfo = Dns.GetHostEntry("localhost");
            ipAddress = ipHostInfo.AddressList[0];
            epRemoto = new IPEndPoint(ipAddress, 11000);

            enviador = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                enviador.Connect(epRemoto);
                conexion = true;
                label1.Content = "Estado: Conectado...";
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e1)
            {
                Console.WriteLine("Unexpected exception : {0}", e1.ToString());
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string mensaje = textBoxM.Text;
            if (conexion)
            {
                try
                {
                    //enviar
                    byte[] msg = Encoding.ASCII.GetBytes("" + mensaje);
                    // Send the data through the socket.    
                    int bytesSent = enviador.Send(msg);
                    // Release the socket.    
                    label1.Content = "Estado: Enviando Datos...";
                    enviador.Shutdown(SocketShutdown.Both);
                    enviador.Close();
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e1)
                {
                    Console.WriteLine("Unexpected exception : {0}", e1.ToString());
                }
            }
        }
    }
}

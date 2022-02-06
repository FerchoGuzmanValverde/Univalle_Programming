using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Net;
using System.Net.Sockets;

namespace SocketEnvia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IPHostEntry ipHostInfo;
        IPAddress ipAddress;
        IPEndPoint epRemoto;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, RoutedEventArgs e)
        {
            ipHostInfo = Dns.GetHostEntry("localhost");
            ipAddress = ipHostInfo.AddressList[0];
            epRemoto = new IPEndPoint(ipAddress, 11000);
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            string mensaje = txtMensaje.Text;
            try
            {
                Socket emisor = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                emisor.Connect(epRemoto);
                //enviar
                byte[] msg = Encoding.ASCII.GetBytes("" + mensaje + "<fin>");
                // Send the data through the socket.    
                int bytesSent = emisor.Send(msg);
                // Release the socket.    
                emisor.Shutdown(SocketShutdown.Both);
                emisor.Close();
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show("ArgumentNullException : {0}" + ane.Message);
            }
            catch (SocketException se)
            {
                MessageBox.Show("SocketException : {0}" + se.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected exception : {0}" + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
        Thread hilo;

        bool conexion = false;
        public MainWindow()
        {
            InitializeComponent();
            
            label1.Content = "Estado: Sin Conexion...";
            ThreadStart delegado = new ThreadStart(RecivirMensaje);
            //Creamos la instancia del hilo 
            hilo = new Thread(delegado);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ipHostInfo = Dns.GetHostEntry("localhost");
            ipAddress = ipHostInfo.AddressList[0];
            epRemoto = new IPEndPoint(ipAddress, 11000);
            hilo.Start();

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
                    /*enviador.Shutdown(SocketShutdown.Both);
                    enviador.Close();*/
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

        public void RecivirMensaje()
        {
            try
            {
                // A Socket must be associated with an endpoint using the Bind method  
                enviador.Bind(epRemoto);
                enviador.Listen(5);
                Socket handler = enviador.Accept();

                Console.WriteLine("conneccion etablecidaaaaaa ...");
                // Incoming data from the client.    
                string data = null;
                byte[] bytes = null;

                while (true)
                {
                    data = null;
                    bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data != null)
                    {
                        txtRecepcion.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render,
                        new Action(delegate
                        {
                            txtRecepcion.AppendText(data + "\n");
                        }));
                    }
                    if (data.IndexOf("Terminar") > -1)
                    {
                        break;
                    }
                }
                Console.WriteLine("Text received : {0}", data);
                /*handler.Shutdown(SocketShutdown.Both);
                handler.Close();
                Console.ReadLine();*/


            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
        }
    }
}

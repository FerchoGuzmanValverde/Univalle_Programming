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
using System.Threading;

namespace Server
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IPHostEntry ipHostInfo;
        IPAddress ipAddress ;
        IPEndPoint epLocal ;
        Thread hilo;
        public MainWindow()
        {
            InitializeComponent();

             ipHostInfo = Dns.GetHostEntry("localhost");
             ipAddress = ipHostInfo.AddressList[0];
             epLocal = new IPEndPoint(ipAddress, 11000);
            ThreadStart delegado = new ThreadStart(RecivirMensaje);
            //Creamos la instancia del hilo 
            hilo = new Thread(delegado);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            hilo.Start();
        }

        public void RecivirMensaje()
        {
            try
            {
                Socket recibe = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // A Socket must be associated with an endpoint using the Bind method  
                recibe.Bind(epLocal);
                recibe.Listen(5);
                Console.WriteLine("Waiting for a connection...");
                Socket handler = recibe.Accept();

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
                    if(data != null)
                    {
                        textBox_recibe.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render,
                        new Action(delegate
                        {
                            textBox_recibe.AppendText(data + "\n");
                        }));
                    }
                    if (data.IndexOf("Terminar") > -1)
                    {
                        break;
                    }
                }
                Console.WriteLine("Text received : {0}", data);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
                Console.ReadLine();


            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
        }
    }
}

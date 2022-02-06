﻿﻿﻿using System;
using System.Text;
using System.Windows;
using System.Net; 
using System.Net.Sockets;
using System.Windows.Controls;
using System.Threading;
using System.Windows.Threading;

namespace ServerSocketWpfApp
{
    public partial class MainWindow : Window
    {// server
        SocketPermission permission;
        Socket socketListener;
        IPEndPoint ipEndPoint;
        Socket handler;

        private TextBox tbAux = new TextBox();

        public MainWindow()
        {
            InitializeComponent();
            tbAux.SelectionChanged += tbAux_SelectionChanged;

            Start_Button.IsEnabled = true;
            StartListen_Button.IsEnabled = false;
            Send_Button.IsEnabled = false;
            Close_Button.IsEnabled = false;
        }

        private void tbAux_SelectionChanged(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate()
            {
                tbMsgReceived.Text = tbAux.Text;
            }
            );
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Crear SocketPermission para acceso a restricciones de socket                 
                permission = new SocketPermission(
                    NetworkAccess.Accept,    // permiso de Conexion 
                    TransportType.Tcp,        // Definee tipo de transporte
                    "",                       // obtiene IP addresses 
                    SocketPermission.AllPorts // todos los puertos 
                );

                // Escuchando el Socket 
                socketListener = null;
                // Asegura que el codigo tenga permiso para acceso al Socket 
                permission.Demand();
                IPHostEntry ipHost = Dns.GetHostEntry("");
                IPAddress ipAddr = ipHost.AddressList[0];
                ipEndPoint = new IPEndPoint(ipAddr, 11000);
                // Crea un Socket para escuchar la conexion entrante 
                socketListener = new Socket(ipAddr.AddressFamily,SocketType.Stream,ProtocolType.Tcp);
                // Asocia un Socket con el local endpoint 
                socketListener.Bind(ipEndPoint);
                tbStatus.Text = "Server Iniciado.";

                Start_Button.IsEnabled = false;
                StartListen_Button.IsEnabled = true;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void Listen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Coloca un Socket en estado de listening 
                socketListener.Listen(10);
                // Inicia la operacion asynchronous para aceptar llamada
                AsyncCallback aCallback = new AsyncCallback(AceptarCallback);
                socketListener.BeginAccept(aCallback, socketListener);
                tbStatus.Text = "Server esta escuchando en... " + ipEndPoint.Address + " puerto: " + ipEndPoint.Port;

                StartListen_Button.IsEnabled = false;
                Send_Button.IsEnabled = true;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        public void AceptarCallback(IAsyncResult ar)
        {
            Socket listener = null;
            // Un nuevo Socket para manejar la comunicacion con el host remoto 
            Socket localHandler = null;
            try
            {
                // Recibiendo en un byte array 
                byte[] buffer = new byte[1024];
                // Obtiene el Socket  de Listening
                listener = (Socket)ar.AsyncState;
                // Crea un nuevo new socket 
                localHandler = listener.EndAccept(ar);
                // Usa el algoritmo de Nagle
                localHandler.NoDelay = false;
                // Crea una array de objectos para pasar datos 
                object[] obj = new object[2];
                obj[0] = buffer;
                obj[1] = localHandler;
                // inicia la recepcion de datos asynchronously 
                localHandler.BeginReceive(
                    buffer,        // Un array de tipo Bytes para recibir datos 
                    0,             // El buffer de posición zero-based 
                    buffer.Length, // El numero de bytes a recibir 
                    SocketFlags.None,// Especifica el comportamiento : send / receive 
                    new AsyncCallback(RecibeCallback),//Un delegate AsyncCallback 
                    obj            // Especifica la informacion para la operacion de recibir 
                    );
                // Inicia una operacion asynchronous para aceptar llamada
                AsyncCallback aCallback = new AsyncCallback(AceptarCallback);
                listener.BeginAccept(aCallback, listener);
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        public void RecibeCallback(IAsyncResult ar)
        {
            try
            {
                // Carga un objeto user-defined que contiene informacion 
                object[] obj = new object[2];
                obj = (object[])ar.AsyncState;
                // byte array para recibir
                byte[] buffer = (byte[])obj[0];
                // Un Socket patra manejar la comunicacion con el host remoto. 
                handler = (Socket)obj[1];
                // Mensaje Recibido
                string mensajeRecibido = string.Empty;
                // Numero de bytes recibidos. 
                int bytesRecibidos = handler.EndReceive(ar);
                if (bytesRecibidos > 0)
                {
                    mensajeRecibido += Encoding.Unicode.GetString(buffer, 0,
                        bytesRecibidos);
                    // Si el mensage contiene "@fin", termina la recepcion
                    if (mensajeRecibido.IndexOf("@fin") > -1)
                    {
                        // Convierte un byte array a string
                        string str = mensajeRecibido.Substring(0, mensajeRecibido.LastIndexOf("@fin"));
                        //Esto es usado por que la UI no puede ser accesada desde un Thread externo 
                        this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate()
                        {
                            tbAux.Text = "Leidos " + str.Length * 2 + " bytes del cliente.\n Datos: " + str;
                        }
                        );
                    }
                    else
                    {
                        // Continua recibiendo datos asynchronously 
                        byte[] buffernew = new byte[1024];
                        obj[0] = buffernew;
                        obj[1] = handler;
                        handler.BeginReceive(buffernew, 0, buffernew.Length,
                            SocketFlags.None,
                            new AsyncCallback(RecibeCallback), obj);
                    }
                    this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate()
                    {
                        tbAux.Text = mensajeRecibido;
                    }
                    );
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Convierte un byte array a string 
                string str = tbMsgToSend.Text;
                // Prepara el mensage de respuesta
                byte[] byteData = Encoding.Unicode.GetBytes(str);
                // Envia los datos asynchronously al Socket 
                handler.BeginSend(byteData, 0, byteData.Length, 0,new AsyncCallback(EnviaCallback), handler);
               // Send_Button.IsEnabled = false;
                //Close_Button.IsEnabled = true;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        public void EnviaCallback(IAsyncResult ar)
        {
            try
            {
                // Un Socket que enviara datos al host remoto 
                Socket otroHandler = (Socket)ar.AsyncState;
                // Numero de bytes enviados al Socket 
                int bytesEnviados = otroHandler.EndSend(ar);
                Console.WriteLine("Enviados {0} bytes al Cliente", bytesEnviados);
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (socketListener.Connected)
                {
                    socketListener.Shutdown(SocketShutdown.Receive);
                    socketListener.Close();
                }
                //Close_Button.IsEnabled = false;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }
    }
}

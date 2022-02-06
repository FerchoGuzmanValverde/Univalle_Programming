﻿﻿using System;
using System.Text;
using System.Windows;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        //cliente
        // array para recibir bytes
        byte[] bytes = new byte[1024]; 
        Socket socketEnviar;
        Thread h1;
        byte bandera = 0;

        public MainWindow()
        {
            InitializeComponent();
            Send_Button.IsEnabled = false;
            Disconnect_Button.IsEnabled = false;
            h1 = new Thread(hilo);
            h1.Start();
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Crear SocketPermission para acceso a restricciones de socket 
                SocketPermission permission = new SocketPermission(
                    NetworkAccess.Connect,    // permiso de Conexion 
                    TransportType.Tcp,        // Definee tipo de transporte
                    "",                       // obtiene IP addresses 
                    SocketPermission.AllPorts // toodos los puertos 
                    );

                // Asegura que el codigo tenga permiso para acceso al Socket 
                permission.Demand();
                IPHostEntry ipHost = Dns.GetHostEntry("");
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

                socketEnviar = new Socket(ipAddr.AddressFamily,SocketType.Stream,ProtocolType.Tcp);
                socketEnviar.NoDelay = false;   // Usa el algoritmo de Nagle 
                socketEnviar.Connect(ipEndPoint);
                tbStatus.Text = "Socket conectado a... " + socketEnviar.RemoteEndPoint.ToString();
                Connect_Button.IsEnabled = false;
                Send_Button.IsEnabled = true;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // enviando mensage 
                //@fin es la señal de terminacion de datos
                string mensaje = tbMsg.Text;
                byte[] msg = Encoding.Unicode.GetBytes(mensaje);
                // envia datos al Socket. 
                int bytesEnviados = socketEnviar.Send(msg);
                //handler.BeginSend(msg, 0, msg.Length, 0, new AsyncCallback(EnviaCallback), handler);
                bandera = 1;
                //Send_Button.IsEnabled = false;
                Disconnect_Button.IsEnabled = true;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }
        
        private void hilo()
        {
            while (true)
            {
                if (bandera == 1)
                {
                    RecibirDatosDelServer();
                }
            }
        }

        private void RecibirDatosDelServer()
        {
            try
            {
                // Recibe datos del Socket  de enlace remoto. 
                int bytesRecibidos = socketEnviar.Receive(bytes);
                // Convierte el bytearray a string 
                String mensajeRecibido = Encoding.Unicode.GetString(bytes, 0, bytesRecibidos);
                // Continua leyendo los datos mientras esten disponibles 
                while (socketEnviar.Available > 0)
                {
                    bytesRecibidos = socketEnviar.Receive(bytes);
                    mensajeRecibido += Encoding.Unicode.GetString(bytes, 0, bytesRecibidos);
                }
                tbReceivedMsg.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Render,
                    new Action(delegate()
                    {
                        tbReceivedMsg.Text = "El server contestó: " + mensajeRecibido;
                    }));
                
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Desabilita el Socket. 
                socketEnviar.Shutdown(SocketShutdown.Both);
                socketEnviar.Close();
                Disconnect_Button.IsEnabled = false;
                h1.Abort();
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        } 
    }
}

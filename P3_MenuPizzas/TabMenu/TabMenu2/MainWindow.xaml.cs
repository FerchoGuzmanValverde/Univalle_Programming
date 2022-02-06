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
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Windows.Threading;
using System.Threading;

namespace TabMenu2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Nodos y colas para pedidos en persona
        int cola = 0;
        Pedido x = new Pedido();
        Pedido y = new Pedido();

        //Pedidos por mensaje
        SocketPermission permission;
        Socket socketListener;
        IPEndPoint ipEndPoint;
        Socket handler;
        private TextBox tbAux = new TextBox();

        //Creamos la base de datos
        BaseDatos db = new BaseDatos();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CargarPizzas();
        }

        public void CargarPizzas()
        {
            //Usamos linq para cargar las pizzas
            ImageBrush ib = new ImageBrush();

            var query = from pizz in db.Pizzas
                        where pizz.Id == 1
                        select new
                        {
                            Nombre = pizz.Nombre,
                            Descripcion = pizz.Descripcion,
                            Imagen = pizz.imagen, 
                            Precio = pizz.Precio
                        };
            foreach (var r1 in query)
            {
                txbPizza1.Text = r1.Nombre;
                txbDescripcionPizza1.Text = r1.Descripcion;
                txbPrecioPizza1.Text = r1.Precio;
                ib.ImageSource = new BitmapImage(new Uri("Imagenes/" + r1.Imagen, UriKind.Relative));
                imgPizza1.Source = ib.ImageSource;
            }

            query = from pizz in db.Pizzas
                        where pizz.Id == 2
                        select new
                        {
                            Nombre = pizz.Nombre,
                            Descripcion = pizz.Descripcion,
                            Imagen = pizz.imagen,
                            Precio = pizz.Precio
                        };
            foreach (var r1 in query)
            {
                txbPizza2.Text = r1.Nombre;
                txbDescripcionPizza2.Text = r1.Descripcion;
                txbPrecioPizza2.Text = r1.Precio;
                ib.ImageSource = new BitmapImage(new Uri("Imagenes/" + r1.Imagen, UriKind.Relative));
                imgPizza2.Source = ib.ImageSource;
            }

            query = from pizz in db.Pizzas
                        where pizz.Id == 3
                        select new
                        {
                            Nombre = pizz.Nombre,
                            Descripcion = pizz.Descripcion,
                            Imagen = pizz.imagen,
                            Precio = pizz.Precio
                        };
            foreach (var r1 in query)
            {
                txbPizza3.Text = r1.Nombre;
                txbDescripcionPizza3.Text = r1.Descripcion;
                txbPrecioPizza3.Text = r1.Precio;
                ib.ImageSource = new BitmapImage(new Uri("Imagenes/" + r1.Imagen, UriKind.Relative));
                imgPizza3.Source = ib.ImageSource;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //PUSH COLA con nodos
            string cliente = txtCliente.Text;
            string pizzaName = (cbxPizza.SelectionBoxItem).ToString();

                if (cola == 0)
                {
                    x.cliente = cliente;
                    x.pizzaName = pizzaName;
                    x.sig = null;
                    lstPedidos.Items.Add("Pedido de " + x.cliente + " de la pizza " + x.pizzaName);
                    cola++;
                }
                else
                {
                    y = x;
                    while (y.sig != null)
                    {
                        y = y.sig;
                    }
                    Pedido nuevo = new Pedido();
                    nuevo.cliente = cliente;
                    nuevo.pizzaName = pizzaName;
                    nuevo.sig = null;
                    y.sig = nuevo;
                    lstPedidos.Items.Add("Pedido de " + nuevo.cliente + " de la pizza " + nuevo.pizzaName);
                    cola++;
                }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //POP COLA con nodos
            if (x == null)
            {
                MessageBox.Show("No existen mas pedidos.");
                cola = 0;
            }
            else
            {
                lstPedidos.Items.RemoveAt(0);
                x = x.sig;
            }
        }

        //PEDIDOS POR MENSAJES
        private void btnIniciarServidor_Click(object sender, RoutedEventArgs e)
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
                socketListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // Asocia un Socket con el local endpoint 
                socketListener.Bind(ipEndPoint);
                tbStatus.Text = "Server Iniciado.";

                btnIniciarServidor.IsEnabled = false;
                btnIniciarEscucha.IsEnabled = true;
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void btnIniciarEscucha_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Coloca un Socket en estado de listening 
                socketListener.Listen(10);
                // Inicia la operacion asynchronous para aceptar llamada
                AsyncCallback aCallback = new AsyncCallback(AceptarCallback);
                socketListener.BeginAccept(aCallback, socketListener);
                tbStatus.Text = "Server esta escuchando en... " + ipEndPoint.Address + " puerto: " + ipEndPoint.Port;

                btnIniciarEscucha.IsEnabled = false;
                btnEnviarMensaje.IsEnabled = true;
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
                            txtMsgRecibido.Text = "Leidos " + str.Length * 2 + " bytes del cliente.\n Datos: " + str;
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
                        txtMsgRecibido.Text = mensajeRecibido;
                    }
                    );
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.ToString()); }
        }

        private void btnEnviarMensaje_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Convierte un byte array a string 
                string str = txtMsgEnviar.Text;
                // Prepara el mensage de respuesta
                byte[] byteData = Encoding.Unicode.GetBytes(str);
                // Envia los datos asynchronously al Socket 
                handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(EnviaCallback), handler);
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

        private void btnDesconectar_Click(object sender, RoutedEventArgs e)
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

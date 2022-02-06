using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EjeSOCKET33
{
    class Program
    {
        static void Main(string[] args)
        {//ENVIA
            IPHostEntry ipHostInfo = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint epRemoto = new IPEndPoint(ipAddress, 11000);

            

            string mensaje = Console.ReadLine();//LEO MENSAJE DEL TECLADO
            try  
            {
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(epRemoto);  
                //enviar
                byte[] msg = Encoding.ASCII.GetBytes(""+mensaje+"<eof>");
                // Send the data through the socket.    
                int bytesSent = sender.Send(msg);  
                // Release the socket.    
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();  
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }  
            Console.ReadLine();
        }
    }
}

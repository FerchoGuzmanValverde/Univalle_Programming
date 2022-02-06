using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EjeSOCKET_recibe
{
    class Program
    {
        static void Main(string[] args)
        {//  RECIBE server
            IPHostEntry ipHostInfo = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint epLocal = new IPEndPoint(ipAddress, 11000);

             try {   
                Socket recibe = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // A Socket must be associated with an endpoint using the Bind method  
                recibe.Bind(epLocal);
                recibe.Listen(5);
                Console.WriteLine("Waiting for a connection...");
                Socket handler = recibe.Accept();
                // Incoming data from the client.    
                string data = null;
                byte[] bytes = null;

                while (true)
                {
                    bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<fin>") > -1)
                    {
                        break;
                    }
                }
                Console.WriteLine("Text received : {0}", data);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
                Console.ReadLine();

             }
             catch (Exception e)
             {
                 Console.WriteLine(e.ToString());
             }  

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Connect();
        }
        static void Connect()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            IPEndPoint address = new IPEndPoint(IPAddress.Parse("192.168.1.68"),80);
            byte[] toReceive = new byte[255];
            try
            {
                socket.Bind(address);
                socket.Listen(1);
                Console.WriteLine("Listening...");
                Socket socket1 = socket.Accept();
                Console.WriteLine("Successfully Connection");
                int x=socket1.Receive(toReceive,0,toReceive.Length,0);
                Array.Resize(ref toReceive,x);
                Console.WriteLine("Client says:"+Encoding.Default.GetString(toReceive));
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}

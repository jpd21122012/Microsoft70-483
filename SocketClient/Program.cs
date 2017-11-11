using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Connect();
        }
        static void Connect()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint address = new IPEndPoint(IPAddress.Parse("192.168.1.68"), 80);
            string message;
            byte[] toSend;

            try
            {
                socket.Connect(address);
                Console.WriteLine("Successfully Client Connection");
                Console.WriteLine("Put a message");
                message=Console.ReadLine();
                toSend = Encoding.Default.GetBytes(message);
                socket.Send(toSend,0,toSend.Length,0);
                Console.WriteLine("Message Sent!!!");
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Console.WriteLine("Press any key to end...");
            Console.ReadLine();
        }
    }
}
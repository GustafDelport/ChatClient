using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Any Key");
            Console.ReadKey();
            TcpClient client = new TcpClient("192.168.1.106",2000);

            Stream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream);

            while (true)
            {
                Console.WriteLine("Enter Message");

                writer.WriteLine(Console.ReadLine());
                writer.Flush();
            }

        }
    }
}

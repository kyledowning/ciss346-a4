using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmpClientConsumer
{
    public class ClientConsum
    {
        public static void SendMessage(string serverIpAddress, int port, string message, FormSmpClientConsumer form)
        {
            Console.WriteLine("Connect -->> " + serverIpAddress + ":" + port);
            TcpClient client = new TcpClient(serverIpAddress, port);
            NetworkStream networkStream = client.GetStream();

            //Send the SMP packet
            StreamWriter writer = new StreamWriter(networkStream);
            writer.WriteLine(message);
            writer.Flush();

            //Receive SMP Response from server
            StreamReader reader = new StreamReader(networkStream);
            string serverResponse = reader.ReadLine();

            //Done with the server
            reader.Close();
            writer.Close();

            ProcessResponsePacket(serverResponse, form);
        }
        private static void ProcessResponsePacket(string serverResponse, FormSmpClientConsumer form)
        {
            form.RecordServerResponse(serverResponse);
        }
    }
}

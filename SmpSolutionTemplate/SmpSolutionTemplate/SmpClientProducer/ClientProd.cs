/*
 * Names: Kyle Downing and Ethan Griffith. 
 * Date: 3/16/25
 * Desc: Clinet Producer TCP code.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmpClientProducer
{
    public class ClientProd
    {
        public static void SendMessage(string serverIpAddress, int port, string message, FormSmpClientProducer form)
        {
            Console.WriteLine("Connect -->> " + serverIpAddress + ":" + port);
            TcpClient client = new TcpClient(serverIpAddress, port);
            NetworkStream networkStream = client.GetStream();

            StreamWriter writer = new StreamWriter(networkStream);
            writer.WriteLine(message);
            writer.Flush();

            StreamReader reader = new StreamReader(networkStream);
            string serverResponse = reader.ReadLine();

            reader.Close();
            writer.Close();

            ProcessResponsePacket(serverResponse, form);
        }
        private static void ProcessResponsePacket(string serverResponse, FormSmpClientProducer form)
        {
            form.RecordServerResponse(serverResponse);
        }
    }
}

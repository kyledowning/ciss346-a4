using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    public class ClientConsumer
    {

        // SendMessage is a static method called from ClientForm.cs when the sendMessage button is clicked.
        public static void SendMessage(string serverIpAddress, int port, string message, ClientForm form)
        {
            // Initalize a connection to the server.
            TcpClient client = new TcpClient(serverIpAddress, port);
            NetworkStream networkStream = client.GetStream();

            //Send the SMP packet - Consume message, append message type to message variable.
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

        // Process a consume response from server. Should contian message contents of consumed message.
        private static void ProcessResponsePacket(string serverResponse, ClientForm form)
        {
            form.RecordServerResponse(serverResponse);
        }
    }
}

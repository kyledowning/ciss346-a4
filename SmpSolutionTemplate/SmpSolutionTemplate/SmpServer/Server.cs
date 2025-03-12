using SmpServer;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SmpServer
{
    public class Server
    {
        static FormSmpServer formSmpServer;
        static TcpListener server;
        public static void Start(object obj)
        {
            formSmpServer = obj as FormSmpServer;

            server = new TcpListener(IPAddress.Parse(formSmpServer.IPAddress), formSmpServer.Port);

            try
            {
                server.Start();

                while (true)
                {
                    TcpClient clientConnection = server.AcceptTcpClient();

                    ProcessConnection(clientConnection);

                    clientConnection.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        public static void ProcessConnection(TcpClient clientConnection)
        {
            NetworkStream networkStream = clientConnection.GetStream();

            StreamReader streamReader = new StreamReader(networkStream);

            string message = streamReader.ReadLine();

            formSmpServer.RecordClientMessage(message);

            string response = "Received message: " + DateTime.Now;

            SendResponse(response, networkStream);

            streamReader.Close();
        }

        private static void SendResponse(String response, NetworkStream networkStream)
        {
            StreamWriter streamWriter = new StreamWriter(networkStream);

            streamWriter.WriteLine(response);

            streamWriter.Close();
        }

        public static void Stop()
        {
            server.Stop();
        }
    }
}

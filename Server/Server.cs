using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class Server
    {
        private Socket serverSocket;
        private List<ClientHandler> clients = new List<ClientHandler>();
        public Server()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Start()
        {
            serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
            serverSocket.Listen(1000);
        }

        public void HandleClients()
        {
            try
            {
                while (true)
                {
                    Socket socket = serverSocket.Accept();
                    ClientHandler client = new ClientHandler(socket);
                    clients.Add(client);
                    client.OdjavljenKlijent += Client_OdjavljenKlijent;
                    Thread clientThread = new Thread(client.HandleRequest);
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void Client_OdjavljenKlijent(object sender, EventArgs e)
        {
            clients.Remove((ClientHandler)sender);
        }

        internal void Stop()
        {
            serverSocket.Dispose();
            foreach (ClientHandler client in clients)
            {
                client.Stop();
            }
        }
    }
}

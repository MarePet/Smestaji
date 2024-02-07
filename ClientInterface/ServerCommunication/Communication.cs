using ClientInterface.Exceptions;
using Common;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace ClientInterface.ServerCommunication
{
    public class Communication
    {
        private Socket socket;
        private CommunicationHelper helper;
        private static Communication instance;
        private Communication() { }

        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }
        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public T SendRecieve<T>(Operation operation, object requestObject = null) where T : class
        {
            try
            {
                if (helper == null) return null;
                Request request = new Request(operation, requestObject);
                helper.Send(request);
                Response response = new Response();
                response = helper.Recieve<Response>();
                if(response==null) return null;
                if(!response.IsSuccesful)throw new SystemOperationException(response.Message);
                return (T)response.ResponseObject;
            }
            catch (IOException)
            {
                throw;
            }
        }
        public void Disconnect()
        {
            try
            {
                Request request = new Request(Operation.Disconnect);
                helper.Send(request);
                socket.Shutdown(SocketShutdown.Both);
                socket.Dispose();
            }
            catch (IOException ioe)
            {
                Debug.WriteLine(ioe.Message);
            }
        }
    }
}

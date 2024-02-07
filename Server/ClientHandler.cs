using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;

namespace Server
{
    internal class ClientHandler
    {
        private CommunicationHelper helper;
        private Socket socket;
        private bool kraj = false;

        public event EventHandler OdjavljenKlijent;

        public ClientHandler(Socket socket)
        {
            helper = new CommunicationHelper(socket);
            this.socket = socket;
        }


        internal void HandleRequest()
        {
            try
            {
                Request request;
                while (!kraj)
                {
                    request = helper.Recieve<Request>();
                    Response response = new Response();
                    try
                    {
                        response = CreateResponse(request);
                    }
                    catch (Exception)
                    {
                        response.IsSuccesful = false;
                        helper.Send(response);
                    }
                    helper.Send(response);
                }
            }
            catch (IOException ioex)
            {
                Debug.WriteLine("At HandleRequests: " + ioex.Message);
                kraj = true;
            }
            finally
            {
                Stop();
                OdjavljenKlijent.Invoke(this, EventArgs.Empty);
            }
        }
        private Response CreateResponse(Request request)
        {
            Response response = new Response();
            if (request == null) return null;
            switch (request.Operation)
            {
                case Operation.Login:
                    response.ResponseObject = Controller.Instance.Login((Administrator)request.RequestObject);
                    if (response.ResponseObject == null)
                    {
                        response.IsSuccesful = false;
                        response.Message = "Sistem ne može da pronađe administratora na osnovu unetih vrednosti!";
                    }
                    else response.IsSuccesful = true;
                    break;
                case Operation.AddNewClient:
                    response.IsSuccesful = Controller.Instance.AddNewClient((Client)request.RequestObject);
                    if(!response.IsSuccesful)
                    {
                        response.Message = "Sistem ne može da kreira novog klijenta";
                    }
                    else
                    {
                        response.ResponseObject = new Client();
                    }
                    break;
                case Operation.GetAllUsers:
                    response.ResponseObject = Controller.Instance.GetAllUsers((Client)request.RequestObject);
                    response.IsSuccesful = true;
                    break;
                case Operation.ClientSearch:
                    response.ResponseObject = Controller.Instance.Search((Client)request.RequestObject);
                    if(response.ResponseObject == null || ((List<Client>)response.ResponseObject).Count == 0) {
                        response.IsSuccesful = false;
                        response.Message = "Sistem ne može da pronađe klijente po zadatoj vrednosti!";
                    }else response.IsSuccesful = true;
                    break;
                case Operation.GetClient:
                    response.ResponseObject = Controller.Instance.GetClient((Client)request.RequestObject);
                    if (response.ResponseObject == null)
                    {
                        response.IsSuccesful = false;
                        response.Message = "Sistem ne može da učita klijenta!";
                    }
                    else response.IsSuccesful = true;
                    break;
                case Operation.UpdateClient:
                    response.IsSuccesful = Controller.Instance.UpdateClient((Client)request.RequestObject);
                    if (!response.IsSuccesful) response.Message = "Sistem ne može da izmeni klijenta!";
                    else response.ResponseObject = new Client();
                    break;
                case Operation.DeleteClient:
                    response.IsSuccesful = Controller.Instance.DeleteClient((Client)request.RequestObject);
                    if (!response.IsSuccesful) response.Message = "Sistem ne može da obrise klijenta!";
                    else response.ResponseObject = new Client();
                    break;
                case Operation.GetAllReservationType:
                    response.ResponseObject = Controller.Instance.GetAllReservationTypes((TipRezervacije)request.RequestObject);
                    response.IsSuccesful = true;
                    break;
                case Operation.GetAllServices:
                    response.ResponseObject = Controller.Instance.GetAllServices((Usluga)request.RequestObject);
                    response.IsSuccesful = true;
                    break;
                case Operation.AddNewReservation:
                    response.IsSuccesful = Controller.Instance.AddNewReservation((Rezervacija)request.RequestObject);
                    if (!response.IsSuccesful)
                    {
                        response.Message = "Sistem ne može da kreira rezervaciju";
                    }
                    else
                    {
                        response.ResponseObject = new Rezervacija();
                    }
                    break;
                case Operation.GetAllReservations:
                    response.ResponseObject = Controller.Instance.GetAllReservations((Rezervacija)request.RequestObject);
                    response.IsSuccesful = true;
                    break;
                case Operation.ReservationSearch:
                    response.ResponseObject = Controller.Instance.SearchReservation((Rezervacija)request.RequestObject);
                    if (response.ResponseObject == null || ((List<Rezervacija>)response.ResponseObject).Count == 0)
                    {
                        response.IsSuccesful = false;
                        response.Message = "Sistem ne može da pronađe rezervacije po zadatoj vrednosti!";
                    }
                    else response.IsSuccesful = true;
                    break;
                case Operation.GetRezervacija:
                    response.ResponseObject = Controller.Instance.GetReservation((Rezervacija)request.RequestObject);
                    if (response.ResponseObject == null)
                    {
                        response.IsSuccesful = false;
                        response.Message = "Sistem ne može da učita rezervaciju!";
                    }
                    else response.IsSuccesful = true;
                    break;
                case Operation.UpdateReservation:
                    response.IsSuccesful = Controller.Instance.UpdateReservation((Rezervacija)request.RequestObject);
                    if (!response.IsSuccesful) response.Message = "Sistem ne može da izmeni rezervaciju!";
                    else response.ResponseObject = new Rezervacija();
                    break;
                case Operation.DeleteReservation:
                    response.IsSuccesful = Controller.Instance.DeleteReservation((Rezervacija)request.RequestObject);
                    if (!response.IsSuccesful) response.Message = "Sistem ne može da obrise rezervaciju!";
                    else response.ResponseObject = new Rezervacija();
                    break;
            }
            return response;
        }
        internal void Stop()
        {
            if (socket != null)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Dispose();
                socket = null;
            }
        }

    }
}
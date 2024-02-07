using Domain;
using Repository.Implementation;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using SystemOperations;

namespace Server
{
    internal class Controller
    {
        private static Controller instance;
        private IDbRepository<IDomainObject> repository;

        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller()
        {
            repository = new GenericDbRepository();
        }

        internal Administrator Login(Administrator administrator)
        {
            SystemOperationBase so = new LoginSystemOperation(administrator);
            so.Execute();
            return ((LoginSystemOperation)so).Result;
        }

        internal bool AddNewClient(Client client)
        {
            SystemOperationBase so = new AddNewClientSystemOperation(client);
            so.Execute();
            return ((AddNewClientSystemOperation)so).Result;
        }

        internal List<Client> GetAllUsers(Client client)
        {
            SystemOperationBase so = new GetAllClientsSystemOperation();
            so.Execute();
            return ((GetAllClientsSystemOperation)so).Result;
        }

        internal List<Client> Search(Client client)
        {
            SystemOperationBase so = new ClientSearchSystemOperation(client);
            so.Execute();
            return ((ClientSearchSystemOperation)so).Result;
        }

        internal object GetClient(Client client)
        {
            SystemOperationBase so = new GetClientSystemOperation(client);
            so.Execute();
            return ((GetClientSystemOperation)so).Result;
        }

        internal bool UpdateClient(Client client)
        {
            SystemOperationBase so = new UpdateClientSystemOperation(client);
            so.Execute();
            return ((UpdateClientSystemOperation)so).Result;
        }

        internal bool DeleteClient(Client client)
        {
            SystemOperationBase so = new DeleteClientSystemOperation(client);
            so.Execute();
            return ((DeleteClientSystemOperation)so).Result;
        }

        internal List<TipRezervacije> GetAllReservationTypes(TipRezervacije tipRezervacije)
        {
            SystemOperationBase so = new GetAllReservationTypesSystemOperation(tipRezervacije);
            so.Execute();
            return ((GetAllReservationTypesSystemOperation)so).Result;
        }

        internal object GetAllServices(Usluga usluga)
        {
            SystemOperationBase so = new GetAllServicesSystemOperation(usluga);
            so.Execute();
            return ((GetAllServicesSystemOperation)so).Result;
        }

        internal List<Rezervacija> GetAllReservations(Rezervacija rezervacija)
        {
            SystemOperationBase so = new GetAllReservationsSystemOperation(rezervacija);
            so.Execute();
            return ((GetAllReservationsSystemOperation)so).Result;
        }

        internal bool AddNewReservation(Rezervacija rezervacija)
        {
            SystemOperationBase so = new AddNewReservationSystemOperation(rezervacija);
            so.Execute();
            return ((AddNewReservationSystemOperation)so).Result;
        }

        internal object SearchReservation(Rezervacija rezervacija)
        {
            SystemOperationBase so = new SearchReservationSystemOperation(rezervacija);
            so.Execute();
            return ((SearchReservationSystemOperation)so).Result;
        }

        internal object GetReservation(Rezervacija rezervacija)
        {
            SystemOperationBase so = new GetReservationSystemOperation(rezervacija);
            so.Execute();
            return ((GetReservationSystemOperation)so).Result;
        }

        internal bool UpdateReservation(Rezervacija rezervacija)
        {
            SystemOperationBase so = new UpdateReservationSystemOperation(rezervacija);
            so.Execute();
            return ((UpdateReservationSystemOperation)so).Result;
        }

        internal bool DeleteReservation(Rezervacija rezervacija)
        {
            SystemOperationBase so = new DeleteReservationSystemOperation(rezervacija);
            so.Execute() ;
            return ((DeleteReservationSystemOperation)so).Result;
        }
    }
}

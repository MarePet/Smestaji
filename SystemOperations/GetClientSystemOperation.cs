using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetClientSystemOperation : SystemOperationBase
    {
        private Client client;

        public GetClientSystemOperation(Client client)
        {
            this.client = client;
        }

        public Client Result { get; set; }
        protected override void ExecuteOperation()
        {
            client.criteria = "WHERE KlijentID = " + client.KlijentID;
            Result = (Client)repository.Get(client);
        }
    }
}

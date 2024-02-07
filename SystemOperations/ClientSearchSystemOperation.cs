using Domain;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations
{
    public class ClientSearchSystemOperation : SystemOperationBase
    {
        public List<Client> Result { get; set; }
        Client client;
        public ClientSearchSystemOperation(Client client)
        {
            this.client = client;
        }
        protected override void ExecuteOperation()
        {
           Result = repository.Search(client).OfType<Client>().ToList();
        }
    }
}

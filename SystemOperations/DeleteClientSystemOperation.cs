using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class DeleteClientSystemOperation : SystemOperationBase
    {
        private Client client;

        public DeleteClientSystemOperation(Client client)
        {
            this.client = client;
        }

        public bool Result { get; set; }
        protected override void ExecuteOperation()
        {
            try
            {
                client.criteria = $"WHERE KlijentId = {client.KlijentID}";
                repository.Delete(client);
                Result = true;
            }
            catch (Exception)
            {
                Result = false;
            }
        }
    }
}

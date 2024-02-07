using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class AddNewClientSystemOperation : SystemOperationBase
    {
        private Client client;
        public bool Result { get; private set; }
        public AddNewClientSystemOperation(Client client)
        {
            this.client = client;
        }

        protected override void ExecuteOperation()
        {
            try
            {
                repository.Add(client);
                Result = true;
            }
            catch (Exception)
            {
                Result = false;
                throw;
            }
        }
    }
}

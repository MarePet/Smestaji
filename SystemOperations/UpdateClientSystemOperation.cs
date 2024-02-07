using Domain;
using System;

namespace SystemOperations
{
    public class UpdateClientSystemOperation : SystemOperationBase
    {
        private Client client;

        public UpdateClientSystemOperation(Client client)
        {
            this.client = client;
        }

        public bool Result { get; set; }
        protected override void ExecuteOperation()
        {
            try
            {
                client.criteria = $"SET Email='{client.Email}', Telefon='{client.Telefon}' WHERE KlijentId = {client.KlijentID};";
                repository.Update(client);
                Result = true;
            }
            catch (Exception)
            {
                Result = false;
            }
        }
    }
}

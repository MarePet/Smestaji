using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetAllClientsSystemOperation : SystemOperationBase
    {
        public List<Client> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(new Client()).OfType<Client>().ToList();
        }
    }
}

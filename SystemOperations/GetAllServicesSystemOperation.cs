using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetAllServicesSystemOperation : SystemOperationBase
    {
        private Usluga usluga;

        public GetAllServicesSystemOperation(Usluga usluga)
        {
            this.usluga = usluga;
        }

        public List<Usluga> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(usluga).OfType<Usluga>().ToList();
        }
    }
}

using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetAllReservationTypesSystemOperation : SystemOperationBase
    {
        private TipRezervacije tipRezervacije;
        public List<TipRezervacije> Result { get; set; }

        public GetAllReservationTypesSystemOperation(TipRezervacije tipRezervacije)
        {
            this.tipRezervacije = tipRezervacije;
        }

        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(tipRezervacije).OfType<TipRezervacije>().ToList();
        }
    }
}

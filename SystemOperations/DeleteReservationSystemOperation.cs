using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class DeleteReservationSystemOperation : SystemOperationBase
    {
        private Rezervacija rezervacija;

        public DeleteReservationSystemOperation(Rezervacija rezervacija)
        {
            this.rezervacija = rezervacija;
        }

        public bool Result { get; set; }

        protected override void ExecuteOperation()
        {
            try
            {
                rezervacija.criteria = $"WHERE RezervacijaID = {rezervacija.RezervacijaID}";
                repository.Delete(rezervacija);
                foreach (StavkaRezervacije stavkaRezervacije in rezervacija.StavkeRezervacije)
                {
                    stavkaRezervacije.criteria = "";
                    repository.Delete(stavkaRezervacije);
                }
                Result = true;
            }
            catch (Exception)
            {
                Result = false;
            }
        }
    }
}

using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetReservationSystemOperation : SystemOperationBase
    {
        private Rezervacija rezervacija;

        public GetReservationSystemOperation(Rezervacija rezervacija)
        {
            this.rezervacija = rezervacija;
        }

        public Rezervacija Result { get; set; }
        protected override void ExecuteOperation()
        {
            rezervacija.criteria = "WHERE RezervacijaID = " + rezervacija.RezervacijaID;
            Result = (Rezervacija)repository.Get(rezervacija);
            StavkaRezervacije sr = new StavkaRezervacije();
            Result.StavkeRezervacije = new List<StavkaRezervacije>();
            sr.RezervacijaID = Result.RezervacijaID;
            Result.StavkeRezervacije = repository.GetAll(sr).OfType<StavkaRezervacije>().ToList();
        }
    }
}

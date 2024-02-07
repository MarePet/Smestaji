using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class GetAllReservationsSystemOperation : SystemOperationBase
    {
        private Rezervacija rezervacija;

        public GetAllReservationsSystemOperation(Rezervacija rezervacija)
        {
            this.rezervacija = rezervacija;
         }

        public List<Rezervacija>  Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(rezervacija).OfType<Rezervacija>().ToList();   
            foreach (Rezervacija r in Result)
            {
                StavkaRezervacije sr = new StavkaRezervacije();
                r.StavkeRezervacije = new List<StavkaRezervacije>();
                sr.RezervacijaID = r.RezervacijaID;
                r.StavkeRezervacije.Add((StavkaRezervacije)repository.Get(sr));
            }
        }
    }
}

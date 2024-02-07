using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class AddNewReservationSystemOperation : SystemOperationBase
    {
        private Rezervacija rezervacija;
        public bool Result { get; set; }

        public AddNewReservationSystemOperation(Rezervacija rezervacija)
        {
            this.rezervacija = rezervacija;
        }

        protected override void ExecuteOperation()
        {
            try
            {
                repository.Add(rezervacija);
                foreach (StavkaRezervacije sr in rezervacija.StavkeRezervacije)
                {
                    repository.Add(sr);
                }
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

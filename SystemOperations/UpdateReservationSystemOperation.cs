using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UpdateReservationSystemOperation : SystemOperationBase
    {
        private Rezervacija rezervacija;
        public bool Result { get; set; }
        public UpdateReservationSystemOperation(Rezervacija rezervacija)
        {
            this.rezervacija = rezervacija;
        }

        protected override void ExecuteOperation()
        {
            try
            {
                rezervacija.criteria = $"SET TipRezervacijeID = {rezervacija.TipRezervacije.TipRezervacijeID}, DatumPocetka = '{rezervacija.DatumPocetka.ToString("yyyy-MM-dd")}',DatumKraja = '{rezervacija.DatumKraja.ToString("yyyy-MM-dd")}' ,BrojDana = {rezervacija.BrojDana}, UkupnaCena = {rezervacija.UkupnaCena.ToString("##.##")} WHERE RezervacijaID = {rezervacija.RezervacijaID}";
                repository.Update(rezervacija);
                foreach (StavkaRezervacije stavkaRezervacije in rezervacija.StavkeRezervacije)
                {
                    stavkaRezervacije.criteria = "";
                    repository.Delete(stavkaRezervacije);
                }
                foreach (StavkaRezervacije stavkaRezervacije1 in rezervacija.StavkeRezervacije)
                {
                    stavkaRezervacije1.criteria = "";
                    repository.Add(stavkaRezervacije1);
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

using ClientInterface.Dialogs.Reservation_dialogs;
using ClientInterface.Exceptions;
using ClientInterface.ServerCommunication;
using ClientInterface.UserControls.Reservation;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientInterface.GUIController.Reservation
{
    internal class UCUpdateReservationController
    {
        internal void Add(ReservationUpdateDialog reservationUpdateDialog,Rezervacija rezervacija)
        {
            ReservationUpdateAddServiceDialog form = new ReservationUpdateAddServiceDialog(rezervacija,reservationUpdateDialog);
            bool kraj = false;
            while (!kraj)
            {
                form.ShowDialog();
                if(form.DialogResult == DialogResult.OK)
                {
                    kraj = true;
                    form.Dispose();
                    return;
                }
            }
        }

        internal void AddService(ReservationUpdateAddServiceDialog reservationUpdateAddServiceDialog, ReservationUpdateDialog reservationUpdateDialog, Rezervacija rezervacija)
        {
            Usluga service = reservationUpdateAddServiceDialog.CbUsluge.SelectedItem as Usluga;
            foreach (StavkaRezervacije sr in rezervacija.StavkeRezervacije)
            {
                if (sr.UslugaID == null) return;
                if (sr.UslugaID.NazivUsluge == service.NazivUsluge)
                {
                    MessageBox.Show("Usluga je već dodata!");
                    return;
                }
            }
            
            StavkaRezervacije stavka = new StavkaRezervacije()
            {
                RezervacijaID = rezervacija.RezervacijaID,
                RBStavke = rezervacija.StavkeRezervacije.Count + 1,
                UslugaID = service,
            };
            rezervacija.StavkeRezervacije.Add(stavka);
            reservationUpdateDialog.DgvUsluge.DataSource = rezervacija.StavkeRezervacije.ToList();
            reservationUpdateDialog.DgvUsluge.Refresh();
        }

        internal void Init(UCUpdateReservation uCUpdateReservation)
        {
            BindingList<Rezervacija> prikaz;
            List<Rezervacija> odgovor = Communication.Instance.SendRecieve<List<Rezervacija>>(Operation.GetAllReservations, new Rezervacija());
            try
            {
                prikaz = new BindingList<Rezervacija>(odgovor);
                uCUpdateReservation.DgvReservations.DataSource = prikaz;
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        internal void InitForm(ReservationUpdateDialog reservationUpdateDialog, Rezervacija rezervacija)
        {
            reservationUpdateDialog.TextBox1.Text = rezervacija.Klijent.ImeKlijenta + " " + rezervacija.Klijent.PrezimeKlijenta;
            reservationUpdateDialog.DpDatumPocetka.Value = rezervacija.DatumPocetka;
            reservationUpdateDialog.DpDatumKraja.Value = rezervacija.DatumKraja;
            reservationUpdateDialog.TxtBrojDana.Text = rezervacija.BrojDana.ToString();
            reservationUpdateDialog.TxtUkupnaCena.Text = rezervacija.UkupnaCena.ToString();
            reservationUpdateDialog.DgvUsluge.DataSource = rezervacija.StavkeRezervacije;

            BindingList<TipRezervacije> cbTipRezervacije;
            List<TipRezervacije> odgovorTR = Communication.Instance.SendRecieve<List<TipRezervacije>>(Operation.GetAllReservationType, new TipRezervacije());
            try
            {
                cbTipRezervacije = new BindingList<TipRezervacije>(odgovorTR);
                reservationUpdateDialog.CbTipoviRezervacije.DataSource = odgovorTR;
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        internal void InitServiceForm(ReservationUpdateAddServiceDialog reservationUpdateAddServiceDialog, Rezervacija rezervacija)
        {
            BindingList<Usluga> cbServices;
            List<Usluga> odgovorServices = Communication.Instance.SendRecieve<List<Usluga>>(Operation.GetAllServices, new Usluga());
            try
            {
                cbServices = new BindingList<Usluga>(odgovorServices);
                reservationUpdateAddServiceDialog.CbUsluge.DataSource = cbServices;
                reservationUpdateAddServiceDialog.TxtOpis.Text = ((Usluga)reservationUpdateAddServiceDialog.CbUsluge.SelectedItem).NazivUsluge;
                reservationUpdateAddServiceDialog.TxtCena.Text = ((Usluga)reservationUpdateAddServiceDialog.CbUsluge.SelectedItem).CenaUslugePoDanu.ToString();
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        internal void Obracunaj(ReservationUpdateDialog reservationUpdateDialog,Rezervacija rezervacija)
        {
            if (rezervacija.StavkeRezervacije.Count == 0)
            {
                MessageBox.Show("Rezervacija mora imati barem jednu stavku!");
                return;
            }
            decimal cenaUsluga = 0;
            foreach (StavkaRezervacije sr in rezervacija.StavkeRezervacije)
            {
                if (sr.UslugaID == null) return;
                cenaUsluga += sr.UslugaID.CenaUslugePoDanu;
            }
            decimal cenaAranzmana = ((TipRezervacije)reservationUpdateDialog.CbTipoviRezervacije.SelectedItem).CenaPoDanu;

            DateTime pocetak = reservationUpdateDialog.DpDatumPocetka.Value;
            DateTime kraj = reservationUpdateDialog.DpDatumKraja.Value;
            
            if (pocetak > kraj)
            {
                MessageBox.Show("Krajnji datum mora biti posle početnog datuma!");
                return;
            }
            if (kraj.Subtract(pocetak).TotalDays < 2)
            {
                MessageBox.Show("Minimalno trajanje rezervacije je 2 dana!");
                return;
            }

            reservationUpdateDialog.TxtUkupnaCena.Text = ((decimal)kraj.Subtract(pocetak).TotalDays * (cenaUsluga + cenaAranzmana)).ToString("F");
        }

        internal void RefreshData(ReservationUpdateAddServiceDialog reservationUpdateAddServiceDialog)
        {
            reservationUpdateAddServiceDialog.TxtOpis.Text = ((Usluga)reservationUpdateAddServiceDialog.CbUsluge.SelectedItem).NazivUsluge;
            reservationUpdateAddServiceDialog.TxtCena.Text = ((Usluga)reservationUpdateAddServiceDialog.CbUsluge.SelectedItem).CenaUslugePoDanu.ToString();
        }

        internal void RemoveService(ReservationUpdateDialog reservationUpdateDialog, Rezervacija rezervacija)
        {
            if(reservationUpdateDialog.DgvUsluge.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate odabrati uslugu za brisanje!");
                return;
            }
            StavkaRezervacije sr = reservationUpdateDialog.DgvUsluge.SelectedRows[0].DataBoundItem as StavkaRezervacije;
            rezervacija.StavkeRezervacije.Remove(sr);
            int i = 1;
            foreach (StavkaRezervacije stavkaRezervacije in rezervacija.StavkeRezervacije)
            {
                stavkaRezervacije.RBStavke = i++;
            }
            BindingList<StavkaRezervacije> list = new BindingList<StavkaRezervacije>(rezervacija.StavkeRezervacije);
            reservationUpdateDialog.DgvUsluge.DataSource = list;
        }

        internal void Search(UCUpdateReservation uCUpdateReservation)
        {
            if (string.IsNullOrEmpty(uCUpdateReservation.TxtCriteria.Text))
            {
                System.Windows.Forms.MessageBox.Show("Unesite kriterijum za pretragu!");
                return;
            }
            string criteria = uCUpdateReservation.TxtCriteria.Text;
            if (int.TryParse(uCUpdateReservation.TxtCriteria.Text, out int result))
            {
                criteria =
                $"WHERE YEAR(r.DatumPocetka) LIKE {result}" +
                $" OR DAY(r.DatumPocetka) LIKE {result}" +
                $" OR MONTH(r.DatumPocetka) LIKE {result}" +
                $" OR YEAR(r.DatumPocetka) LIKE {result}";
            }
            else
            {
                criteria = $"WHERE r.ImeKlijenta = '{uCUpdateReservation.TxtCriteria.Text}%' OR r.PrezimeKlijenta LIKE '{uCUpdateReservation.TxtCriteria.Text}%'";
            }
            Rezervacija rezervacija = new Rezervacija();
            rezervacija.criteria = criteria;
            List<Rezervacija> pronadjeneRezervacije = new List<Rezervacija>();
            try
            {
                pronadjeneRezervacije = Communication.Instance.SendRecieve<List<Rezervacija>>(Operation.ReservationSearch, rezervacija);
                try
                {
                    BindingList<Rezervacija> list = new BindingList<Rezervacija>(pronadjeneRezervacije);
                    uCUpdateReservation.DgvReservations.DataSource = list;
                }
                catch (ArgumentNullException)
                {
                    return;
                }
                System.Windows.Forms.MessageBox.Show("Sistem je našao rezervacije po zadatoj vrednosti!");
            }
            catch (SystemOperationException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }

        internal void SetDate(ReservationUpdateDialog reservationUpdateDialog)
        {
            DateTime pocetak = reservationUpdateDialog.DpDatumPocetka.Value;
            DateTime kraj = reservationUpdateDialog.DpDatumKraja.Value;
            if (pocetak > kraj)
            {
                MessageBox.Show("Krajnji datum mora biti posle početnog datuma!");
                return;
            }
            if (kraj.Subtract(pocetak).TotalDays < 2)
            {
                MessageBox.Show("Minimalno trajanje rezervacije je 2 dana!");
                return;
            }
            reservationUpdateDialog.TxtBrojDana.Text = kraj.Subtract(pocetak).TotalDays.ToString();
        }

        internal void Update(UCUpdateReservation uCUpdateReservation)
        {
            bool kraj = false;
            while (!kraj)
            {
                if (uCUpdateReservation.DgvReservations.SelectedRows.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne može da učita rezervaciju!");
                    return;
                }
                Rezervacija rezervacija = uCUpdateReservation.DgvReservations.SelectedRows[0].DataBoundItem as Rezervacija;
                rezervacija = Communication.Instance.SendRecieve<Rezervacija>(Operation.GetRezervacija, rezervacija);
                if (rezervacija == null) return;
                MessageBox.Show("Sistem je učitao rezervaciju!");
                ReservationUpdateDialog form = new ReservationUpdateDialog(rezervacija);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    kraj = true;
                    form.Dispose();
                    return;
                }
            }
        }

        internal void UpdateReservation(ReservationUpdateDialog reservationUpdateDialog, Rezervacija rezervacija)
        {
            if (!Validacija(reservationUpdateDialog,rezervacija))
            {
                return;
            }
            rezervacija.TipRezervacije = reservationUpdateDialog.CbTipoviRezervacije.SelectedItem as TipRezervacije;
            rezervacija.DatumPocetka = reservationUpdateDialog.DpDatumPocetka.Value;
            rezervacija.DatumKraja = reservationUpdateDialog.DpDatumKraja.Value;
            rezervacija.BrojDana = int.Parse(reservationUpdateDialog.TxtBrojDana.Text);
            rezervacija.UkupnaCena = decimal.Parse(reservationUpdateDialog.TxtUkupnaCena.Text);

            try
            {
                if (Communication.Instance.SendRecieve<Rezervacija>(Operation.UpdateReservation, rezervacija) == null) return;
                reservationUpdateDialog.DialogResult = DialogResult.OK;
                MessageBox.Show("Sistem je izmenio rezervaciju!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool Validacija(ReservationUpdateDialog reservationUpdateDialog, Rezervacija rezervacija)
        {
            if (string.IsNullOrEmpty(reservationUpdateDialog.TxtUkupnaCena.Text))
            {
                reservationUpdateDialog.TxtUkupnaCena.BackColor = Color.Salmon;
                MessageBox.Show("Sva polja su obavezna!");
                return false;
            }
            else reservationUpdateDialog.TxtUkupnaCena.BackColor = Color.White;
            if(rezervacija.StavkeRezervacije.Count == 0)
            {
                MessageBox.Show("Mora biti odabrana barem jedna usluga!");
                return false;
            }
            return true;
        }
    }
}

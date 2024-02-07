using ClientInterface.Exceptions;
using ClientInterface.ServerCommunication;
using ClientInterface.UserControls.Reservation;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClientInterface.GUIController.Reservation
{
    internal class UCAddNewReservationController
    {


        internal void Init(UCAddNewReservation uCAddNewReservation)
        {
            BindingList<Client> cbClient;
            BindingList<TipRezervacije> cbTipRezervacije;
            List<Client> odgovorClient = Communication.Instance.SendRecieve<List<Client>>(Operation.GetAllUsers, new Client());
            List<TipRezervacije> odgovorTR = Communication.Instance.SendRecieve<List<TipRezervacije>>(Operation.GetAllReservationType, new TipRezervacije());
            try
            {
                List<Usluga> services = new List<Usluga>();
                cbClient = new BindingList<Client>(odgovorClient);
                cbTipRezervacije = new BindingList<TipRezervacije>(odgovorTR);
                uCAddNewReservation.CbKlijenti.DataSource = cbClient;
                uCAddNewReservation.CbTipoviRezervacije.DataSource = cbTipRezervacije;
                uCAddNewReservation.DgvUsluge.DataSource = services;
                uCAddNewReservation.TxtAdministrator.Text = Session.Session.Instance.CurrentAdmin.Ime + " " + Session.Session.Instance.CurrentAdmin.Prezime;
            }
            catch (ArgumentNullException)
            {
                return;
            }

        }

        internal void SetDate(UCAddNewReservation uCAddNewReservation)
        {
            DateTime pocetak = uCAddNewReservation.DpDatumPocetka.Value;
            DateTime kraj = uCAddNewReservation.DpDatumKraja.Value;
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
            uCAddNewReservation.TxtBrojDana.Text = kraj.Subtract(pocetak).TotalDays.ToString();
        }

        internal void CreateReservation(UCAddNewReservation uCAddNewReservation)
        {

            if (!Validacija(uCAddNewReservation)) return;
            string datumPocetka = uCAddNewReservation.DpDatumPocetka.Value.ToString("yyyy-MM-dd");
            string datumKraja = uCAddNewReservation.DpDatumKraja.Value.ToString("yyyy-MM-dd");
            Rezervacija rezervacija = new Rezervacija()
            {
                RezervacijaID = int.Parse(uCAddNewReservation.TxtIDRezervacije.Text),
                DatumPocetka = DateTime.ParseExact(datumPocetka, "yyyy-MM-dd", null),
                DatumKraja = DateTime.ParseExact(datumKraja,"yyyy-MM-dd", null),
                BrojDana = int.Parse(uCAddNewReservation.TxtBrojDana.Text),
                UkupnaCena = decimal.Parse(uCAddNewReservation.TxtUkupnaCena.Text),
                TipRezervacije = uCAddNewReservation.CbTipoviRezervacije.SelectedItem as TipRezervacije,
                Klijent = uCAddNewReservation.CbKlijenti.SelectedItem as Client,
                Administrator = Session.Session.Instance.CurrentAdmin,
            };
            List<StavkaRezervacije> stavke = new List<StavkaRezervacije>();
            int i = 1;
            foreach (Usluga u in Session.Session.Instance.Usluge)
            {
                StavkaRezervacije sr = new StavkaRezervacije();
                sr.RezervacijaID = rezervacija.RezervacijaID;
                sr.RBStavke = i;
                sr.UslugaID = u;
                i++;
                stavke.Add(sr);
            }
            rezervacija.StavkeRezervacije = stavke;
            try
            {
                if (Communication.Instance.SendRecieve<Rezervacija>(Operation.AddNewReservation, rezervacija) == null) return;
                MessageBox.Show("Sistem je kreirao rezervaciju!");
                Session.Session.Instance.Usluge.Clear();
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Validacija(UCAddNewReservation uCAddNewReservation)
        {
            if (string.IsNullOrEmpty(uCAddNewReservation.TxtIDRezervacije.Text))
            {
                MessageBox.Show("Sva polja su obavezna!");
                uCAddNewReservation.TxtIDRezervacije.BackColor = Color.Salmon;
                return false;
            }
            else uCAddNewReservation.TxtIDRezervacije.BackColor = Color.White;
            if (string.IsNullOrEmpty(uCAddNewReservation.TxtUkupnaCena.Text))
            {
                MessageBox.Show("Sva polja su obavezna!");
                uCAddNewReservation.TxtUkupnaCena.BackColor = Color.Salmon;
                return false;
            }
            else uCAddNewReservation.TxtUkupnaCena.BackColor = Color.White;
            if (Session.Session.Instance.Usluge.Count == 0)
            {
                MessageBox.Show("Mora biti izabrana barem jedna usluga!");
                return false;
            }
            try
            {
                List<Rezervacija> reservations = Communication.Instance.SendRecieve<List<Rezervacija>>(Operation.GetAllReservations, new Rezervacija());
                if(reservations == null) return false;
                foreach (Rezervacija r in reservations)
                {
                    if (r.Klijent.ImeKlijenta == ((Client)uCAddNewReservation.CbKlijenti.SelectedItem).ImeKlijenta && r.Klijent.PrezimeKlijenta == ((Client)uCAddNewReservation.CbKlijenti.SelectedItem).PrezimeKlijenta && r.DatumPocetka.ToString("yyyy-MM-dd") == uCAddNewReservation.DpDatumPocetka.Value.ToString("yyyy-MM-dd") && r.DatumKraja.ToString("yyyy-MM-dd") == uCAddNewReservation.DpDatumKraja.Value.ToString("yyyy-MM-dd"))
                    {
                        MessageBox.Show("Klijent već ima rezervaciju za izabrani termin!");
                        return false;
                    }
                }
                return true;
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}

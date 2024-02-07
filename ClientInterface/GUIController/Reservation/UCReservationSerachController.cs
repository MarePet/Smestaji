using ClientInterface.Dialogs.Client_dialogs;
using ClientInterface.Dialogs.Reservation_dialogs;
using ClientInterface.Exceptions;
using ClientInterface.ServerCommunication;
using ClientInterface.UserControls.Reservation;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientInterface.GUIController.Reservation
{
    internal class UCReservationSerachController
    {
        internal void Details(UCReservationSearch uCReservationSearch)
        {
            bool kraj = false;
            while (!kraj)
            {
                if (uCReservationSearch.DgvUsers.SelectedRows.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne može da učita rezervaciju!");
                    return;
                }
                Rezervacija rezervacija = uCReservationSearch.DgvUsers.SelectedRows[0].DataBoundItem as Rezervacija;
                rezervacija = Communication.Instance.SendRecieve<Rezervacija>(Operation.GetRezervacija, rezervacija);
                if (rezervacija == null) return;
                MessageBox.Show("Sistem je učitao rezervaciju!");
                ReservationDetails form = new ReservationDetails(rezervacija);
                form.ShowDialog();
                if(form.DialogResult == DialogResult.OK)
                {
                    kraj = true;
                    form.Dispose();
                    return;
                }
            }
        }

        internal void Init(UCReservationSearch uCReservationSearch)
        {
            BindingList<Rezervacija> prikaz;
            List<Rezervacija> odgovor = Communication.Instance.SendRecieve<List<Rezervacija>>(Operation.GetAllReservations, new Rezervacija());
            try
            {
                prikaz = new BindingList<Rezervacija>(odgovor);
                uCReservationSearch.DgvUsers.DataSource = prikaz;
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        internal void InitForm(ReservationDetails reservationDetails, Rezervacija rezervacija)
        {
            reservationDetails.TxtKlijent.Text = rezervacija.Klijent.ImeKlijenta + " " + rezervacija.Klijent.PrezimeKlijenta;
            reservationDetails.TxtBrojDana.Text = rezervacija.BrojDana.ToString();
            reservationDetails.TxtUkupnaCena.Text = rezervacija.UkupnaCena.ToString();
            reservationDetails.DgvUsluge.DataSource = rezervacija.StavkeRezervacije;
        }

        internal void Search(UCReservationSearch uCReservationSearch)
        {
            if(string.IsNullOrEmpty(uCReservationSearch.TxtCriteria.Text))
            {
                System.Windows.Forms.MessageBox.Show("Unesite kriterijum za pretragu!");
                return;
            }
            string criteria = uCReservationSearch.TxtCriteria.Text;
            if (int.TryParse(uCReservationSearch.TxtCriteria.Text, out int result))
            {
                criteria = 
                $"WHERE YEAR(r.DatumPocetka) LIKE {result}" +
                $" OR DAY(r.DatumPocetka) LIKE {result}" +
                $" OR MONTH(r.DatumPocetka) LIKE {result}" +
                $" OR YEAR(r.DatumPocetka) LIKE {result}";
            }
            else
            {
               criteria = $"WHERE r.ImeKlijenta = '{uCReservationSearch.TxtCriteria.Text}%' OR r.PrezimeKlijenta LIKE '{uCReservationSearch.TxtCriteria.Text}%'";
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
                    uCReservationSearch.DgvUsers.DataSource = list;
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
    }
}

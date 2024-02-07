using ClientInterface.Dialogs.Reservation_dialogs;
using ClientInterface.ServerCommunication;
using ClientInterface.Session;
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
    internal class ServicesController
    {
        
        BindingList<Usluga> services = new BindingList<Usluga>();
        public BindingList<Usluga> Services { get; set; }
        public ServicesController( )
        {
           
        }

        internal void Add(UCAddNewReservation uCAddNewReservation)
        {
            AddServicesDialog form = new AddServicesDialog(uCAddNewReservation);
            bool kraj = false;
            while (!kraj)
            {
                form.ShowDialog();
                if(form.DialogResult == DialogResult.OK)
                {
                    kraj = true;
                    return;
                }
            }
        }

        internal void AddService(AddServicesDialog addServicesDialog, UCAddNewReservation uCAddNewReservation)
        {
            Usluga service = addServicesDialog.CbUsluge.SelectedItem as Usluga;
            if (Session.Session.Instance.Usluge.Contains(service))
            {
                MessageBox.Show("Usluga je već dodata!");
                return;
            }
            services.Add(service);
            Session.Session.Instance.Usluge = services;
            uCAddNewReservation.DgvUsluge.DataSource = Session.Session.Instance.Usluge;
        }

        internal void Init(AddServicesDialog addServicesDialog)
        {
            BindingList<Usluga> cbServices;
            List<Usluga> odgovorServices = Communication.Instance.SendRecieve<List<Usluga>>(Operation.GetAllServices, new Usluga());
            try
            {
                cbServices = new BindingList<Usluga>(odgovorServices);
                addServicesDialog.CbUsluge.DataSource = cbServices;
                addServicesDialog.TxtOpis.Text = ((Usluga)addServicesDialog.CbUsluge.SelectedItem).NazivUsluge;
                addServicesDialog.TxtCena.Text = ((Usluga)addServicesDialog.CbUsluge.SelectedItem).CenaUslugePoDanu.ToString();
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        internal void Remove(UCAddNewReservation uCAddNewReservation)
        {
            if (uCAddNewReservation.DgvUsluge.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate odabrati red za brisanje!");
                return;
            }
            Session.Session.Instance.Usluge.Remove(uCAddNewReservation.DgvUsluge.SelectedRows[0].DataBoundItem as Usluga);
        }

        internal void UpdateData(AddServicesDialog addServicesDialog)
        {
            addServicesDialog.TxtOpis.Text = ((Usluga)addServicesDialog.CbUsluge.SelectedItem).NazivUsluge;
            addServicesDialog.TxtCena.Text = ((Usluga)addServicesDialog.CbUsluge.SelectedItem).CenaUslugePoDanu.ToString();
        }

        internal void Obracunaj(UCAddNewReservation uCAddNewReservation)
        {
            if(Session.Session.Instance.Usluge.Count  == 0)
            {
                MessageBox.Show("Rezervacija mora imati barem jednu stavku!");
                return;
            }
            decimal cenaUsluga = 0;
            foreach (Usluga usluga in Session.Session.Instance.Usluge)
            {
                if (usluga == null) return;
                cenaUsluga += usluga.CenaUslugePoDanu;
            }
            decimal cenaAranzmana = ((TipRezervacije)uCAddNewReservation.CbTipoviRezervacije.SelectedItem).CenaPoDanu;

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

            uCAddNewReservation.TxtUkupnaCena.Text = ((decimal)kraj.Subtract(pocetak).TotalDays * (cenaUsluga + cenaAranzmana)).ToString("F");
        }
    }
}

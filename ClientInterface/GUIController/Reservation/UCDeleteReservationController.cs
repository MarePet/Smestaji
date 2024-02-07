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
    internal class UCDeleteReservationController
    {
        internal void Delete(Rezervacija rezervacija, DeleteReservationDialog deleteReservationDialog)
        {
            try
            {
                if (Communication.Instance.SendRecieve<Rezervacija>(Operation.DeleteReservation, rezervacija) == null) return;
                System.Windows.Forms.MessageBox.Show("Sistem je obrisao rezervaciju!");
                deleteReservationDialog.DialogResult = DialogResult.OK;
            }
            catch (SystemOperationException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void Details(UCDeleteReservation uCDeleteReservation)
        {
            bool kraj = false;
            while (!kraj)
            {
                if (uCDeleteReservation.DgvReservations.SelectedRows.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne može da učita rezervaciju!");
                    return;
                }
                Rezervacija rezervacija = uCDeleteReservation.DgvReservations.SelectedRows[0].DataBoundItem as Rezervacija;
                rezervacija = Communication.Instance.SendRecieve<Rezervacija>(Operation.GetRezervacija, rezervacija);
                if (rezervacija == null) return;
                MessageBox.Show("Sistem je učitao rezervaciju!");
                DeleteReservationDialog form = new DeleteReservationDialog(rezervacija);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    kraj = true;
                    form.Dispose();
                    Init(uCDeleteReservation);
                    return;
                }
            }
        }

        internal void Init(UCDeleteReservation uCDeleteReservation)
        {
            BindingList<Rezervacija> prikaz;
            List<Rezervacija> odgovor = Communication.Instance.SendRecieve<List<Rezervacija>>(Operation.GetAllReservations, new Rezervacija());
            try
            {
                prikaz = new BindingList<Rezervacija>(odgovor);
                uCDeleteReservation.DgvReservations.DataSource = prikaz;
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        internal void InitForm(DeleteReservationDialog deleteReservationDialog, Rezervacija rezervacija)
        {
            deleteReservationDialog.TxtKlijent.Text = rezervacija.Klijent.ImeKlijenta + " " + rezervacija.Klijent.PrezimeKlijenta;
            deleteReservationDialog.TxtBrojDana.Text = rezervacija.BrojDana.ToString();
            deleteReservationDialog.TxtUkupnaCena.Text = rezervacija.UkupnaCena.ToString();
            deleteReservationDialog.DgvUsluge.DataSource = rezervacija.StavkeRezervacije;
        }
    }
}

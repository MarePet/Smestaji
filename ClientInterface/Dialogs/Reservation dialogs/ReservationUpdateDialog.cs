using ClientInterface.GUIController.Reservation;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientInterface.Dialogs.Reservation_dialogs
{
    public partial class ReservationUpdateDialog : Form
    {
        private UCUpdateReservationController controller;
        private Rezervacija rezervacija;
        public ReservationUpdateDialog(Domain.Rezervacija rezervacija)
        {
            InitializeComponent();
            controller = new UCUpdateReservationController();
            Init(rezervacija);
            this.rezervacija = rezervacija;
        }

        private void Init(Domain.Rezervacija rezervacija)
        {
            controller.InitForm(this,rezervacija);
        }

        private void dpDatumKraja_ValueChanged(object sender, EventArgs e)
        {
            controller.SetDate(this);
        }

        private void btnObracunaj_Click(object sender, EventArgs e)
        {
            controller.Obracunaj(this,rezervacija);
        }

        private void btnDodajUsluge_Click(object sender, EventArgs e)
        {
            controller.Add(this,rezervacija);
        }

        private void btnIzmeniRezervaciju_Click(object sender, EventArgs e)
        {
            controller.UpdateReservation(this, rezervacija);
        }

        private void btnObrisiUslugu_Click(object sender, EventArgs e)
        {
            controller.RemoveService(this, rezervacija);
        }

        private void ReservationUpdateDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

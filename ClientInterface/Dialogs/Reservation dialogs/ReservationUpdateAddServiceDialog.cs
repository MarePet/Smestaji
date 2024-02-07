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
    public partial class ReservationUpdateAddServiceDialog : Form
    {
        private UCUpdateReservationController controller;
        private Rezervacija rezervacija;
        private ReservationUpdateDialog reservationUpdateDialog;
        public ReservationUpdateAddServiceDialog(Domain.Rezervacija rezervacija, ReservationUpdateDialog reservationUpdateDialog)
        {
            InitializeComponent();
            controller = new UCUpdateReservationController();
            Init(rezervacija);
            this.rezervacija = rezervacija;
            this.reservationUpdateDialog = reservationUpdateDialog;
        }

        private void Init(Rezervacija rezervacija)
        {
            controller.InitServiceForm(this,rezervacija);
        }

        private void btnDodajUslugu_Click(object sender, EventArgs e)
        {
            controller.AddService(this, reservationUpdateDialog,rezervacija);
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cbUsluge_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.RefreshData(this);
        }
    }
}

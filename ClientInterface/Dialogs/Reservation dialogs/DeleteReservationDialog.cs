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
    public partial class DeleteReservationDialog : Form
    {
        private UCDeleteReservationController controller;
        private Rezervacija rezervacija;
        public DeleteReservationDialog(Domain.Rezervacija rezervacija)
        {
            InitializeComponent();
            controller = new UCDeleteReservationController();
            this.rezervacija = rezervacija;
            Init(rezervacija);
        }

        private void Init(Rezervacija rezervacija)
        {
            controller.InitForm(this,rezervacija);
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            controller.Delete(rezervacija,this);
        }

        private void DeleteReservationDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

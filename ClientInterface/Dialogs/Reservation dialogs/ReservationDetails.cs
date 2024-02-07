using ClientInterface.GUIController.Reservation;
using ClientInterface.UserControls.Reservation;
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
    public partial class ReservationDetails : Form
    {
        private UCReservationSerachController controller;
        
        public ReservationDetails(Domain.Rezervacija rezervacija)
        {
            InitializeComponent();
            controller = new UCReservationSerachController();
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

        private void ReservationDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

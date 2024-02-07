using ClientInterface.GUIController;
using ClientInterface.GUIController.Reservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientInterface.UserControls.Reservation
{
    public partial class UCAddNewReservation : UserControl
    {
        private UCAddNewReservationController controller;
        private ServicesController servicesController;
        public UCAddNewReservation()
        {
            InitializeComponent();
            controller = new UCAddNewReservationController();
            servicesController = new ServicesController();
            Init();
        }

        private void Init()
        {
            controller.Init(this);
        }

        private void btnDodajUsluge_Click(object sender, EventArgs e)
        {
            servicesController.Add(this);
        }

        private void btnObrisiUslugu_Click(object sender, EventArgs e)
        {
            servicesController.Remove(this);
        }

        private void dpDatumKraja_ValueChanged(object sender, EventArgs e)
        {
            controller.SetDate(this);
        }

        private void btnObracunaj_Click(object sender, EventArgs e)
        {
            servicesController.Obracunaj(this);
        }

        private void btnKreairajRezervaciju_Click(object sender, EventArgs e)
        {
            controller.CreateReservation(this);
        }
    }
}

using ClientInterface.GUIController.Reservation;
using ClientInterface.UserControls.Reservation;
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
    public partial class AddServicesDialog : Form
    {
        private ServicesController controller;
        UCAddNewReservation uCAddNewReservation;
        public AddServicesDialog(UCAddNewReservation uCAddNewReservation)
        {
            InitializeComponent();
            this.uCAddNewReservation = uCAddNewReservation;
            controller = new ServicesController();
            Init();
        }

        private void Init()
        {
            controller.Init(this);
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }

        private void cbUsluge_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.UpdateData(this);
        }

        private void AddServicesDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnDodajUslugu_Click(object sender, EventArgs e)
        {
            controller.AddService(this, uCAddNewReservation);
        }
    }
}

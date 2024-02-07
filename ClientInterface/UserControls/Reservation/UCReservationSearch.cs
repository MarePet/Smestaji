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
    public partial class UCReservationSearch : UserControl
    {
        private UCReservationSerachController controller;
        public UCReservationSearch()
        {
            InitializeComponent();
            controller = new UCReservationSerachController();
            Init();
        }

        private void Init()
        {
            controller.Init(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            controller.Search(this);
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            controller.Details(this);
        }

        private void txtCriteria_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

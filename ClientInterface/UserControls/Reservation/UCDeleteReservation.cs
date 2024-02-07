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
    public partial class UCDeleteReservation : UserControl
    {
        private UCDeleteReservationController controller;
        public UCDeleteReservation()
        {
            InitializeComponent();
            controller = new UCDeleteReservationController();
            Init();
        }

        private void Init()
        {
            controller.Init(this);
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            controller.Details(this);
        }
    }
}

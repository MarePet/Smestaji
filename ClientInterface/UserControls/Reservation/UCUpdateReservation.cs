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
    public partial class UCUpdateReservation : UserControl
    {
        private UCUpdateReservationController controller;
        public UCUpdateReservation()
        {
            InitializeComponent();
            controller = new UCUpdateReservationController();
            Init();
        }

        private void Init()
        {
            controller.Init(this);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            controller.Update(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            controller.Search(this);
        }
    }
}

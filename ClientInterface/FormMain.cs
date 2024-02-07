using ClientInterface.GUIController;
using ClientInterface.UserControls.Client;
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

namespace ClientInterface
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void kreirajNovogKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCAddNewClient addNewClient = new UCAddNewClient();
            pnlMain.Controls.Add(addNewClient);

        }

        private void pretraziKlijenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCClientSearch uCClientSearch = new UCClientSearch();
            pnlMain.Controls.Add(uCClientSearch);
        }

        private void izmenaPodatakaKlijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCUpdateClient uCUpdateClient = new UCUpdateClient();
            pnlMain.Controls.Add(uCUpdateClient);
        }

        private void brisanjeKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCDeleteClient uCDeleteClient = new UCDeleteClient();
            pnlMain.Controls.Add(uCDeleteClient);
        }

        private void kreirajRezervacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCAddNewReservation uCAddNewReservation = new UCAddNewReservation();
            pnlMain.Controls.Add(uCAddNewReservation);
        }

        private void pretragaRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCReservationSearch uCReservationSearch = new UCReservationSearch();
            pnlMain.Controls.Add(uCReservationSearch);
        }

        private void izmenaRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCUpdateReservation uCUpdateReservation = new UCUpdateReservation();
            pnlMain.Controls.Add(uCUpdateReservation);  
        }

        private void otkazivanjeRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCDeleteReservation uCDeleteReservation = new UCDeleteReservation();
            pnlMain.Controls.Add(uCDeleteReservation);
        }
    }
}

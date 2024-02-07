using ClientInterface.GUIController;
using ClientInterface.UserControls.Client;
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

namespace ClientInterface.Dialogs.Client_dialogs
{
    public partial class DeleteClientForm : Form
    {
        private Client client;
        private UCDeleteClientController controller;
        public DeleteClientForm(Client client)
        {
            this.client = client;
            InitializeComponent();
            controller = new UCDeleteClientController();
            controller.InitForm(this, client);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            controller.Delete(client);
            DialogResult = DialogResult.OK;
        }
    }
}

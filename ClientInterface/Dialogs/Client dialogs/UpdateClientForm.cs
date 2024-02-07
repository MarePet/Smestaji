using ClientInterface.GUIController;
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
    public partial class UpdateClientForm : Form
    {
        private UCUpdateClientController controller;
        private Client client;

        public UpdateClientForm()
        {
            
        }

        public UpdateClientForm(Client client)
        {
            InitializeComponent();
            controller = new UCUpdateClientController();
            this.client = client;
            controller.InitForm(this,client);
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            controller.Update(this,client);
            DialogResult = DialogResult.OK;
        }
    }
}

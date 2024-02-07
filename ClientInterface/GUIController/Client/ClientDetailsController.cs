using ClientInterface.Dialogs.Client_dialogs;
using ClientInterface.ServerCommunication;
using ClientInterface.UserControls.Client;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientInterface.GUIController
{
    internal class ClientDetailsController
    {
        internal void Show(UCClientSearch uCClientSearch)
        {
            if (uCClientSearch.DgvUsers.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da učita klijenta!");
                return;
            }
            Client client = uCClientSearch.DgvUsers.SelectedRows[0].DataBoundItem as Client;
            client = Communication.Instance.SendRecieve<Client>(Operation.GetClient, client);
            if (client == null) return;
            MessageBox.Show("Sistem je učitao klijenta!");
            ClientDetailsForm form = new ClientDetailsForm(client);

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                form.Dispose();
                Init(uCClientSearch);
            }
        }

        private void Init(UCClientSearch uCClientSearch)
        {
            BindingList<Client> prikaz;
            List<Client> odgovor = Communication.Instance.SendRecieve<List<Client>>(Operation.GetAllUsers, new Client());
            try
            {
                prikaz = new BindingList<Client>(odgovor);
                uCClientSearch.DgvUsers.DataSource = prikaz;
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }
    }
}

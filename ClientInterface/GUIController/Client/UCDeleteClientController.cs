using ClientInterface.Dialogs.Client_dialogs;
using ClientInterface.Exceptions;
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

namespace ClientInterface.GUIController
{
    internal class UCDeleteClientController
    {
        internal void Delete(Client client)
        {
            try
            {
                if(Communication.Instance.SendRecieve<Client>(Operation.DeleteClient, client)==null)return;
                System.Windows.Forms.MessageBox.Show("Sistem je obrisao klijenta!");
            }
            catch (SystemOperationException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        internal void GetClient(UCDeleteClient uCDeleteClient)
        {
            if (uCDeleteClient.DgvUsers.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da učita klijenta!");
                return;
            }
            Client client = uCDeleteClient.DgvUsers.SelectedRows[0].DataBoundItem as Client;
            client = Communication.Instance.SendRecieve<Client>(Operation.GetClient, client);
            if (client == null) return;
            DeleteClientForm form = new DeleteClientForm(client);
            
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                form.Dispose();
                Init(uCDeleteClient);
            }
        }

        internal void Init(UCDeleteClient uCDeleteClient)
        {
            BindingList<Client> prikaz;
            List<Client> odgovor = Communication.Instance.SendRecieve<List<Client>>(Operation.GetAllUsers, new Client());
            try
            {
                prikaz = new BindingList<Client>(odgovor);
                uCDeleteClient.DgvUsers.DataSource = prikaz;
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        internal void InitForm(DeleteClientForm deleteClientForm, Client client)
        {
            if (client == null) return;
            deleteClientForm.TxtIme.Text = client.ImeKlijenta;
            deleteClientForm.TxtPrezime.Text = client.PrezimeKlijenta;
            deleteClientForm.TxtEmail.Text = client.Email;
            deleteClientForm.TxtTelefon.Text = client.Telefon;
        }

        internal void Search(UCDeleteClient uCDeleteClient)
        {
            if (string.IsNullOrEmpty(uCDeleteClient.TxtCriteria.Text))
            {
                System.Windows.Forms.MessageBox.Show("Unesite kriterijum za pretragu!");
                return;
            }
            string criteria = uCDeleteClient.TxtCriteria.Text;

            Client client = new Client();
            client.criteria = $"WHERE ImeKlijenta LIKE '{criteria}%' " + $"OR PrezimeKlijenta LIKE '{criteria}%'";

            List<Client> pronadjeniKorisnici = new List<Client>();
            try
            {
                pronadjeniKorisnici = Communication.Instance.SendRecieve<List<Client>>(Operation.ClientSearch, client);
                try
                {
                    BindingList<Client> list = new BindingList<Client>(pronadjeniKorisnici);
                    uCDeleteClient.DgvUsers.DataSource = list;
                }
                catch (ArgumentNullException)
                {
                    return;
                }
                System.Windows.Forms.MessageBox.Show("Sistem je našao klijente po zadatoj vrednosti!");
            }
            catch (SystemOperationException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}

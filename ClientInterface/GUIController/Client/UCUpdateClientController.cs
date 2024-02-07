using ClientInterface.Dialogs.Client_dialogs;
using ClientInterface.Exceptions;
using ClientInterface.ServerCommunication;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace ClientInterface.GUIController
{
    internal class UCUpdateClientController
    {
        internal void Init(UCUpdateClient uCUpdateClient)
        {
            BindingList<Client> prikaz;
            List<Client> odgovor = Communication.Instance.SendRecieve<List<Client>>(Operation.GetAllUsers, new Client());
            try
            {
                prikaz = new BindingList<Client>(odgovor);
                uCUpdateClient.DgvUsers.DataSource = prikaz;
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        internal void Search(UCUpdateClient uCUpdateClient)
        {
            if (string.IsNullOrEmpty(uCUpdateClient.TxtCriteria.Text))
            {
                System.Windows.Forms.MessageBox.Show("Unesite kriterijum za pretragu!");
                return;
            }
            string criteria = uCUpdateClient.TxtCriteria.Text;

            Client client = new Client();
            client.criteria = $"WHERE ImeKlijenta LIKE '{criteria}%' " + $"OR PrezimeKlijenta LIKE '{criteria}%'";

            List<Client> pronadjeniKorisnici = new List<Client>();
            try
            {
                pronadjeniKorisnici = Communication.Instance.SendRecieve<List<Client>>(Operation.ClientSearch, client);
                try
                {
                    BindingList<Client> list = new BindingList<Client>(pronadjeniKorisnici);
                    uCUpdateClient.DgvUsers.DataSource = list;
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

        internal void GetClient(UCUpdateClient uCUpdateClient)
        {
            if (uCUpdateClient.DgvUsers.SelectedRows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne može da učita klijenta!");
                return;
            }
            Client client = uCUpdateClient.DgvUsers.SelectedRows[0].DataBoundItem as Client;
            client = Communication.Instance.SendRecieve<Client>(Operation.GetClient, client);
            if (client == null) return;
            UpdateClientForm form = new UpdateClientForm(client);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                form.Dispose();
                Init(uCUpdateClient);
            }
        }

        internal void Update(UpdateClientForm updateClientForm, Client client)
        {
            if (string.IsNullOrEmpty(updateClientForm.TxtNovEmail.Text))
            {
                updateClientForm.TxtNovEmail.BackColor = Color.Salmon;
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna!");
                return;
            }
            if (string.IsNullOrEmpty(updateClientForm.TxtNovTelefon.Text))
            {
                updateClientForm.TxtNovTelefon.BackColor = Color.Salmon;
                System.Windows.Forms.MessageBox.Show("Sva polja su obavezna!");
                return;
            }
            client.Telefon = updateClientForm.TxtNovTelefon.Text;
            client.Email = updateClientForm.TxtNovEmail.Text;
            try
            {
                if (Communication.Instance.SendRecieve<Client>(Operation.UpdateClient, client) == null) return; 
                System.Windows.Forms.MessageBox.Show("Sistem je uspešno izmenio klijenta!");
            }
            catch (SystemOperationException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show("Sistem ne može da izmeni klijenta!");
            }
        }

        internal void InitForm(UpdateClientForm updateClientForm, Client client)
        {
            if (client == null) { return; }
            updateClientForm.TxtIme.Text = client.ImeKlijenta;
            updateClientForm.TxtPrezime.Text = client.PrezimeKlijenta;
            updateClientForm.TxtEmail.Text = client.Email;
            updateClientForm.TxtTelefon.Text = client.Telefon;
        }
    }
}

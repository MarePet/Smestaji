using ClientInterface.Exceptions;
using ClientInterface.ServerCommunication;
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
    internal class UCClientSearchController
    {
        internal void GetClient(Client client, Dialogs.Client_dialogs.ClientDetailsForm clientDetailsForm)
        {
            client = Communication.Instance.SendRecieve<Client>(Operation.GetClient, client);
            if (client == null) return;
            clientDetailsForm.TxtIme.Text = client.ImeKlijenta;
            clientDetailsForm.TxtPrezime.Text = client.PrezimeKlijenta;
            clientDetailsForm.TxtEmail.Text = client.Email;
            clientDetailsForm.TxtTelefon.Text = client.Telefon;
        }

        internal void Init(UCClientSearch uCClientSearch)
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

        internal void Search(UCClientSearch uCClientSearch)
        {
            if (string.IsNullOrEmpty(uCClientSearch.TxtCriteria.Text))
            {
                System.Windows.Forms.MessageBox.Show("Unesite kriterijum za pretragu!");
                return;
            }
            string criteria = uCClientSearch.TxtCriteria.Text;

            Client client = new Client();
            client.criteria = $"WHERE ImeKlijenta LIKE '{criteria}%' " + $"OR PrezimeKlijenta LIKE '{criteria}%'";

            List<Client> pronadjeniKorisnici = new List<Client>();
            try
            {
                pronadjeniKorisnici = Communication.Instance.SendRecieve<List<Client>>(Operation.ClientSearch, client);
                try
                {
                    BindingList<Client> list = new BindingList<Client>(pronadjeniKorisnici);
                    uCClientSearch.DgvUsers.DataSource = list;
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

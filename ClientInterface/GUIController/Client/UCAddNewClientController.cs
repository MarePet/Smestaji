using ClientInterface.UserControls.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Drawing;
using ClientInterface.Exceptions;
using ClientInterface.ServerCommunication;
using Common;
using System.IO;
using System.Windows.Forms;
using ClientInterface.UserControls.Reservation;

namespace ClientInterface.GUIController
{
    internal class UCAddNewClientController
    {
        internal void AddNewClient(UCAddNewClient addNewClient)
        {
            int id;
            try
            {
                id = int.Parse(addNewClient.TxtID.Text);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ID klijenta mora biti cifra!");
                return;
            }

            string ime = addNewClient.TxtIme.Text;
            string prezime = addNewClient.TxtPrezime.Text;
            string email = addNewClient.TxtEmail.Text;
            string telefon = addNewClient.TxtTelefon.Text;

            if(!Validacija(ime,prezime,email,telefon,addNewClient))return;

            Client client = new Client();

            client.KlijentID = id;
            client.ImeKlijenta = ime;
            client.PrezimeKlijenta = prezime;
            client.Email= email;
            client.Telefon= telefon;

            try
            {
                if(Communication.Instance.SendRecieve<Client>(Operation.AddNewClient, client)==null)return;
                MessageBox.Show("Sistem je uspešno kreirao klijenta!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Validacija(string ime, string prezime, string email, string telefon, UCAddNewClient addNewClient)
        {
            if (string.IsNullOrEmpty(addNewClient.TxtID.Text))
            {
                addNewClient.TxtID.BackColor = Color.Salmon;
                return false;
            }
            else
            {
                addNewClient.TxtID.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(ime))
            {
                addNewClient.TxtIme.BackColor = Color.Salmon;
                return false;
            }
            else
            {
                addNewClient.TxtIme.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(prezime))
            {
                addNewClient.TxtPrezime.BackColor = Color.Salmon;
                return false;
            }
            else
            {
                addNewClient.TxtPrezime.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(email))
            {
                addNewClient.TxtEmail.BackColor = Color.Salmon;
                return false;
            }
            else
            {
                addNewClient.TxtEmail.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(telefon))
            {
                addNewClient.TxtTelefon.BackColor = Color.Salmon;
                return false;
            }
            else
            {
                addNewClient.TxtTelefon.BackColor = Color.White;
            }
            return true;
        }
    }
}

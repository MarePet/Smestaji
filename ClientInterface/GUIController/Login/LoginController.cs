using ClientInterface.Exceptions;
using ClientInterface.ServerCommunication;
using Common;
using Domain;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClientInterface.GUIController
{
    public class LoginController
    {
        internal void Login(FormLogin formLogin)
        {
            string username = formLogin.TxtUsername.Text;
            string password = formLogin.TxtPassword.Text;

            if (string.IsNullOrEmpty
                (username))
            {
                formLogin.TxtUsername.BackColor = Color.Salmon;
                return;
            }
            else
            {
                formLogin.TxtUsername.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(password))
            {
                formLogin.TxtPassword.BackColor = Color.Salmon;
                return;
            }
            else
            {
                formLogin.TxtPassword.BackColor = Color.White;
            }

            Administrator administrator = new Administrator()
            {
                Username = username,
                Password = password,
            };

            try
            {
                Communication.Instance.Connect();
                administrator = Communication.Instance.SendRecieve<Administrator>(Operation.Login, administrator);
                Session.Session.Instance.CurrentAdmin = administrator;
                MessageBox.Show($"Uspesno ste se prijavili na sistem!");
                formLogin.DialogResult = DialogResult.OK;
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
    }
}

using ClientInterface.GUIController;
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
    public partial class FormLogin : Form
    {
        private LoginController loginController;
        public FormLogin()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                loginController.Login(this);
            }
            catch (Exception)
            {
                MessageBox.Show("Server nije pokrenut!");
                return;
            }
        }
    }
}

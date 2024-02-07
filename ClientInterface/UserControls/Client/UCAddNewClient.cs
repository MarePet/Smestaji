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

namespace ClientInterface.UserControls.Client
{
    public partial class UCAddNewClient : UserControl
    {
        private UCAddNewClientController controller;
        
        public UCAddNewClient()
        {
            InitializeComponent();
            controller = new UCAddNewClientController();  
            this.Dock = DockStyle.Fill;
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            controller.AddNewClient(this);
        }
    }
}

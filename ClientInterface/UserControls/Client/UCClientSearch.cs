using ClientInterface.Dialogs.Client_dialogs;
using ClientInterface.ServerCommunication;
using Common;
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

namespace ClientInterface.GUIController
{
    public partial class UCClientSearch : UserControl
    {
        private UCClientSearchController controller;
        private ClientDetailsController detailsController;
        public UCClientSearch()
        {
            InitializeComponent();
            controller = new UCClientSearchController();
            Init();   
        }

        public void Init()
        {
            controller.Init(this);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            controller.Search(this);
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            detailsController = new ClientDetailsController();
            detailsController.Show(this);
        }
    }
}

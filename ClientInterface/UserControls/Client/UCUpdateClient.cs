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
    public partial class UCUpdateClient : UserControl
    {
        private UCUpdateClientController controller;
        public UCUpdateClient()
        {
            InitializeComponent();
            controller = new UCUpdateClientController();
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

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            controller.GetClient(this);
        }
    }
}

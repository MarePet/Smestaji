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
    public partial class UCDeleteClient : UserControl
    {
        private UCDeleteClientController controller;
        public UCDeleteClient()
        {
            InitializeComponent();
            controller = new UCDeleteClientController();
            Init();
        }

        private void Init()
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

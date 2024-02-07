using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormServer : Form
    {
        private Server server;
        public FormServer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                server = new Server();
                server.Start();
                Thread serverThread = new Thread(server.HandleClients);
                serverThread.Start();
                btnStop.Enabled = true;
                btnStart.Enabled = false;
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void FormServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

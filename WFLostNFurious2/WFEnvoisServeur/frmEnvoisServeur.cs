using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEnvoisServeur
{
    public partial class frmEnvoisServeur : Form
    {
        static UdpClient udpClient;
        private static Thread thEcoute;
        static string input;

        public frmEnvoisServeur()
        {
            InitializeComponent();

            input = "";
            udpClient = new UdpClient(1081);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string ipCible = tbxIp.Text.ToString();
            int portCible = Convert.ToInt32(tbxPort.Text);

            byte[] message;
            message = Encoding.Default.GetBytes(tbxMessage.Text);
            udpClient.Send(message, message.Length, ipCible, portCible);

        }

        private void FrmEnvoisServeur_Load(object sender, EventArgs e)
        {
            thEcoute = new Thread(new ThreadStart(Ecouter));
            thEcoute.Start();
        }

        /// <summary>
        /// Fonction pour ecouter
        /// </summary>
        private void Ecouter()
        {
            while (true)
            {
                IPEndPoint client = null;
                byte[] data = udpClient.Receive(ref client);
                input += $"Données en provenance de {client.Address}:{client.Port}{Environment.NewLine}{Encoding.Default.GetString(data)}{Environment.NewLine}";
                UpdateInput();
            }
        }

        private void UpdateInput()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate {
                    tbxRecieve.Text = input;
                }));
            }
        }

        private void BtnSTOP_Click(object sender, EventArgs e)
        {
            string ipCible = "127.0.0.1";
            int portCible = 1080;

            byte[] message;
            message = Encoding.Default.GetBytes("True");
            udpClient.Send(message, message.Length, ipCible, portCible);
        }

        private void FrmEnvoisServeur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

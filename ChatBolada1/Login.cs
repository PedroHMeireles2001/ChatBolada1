using ChatCommom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBolada1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_entrar_Click(object sender, EventArgs e)
        {
            if (!Class1.isValidServer(TXT_server.Text))
            {
                MessageBox.Show("Server Inválido");
                return;
            }
            if (TXT_nick.Text.Contains(Class1.separator))
            {
                MessageBox.Show("Nick Inválido");
                return;
            }
            conectar();
        }
        private void conectar()
        {
            string[] server = TXT_server.Text.Split(':');
            conectar(server[0], Convert.ToInt32(server[1]));
        }
        private void conectar(string host,int porta)
        {
            try
            {
                string[] server = TXT_server.Text.Split(':');
                TcpClient client = new TcpClient();
                client.Connect(host,porta);
                StreamWriter sw = new StreamWriter(client.GetStream());
                Chat chat = new Chat(TXT_nick.Text, client);
                chat.Show();
                this.Hide();
            }
            catch (SocketException ee)
            {
                DialogResult resultado = MessageBox.Show(ee.Message, "Erro ao se conectar", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (resultado == DialogResult.Retry)
                {
                    conectar(host,porta);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ServerBolada1", TXT_server.Text);
        }
    }
}

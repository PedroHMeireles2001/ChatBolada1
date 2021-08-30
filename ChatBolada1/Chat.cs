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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBolada1
{
    public partial class Chat : Form
    {
        private Usuario user;
        private TcpClient client;
        public delegate void ChatCallBack(string msg);
        public delegate void NotifyCallBack(string nick,string discriminator);



        public Chat(string nick,TcpClient client)
        {
            
            string discriminator = formatDiscriminator(new Random().Next(1, 9999));

            //this.writer = new StreamWriter(client.GetStream());
            //this.reader = new StreamReader(client.GetStream());
            
            this.user = new Usuario(nick, discriminator);
            this.client = client;
            InitializeComponent();
            Class1.sendmessage(client,"CHAT" + Class1.separator + "NEW" + Class1.separator + nick + Class1.separator + discriminator + Class1.separator + discriminator);
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(this.Sair);
            Thread tr = new Thread(new ThreadStart(ouvir));
            tr.Start();
           
        }
       
        private string formatDiscriminator(int number)
        {
            if (number < 10)
            {
                return "000" + number;
            }
            else if (number < 100)
            {
                return "00" + number;
            }else if(number < 1000)
            {
                return "0" + number;
            }
            else
            {
                return "" + number;
            }
        }
        private void Sair(object sender, EventArgs e)
        {
            MessageBox.Show("TaskManager");
        }
        private void novamesagem(string msg,string nick)
        {
            novamesagem("[" + nick + "] " + msg);
        }

        public void appendNick(string nick,string discriminator)
        {
            if (InvokeRequired)
            {
                Invoke((NotifyCallBack)appendNick, nick,discriminator);
            }
            else
            {
                ListViewItem item = new ListViewItem(new string[] {nick,discriminator});
                item.Tag = new UsuarioClient(nick, discriminator, item);
                LV_nicks.Items.Add(item);
            }
        }
        public void removeNick(string nick, string discriminator)
        {
            if (InvokeRequired)
            {
                Invoke((NotifyCallBack)removeNick, nick,discriminator);
            }
            else
            {
                UsuarioClient user = getUsuario(nick, discriminator);
                if(user != null)
                {
                    LV_nicks.Items.Remove(user.view);
                    LV_nicks.Update();
                }
                
            }
        }
        private UsuarioClient getUsuario(string nick, string discriminator)
        {
            foreach(ListViewItem i in LV_nicks.Items)
            {
                UsuarioClient uc = (UsuarioClient)i.Tag;
                if(uc.nick.Equals(nick) && uc.discriminator.Equals(discriminator))
                {
                    return uc;
                }
            }
            MessageBox.Show("NULL");
            return null;
        }
        public void novamesagem(string msg)
        {
            if (InvokeRequired)
            {
                Invoke((ChatCallBack)novamesagem, msg);
            }
            else
            {
                RTXT_chat.AppendText(msg + "\n");
                RTXT_chat.SelectionStart = RTXT_chat.Text.Length;
                RTXT_chat.ScrollToCaret();
            }
        }
        private void ouvir()
        {
            StreamReader sr = new StreamReader(client.GetStream());
            while (true)
            {
                string msg = sr.ReadLine();
                string[] msgs = msg.Split(new string[] { Class1.separator }, StringSplitOptions.RemoveEmptyEntries);
                if(msgs[0] == "CHAT")
                {
                    if(msgs[1] == "NOTIFY" && msgs.Length == 4)
                    {
                        appendNick(msgs[2],msgs[3]);
                    }
                    if (msgs[1] == "NOTIFYPRIV" && msgs.Length == 4)
                    {
                        novamesagem(msgs[2], msgs[3]);
                    }
                    if (msgs[1] == "NOTIFYREMOVE" && msgs.Length == 4)
                    {
                        removeNick(msgs[2],msgs[3]);
                    }
                    if (msgs[1] == "NOTIFYBAN" && (msgs.Length == 4 || msgs.Length == 3))
                    {
                        MessageBox.Show(msgs.Length == 4 ? "Você foi banido por " + msgs[2] + "\nMotivo:" + msgs[3] : "Você foi banido por " + msgs[2], "Você foi banido");
                        Application.Exit();
                    }
                    if (msgs[1] == "MESSAGE" && msgs.Length == 4)
                    {
                        novamesagem(msgs[2],msgs[3]);
                    }
                    if (msgs[1] == "SERVERMESSAGE" && msgs.Length == 3)
                    {
                        novamesagem("SERVER: " + msgs[2]);
                    }
                }
            }
        }
        private void Chat_Load(object sender, EventArgs e)
        {
            //appendNick(this.user.nick,this.user.discriminator);

        }

        private void BTN_enviar_Click(object sender, EventArgs e)
        {
            enviarmensagem();
        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TXT_mensagem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enviarmensagem();
            }
        }

        private void enviarmensagem()
        {
            if (TXT_mensagem.Text.Contains(Class1.separator))
            {
                MessageBox.Show("Mensagem Inválida");
                return;
            }
            Class1.sendmessage(client, "CHAT" + Class1.separator + "MESSAGE" + Class1.separator + TXT_mensagem.Text);
            TXT_mensagem.Clear();
        }

        private void mensagemPrivadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario usr = (Usuario)LV_nicks.SelectedItems[0].Tag;
            if(usr == null)
            {
                return;
            }
            DialogMessage dmsg = new DialogMessage("Mensagem:", "Mensagem privada para: " + usr.getNickWithDiscriminator());
            DialogResult rmsg = dmsg.ShowDialog();
            if(rmsg == DialogResult.OK)
            {
                string msg = dmsg.message;
                Class1.sendmessage(this.client,"CHAT" + Class1.separator + "PRIV" + Class1.separator + usr.nick + Class1.separator + usr.discriminator + Class1.separator + msg);
            }
            
        }

        private void banirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LV_nicks.SelectedItems[0] != null)
            {
                Usuario usr = (Usuario)LV_nicks.SelectedItems[0].Tag;
                DialogMessage dmsg = new DialogMessage("Motivo:", "Banindo " + usr.getNickWithDiscriminator());
                DialogResult rmsg = dmsg.ShowDialog();
                if(rmsg == DialogResult.OK)
                {
                    Class1.sendmessage(client, "CHAT" + Class1.separator + "BAN" + Class1.separator + usr.nick + Class1.separator + usr.discriminator + Class1.separator + user.getNickWithDiscriminator() + Class1.separator + dmsg.message);
                }
                else
                {
                    Class1.sendmessage(client, "CHAT" + Class1.separator + "BAN" + Class1.separator + usr.nick + Class1.separator + usr.discriminator + Class1.separator + user.getNickWithDiscriminator());
                }
                
            }
        }
    }
}

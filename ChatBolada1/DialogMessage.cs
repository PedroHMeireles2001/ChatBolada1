using ChatCommom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBolada1
{
    public partial class DialogMessage : Form
    {
        private string label;
        private string title;
        public string message;
        public DialogMessage(string label, string title)
        {
            this.label = label;
            this.title = title;
            InitializeComponent();
        }

        private void DialogMessage_Load(object sender, EventArgs e)
        {
            LBL_for.Text = this.label;
            this.Text = title;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXT_msgpriv.Text.Contains(Class1.separator))
            {
                MessageBox.Show("A mensagem contem caracteres inválidos");
                return;
            }
            this.message = TXT_msgpriv.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}

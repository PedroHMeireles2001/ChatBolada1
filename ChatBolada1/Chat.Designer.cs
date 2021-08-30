
namespace ChatBolada1
{
    partial class Chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RTXT_chat = new System.Windows.Forms.RichTextBox();
            this.TXT_mensagem = new System.Windows.Forms.TextBox();
            this.BTN_enviar = new System.Windows.Forms.Button();
            this.LV_nicks = new System.Windows.Forms.ListView();
            this.CH_nick = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_discriminator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMS_user = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mensagemPrivadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moderaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kikarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTXT_chat
            // 
            this.RTXT_chat.Location = new System.Drawing.Point(12, 12);
            this.RTXT_chat.Name = "RTXT_chat";
            this.RTXT_chat.ReadOnly = true;
            this.RTXT_chat.Size = new System.Drawing.Size(601, 229);
            this.RTXT_chat.TabIndex = 0;
            this.RTXT_chat.Text = "";
            // 
            // TXT_mensagem
            // 
            this.TXT_mensagem.Location = new System.Drawing.Point(12, 247);
            this.TXT_mensagem.Name = "TXT_mensagem";
            this.TXT_mensagem.Size = new System.Drawing.Size(601, 20);
            this.TXT_mensagem.TabIndex = 2;
            this.TXT_mensagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_mensagem_KeyUp);
            // 
            // BTN_enviar
            // 
            this.BTN_enviar.Location = new System.Drawing.Point(638, 242);
            this.BTN_enviar.Name = "BTN_enviar";
            this.BTN_enviar.Size = new System.Drawing.Size(150, 29);
            this.BTN_enviar.TabIndex = 3;
            this.BTN_enviar.Text = "Enviar";
            this.BTN_enviar.UseVisualStyleBackColor = true;
            this.BTN_enviar.Click += new System.EventHandler(this.BTN_enviar_Click);
            // 
            // LV_nicks
            // 
            this.LV_nicks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LV_nicks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_nick,
            this.CH_discriminator});
            this.LV_nicks.ContextMenuStrip = this.CMS_user;
            this.LV_nicks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_nicks.HideSelection = false;
            this.LV_nicks.Location = new System.Drawing.Point(638, 12);
            this.LV_nicks.Name = "LV_nicks";
            this.LV_nicks.Scrollable = false;
            this.LV_nicks.Size = new System.Drawing.Size(150, 224);
            this.LV_nicks.TabIndex = 4;
            this.LV_nicks.UseCompatibleStateImageBehavior = false;
            this.LV_nicks.View = System.Windows.Forms.View.Details;
            // 
            // CH_nick
            // 
            this.CH_nick.Text = "Nick";
            this.CH_nick.Width = 94;
            // 
            // CH_discriminator
            // 
            this.CH_discriminator.Text = "ID";
            // 
            // CMS_user
            // 
            this.CMS_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensagemPrivadaToolStripMenuItem,
            this.moderaçãoToolStripMenuItem});
            this.CMS_user.Name = "CMS_user";
            this.CMS_user.Size = new System.Drawing.Size(181, 70);
            // 
            // mensagemPrivadaToolStripMenuItem
            // 
            this.mensagemPrivadaToolStripMenuItem.Name = "mensagemPrivadaToolStripMenuItem";
            this.mensagemPrivadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mensagemPrivadaToolStripMenuItem.Text = "Mensagem privada";
            this.mensagemPrivadaToolStripMenuItem.Click += new System.EventHandler(this.mensagemPrivadaToolStripMenuItem_Click);
            // 
            // moderaçãoToolStripMenuItem
            // 
            this.moderaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banirToolStripMenuItem,
            this.kikarToolStripMenuItem,
            this.mutarToolStripMenuItem});
            this.moderaçãoToolStripMenuItem.Name = "moderaçãoToolStripMenuItem";
            this.moderaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moderaçãoToolStripMenuItem.Text = "Moderação";
            // 
            // banirToolStripMenuItem
            // 
            this.banirToolStripMenuItem.Name = "banirToolStripMenuItem";
            this.banirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.banirToolStripMenuItem.Text = "Banir";
            this.banirToolStripMenuItem.Click += new System.EventHandler(this.banirToolStripMenuItem_Click);
            // 
            // kikarToolStripMenuItem
            // 
            this.kikarToolStripMenuItem.Name = "kikarToolStripMenuItem";
            this.kikarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kikarToolStripMenuItem.Text = "Kikar";
            // 
            // mutarToolStripMenuItem
            // 
            this.mutarToolStripMenuItem.Name = "mutarToolStripMenuItem";
            this.mutarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mutarToolStripMenuItem.Text = "Mutar";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.LV_nicks);
            this.Controls.Add(this.BTN_enviar);
            this.Controls.Add(this.TXT_mensagem);
            this.Controls.Add(this.RTXT_chat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Chat";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chat_FormClosed);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.CMS_user.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTXT_chat;
        private System.Windows.Forms.TextBox TXT_mensagem;
        private System.Windows.Forms.Button BTN_enviar;
        private System.Windows.Forms.ListView LV_nicks;
        private System.Windows.Forms.ColumnHeader CH_nick;
        private System.Windows.Forms.ColumnHeader CH_discriminator;
        private System.Windows.Forms.ContextMenuStrip CMS_user;
        private System.Windows.Forms.ToolStripMenuItem mensagemPrivadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moderaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kikarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mutarToolStripMenuItem;
    }
}
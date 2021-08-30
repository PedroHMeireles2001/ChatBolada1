
namespace ChatBolada1
{
    partial class Login
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
            this.BTN_entrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_nick = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_entrar
            // 
            this.BTN_entrar.Location = new System.Drawing.Point(12, 93);
            this.BTN_entrar.Name = "BTN_entrar";
            this.BTN_entrar.Size = new System.Drawing.Size(65, 30);
            this.BTN_entrar.TabIndex = 12;
            this.BTN_entrar.Text = "Entrar";
            this.BTN_entrar.UseVisualStyleBackColor = true;
            this.BTN_entrar.Click += new System.EventHandler(this.BTN_entrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Hospedar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Server";
            // 
            // TXT_server
            // 
            this.TXT_server.Location = new System.Drawing.Point(12, 67);
            this.TXT_server.Name = "TXT_server";
            this.TXT_server.Size = new System.Drawing.Size(170, 20);
            this.TXT_server.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nick";
            // 
            // TXT_nick
            // 
            this.TXT_nick.Location = new System.Drawing.Point(12, 25);
            this.TXT_nick.Name = "TXT_nick";
            this.TXT_nick.Size = new System.Drawing.Size(170, 20);
            this.TXT_nick.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 132);
            this.Controls.Add(this.BTN_entrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_server);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_nick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Entrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_entrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_nick;
    }
}
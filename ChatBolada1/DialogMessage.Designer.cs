
namespace ChatBolada1
{
    partial class DialogMessage
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
            this.TXT_msgpriv = new System.Windows.Forms.TextBox();
            this.LBL_for = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_msgpriv
            // 
            this.TXT_msgpriv.Location = new System.Drawing.Point(12, 37);
            this.TXT_msgpriv.Name = "TXT_msgpriv";
            this.TXT_msgpriv.Size = new System.Drawing.Size(341, 20);
            this.TXT_msgpriv.TabIndex = 0;
            // 
            // LBL_for
            // 
            this.LBL_for.AutoSize = true;
            this.LBL_for.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_for.Location = new System.Drawing.Point(12, 18);
            this.LBL_for.Name = "LBL_for";
            this.LBL_for.Size = new System.Drawing.Size(216, 16);
            this.LBL_for.TabIndex = 1;
            this.LBL_for.Text = "Mensagem privada para Pinto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DialogMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 97);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBL_for);
            this.Controls.Add(this.TXT_msgpriv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DialogMessage";
            this.Text = "Mensagem Privada";
            this.Load += new System.EventHandler(this.DialogMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_msgpriv;
        private System.Windows.Forms.Label LBL_for;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
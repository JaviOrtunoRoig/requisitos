namespace CampusApS
{
    partial class PantallaRegistroONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistroONG));
            this.lbNumONG = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tNumRegONG = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.tConfPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNumONG
            // 
            this.lbNumONG.AutoSize = true;
            this.lbNumONG.ForeColor = System.Drawing.Color.White;
            this.lbNumONG.Location = new System.Drawing.Point(42, 363);
            this.lbNumONG.Name = "lbNumONG";
            this.lbNumONG.Size = new System.Drawing.Size(149, 13);
            this.lbNumONG.TabIndex = 19;
            this.lbNumONG.Text = "Numero de registro de la ONG";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(42, 229);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 13);
            this.lbPassword.TabIndex = 18;
            this.lbPassword.Text = "Contraseña";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(42, 159);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(98, 13);
            this.lbUsername.TabIndex = 17;
            this.lbUsername.Text = "Nombre de Usuario";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(42, 86);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(93, 13);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Correo electrónico";
            // 
            // tNumRegONG
            // 
            this.tNumRegONG.Location = new System.Drawing.Point(45, 379);
            this.tNumRegONG.Name = "tNumRegONG";
            this.tNumRegONG.Size = new System.Drawing.Size(253, 20);
            this.tNumRegONG.TabIndex = 24;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(45, 245);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(253, 20);
            this.tPassword.TabIndex = 22;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(45, 175);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(253, 20);
            this.tNombre.TabIndex = 21;
            // 
            // tCorreo
            // 
            this.tCorreo.Location = new System.Drawing.Point(45, 102);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(253, 20);
            this.tCorreo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "¡Bienvenido, nuevo usuario de ONG!";
            // 
            // bConfirmar
            // 
            this.bConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConfirmar.Location = new System.Drawing.Point(277, 439);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 25;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // tConfPassword
            // 
            this.tConfPassword.Location = new System.Drawing.Point(45, 313);
            this.tConfPassword.Name = "tConfPassword";
            this.tConfPassword.PasswordChar = '*';
            this.tConfPassword.Size = new System.Drawing.Size(253, 20);
            this.tConfPassword.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Confirmar Contraseña";
            // 
            // PantallaRegistroONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(364, 474);
            this.Controls.Add(this.tConfPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNumRegONG);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.lbNumONG);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaRegistroONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro usuario de ONG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumONG;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tNumRegONG;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.TextBox tConfPassword;
        private System.Windows.Forms.Label label2;
    }
}
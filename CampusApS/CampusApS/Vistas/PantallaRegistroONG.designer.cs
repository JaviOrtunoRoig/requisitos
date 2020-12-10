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
            this.lbNumONG.Location = new System.Drawing.Point(56, 447);
            this.lbNumONG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumONG.Name = "lbNumONG";
            this.lbNumONG.Size = new System.Drawing.Size(201, 17);
            this.lbNumONG.TabIndex = 19;
            this.lbNumONG.Text = "Numero de registro de la ONG";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(56, 282);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(81, 17);
            this.lbPassword.TabIndex = 18;
            this.lbPassword.Text = "Contraseña";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(56, 196);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(131, 17);
            this.lbUsername.TabIndex = 17;
            this.lbUsername.Text = "Nombre de Usuario";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(56, 106);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(124, 17);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Correo electrónico";
            // 
            // tNumRegONG
            // 
            this.tNumRegONG.Location = new System.Drawing.Point(60, 466);
            this.tNumRegONG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tNumRegONG.Name = "tNumRegONG";
            this.tNumRegONG.Size = new System.Drawing.Size(336, 22);
            this.tNumRegONG.TabIndex = 23;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(60, 302);
            this.tPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(336, 22);
            this.tPassword.TabIndex = 22;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(60, 215);
            this.tNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(336, 22);
            this.tNombre.TabIndex = 21;
            // 
            // tCorreo
            // 
            this.tCorreo.Location = new System.Drawing.Point(60, 126);
            this.tCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(336, 22);
            this.tCorreo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "¡Bienvenido, nuevo usuario de ONG!";
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(369, 540);
            this.bConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(100, 28);
            this.bConfirmar.TabIndex = 25;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // tConfPassword
            // 
            this.tConfPassword.Location = new System.Drawing.Point(60, 385);
            this.tConfPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tConfPassword.Name = "tConfPassword";
            this.tConfPassword.PasswordChar = '*';
            this.tConfPassword.Size = new System.Drawing.Size(336, 22);
            this.tConfPassword.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 366);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Confirmar Contraseña";
            // 
            // PantallaRegistroONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 583);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PantallaRegistroONG";
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
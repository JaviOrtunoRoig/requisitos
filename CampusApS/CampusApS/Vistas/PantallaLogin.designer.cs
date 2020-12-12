namespace CampusApS
{
    partial class PantallaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaLogin));
            this.lbCorreoUser = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.bRecuperarPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCorreoUser
            // 
            this.lbCorreoUser.AutoSize = true;
            this.lbCorreoUser.Location = new System.Drawing.Point(321, 58);
            this.lbCorreoUser.Name = "lbCorreoUser";
            this.lbCorreoUser.Size = new System.Drawing.Size(98, 13);
            this.lbCorreoUser.TabIndex = 0;
            this.lbCorreoUser.Text = "Nombre de Usuario";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(334, 135);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(66, 13);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Constraseña";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(246, 83);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(257, 20);
            this.tNombre.TabIndex = 2;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(246, 160);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(257, 20);
            this.tPassword.TabIndex = 3;
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(246, 228);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 4;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // bRecuperarPass
            // 
            this.bRecuperarPass.Location = new System.Drawing.Point(362, 228);
            this.bRecuperarPass.Name = "bRecuperarPass";
            this.bRecuperarPass.Size = new System.Drawing.Size(141, 23);
            this.bRecuperarPass.TabIndex = 5;
            this.bRecuperarPass.Text = "Recuperar la contraseña";
            this.bRecuperarPass.UseVisualStyleBackColor = true;
            this.bRecuperarPass.Click += new System.EventHandler(this.bRecuperar_Click);
            // 
            // PantallaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 323);
            this.Controls.Add(this.bRecuperarPass);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbCorreoUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaLogin";
            this.Text = "Iniciar Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCorreoUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Button bRecuperarPass;
    }
}
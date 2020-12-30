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
            this.lbCorreoUser.Location = new System.Drawing.Point(428, 71);
            this.lbCorreoUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCorreoUser.Name = "lbCorreoUser";
            this.lbCorreoUser.Size = new System.Drawing.Size(131, 17);
            this.lbCorreoUser.TabIndex = 0;
            this.lbCorreoUser.Text = "Nombre de Usuario";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(445, 166);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(81, 17);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Contraseña";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(328, 102);
            this.tNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(341, 22);
            this.tNombre.TabIndex = 2;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(328, 197);
            this.tPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(341, 22);
            this.tPassword.TabIndex = 3;
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(328, 281);
            this.bConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(100, 28);
            this.bConfirmar.TabIndex = 4;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // bRecuperarPass
            // 
            this.bRecuperarPass.Location = new System.Drawing.Point(483, 281);
            this.bRecuperarPass.Margin = new System.Windows.Forms.Padding(4);
            this.bRecuperarPass.Name = "bRecuperarPass";
            this.bRecuperarPass.Size = new System.Drawing.Size(188, 28);
            this.bRecuperarPass.TabIndex = 5;
            this.bRecuperarPass.Text = "Recuperar la contraseña";
            this.bRecuperarPass.UseVisualStyleBackColor = true;
            this.bRecuperarPass.Click += new System.EventHandler(this.bRecuperar_Click);
            // 
            // PantallaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 477);
            this.Controls.Add(this.bRecuperarPass);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbCorreoUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
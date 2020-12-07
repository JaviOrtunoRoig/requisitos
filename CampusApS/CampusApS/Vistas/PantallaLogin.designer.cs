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
            this.lbCorreoUser = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.bRecuperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCorreoUser
            // 
            this.lbCorreoUser.AutoSize = true;
            this.lbCorreoUser.Location = new System.Drawing.Point(273, 57);
            this.lbCorreoUser.Name = "lbCorreoUser";
            this.lbCorreoUser.Size = new System.Drawing.Size(192, 13);
            this.lbCorreoUser.TabIndex = 0;
            this.lbCorreoUser.Text = "Correo electrónico o nombre de usuario";
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
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(246, 83);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(257, 20);
            this.tbCorreo.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(246, 160);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(257, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(246, 228);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 4;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            // 
            // bRecuperar
            // 
            this.bRecuperar.Location = new System.Drawing.Point(362, 228);
            this.bRecuperar.Name = "bRecuperar";
            this.bRecuperar.Size = new System.Drawing.Size(141, 23);
            this.bRecuperar.TabIndex = 5;
            this.bRecuperar.Text = "Recuperar la contraseña";
            this.bRecuperar.UseVisualStyleBackColor = true;
            // 
            // PantallaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 323);
            this.Controls.Add(this.bRecuperar);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbCorreoUser);
            this.Name = "PantallaLogin";
            this.Text = "PantallaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCorreoUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Button bRecuperar;
    }
}
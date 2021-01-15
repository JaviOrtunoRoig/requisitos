namespace CampusApS
{
    partial class PantallaRegistroAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistroAdmin));
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbInvCode = new System.Windows.Forms.Label();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tCodigoInvitacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.lConfPassword = new System.Windows.Forms.Label();
            this.tConfPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(62, 85);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(93, 13);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Correo electrónico";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(62, 148);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(98, 13);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Nombre de Usuario";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(62, 213);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Contraseña";
            // 
            // lbInvCode
            // 
            this.lbInvCode.AutoSize = true;
            this.lbInvCode.ForeColor = System.Drawing.Color.White;
            this.lbInvCode.Location = new System.Drawing.Point(62, 341);
            this.lbInvCode.Name = "lbInvCode";
            this.lbInvCode.Size = new System.Drawing.Size(104, 13);
            this.lbInvCode.TabIndex = 3;
            this.lbInvCode.Text = "Código de Invitación";
            // 
            // tCorreo
            // 
            this.tCorreo.Location = new System.Drawing.Point(65, 101);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(253, 20);
            this.tCorreo.TabIndex = 4;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(65, 164);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(253, 20);
            this.tNombre.TabIndex = 5;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(65, 229);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(253, 20);
            this.tPassword.TabIndex = 6;
            // 
            // tCodigoInvitacion
            // 
            this.tCodigoInvitacion.Location = new System.Drawing.Point(65, 357);
            this.tCodigoInvitacion.Name = "tCodigoInvitacion";
            this.tCodigoInvitacion.Size = new System.Drawing.Size(253, 20);
            this.tCodigoInvitacion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "¡Bienvenido, nuevo administrador!";
            // 
            // bConfirmar
            // 
            this.bConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConfirmar.Location = new System.Drawing.Point(306, 416);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 9;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // lConfPassword
            // 
            this.lConfPassword.AutoSize = true;
            this.lConfPassword.ForeColor = System.Drawing.Color.White;
            this.lConfPassword.Location = new System.Drawing.Point(62, 277);
            this.lConfPassword.Name = "lConfPassword";
            this.lConfPassword.Size = new System.Drawing.Size(107, 13);
            this.lConfPassword.TabIndex = 10;
            this.lConfPassword.Text = "Confirmar contraseña";
            // 
            // tConfPassword
            // 
            this.tConfPassword.Location = new System.Drawing.Point(65, 293);
            this.tConfPassword.Name = "tConfPassword";
            this.tConfPassword.PasswordChar = '*';
            this.tConfPassword.Size = new System.Drawing.Size(253, 20);
            this.tConfPassword.TabIndex = 7;
            // 
            // PantallaRegistroAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(393, 451);
            this.Controls.Add(this.tConfPassword);
            this.Controls.Add(this.lConfPassword);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tCodigoInvitacion);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.lbInvCode);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbEmail);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaRegistroAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbInvCode;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tCodigoInvitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Label lConfPassword;
        private System.Windows.Forms.TextBox tConfPassword;
    }
}
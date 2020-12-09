namespace CampusApS
{
    partial class PantallaRegistroProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistroProfesor));
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tNumExp = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.lbNumExp = new System.Windows.Forms.Label();
            this.tConfPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(68, 217);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Contraseña";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(68, 147);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(98, 13);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Nombre de Usuario";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(68, 74);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(93, 13);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Correo electrónico";
            // 
            // tNumExp
            // 
            this.tNumExp.Location = new System.Drawing.Point(71, 372);
            this.tNumExp.Name = "tNumExp";
            this.tNumExp.Size = new System.Drawing.Size(253, 20);
            this.tNumExp.TabIndex = 11;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(71, 233);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(253, 20);
            this.tPassword.TabIndex = 10;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(71, 163);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(253, 20);
            this.tNombre.TabIndex = 9;
            // 
            // tCorreo
            // 
            this.tCorreo.Location = new System.Drawing.Point(71, 90);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(253, 20);
            this.tCorreo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "¡Bienvenido, nuevo profesor!";
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(314, 432);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 14;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            // 
            // lbNumExp
            // 
            this.lbNumExp.AutoSize = true;
            this.lbNumExp.Location = new System.Drawing.Point(68, 356);
            this.lbNumExp.Name = "lbNumExp";
            this.lbNumExp.Size = new System.Drawing.Size(115, 13);
            this.lbNumExp.TabIndex = 15;
            this.lbNumExp.Text = "Numero de Expediente";
            // 
            // tConfPassword
            // 
            this.tConfPassword.Location = new System.Drawing.Point(71, 304);
            this.tConfPassword.Name = "tConfPassword";
            this.tConfPassword.PasswordChar = '*';
            this.tConfPassword.Size = new System.Drawing.Size(253, 20);
            this.tConfPassword.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Confirmar Contraseña";
            // 
            // PantallaRegistroProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 467);
            this.Controls.Add(this.tConfPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNumExp);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNumExp);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaRegistroProfesor";
            this.Text = "Registro profesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tNumExp;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Label lbNumExp;
        private System.Windows.Forms.TextBox tConfPassword;
        private System.Windows.Forms.Label label2;
    }
}
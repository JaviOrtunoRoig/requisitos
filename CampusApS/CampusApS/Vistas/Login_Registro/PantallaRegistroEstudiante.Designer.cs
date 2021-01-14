namespace CampusApS
{
    partial class PantallaRegistroEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistroEstudiante));
            this.label1 = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tConfPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "¡Bienvenido, nuevo estudiante!";
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(60, 248);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(253, 20);
            this.tPassword.TabIndex = 28;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(57, 232);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 13);
            this.lbPassword.TabIndex = 23;
            this.lbPassword.Text = "Contraseña";
            // 
            // tCorreo
            // 
            this.tCorreo.Location = new System.Drawing.Point(60, 93);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(253, 20);
            this.tCorreo.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Correo electrónico";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(60, 170);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(253, 20);
            this.tNombre.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre de Usuario";
            // 
            // tConfPassword
            // 
            this.tConfPassword.Location = new System.Drawing.Point(60, 320);
            this.tConfPassword.Name = "tConfPassword";
            this.tConfPassword.PasswordChar = '*';
            this.tConfPassword.Size = new System.Drawing.Size(253, 20);
            this.tConfPassword.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // bConfirmar
            // 
            this.bConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConfirmar.Location = new System.Drawing.Point(314, 390);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 31;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // PantallaRegistroEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(401, 425);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tConfPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaRegistroEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tConfPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bConfirmar;
    }
}
namespace CampusApS
{
    partial class PantallaBienvenido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaBienvenido));
            this.label1 = new System.Windows.Forms.Label();
            this.bLogin = new XanderUI.XUIButton();
            this.bRegister = new XanderUI.XUIButton();
            this.bInvitado = new XanderUI.XUIButton();
            this.lbRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a CampusApS";
            // 
            // bLogin
            // 
            this.bLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bLogin.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bLogin.ButtonImage")));
            this.bLogin.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bLogin.ButtonText = "Iniciar Sesión";
            this.bLogin.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.bLogin.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.bLogin.CornerRadius = 5;
            this.bLogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bLogin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bLogin.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bLogin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bLogin.Location = new System.Drawing.Point(80, 171);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(200, 50);
            this.bLogin.TabIndex = 1;
            this.bLogin.TextColor = System.Drawing.Color.DodgerBlue;
            this.bLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bRegister
            // 
            this.bRegister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bRegister.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bRegister.ButtonImage")));
            this.bRegister.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bRegister.ButtonText = "Registrarse";
            this.bRegister.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.bRegister.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.bRegister.CornerRadius = 5;
            this.bRegister.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bRegister.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bRegister.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bRegister.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bRegister.Location = new System.Drawing.Point(545, 161);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(200, 50);
            this.bRegister.TabIndex = 2;
            this.bRegister.TextColor = System.Drawing.Color.DodgerBlue;
            this.bRegister.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // bInvitado
            // 
            this.bInvitado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bInvitado.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bInvitado.ButtonImage")));
            this.bInvitado.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bInvitado.ButtonText = "Entrar como invitado";
            this.bInvitado.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.bInvitado.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.bInvitado.CornerRadius = 5;
            this.bInvitado.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bInvitado.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bInvitado.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bInvitado.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bInvitado.Location = new System.Drawing.Point(545, 249);
            this.bInvitado.Name = "bInvitado";
            this.bInvitado.Size = new System.Drawing.Size(200, 50);
            this.bInvitado.TabIndex = 3;
            this.bInvitado.TextColor = System.Drawing.Color.DodgerBlue;
            this.bInvitado.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bInvitado.Click += new System.EventHandler(this.bInvitado_Click);
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Location = new System.Drawing.Point(564, 97);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(150, 13);
            this.lbRegister.TabIndex = 4;
            this.lbRegister.Text = "¿No estás registrado todavía?";
            // 
            // PantallaBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 409);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.bInvitado);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.label1);
            this.Name = "PantallaBienvenido";
            this.Text = "PantallaBienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton bLogin;
        private XanderUI.XUIButton bRegister;
        private XanderUI.XUIButton bInvitado;
        private System.Windows.Forms.Label lbRegister;
    }
}
namespace CampusApS.Vistas.Opciones {
    partial class Opciones {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones));
            this.bcambiarNombre = new XanderUI.XUIButton();
            this.bDarseDeBaja = new XanderUI.XUIButton();
            this.bInvitarAdminitrador = new XanderUI.XUIButton();
            this.bBandejaEntrada = new XanderUI.XUIButton();
            this.bMisCursos = new XanderUI.XUIButton();
            this.bMisAS = new XanderUI.XUIButton();
            this.bEliminarUsuario = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // bcambiarNombre
            // 
            this.bcambiarNombre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bcambiarNombre.ButtonImage = global::CampusApS.Properties.Resources.Login;
            this.bcambiarNombre.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bcambiarNombre.ButtonText = "Cambiar nombre";
            this.bcambiarNombre.ClickBackColor = System.Drawing.Color.Black;
            this.bcambiarNombre.ClickTextColor = System.Drawing.Color.Black;
            this.bcambiarNombre.CornerRadius = 5;
            this.bcambiarNombre.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bcambiarNombre.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bcambiarNombre.HoverTextColor = System.Drawing.Color.White;
            this.bcambiarNombre.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bcambiarNombre.Location = new System.Drawing.Point(61, 36);
            this.bcambiarNombre.Name = "bcambiarNombre";
            this.bcambiarNombre.Size = new System.Drawing.Size(200, 50);
            this.bcambiarNombre.TabIndex = 0;
            this.bcambiarNombre.TextColor = System.Drawing.Color.Black;
            this.bcambiarNombre.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bcambiarNombre.Click += new System.EventHandler(this.bcambiarNombre_Click);
            // 
            // bDarseDeBaja
            // 
            this.bDarseDeBaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bDarseDeBaja.ButtonImage = global::CampusApS.Properties.Resources.salir;
            this.bDarseDeBaja.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bDarseDeBaja.ButtonText = "Darse de baja";
            this.bDarseDeBaja.ClickBackColor = System.Drawing.Color.Black;
            this.bDarseDeBaja.ClickTextColor = System.Drawing.Color.Black;
            this.bDarseDeBaja.CornerRadius = 5;
            this.bDarseDeBaja.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bDarseDeBaja.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bDarseDeBaja.HoverTextColor = System.Drawing.Color.White;
            this.bDarseDeBaja.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bDarseDeBaja.Location = new System.Drawing.Point(61, 185);
            this.bDarseDeBaja.Name = "bDarseDeBaja";
            this.bDarseDeBaja.Size = new System.Drawing.Size(200, 50);
            this.bDarseDeBaja.TabIndex = 1;
            this.bDarseDeBaja.TextColor = System.Drawing.Color.Black;
            this.bDarseDeBaja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bDarseDeBaja.Click += new System.EventHandler(this.bDarseDeBaja_Click);
            // 
            // bInvitarAdminitrador
            // 
            this.bInvitarAdminitrador.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bInvitarAdminitrador.ButtonImage = global::CampusApS.Properties.Resources.invitarAdmin;
            this.bInvitarAdminitrador.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bInvitarAdminitrador.ButtonText = "Invitar a un administrador";
            this.bInvitarAdminitrador.ClickBackColor = System.Drawing.Color.Black;
            this.bInvitarAdminitrador.ClickTextColor = System.Drawing.Color.Black;
            this.bInvitarAdminitrador.CornerRadius = 5;
            this.bInvitarAdminitrador.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bInvitarAdminitrador.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bInvitarAdminitrador.HoverTextColor = System.Drawing.Color.White;
            this.bInvitarAdminitrador.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.bInvitarAdminitrador.Location = new System.Drawing.Point(294, 185);
            this.bInvitarAdminitrador.Name = "bInvitarAdminitrador";
            this.bInvitarAdminitrador.Size = new System.Drawing.Size(200, 50);
            this.bInvitarAdminitrador.TabIndex = 2;
            this.bInvitarAdminitrador.TextColor = System.Drawing.Color.Black;
            this.bInvitarAdminitrador.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bInvitarAdminitrador.Click += new System.EventHandler(this.bInvitarAdminitrador_Click);
            // 
            // bBandejaEntrada
            // 
            this.bBandejaEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bBandejaEntrada.ButtonImage = global::CampusApS.Properties.Resources.correo;
            this.bBandejaEntrada.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bBandejaEntrada.ButtonText = "Bandeja de entrada";
            this.bBandejaEntrada.ClickBackColor = System.Drawing.Color.Black;
            this.bBandejaEntrada.ClickTextColor = System.Drawing.Color.Black;
            this.bBandejaEntrada.CornerRadius = 5;
            this.bBandejaEntrada.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bBandejaEntrada.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bBandejaEntrada.HoverTextColor = System.Drawing.Color.White;
            this.bBandejaEntrada.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.bBandejaEntrada.Location = new System.Drawing.Point(294, 36);
            this.bBandejaEntrada.Name = "bBandejaEntrada";
            this.bBandejaEntrada.Size = new System.Drawing.Size(200, 50);
            this.bBandejaEntrada.TabIndex = 3;
            this.bBandejaEntrada.TextColor = System.Drawing.Color.Black;
            this.bBandejaEntrada.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bBandejaEntrada.Click += new System.EventHandler(this.bBandejaEntrada_Click);
            // 
            // bMisCursos
            // 
            this.bMisCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bMisCursos.ButtonImage = global::CampusApS.Properties.Resources.curso;
            this.bMisCursos.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bMisCursos.ButtonText = "Mis cursos";
            this.bMisCursos.ClickBackColor = System.Drawing.Color.Black;
            this.bMisCursos.ClickTextColor = System.Drawing.Color.Black;
            this.bMisCursos.CornerRadius = 5;
            this.bMisCursos.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bMisCursos.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bMisCursos.HoverTextColor = System.Drawing.Color.White;
            this.bMisCursos.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bMisCursos.Location = new System.Drawing.Point(61, 106);
            this.bMisCursos.Name = "bMisCursos";
            this.bMisCursos.Size = new System.Drawing.Size(200, 50);
            this.bMisCursos.TabIndex = 4;
            this.bMisCursos.TextColor = System.Drawing.Color.Black;
            this.bMisCursos.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bMisCursos.Click += new System.EventHandler(this.bMisCursos_Click);
            // 
            // bMisAS
            // 
            this.bMisAS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bMisAS.ButtonImage = global::CampusApS.Properties.Resources.curso;
            this.bMisAS.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bMisAS.ButtonText = "Mis actividades sociales";
            this.bMisAS.ClickBackColor = System.Drawing.Color.Black;
            this.bMisAS.ClickTextColor = System.Drawing.Color.Black;
            this.bMisAS.CornerRadius = 5;
            this.bMisAS.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bMisAS.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bMisAS.HoverTextColor = System.Drawing.Color.White;
            this.bMisAS.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.bMisAS.Location = new System.Drawing.Point(294, 106);
            this.bMisAS.Name = "bMisAS";
            this.bMisAS.Size = new System.Drawing.Size(200, 50);
            this.bMisAS.TabIndex = 5;
            this.bMisAS.TextColor = System.Drawing.Color.Black;
            this.bMisAS.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bMisAS.Click += new System.EventHandler(this.bMisAS_Click);
            // 
            // bEliminarUsuario
            // 
            this.bEliminarUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarUsuario.ButtonImage = global::CampusApS.Properties.Resources.salir;
            this.bEliminarUsuario.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bEliminarUsuario.ButtonText = "Eliminar usuario";
            this.bEliminarUsuario.ClickBackColor = System.Drawing.Color.Black;
            this.bEliminarUsuario.ClickTextColor = System.Drawing.Color.Black;
            this.bEliminarUsuario.CornerRadius = 5;
            this.bEliminarUsuario.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarUsuario.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bEliminarUsuario.HoverTextColor = System.Drawing.Color.White;
            this.bEliminarUsuario.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminarUsuario.Location = new System.Drawing.Point(61, 256);
            this.bEliminarUsuario.Name = "bEliminarUsuario";
            this.bEliminarUsuario.Size = new System.Drawing.Size(200, 50);
            this.bEliminarUsuario.TabIndex = 6;
            this.bEliminarUsuario.TextColor = System.Drawing.Color.Black;
            this.bEliminarUsuario.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarUsuario.Click += new System.EventHandler(this.bEliminarUsuario_Click);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(535, 318);
            this.Controls.Add(this.bEliminarUsuario);
            this.Controls.Add(this.bMisAS);
            this.Controls.Add(this.bMisCursos);
            this.Controls.Add(this.bBandejaEntrada);
            this.Controls.Add(this.bInvitarAdminitrador);
            this.Controls.Add(this.bDarseDeBaja);
            this.Controls.Add(this.bcambiarNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.Opciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton bcambiarNombre;
        private XanderUI.XUIButton bDarseDeBaja;
        private XanderUI.XUIButton bInvitarAdminitrador;
        private XanderUI.XUIButton bBandejaEntrada;
        private XanderUI.XUIButton bMisCursos;
        private XanderUI.XUIButton bMisAS;
        private XanderUI.XUIButton bEliminarUsuario;

    }
}
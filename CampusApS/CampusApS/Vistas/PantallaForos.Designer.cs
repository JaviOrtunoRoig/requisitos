namespace CampusApS.Vistas
{
    partial class PantallaForos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaForos));
            this.bActSociales = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.lbForos = new System.Windows.Forms.ListBox();
            this.bPapelera = new XanderUI.XUIButton();
            this.bEliminarForo = new XanderUI.XUIButton();
            this.bAnadirForo = new XanderUI.XUIButton();
            this.bBaja = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // bActSociales
            // 
            this.bActSociales.Location = new System.Drawing.Point(1011, 12);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(138, 23);
            this.bActSociales.TabIndex = 7;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(889, 12);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(126, 23);
            this.bCursos.TabIndex = 6;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            // 
            // bForos
            // 
            this.bForos.Location = new System.Drawing.Point(766, 12);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(127, 23);
            this.bForos.TabIndex = 5;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            // 
            // bNoticias
            // 
            this.bNoticias.Location = new System.Drawing.Point(645, 12);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 4;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 48);
            this.label1.TabIndex = 25;
            this.label1.Text = "FOROS";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(917, 180);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 24;
            // 
            // lbForos
            // 
            this.lbForos.FormattingEnabled = true;
            this.lbForos.Location = new System.Drawing.Point(272, 180);
            this.lbForos.Name = "lbForos";
            this.lbForos.Size = new System.Drawing.Size(598, 303);
            this.lbForos.TabIndex = 23;
            // 
            // bPapelera
            // 
            this.bPapelera.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bPapelera.ButtonImage = global::CampusApS.Properties.Resources.Papelera;
            this.bPapelera.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bPapelera.ButtonText = "";
            this.bPapelera.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.bPapelera.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.bPapelera.CornerRadius = 5;
            this.bPapelera.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bPapelera.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bPapelera.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bPapelera.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bPapelera.Location = new System.Drawing.Point(1065, 409);
            this.bPapelera.Name = "bPapelera";
            this.bPapelera.Size = new System.Drawing.Size(44, 42);
            this.bPapelera.TabIndex = 28;
            this.bPapelera.TextColor = System.Drawing.Color.DodgerBlue;
            this.bPapelera.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // bEliminarForo
            // 
            this.bEliminarForo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarForo.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bEliminarForo.ButtonImage")));
            this.bEliminarForo.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bEliminarForo.ButtonText = "Eliminar un foro";
            this.bEliminarForo.ClickBackColor = System.Drawing.Color.Firebrick;
            this.bEliminarForo.ClickTextColor = System.Drawing.Color.Firebrick;
            this.bEliminarForo.CornerRadius = 5;
            this.bEliminarForo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarForo.HoverBackgroundColor = System.Drawing.Color.Firebrick;
            this.bEliminarForo.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarForo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminarForo.Location = new System.Drawing.Point(917, 380);
            this.bEliminarForo.Name = "bEliminarForo";
            this.bEliminarForo.Size = new System.Drawing.Size(192, 23);
            this.bEliminarForo.TabIndex = 27;
            this.bEliminarForo.TextColor = System.Drawing.Color.Firebrick;
            this.bEliminarForo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // bAnadirForo
            // 
            this.bAnadirForo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirForo.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bAnadirForo.ButtonImage")));
            this.bAnadirForo.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bAnadirForo.ButtonText = "Añadir una foro";
            this.bAnadirForo.ClickBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirForo.ClickTextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirForo.CornerRadius = 5;
            this.bAnadirForo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirForo.HoverBackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirForo.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirForo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bAnadirForo.Location = new System.Drawing.Point(917, 351);
            this.bAnadirForo.Name = "bAnadirForo";
            this.bAnadirForo.Size = new System.Drawing.Size(192, 23);
            this.bAnadirForo.TabIndex = 26;
            this.bAnadirForo.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirForo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // bBaja
            // 
            this.bBaja.BackgroundColor = System.Drawing.Color.White;
            this.bBaja.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bBaja.ButtonImage")));
            this.bBaja.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.bBaja.ButtonText = "Darse de baja";
            this.bBaja.ClickBackColor = System.Drawing.Color.Black;
            this.bBaja.ClickTextColor = System.Drawing.Color.Black;
            this.bBaja.CornerRadius = 5;
            this.bBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bBaja.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bBaja.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bBaja.HoverTextColor = System.Drawing.Color.White;
            this.bBaja.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bBaja.Location = new System.Drawing.Point(12, 596);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(161, 22);
            this.bBaja.TabIndex = 29;
            this.bBaja.TextColor = System.Drawing.Color.Black;
            this.bBaja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // PantallaForos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 630);
            this.Controls.Add(this.bBaja);
            this.Controls.Add(this.bPapelera);
            this.Controls.Add(this.bEliminarForo);
            this.Controls.Add(this.bAnadirForo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.lbForos);
            this.Controls.Add(this.bActSociales);
            this.Controls.Add(this.bCursos);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bNoticias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaForos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.ListBox lbForos;
        private XanderUI.XUIButton bPapelera;
        private XanderUI.XUIButton bEliminarForo;
        private XanderUI.XUIButton bAnadirForo;
        private XanderUI.XUIButton bBaja;
    }
}
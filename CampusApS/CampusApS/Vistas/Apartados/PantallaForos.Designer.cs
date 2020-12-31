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
            this.carta = new XanderUI.XUICard();
            this.SuspendLayout();
            // 
            // bActSociales
            // 
            this.bActSociales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bActSociales.Location = new System.Drawing.Point(1011, 12);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(138, 23);
            this.bActSociales.TabIndex = 7;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            this.bActSociales.Click += new System.EventHandler(this.bActSociales_Click);
            // 
            // bCursos
            // 
            this.bCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCursos.Location = new System.Drawing.Point(889, 12);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(126, 23);
            this.bCursos.TabIndex = 6;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bForos
            // 
            this.bForos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bForos.Location = new System.Drawing.Point(766, 12);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(127, 23);
            this.bForos.TabIndex = 5;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            // 
            // bNoticias
            // 
            this.bNoticias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNoticias.Location = new System.Drawing.Point(645, 12);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 4;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 83);
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
            this.lbForos.Location = new System.Drawing.Point(366, 180);
            this.lbForos.Name = "lbForos";
            this.lbForos.Size = new System.Drawing.Size(479, 303);
            this.lbForos.TabIndex = 23;
            this.lbForos.DoubleClick += new System.EventHandler(this.lbForos_DoubleClick);
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
            this.bPapelera.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bPapelera.Click += new System.EventHandler(this.bPapelera_Click);
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
            this.bEliminarForo.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bEliminarForo.Click += new System.EventHandler(this.bEliminarForo_Click);
            // 
            // bAnadirForo
            // 
            this.bAnadirForo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirForo.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bAnadirForo.ButtonImage")));
            this.bAnadirForo.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bAnadirForo.ButtonText = "Añadir un foro";
            this.bAnadirForo.ClickBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirForo.ClickTextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirForo.CornerRadius = 5;
            this.bAnadirForo.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bAnadirForo.Click += new System.EventHandler(this.bAnadirForo_Click);
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
            this.bBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bBaja.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bBaja.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bBaja.HoverTextColor = System.Drawing.Color.White;
            this.bBaja.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bBaja.Location = new System.Drawing.Point(12, 588);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(161, 22);
            this.bBaja.TabIndex = 29;
            this.bBaja.TextColor = System.Drawing.Color.Black;
            this.bBaja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
            // 
            // carta
            // 
            this.carta.BackColor = System.Drawing.Color.Transparent;
            this.carta.Color1 = System.Drawing.Color.Gray;
            this.carta.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carta.ForeColor = System.Drawing.Color.White;
            this.carta.Location = new System.Drawing.Point(12, 60);
            this.carta.Name = "carta";
            this.carta.Size = new System.Drawing.Size(294, 163);
            this.carta.TabIndex = 52;
            this.carta.Text = "xuiCard1";
            this.carta.Text1 = "Tipo de usuario";
            this.carta.Text2 = "Nombre del usuario";
            this.carta.Text3 = "num expediente";
            // 
            // PantallaForos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CampusApS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1184, 700);
            this.Controls.Add(this.carta);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaForos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.Load += new System.EventHandler(this.PantallaForos_Load);
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
        private XanderUI.XUICard carta;
    }
}
namespace CampusApS
{
    partial class PantallaActividadesSociales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaActividadesSociales));
            this.bActSociales = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.lbActSociales = new System.Windows.Forms.ListBox();
            this.bAnadirAct = new XanderUI.XUIButton();
            this.bEliminarAct = new XanderUI.XUIButton();
            this.bPapelera = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.carta = new XanderUI.XUICard();
            this.bOpciones = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // bActSociales
            // 
            this.bActSociales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bActSociales.Location = new System.Drawing.Point(1013, 12);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(138, 23);
            this.bActSociales.TabIndex = 11;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            // 
            // bCursos
            // 
            this.bCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCursos.Location = new System.Drawing.Point(891, 12);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(126, 23);
            this.bCursos.TabIndex = 10;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bForos
            // 
            this.bForos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bForos.Location = new System.Drawing.Point(768, 12);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(127, 23);
            this.bForos.TabIndex = 9;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNoticias.Location = new System.Drawing.Point(647, 12);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 8;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(917, 177);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 12;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // lbActSociales
            // 
            this.lbActSociales.FormattingEnabled = true;
            this.lbActSociales.Location = new System.Drawing.Point(375, 180);
            this.lbActSociales.Name = "lbActSociales";
            this.lbActSociales.Size = new System.Drawing.Size(475, 290);
            this.lbActSociales.TabIndex = 13;
            this.lbActSociales.DoubleClick += new System.EventHandler(this.lbActSociales_DoubleClick);
            // 
            // bAnadirAct
            // 
            this.bAnadirAct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirAct.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bAnadirAct.ButtonImage")));
            this.bAnadirAct.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bAnadirAct.ButtonText = "Añadir una actividad social";
            this.bAnadirAct.ClickBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirAct.ClickTextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirAct.CornerRadius = 5;
            this.bAnadirAct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAnadirAct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirAct.HoverBackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirAct.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirAct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bAnadirAct.Location = new System.Drawing.Point(917, 358);
            this.bAnadirAct.Name = "bAnadirAct";
            this.bAnadirAct.Size = new System.Drawing.Size(192, 23);
            this.bAnadirAct.TabIndex = 15;
            this.bAnadirAct.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirAct.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirAct.Click += new System.EventHandler(this.bAnadirAct_Click);
            // 
            // bEliminarAct
            // 
            this.bEliminarAct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarAct.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bEliminarAct.ButtonImage")));
            this.bEliminarAct.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bEliminarAct.ButtonText = "Eliminar una actividad social";
            this.bEliminarAct.ClickBackColor = System.Drawing.Color.Firebrick;
            this.bEliminarAct.ClickTextColor = System.Drawing.Color.Firebrick;
            this.bEliminarAct.CornerRadius = 5;
            this.bEliminarAct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEliminarAct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarAct.HoverBackgroundColor = System.Drawing.Color.Firebrick;
            this.bEliminarAct.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarAct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminarAct.Location = new System.Drawing.Point(917, 387);
            this.bEliminarAct.Name = "bEliminarAct";
            this.bEliminarAct.Size = new System.Drawing.Size(192, 23);
            this.bEliminarAct.TabIndex = 16;
            this.bEliminarAct.TextColor = System.Drawing.Color.Firebrick;
            this.bEliminarAct.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarAct.Click += new System.EventHandler(this.bEliminarAct_Click);
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
            this.bPapelera.Location = new System.Drawing.Point(1065, 438);
            this.bPapelera.Name = "bPapelera";
            this.bPapelera.Size = new System.Drawing.Size(44, 42);
            this.bPapelera.TabIndex = 17;
            this.bPapelera.TextColor = System.Drawing.Color.DodgerBlue;
            this.bPapelera.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bPapelera.Click += new System.EventHandler(this.bPapelera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 48);
            this.label1.TabIndex = 19;
            this.label1.Text = "ACTIVIDADES SOCIALES";
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
            this.carta.TabIndex = 25;
            this.carta.Text = "xuiCard1";
            this.carta.Text1 = "Tipo de usuario";
            this.carta.Text2 = "Nombre del usuario";
            this.carta.Text3 = "";
            // 
            // bOpciones
            // 
            this.bOpciones.BackgroundColor = System.Drawing.Color.Transparent;
            this.bOpciones.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bOpciones.ButtonImage")));
            this.bOpciones.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bOpciones.ButtonText = "";
            this.bOpciones.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.bOpciones.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.bOpciones.CornerRadius = 5;
            this.bOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOpciones.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bOpciones.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bOpciones.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bOpciones.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.bOpciones.Location = new System.Drawing.Point(25, 538);
            this.bOpciones.Name = "bOpciones";
            this.bOpciones.Size = new System.Drawing.Size(69, 62);
            this.bOpciones.TabIndex = 26;
            this.bOpciones.TextColor = System.Drawing.Color.DodgerBlue;
            this.bOpciones.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bOpciones.Click += new System.EventHandler(this.bOpciones_Click);
            // 
            // PantallaActividadesSociales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CampusApS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1184, 700);
            this.Controls.Add(this.bOpciones);
            this.Controls.Add(this.carta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPapelera);
            this.Controls.Add(this.bEliminarAct);
            this.Controls.Add(this.bAnadirAct);
            this.Controls.Add(this.lbActSociales);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.bActSociales);
            this.Controls.Add(this.bCursos);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bNoticias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaActividadesSociales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.Load += new System.EventHandler(this.PantallaActividadesSociales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.ListBox lbActSociales;
        private XanderUI.XUIButton bAnadirAct;
        private XanderUI.XUIButton bEliminarAct;
        private XanderUI.XUIButton bPapelera;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUICard carta;
        private XanderUI.XUIButton bOpciones;
    }
}
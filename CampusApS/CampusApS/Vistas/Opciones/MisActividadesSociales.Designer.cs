namespace CampusApS.Vistas.Opciones {
    partial class MisActividadesSociales {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisActividadesSociales));
            this.bOpciones = new XanderUI.XUIButton();
            this.carta = new XanderUI.XUICard();
            this.bPapelera = new XanderUI.XUIButton();
            this.bEliminarAS = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.lMisAS = new System.Windows.Forms.ListBox();
            this.bActSociales = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.bOpciones.TabIndex = 66;
            this.bOpciones.TextColor = System.Drawing.Color.DodgerBlue;
            this.bOpciones.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bOpciones.Click += new System.EventHandler(this.bOpciones_Click);
            // 
            // carta
            // 
            this.carta.BackColor = System.Drawing.Color.Transparent;
            this.carta.Color1 = System.Drawing.Color.Gray;
            this.carta.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carta.ForeColor = System.Drawing.Color.White;
            this.carta.Location = new System.Drawing.Point(12, 57);
            this.carta.Name = "carta";
            this.carta.Size = new System.Drawing.Size(294, 163);
            this.carta.TabIndex = 65;
            this.carta.Text = "xuiCard1";
            this.carta.Text1 = "Tipo de usuario";
            this.carta.Text2 = "Nombre del usuario";
            this.carta.Text3 = "";
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
            this.bPapelera.Location = new System.Drawing.Point(1081, 408);
            this.bPapelera.Name = "bPapelera";
            this.bPapelera.Size = new System.Drawing.Size(44, 42);
            this.bPapelera.TabIndex = 63;
            this.bPapelera.TextColor = System.Drawing.Color.DodgerBlue;
            this.bPapelera.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bPapelera.Click += new System.EventHandler(this.bPapelera_Click);
            // 
            // bEliminarAS
            // 
            this.bEliminarAS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarAS.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bEliminarAS.ButtonImage")));
            this.bEliminarAS.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bEliminarAS.ButtonText = "Eliminar una actividad social";
            this.bEliminarAS.ClickBackColor = System.Drawing.Color.Firebrick;
            this.bEliminarAS.ClickTextColor = System.Drawing.Color.Firebrick;
            this.bEliminarAS.CornerRadius = 5;
            this.bEliminarAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEliminarAS.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarAS.HoverBackgroundColor = System.Drawing.Color.Firebrick;
            this.bEliminarAS.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarAS.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminarAS.Location = new System.Drawing.Point(933, 359);
            this.bEliminarAS.Name = "bEliminarAS";
            this.bEliminarAS.Size = new System.Drawing.Size(192, 23);
            this.bEliminarAS.TabIndex = 62;
            this.bEliminarAS.TextColor = System.Drawing.Color.Firebrick;
            this.bEliminarAS.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarAS.Click += new System.EventHandler(this.bEliminarAS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 48);
            this.label1.TabIndex = 60;
            this.label1.Text = "MIS ACTIVIDADES SOCIALES";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(933, 179);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 59;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // lMisAS
            // 
            this.lMisAS.FormattingEnabled = true;
            this.lMisAS.Location = new System.Drawing.Point(382, 179);
            this.lMisAS.Name = "lMisAS";
            this.lMisAS.Size = new System.Drawing.Size(479, 303);
            this.lMisAS.TabIndex = 58;
            this.lMisAS.DoubleClick += new System.EventHandler(this.lMisAS_DoubleClick);
            // 
            // bActSociales
            // 
            this.bActSociales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bActSociales.Location = new System.Drawing.Point(1027, 11);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(138, 23);
            this.bActSociales.TabIndex = 57;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            this.bActSociales.Click += new System.EventHandler(this.bActSociales_Click);
            // 
            // bCursos
            // 
            this.bCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCursos.Location = new System.Drawing.Point(905, 11);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(126, 23);
            this.bCursos.TabIndex = 56;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bForos
            // 
            this.bForos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bForos.Location = new System.Drawing.Point(782, 11);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(127, 23);
            this.bForos.TabIndex = 55;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNoticias.Location = new System.Drawing.Point(661, 11);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 54;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // MisActividadesSociales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CampusApS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1184, 700);
            this.Controls.Add(this.bOpciones);
            this.Controls.Add(this.carta);
            this.Controls.Add(this.bPapelera);
            this.Controls.Add(this.bEliminarAS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.lMisAS);
            this.Controls.Add(this.bActSociales);
            this.Controls.Add(this.bCursos);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bNoticias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MisActividadesSociales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusAps";
            this.Load += new System.EventHandler(this.MisActividadesSociales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton bOpciones;
        private XanderUI.XUICard carta;
        private XanderUI.XUIButton bPapelera;
        private XanderUI.XUIButton bEliminarAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.ListBox lMisAS;
        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bNoticias;
    }
}
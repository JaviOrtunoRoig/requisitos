namespace CampusApS.Vistas.Apartados {
    partial class VerHilos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerHilos));
            this.carta = new XanderUI.XUICard();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.bPapelera = new XanderUI.XUIButton();
            this.bEliminarHilo = new XanderUI.XUIButton();
            this.bAnadirHilo = new XanderUI.XUIButton();
            this.lbHilos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.bActSociales = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carta
            // 
            this.carta.BackColor = System.Drawing.Color.Transparent;
            this.carta.Color1 = System.Drawing.Color.Gray;
            this.carta.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carta.ForeColor = System.Drawing.Color.White;
            this.carta.Location = new System.Drawing.Point(31, 60);
            this.carta.Name = "carta";
            this.carta.Size = new System.Drawing.Size(294, 163);
            this.carta.TabIndex = 49;
            this.carta.Text = "xuiCard1";
            this.carta.Text1 = "Tipo de usuario";
            this.carta.Text2 = "Nombre del usuario";
            this.carta.Text3 = "num expediente";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lDescripcion.Location = new System.Drawing.Point(385, 164);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lDescripcion.TabIndex = 48;
            this.lDescripcion.Text = "Descripcion";
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
            this.bPapelera.Location = new System.Drawing.Point(1083, 407);
            this.bPapelera.Name = "bPapelera";
            this.bPapelera.Size = new System.Drawing.Size(44, 42);
            this.bPapelera.TabIndex = 47;
            this.bPapelera.TextColor = System.Drawing.Color.DodgerBlue;
            this.bPapelera.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // bEliminarHilo
            // 
            this.bEliminarHilo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarHilo.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bEliminarHilo.ButtonImage")));
            this.bEliminarHilo.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bEliminarHilo.ButtonText = "Eliminar un hilo";
            this.bEliminarHilo.ClickBackColor = System.Drawing.Color.Firebrick;
            this.bEliminarHilo.ClickTextColor = System.Drawing.Color.Firebrick;
            this.bEliminarHilo.CornerRadius = 5;
            this.bEliminarHilo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEliminarHilo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarHilo.HoverBackgroundColor = System.Drawing.Color.Firebrick;
            this.bEliminarHilo.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarHilo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminarHilo.Location = new System.Drawing.Point(935, 378);
            this.bEliminarHilo.Name = "bEliminarHilo";
            this.bEliminarHilo.Size = new System.Drawing.Size(192, 23);
            this.bEliminarHilo.TabIndex = 46;
            this.bEliminarHilo.TextColor = System.Drawing.Color.Firebrick;
            this.bEliminarHilo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // bAnadirHilo
            // 
            this.bAnadirHilo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirHilo.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bAnadirHilo.ButtonImage")));
            this.bAnadirHilo.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bAnadirHilo.ButtonText = "Añadir una hilo";
            this.bAnadirHilo.ClickBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirHilo.ClickTextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirHilo.CornerRadius = 5;
            this.bAnadirHilo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAnadirHilo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirHilo.HoverBackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirHilo.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirHilo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bAnadirHilo.Location = new System.Drawing.Point(935, 349);
            this.bAnadirHilo.Name = "bAnadirHilo";
            this.bAnadirHilo.Size = new System.Drawing.Size(192, 23);
            this.bAnadirHilo.TabIndex = 45;
            this.bAnadirHilo.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirHilo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // lbHilos
            // 
            this.lbHilos.FormattingEnabled = true;
            this.lbHilos.Location = new System.Drawing.Point(388, 267);
            this.lbHilos.Name = "lbHilos";
            this.lbHilos.Size = new System.Drawing.Size(388, 134);
            this.lbHilos.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 243);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Hilos";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(935, 180);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 42;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // bActSociales
            // 
            this.bActSociales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bActSociales.Location = new System.Drawing.Point(1034, 12);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(138, 23);
            this.bActSociales.TabIndex = 41;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            // 
            // bCursos
            // 
            this.bCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCursos.Location = new System.Drawing.Point(912, 12);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(126, 23);
            this.bCursos.TabIndex = 40;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            // 
            // bForos
            // 
            this.bForos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bForos.Location = new System.Drawing.Point(789, 12);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(127, 23);
            this.bForos.TabIndex = 39;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            // 
            // bNoticias
            // 
            this.bNoticias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNoticias.Location = new System.Drawing.Point(668, 12);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 38;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 84);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(292, 48);
            this.label1.TabIndex = 37;
            this.label1.Text = "NOMBRE DEL HILO";
            // 
            // VerHilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CampusApS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1184, 700);
            this.Controls.Add(this.carta);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.bPapelera);
            this.Controls.Add(this.bEliminarHilo);
            this.Controls.Add(this.bAnadirHilo);
            this.Controls.Add(this.lbHilos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.bActSociales);
            this.Controls.Add(this.bCursos);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bNoticias);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VerHilos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.Load += new System.EventHandler(this.VerHilos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICard carta;
        private System.Windows.Forms.Label lDescripcion;
        private XanderUI.XUIButton bPapelera;
        private XanderUI.XUIButton bEliminarHilo;
        private XanderUI.XUIButton bAnadirHilo;
        private System.Windows.Forms.ListBox lbHilos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Label label1;
    }
}
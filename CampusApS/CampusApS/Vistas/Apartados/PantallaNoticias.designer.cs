namespace CampusApS
{
    partial class PantallaNoticias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaNoticias));
            this.bNoticias = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bActSociales = new System.Windows.Forms.Button();
            this.lbNoticias = new System.Windows.Forms.ListBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.bBaja = new XanderUI.XUIButton();
            this.bPapelera = new XanderUI.XUIButton();
            this.bEliminarNoticia = new XanderUI.XUIButton();
            this.bAnadirNoticia = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bInvitar = new XanderUI.XUIButton();
            this.carta = new XanderUI.XUICard();
            this.bOpciones = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // bNoticias
            // 
            this.bNoticias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNoticias.Location = new System.Drawing.Point(859, 15);
            this.bNoticias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(169, 28);
            this.bNoticias.TabIndex = 0;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            // 
            // bForos
            // 
            this.bForos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bForos.Location = new System.Drawing.Point(1020, 15);
            this.bForos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(169, 28);
            this.bForos.TabIndex = 1;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // bCursos
            // 
            this.bCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCursos.Location = new System.Drawing.Point(1184, 15);
            this.bCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(168, 28);
            this.bCursos.TabIndex = 2;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bActSociales
            // 
            this.bActSociales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bActSociales.Location = new System.Drawing.Point(1347, 15);
            this.bActSociales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(184, 28);
            this.bActSociales.TabIndex = 3;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            this.bActSociales.Click += new System.EventHandler(this.bActSociales_Click);
            // 
            // lbNoticias
            // 
            this.lbNoticias.FormattingEnabled = true;
            this.lbNoticias.ItemHeight = 16;
            this.lbNoticias.Location = new System.Drawing.Point(500, 222);
            this.lbNoticias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNoticias.Name = "lbNoticias";
            this.lbNoticias.Size = new System.Drawing.Size(632, 356);
            this.lbNoticias.TabIndex = 4;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(1299, 223);
            this.calendario.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 5;
            // 
            // bBaja
            // 
            this.bBaja.BackgroundColor = System.Drawing.Color.White;
            this.bBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.bBaja.Location = new System.Drawing.Point(16, 711);
            this.bBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(215, 27);
            this.bBaja.TabIndex = 11;
            this.bBaja.TextColor = System.Drawing.Color.Black;
            this.bBaja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
            // 
            // bPapelera
            // 
            this.bPapelera.BackgroundColor = System.Drawing.Color.Transparent;
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
            this.bPapelera.Location = new System.Drawing.Point(1496, 508);
            this.bPapelera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPapelera.Name = "bPapelera";
            this.bPapelera.Size = new System.Drawing.Size(59, 52);
            this.bPapelera.TabIndex = 21;
            this.bPapelera.TextColor = System.Drawing.Color.DodgerBlue;
            this.bPapelera.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // bEliminarNoticia
            // 
            this.bEliminarNoticia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarNoticia.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bEliminarNoticia.ButtonImage")));
            this.bEliminarNoticia.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bEliminarNoticia.ButtonText = "Eliminar una noticia";
            this.bEliminarNoticia.ClickBackColor = System.Drawing.Color.Firebrick;
            this.bEliminarNoticia.ClickTextColor = System.Drawing.Color.Firebrick;
            this.bEliminarNoticia.CornerRadius = 5;
            this.bEliminarNoticia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEliminarNoticia.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarNoticia.HoverBackgroundColor = System.Drawing.Color.Firebrick;
            this.bEliminarNoticia.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarNoticia.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminarNoticia.Location = new System.Drawing.Point(1299, 473);
            this.bEliminarNoticia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEliminarNoticia.Name = "bEliminarNoticia";
            this.bEliminarNoticia.Size = new System.Drawing.Size(256, 28);
            this.bEliminarNoticia.TabIndex = 20;
            this.bEliminarNoticia.TextColor = System.Drawing.Color.Firebrick;
            this.bEliminarNoticia.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // bAnadirNoticia
            // 
            this.bAnadirNoticia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirNoticia.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bAnadirNoticia.ButtonImage")));
            this.bAnadirNoticia.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bAnadirNoticia.ButtonText = "Añadir una noticia";
            this.bAnadirNoticia.ClickBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirNoticia.ClickTextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirNoticia.CornerRadius = 5;
            this.bAnadirNoticia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAnadirNoticia.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirNoticia.HoverBackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirNoticia.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirNoticia.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bAnadirNoticia.Location = new System.Drawing.Point(1299, 437);
            this.bAnadirNoticia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAnadirNoticia.Name = "bAnadirNoticia";
            this.bAnadirNoticia.Size = new System.Drawing.Size(256, 28);
            this.bAnadirNoticia.TabIndex = 19;
            this.bAnadirNoticia.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirNoticia.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 63);
            this.label1.TabIndex = 22;
            this.label1.Text = "NOTICIAS";
            // 
            // bInvitar
            // 
            this.bInvitar.BackgroundColor = System.Drawing.Color.White;
            this.bInvitar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bInvitar.ButtonImage")));
            this.bInvitar.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.bInvitar.ButtonText = "Invitar a un Administrador";
            this.bInvitar.ClickBackColor = System.Drawing.Color.Black;
            this.bInvitar.ClickTextColor = System.Drawing.Color.Black;
            this.bInvitar.CornerRadius = 5;
            this.bInvitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInvitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bInvitar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bInvitar.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bInvitar.HoverTextColor = System.Drawing.Color.White;
            this.bInvitar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bInvitar.Location = new System.Drawing.Point(16, 677);
            this.bInvitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bInvitar.Name = "bInvitar";
            this.bInvitar.Size = new System.Drawing.Size(311, 27);
            this.bInvitar.TabIndex = 23;
            this.bInvitar.TextColor = System.Drawing.Color.Black;
            this.bInvitar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bInvitar.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // carta
            // 
            this.carta.BackColor = System.Drawing.Color.Transparent;
            this.carta.Color1 = System.Drawing.Color.Gray;
            this.carta.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carta.ForeColor = System.Drawing.Color.White;
            this.carta.Location = new System.Drawing.Point(16, 74);
            this.carta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carta.Name = "carta";
            this.carta.Size = new System.Drawing.Size(392, 201);
            this.carta.TabIndex = 24;
            this.carta.Text = "xuiCard1";
            this.carta.Text1 = "Tipo de usuario";
            this.carta.Text2 = "Nombre del usuario";
            this.carta.Text3 = "num expediente";
            // 
            // bOpciones
            // 
            this.bOpciones.BackgroundColor = System.Drawing.Color.Transparent;
            this.bOpciones.ButtonImage = global::CampusApS.Properties.Resources.opciones;
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
            this.bOpciones.Location = new System.Drawing.Point(139, 572);
            this.bOpciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOpciones.Name = "bOpciones";
            this.bOpciones.Size = new System.Drawing.Size(92, 76);
            this.bOpciones.TabIndex = 25;
            this.bOpciones.TextColor = System.Drawing.Color.DodgerBlue;
            this.bOpciones.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bOpciones.Click += new System.EventHandler(this.bOpciones_Click);
            // 
            // PantallaNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CampusApS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1579, 862);
            this.Controls.Add(this.bOpciones);
            this.Controls.Add(this.carta);
            this.Controls.Add(this.bInvitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPapelera);
            this.Controls.Add(this.bEliminarNoticia);
            this.Controls.Add(this.bAnadirNoticia);
            this.Controls.Add(this.bBaja);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.lbNoticias);
            this.Controls.Add(this.bActSociales);
            this.Controls.Add(this.bCursos);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bNoticias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PantallaNoticias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.Load += new System.EventHandler(this.PantallaNoticias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.ListBox lbNoticias;
        private System.Windows.Forms.MonthCalendar calendario;
        private XanderUI.XUIButton bBaja;
        private XanderUI.XUIButton bPapelera;
        private XanderUI.XUIButton bEliminarNoticia;
        private XanderUI.XUIButton bAnadirNoticia;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton bInvitar;
        private XanderUI.XUICard carta;
        private XanderUI.XUIButton bOpciones;
    }
}
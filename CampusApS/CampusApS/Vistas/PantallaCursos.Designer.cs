namespace CampusApS
{
    partial class PantallaCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCursos));
            this.bActSociales = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.lbCursos = new System.Windows.Forms.ListBox();
            this.bBaja = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bParticiparCurso = new XanderUI.XUIButton();
            this.bPapelera = new XanderUI.XUIButton();
            this.bEliminarCurso = new XanderUI.XUIButton();
            this.bAnadirCurso = new XanderUI.XUIButton();
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
            this.bActSociales.Click += new System.EventHandler(this.bActSociales_Click);
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
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.Location = new System.Drawing.Point(645, 12);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 4;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(918, 180);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 8;
            // 
            // lbCursos
            // 
            this.lbCursos.FormattingEnabled = true;
            this.lbCursos.Location = new System.Drawing.Point(375, 180);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(446, 134);
            this.lbCursos.TabIndex = 9;
            this.lbCursos.DoubleClick += new System.EventHandler(this.lbCursos_DoubleClick);
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
            this.bBaja.Location = new System.Drawing.Point(12, 577);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(161, 22);
            this.bBaja.TabIndex = 10;
            this.bBaja.TextColor = System.Drawing.Color.Black;
            this.bBaja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "CURSOS";
            // 
            // bParticiparCurso
            // 
            this.bParticiparCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bParticiparCurso.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bParticiparCurso.ButtonImage")));
            this.bParticiparCurso.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bParticiparCurso.ButtonText = "Participar en un curso";
            this.bParticiparCurso.ClickBackColor = System.Drawing.Color.DimGray;
            this.bParticiparCurso.ClickTextColor = System.Drawing.Color.DimGray;
            this.bParticiparCurso.CornerRadius = 5;
            this.bParticiparCurso.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bParticiparCurso.HoverBackgroundColor = System.Drawing.Color.DimGray;
            this.bParticiparCurso.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bParticiparCurso.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bParticiparCurso.Location = new System.Drawing.Point(918, 353);
            this.bParticiparCurso.Name = "bParticiparCurso";
            this.bParticiparCurso.Size = new System.Drawing.Size(192, 23);
            this.bParticiparCurso.TabIndex = 24;
            this.bParticiparCurso.TextColor = System.Drawing.Color.DimGray;
            this.bParticiparCurso.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bParticiparCurso.Click += new System.EventHandler(this.bParticiparCurso_Click);
            // 
            // bPapelera
            // 
            this.bPapelera.BackgroundColor = System.Drawing.Color.Transparent;
            this.bPapelera.ButtonImage = global::CampusApS.Properties.Resources.Papelera;
            this.bPapelera.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bPapelera.ButtonText = "";
            this.bPapelera.ClickBackColor = System.Drawing.Color.Transparent;
            this.bPapelera.ClickTextColor = System.Drawing.Color.Transparent;
            this.bPapelera.CornerRadius = 5;
            this.bPapelera.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bPapelera.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.bPapelera.HoverTextColor = System.Drawing.Color.Transparent;
            this.bPapelera.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bPapelera.Location = new System.Drawing.Point(1066, 440);
            this.bPapelera.Name = "bPapelera";
            this.bPapelera.Size = new System.Drawing.Size(44, 42);
            this.bPapelera.TabIndex = 23;
            this.bPapelera.TextColor = System.Drawing.Color.Transparent;
            this.bPapelera.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bPapelera.Click += new System.EventHandler(this.bPapelera_Click);
            // 
            // bEliminarCurso
            // 
            this.bEliminarCurso.BackgroundColor = System.Drawing.Color.White;
            this.bEliminarCurso.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bEliminarCurso.ButtonImage")));
            this.bEliminarCurso.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bEliminarCurso.ButtonText = "Eliminar un curso";
            this.bEliminarCurso.ClickBackColor = System.Drawing.Color.Firebrick;
            this.bEliminarCurso.ClickTextColor = System.Drawing.Color.Firebrick;
            this.bEliminarCurso.CornerRadius = 5;
            this.bEliminarCurso.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarCurso.HoverBackgroundColor = System.Drawing.Color.Firebrick;
            this.bEliminarCurso.HoverTextColor = System.Drawing.Color.White;
            this.bEliminarCurso.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminarCurso.Location = new System.Drawing.Point(918, 411);
            this.bEliminarCurso.Name = "bEliminarCurso";
            this.bEliminarCurso.Size = new System.Drawing.Size(192, 23);
            this.bEliminarCurso.TabIndex = 22;
            this.bEliminarCurso.TextColor = System.Drawing.Color.Firebrick;
            this.bEliminarCurso.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarCurso.Click += new System.EventHandler(this.bEliminarCurso_Click);
            // 
            // bAnadirCurso
            // 
            this.bAnadirCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirCurso.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bAnadirCurso.ButtonImage")));
            this.bAnadirCurso.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bAnadirCurso.ButtonText = "Añadir un curso";
            this.bAnadirCurso.ClickBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirCurso.ClickTextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirCurso.CornerRadius = 5;
            this.bAnadirCurso.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirCurso.HoverBackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirCurso.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirCurso.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bAnadirCurso.Location = new System.Drawing.Point(918, 382);
            this.bAnadirCurso.Name = "bAnadirCurso";
            this.bAnadirCurso.Size = new System.Drawing.Size(192, 23);
            this.bAnadirCurso.TabIndex = 21;
            this.bAnadirCurso.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirCurso.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirCurso.Click += new System.EventHandler(this.bAnadirCurso_Click);
            // 
            // PantallaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CampusApS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.bParticiparCurso);
            this.Controls.Add(this.bPapelera);
            this.Controls.Add(this.bEliminarCurso);
            this.Controls.Add(this.bAnadirCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBaja);
            this.Controls.Add(this.lbCursos);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.bActSociales);
            this.Controls.Add(this.bCursos);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bNoticias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.Load += new System.EventHandler(this.PantallaCursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.ListBox lbCursos;
        private XanderUI.XUIButton bBaja;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton bParticiparCurso;
        private XanderUI.XUIButton bPapelera;
        private XanderUI.XUIButton bEliminarCurso;
        private XanderUI.XUIButton bAnadirCurso;
    }
}
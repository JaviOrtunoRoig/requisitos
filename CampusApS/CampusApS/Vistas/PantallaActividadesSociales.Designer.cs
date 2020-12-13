namespace CampusApS.Vistas
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
            this.bBaja = new XanderUI.XUIButton();
            this.bAnadirAct = new XanderUI.XUIButton();
            this.bEliminarAct = new XanderUI.XUIButton();
            this.bPapelera = new XanderUI.XUIButton();
            this.bParticiparAct = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bActSociales
            // 
            this.bActSociales.Location = new System.Drawing.Point(1351, 15);
            this.bActSociales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(184, 28);
            this.bActSociales.TabIndex = 11;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(1188, 15);
            this.bCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(168, 28);
            this.bCursos.TabIndex = 10;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bForos
            // 
            this.bForos.Location = new System.Drawing.Point(1024, 15);
            this.bForos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(169, 28);
            this.bForos.TabIndex = 9;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.Location = new System.Drawing.Point(863, 15);
            this.bNoticias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(169, 28);
            this.bNoticias.TabIndex = 8;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(1223, 218);
            this.calendario.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 12;
            // 
            // lbActSociales
            // 
            this.lbActSociales.FormattingEnabled = true;
            this.lbActSociales.ItemHeight = 16;
            this.lbActSociales.Location = new System.Drawing.Point(355, 218);
            this.lbActSociales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbActSociales.Name = "lbActSociales";
            this.lbActSociales.Size = new System.Drawing.Size(796, 372);
            this.lbActSociales.TabIndex = 13;
            this.lbActSociales.SelectedIndexChanged += new System.EventHandler(this.lbActSociales_SelectedIndexChanged);
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
            this.bBaja.Location = new System.Drawing.Point(16, 735);
            this.bBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(215, 27);
            this.bBaja.TabIndex = 14;
            this.bBaja.TextColor = System.Drawing.Color.Black;
            this.bBaja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
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
            this.bAnadirAct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirAct.HoverBackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirAct.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirAct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bAnadirAct.Location = new System.Drawing.Point(1223, 468);
            this.bAnadirAct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAnadirAct.Name = "bAnadirAct";
            this.bAnadirAct.Size = new System.Drawing.Size(256, 28);
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
            this.bEliminarAct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarAct.HoverBackgroundColor = System.Drawing.Color.Firebrick;
            this.bEliminarAct.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarAct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminarAct.Location = new System.Drawing.Point(1223, 503);
            this.bEliminarAct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEliminarAct.Name = "bEliminarAct";
            this.bEliminarAct.Size = new System.Drawing.Size(256, 28);
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
            this.bPapelera.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bPapelera.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bPapelera.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bPapelera.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bPapelera.Location = new System.Drawing.Point(1420, 539);
            this.bPapelera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPapelera.Name = "bPapelera";
            this.bPapelera.Size = new System.Drawing.Size(59, 52);
            this.bPapelera.TabIndex = 17;
            this.bPapelera.TextColor = System.Drawing.Color.DodgerBlue;
            this.bPapelera.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bPapelera.Click += new System.EventHandler(this.bPapelera_Click);
            // 
            // bParticiparAct
            // 
            this.bParticiparAct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bParticiparAct.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bParticiparAct.ButtonImage")));
            this.bParticiparAct.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bParticiparAct.ButtonText = "Participar en una actividad social";
            this.bParticiparAct.ClickBackColor = System.Drawing.Color.DimGray;
            this.bParticiparAct.ClickTextColor = System.Drawing.Color.DimGray;
            this.bParticiparAct.CornerRadius = 5;
            this.bParticiparAct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bParticiparAct.HoverBackgroundColor = System.Drawing.Color.DimGray;
            this.bParticiparAct.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bParticiparAct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bParticiparAct.Location = new System.Drawing.Point(1223, 432);
            this.bParticiparAct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bParticiparAct.Name = "bParticiparAct";
            this.bParticiparAct.Size = new System.Drawing.Size(256, 28);
            this.bParticiparAct.TabIndex = 18;
            this.bParticiparAct.TextColor = System.Drawing.Color.DimGray;
            this.bParticiparAct.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bParticiparAct.Click += new System.EventHandler(this.bParticiparAct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 63);
            this.label1.TabIndex = 19;
            this.label1.Text = "ACTIVIDADES SOCIALES";
            // 
            // PantallaActividadesSociales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 777);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bParticiparAct);
            this.Controls.Add(this.bPapelera);
            this.Controls.Add(this.bEliminarAct);
            this.Controls.Add(this.bAnadirAct);
            this.Controls.Add(this.bBaja);
            this.Controls.Add(this.lbActSociales);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.bActSociales);
            this.Controls.Add(this.bCursos);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bNoticias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PantallaActividadesSociales";
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
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.ListBox lbActSociales;
        private XanderUI.XUIButton bBaja;
        private XanderUI.XUIButton bAnadirAct;
        private XanderUI.XUIButton bEliminarAct;
        private XanderUI.XUIButton bPapelera;
        private XanderUI.XUIButton bParticiparAct;
        private System.Windows.Forms.Label label1;
    }
}
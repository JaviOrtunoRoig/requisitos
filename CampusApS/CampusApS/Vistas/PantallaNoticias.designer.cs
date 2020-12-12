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
            this.SuspendLayout();
            // 
            // bNoticias
            // 
            this.bNoticias.Location = new System.Drawing.Point(644, 12);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 0;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            // 
            // bForos
            // 
            this.bForos.Location = new System.Drawing.Point(765, 12);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(127, 23);
            this.bForos.TabIndex = 1;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(888, 12);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(126, 23);
            this.bCursos.TabIndex = 2;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            // 
            // bActSociales
            // 
            this.bActSociales.Location = new System.Drawing.Point(1010, 12);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(138, 23);
            this.bActSociales.TabIndex = 3;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            // 
            // lbNoticias
            // 
            this.lbNoticias.FormattingEnabled = true;
            this.lbNoticias.Location = new System.Drawing.Point(271, 181);
            this.lbNoticias.Name = "lbNoticias";
            this.lbNoticias.Size = new System.Drawing.Size(598, 303);
            this.lbNoticias.TabIndex = 4;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(916, 181);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 5;
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
            this.bBaja.TabIndex = 11;
            this.bBaja.TextColor = System.Drawing.Color.Black;
            this.bBaja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.bPapelera.Location = new System.Drawing.Point(1064, 413);
            this.bPapelera.Name = "bPapelera";
            this.bPapelera.Size = new System.Drawing.Size(44, 42);
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
            this.bEliminarNoticia.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarNoticia.HoverBackgroundColor = System.Drawing.Color.Firebrick;
            this.bEliminarNoticia.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarNoticia.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminarNoticia.Location = new System.Drawing.Point(916, 384);
            this.bEliminarNoticia.Name = "bEliminarNoticia";
            this.bEliminarNoticia.Size = new System.Drawing.Size(192, 23);
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
            this.bAnadirNoticia.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirNoticia.HoverBackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirNoticia.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirNoticia.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bAnadirNoticia.Location = new System.Drawing.Point(916, 355);
            this.bAnadirNoticia.Name = "bAnadirNoticia";
            this.bAnadirNoticia.Size = new System.Drawing.Size(192, 23);
            this.bAnadirNoticia.TabIndex = 19;
            this.bAnadirNoticia.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirNoticia.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 48);
            this.label1.TabIndex = 22;
            this.label1.Text = "NOTICIAS";
            // 
            // PantallaNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 630);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaNoticias";
            this.Text = "CampusApS";
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
    }
}
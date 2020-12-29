namespace CampusApS.Vistas {
    partial class Curso {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Curso));
            this.label1 = new System.Windows.Forms.Label();
            this.bActSociales = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbForos = new System.Windows.Forms.ListBox();
            this.bPapelera = new XanderUI.XUIButton();
            this.bEliminarForo = new XanderUI.XUIButton();
            this.bAnadirForo = new XanderUI.XUIButton();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 88);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(331, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "NOMBRE DEL CURSO";
            // 
            // bActSociales
            // 
            this.bActSociales.Location = new System.Drawing.Point(1015, 12);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(138, 23);
            this.bActSociales.TabIndex = 24;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            this.bActSociales.Click += new System.EventHandler(this.bActSociales_Click);
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(893, 12);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(126, 23);
            this.bCursos.TabIndex = 23;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bForos
            // 
            this.bForos.Location = new System.Drawing.Point(770, 12);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(127, 23);
            this.bForos.TabIndex = 22;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.Location = new System.Drawing.Point(649, 12);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 21;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(916, 180);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 247);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Foros";
            // 
            // lbForos
            // 
            this.lbForos.FormattingEnabled = true;
            this.lbForos.Location = new System.Drawing.Point(280, 271);
            this.lbForos.Name = "lbForos";
            this.lbForos.Size = new System.Drawing.Size(555, 134);
            this.lbForos.TabIndex = 28;
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
            this.bPapelera.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bPapelera.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bPapelera.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bPapelera.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bPapelera.Location = new System.Drawing.Point(1064, 407);
            this.bPapelera.Name = "bPapelera";
            this.bPapelera.Size = new System.Drawing.Size(44, 42);
            this.bPapelera.TabIndex = 31;
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
            this.bEliminarForo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarForo.HoverBackgroundColor = System.Drawing.Color.Firebrick;
            this.bEliminarForo.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bEliminarForo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminarForo.Location = new System.Drawing.Point(916, 378);
            this.bEliminarForo.Name = "bEliminarForo";
            this.bEliminarForo.Size = new System.Drawing.Size(192, 23);
            this.bEliminarForo.TabIndex = 30;
            this.bEliminarForo.TextColor = System.Drawing.Color.Firebrick;
            this.bEliminarForo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminarForo.Click += new System.EventHandler(this.bEliminarForo_Click);
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
            this.bAnadirForo.Location = new System.Drawing.Point(916, 349);
            this.bAnadirForo.Name = "bAnadirForo";
            this.bAnadirForo.Size = new System.Drawing.Size(192, 23);
            this.bAnadirForo.TabIndex = 29;
            this.bAnadirForo.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirForo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirForo.Click += new System.EventHandler(this.bAnadirForo_Click);
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(277, 168);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lDescripcion.TabIndex = 32;
            this.lDescripcion.Text = "Descripcion";
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 629);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.bPapelera);
            this.Controls.Add(this.bEliminarForo);
            this.Controls.Add(this.bAnadirForo);
            this.Controls.Add(this.lbForos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.bActSociales);
            this.Controls.Add(this.bCursos);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bNoticias);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.Load += new System.EventHandler(this.Curso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbForos;
        private XanderUI.XUIButton bPapelera;
        private XanderUI.XUIButton bEliminarForo;
        private XanderUI.XUIButton bAnadirForo;
        private System.Windows.Forms.Label lDescripcion;
    }
}
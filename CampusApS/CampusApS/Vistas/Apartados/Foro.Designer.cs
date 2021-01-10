namespace CampusApS
{
    partial class Foro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foro));
            this.lbHilos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.bActSociales = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lDescripción = new System.Windows.Forms.Label();
            this.carta = new XanderUI.XUICard();
            this.bOpciones = new XanderUI.XUIButton();
            this.bPapelera = new XanderUI.XUIButton();
            this.bEliminarHilo = new XanderUI.XUIButton();
            this.bAnadirHilo = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // lbHilos
            // 
            this.lbHilos.FormattingEnabled = true;
            this.lbHilos.ItemHeight = 16;
            this.lbHilos.Location = new System.Drawing.Point(485, 327);
            this.lbHilos.Margin = new System.Windows.Forms.Padding(4);
            this.lbHilos.Name = "lbHilos";
            this.lbHilos.Size = new System.Drawing.Size(517, 164);
            this.lbHilos.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(62, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "Hilos";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(1223, 222);
            this.calendario.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 37;
            // 
            // bActSociales
            // 
            this.bActSociales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bActSociales.Location = new System.Drawing.Point(1355, 15);
            this.bActSociales.Margin = new System.Windows.Forms.Padding(4);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(184, 28);
            this.bActSociales.TabIndex = 36;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            this.bActSociales.Click += new System.EventHandler(this.bActSociales_Click);
            // 
            // bCursos
            // 
            this.bCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCursos.Location = new System.Drawing.Point(1192, 15);
            this.bCursos.Margin = new System.Windows.Forms.Padding(4);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(168, 28);
            this.bCursos.TabIndex = 35;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bForos
            // 
            this.bForos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bForos.Location = new System.Drawing.Point(1028, 15);
            this.bForos.Margin = new System.Windows.Forms.Padding(4);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(169, 28);
            this.bForos.TabIndex = 34;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNoticias.Location = new System.Drawing.Point(867, 15);
            this.bNoticias.Margin = new System.Windows.Forms.Padding(4);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(169, 28);
            this.bNoticias.TabIndex = 33;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(346, 63);
            this.label1.TabIndex = 32;
            this.label1.Text = "TÍTULO DEL FORO";
            // 
            // lDescripción
            // 
            this.lDescripción.AutoSize = true;
            this.lDescripción.BackColor = System.Drawing.Color.Transparent;
            this.lDescripción.Location = new System.Drawing.Point(481, 222);
            this.lDescripción.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDescripción.Name = "lDescripción";
            this.lDescripción.Size = new System.Drawing.Size(134, 17);
            this.lDescripción.TabIndex = 40;
            this.lDescripción.Text = "Descripción del foro";
            // 
            // carta
            // 
            this.carta.BackColor = System.Drawing.Color.Transparent;
            this.carta.Color1 = System.Drawing.Color.Gray;
            this.carta.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carta.ForeColor = System.Drawing.Color.White;
            this.carta.Location = new System.Drawing.Point(16, 74);
            this.carta.Margin = new System.Windows.Forms.Padding(4);
            this.carta.Name = "carta";
            this.carta.Size = new System.Drawing.Size(392, 201);
            this.carta.TabIndex = 41;
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
            this.bOpciones.Location = new System.Drawing.Point(33, 662);
            this.bOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.bOpciones.Name = "bOpciones";
            this.bOpciones.Size = new System.Drawing.Size(92, 76);
            this.bOpciones.TabIndex = 42;
            this.bOpciones.TextColor = System.Drawing.Color.DodgerBlue;
            this.bOpciones.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bOpciones.Click += new System.EventHandler(this.bOpciones_Click);
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
            this.bPapelera.Location = new System.Drawing.Point(1065, 423);
            this.bPapelera.Name = "bPapelera";
            this.bPapelera.Size = new System.Drawing.Size(44, 42);
            this.bPapelera.TabIndex = 45;
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
            this.bEliminarHilo.Location = new System.Drawing.Point(917, 394);
            this.bEliminarHilo.Name = "bEliminarHilo";
            this.bEliminarHilo.Size = new System.Drawing.Size(192, 23);
            this.bEliminarHilo.TabIndex = 44;
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
            this.bAnadirHilo.Location = new System.Drawing.Point(917, 365);
            this.bAnadirHilo.Name = "bAnadirHilo";
            this.bAnadirHilo.Size = new System.Drawing.Size(192, 23);
            this.bAnadirHilo.TabIndex = 43;
            this.bAnadirHilo.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirHilo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // Foro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CampusApS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1184, 700);
            this.Controls.Add(this.bPapelera);
            this.Controls.Add(this.bEliminarHilo);
            this.Controls.Add(this.bAnadirHilo);
            this.Controls.Add(this.bOpciones);
            this.Controls.Add(this.carta);
            this.Controls.Add(this.lDescripción);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Foro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.Load += new System.EventHandler(this.Foro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbHilos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDescripción;
        private XanderUI.XUICard carta;
        private XanderUI.XUIButton bOpciones;
        private XanderUI.XUIButton bPapelera;
        private XanderUI.XUIButton bEliminarHilo;
        private XanderUI.XUIButton bAnadirHilo;
    }
}
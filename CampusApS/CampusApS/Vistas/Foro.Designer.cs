namespace CampusApS.Vistas
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
            this.bBaja = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // lbHilos
            // 
            this.lbHilos.FormattingEnabled = true;
            this.lbHilos.Location = new System.Drawing.Point(280, 256);
            this.lbHilos.Name = "lbHilos";
            this.lbHilos.Size = new System.Drawing.Size(555, 134);
            this.lbHilos.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 232);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Hilos";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(917, 180);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 37;
            // 
            // bActSociales
            // 
            this.bActSociales.Location = new System.Drawing.Point(1016, 12);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(138, 23);
            this.bActSociales.TabIndex = 36;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(894, 12);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(126, 23);
            this.bCursos.TabIndex = 35;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            // 
            // bForos
            // 
            this.bForos.Location = new System.Drawing.Point(771, 12);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(127, 23);
            this.bForos.TabIndex = 34;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            // 
            // bNoticias
            // 
            this.bNoticias.Location = new System.Drawing.Point(650, 12);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 33;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 88);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(276, 48);
            this.label1.TabIndex = 32;
            this.label1.Text = "TÍTULO DEL FORO";
            // 
            // lDescripción
            // 
            this.lDescripción.AutoSize = true;
            this.lDescripción.Location = new System.Drawing.Point(277, 180);
            this.lDescripción.Name = "lDescripción";
            this.lDescripción.Size = new System.Drawing.Size(101, 13);
            this.lDescripción.TabIndex = 40;
            this.lDescripción.Text = "Descripción del foro";
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
            this.bBaja.Location = new System.Drawing.Point(12, 594);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(161, 22);
            this.bBaja.TabIndex = 41;
            this.bBaja.TextColor = System.Drawing.Color.Black;
            this.bBaja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // Foro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 628);
            this.Controls.Add(this.bBaja);
            this.Controls.Add(this.lDescripción);
            this.Controls.Add(this.lbHilos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.bActSociales);
            this.Controls.Add(this.bCursos);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bNoticias);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private XanderUI.XUIButton bBaja;
    }
}
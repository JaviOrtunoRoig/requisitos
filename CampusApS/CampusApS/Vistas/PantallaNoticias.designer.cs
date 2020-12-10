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
            this.bDarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNoticias
            // 
            this.bNoticias.Location = new System.Drawing.Point(638, 34);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 0;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            // 
            // bForos
            // 
            this.bForos.Location = new System.Drawing.Point(759, 34);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(127, 23);
            this.bForos.TabIndex = 1;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(882, 34);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(126, 23);
            this.bCursos.TabIndex = 2;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            // 
            // bActSociales
            // 
            this.bActSociales.Location = new System.Drawing.Point(1004, 34);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(138, 23);
            this.bActSociales.TabIndex = 3;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            // 
            // lbNoticias
            // 
            this.lbNoticias.FormattingEnabled = true;
            this.lbNoticias.Location = new System.Drawing.Point(234, 144);
            this.lbNoticias.Name = "lbNoticias";
            this.lbNoticias.Size = new System.Drawing.Size(598, 303);
            this.lbNoticias.TabIndex = 4;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(950, 450);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 5;
            // 
            // bDarse
            // 
            this.bDarse.Location = new System.Drawing.Point(1047, 218);
            this.bDarse.Name = "bDarse";
            this.bDarse.Size = new System.Drawing.Size(75, 40);
            this.bDarse.TabIndex = 6;
            this.bDarse.Text = "Darse de baja";
            this.bDarse.UseVisualStyleBackColor = true;
            this.bDarse.Click += new System.EventHandler(this.bDarse_Click);
            // 
            // PantallaNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 630);
            this.Controls.Add(this.bDarse);
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

        }

        #endregion

        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.ListBox lbNoticias;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button bDarse;
    }
}
﻿namespace CampusApS
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
            this.SuspendLayout();
            // 
            // bNoticias
            // 
            this.bNoticias.Location = new System.Drawing.Point(634, 34);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(127, 23);
            this.bNoticias.TabIndex = 0;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            // 
            // bForos
            // 
            this.bForos.Location = new System.Drawing.Point(755, 34);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(127, 23);
            this.bForos.TabIndex = 1;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(878, 34);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(126, 23);
            this.bCursos.TabIndex = 2;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            // 
            // bActSociales
            // 
            this.bActSociales.Location = new System.Drawing.Point(1000, 34);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(138, 23);
            this.bActSociales.TabIndex = 3;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            // 
            // lbNoticias
            // 
            this.lbNoticias.FormattingEnabled = true;
            this.lbNoticias.Location = new System.Drawing.Point(235, 144);
            this.lbNoticias.Name = "lbNoticias";
            this.lbNoticias.Size = new System.Drawing.Size(598, 303);
            this.lbNoticias.TabIndex = 4;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(930, 144);
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
            // PantallaNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 630);
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

        }

        #endregion

        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.ListBox lbNoticias;
        private System.Windows.Forms.MonthCalendar calendario;
        private XanderUI.XUIButton bBaja;
    }
}
﻿namespace CampusApS.Vistas.Apartados {
    partial class Hilo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hilo));
            this.ltitulo = new System.Windows.Forms.Label();
            this.lRespuestas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(49, 34);
            this.ltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(62, 24);
            this.ltitulo.TabIndex = 0;
            this.ltitulo.Text = "Titulo";
            // 
            // lRespuestas
            // 
            this.lRespuestas.FormattingEnabled = true;
            this.lRespuestas.ItemHeight = 16;
            this.lRespuestas.Location = new System.Drawing.Point(53, 126);
            this.lRespuestas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lRespuestas.Name = "lRespuestas";
            this.lRespuestas.Size = new System.Drawing.Size(349, 212);
            this.lRespuestas.TabIndex = 1;
            this.lRespuestas.DoubleClick += new System.EventHandler(this.lRespuestas_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Respuestas";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.xuiButton1.ButtonText = "Responder";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(89, 374);
            this.xuiButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(267, 62);
            this.xuiButton1.TabIndex = 3;
            this.xuiButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // Hilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRespuestas);
            this.Controls.Add(this.ltitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Hilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hilo";
            this.Load += new System.EventHandler(this.Hilo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.ListBox lRespuestas;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButton1;
    }
}
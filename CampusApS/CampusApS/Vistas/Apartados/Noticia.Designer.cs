﻿namespace CampusApS.Vistas.Apartados {
    partial class Noticia {
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
            this.lTitulo = new System.Windows.Forms.Label();
            this.tBoxContenido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(59, 53);
            this.lTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(50, 20);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Titulo";
            // 
            // tBoxContenido
            // 
            this.tBoxContenido.Location = new System.Drawing.Point(63, 105);
            this.tBoxContenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxContenido.Multiline = true;
            this.tBoxContenido.Name = "tBoxContenido";
            this.tBoxContenido.ReadOnly = true;
            this.tBoxContenido.Size = new System.Drawing.Size(379, 253);
            this.tBoxContenido.TabIndex = 1;
            // 
            // Noticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1021, 543);
            this.Controls.Add(this.tBoxContenido);
            this.Controls.Add(this.lTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Noticia";
            this.Text = "Noticia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TextBox tBoxContenido;
    }
}
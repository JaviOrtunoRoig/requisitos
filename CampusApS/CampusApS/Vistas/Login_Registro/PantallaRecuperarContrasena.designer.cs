﻿namespace CampusApS
{
    partial class PantallaRecuperarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRecuperarContrasena));
            this.label1 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca su nombre de usuario";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(49, 71);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(257, 20);
            this.tNombre.TabIndex = 3;
            // 
            // bConfirmar
            // 
            this.bConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConfirmar.Location = new System.Drawing.Point(271, 119);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 5;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // PantallaRecuperarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(358, 154);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaRecuperarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Button bConfirmar;
    }
}
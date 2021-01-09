namespace CampusApS.Vistas.Opciones {
    partial class CambiarNombre {
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tNuevoNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAceptar.Location = new System.Drawing.Point(127, 114);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(100, 28);
            this.bAceptar.TabIndex = 0;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca tu nuevo nombre";
            // 
            // tNuevoNombre
            // 
            this.tNuevoNombre.BackColor = System.Drawing.SystemColors.Window;
            this.tNuevoNombre.Location = new System.Drawing.Point(113, 62);
            this.tNuevoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tNuevoNombre.Name = "tNuevoNombre";
            this.tNuevoNombre.Size = new System.Drawing.Size(132, 22);
            this.tNuevoNombre.TabIndex = 2;
            // 
            // CambiarNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 158);
            this.Controls.Add(this.tNuevoNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CambiarNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarNombre";
            this.Load += new System.EventHandler(this.CambiarNombre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNuevoNombre;
    }
}
namespace CampusApS.Vistas.Apartados {
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
            this.ltitulo = new System.Windows.Forms.Label();
            this.lRespuestas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(37, 28);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(50, 18);
            this.ltitulo.TabIndex = 0;
            this.ltitulo.Text = "Titulo";
            // 
            // lRespuestas
            // 
            this.lRespuestas.FormattingEnabled = true;
            this.lRespuestas.Location = new System.Drawing.Point(40, 102);
            this.lRespuestas.Name = "lRespuestas";
            this.lRespuestas.Size = new System.Drawing.Size(263, 173);
            this.lRespuestas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Respuestas";
            // 
            // Hilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(345, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRespuestas);
            this.Controls.Add(this.ltitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Hilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.ListBox lRespuestas;
        private System.Windows.Forms.Label label1;
    }
}
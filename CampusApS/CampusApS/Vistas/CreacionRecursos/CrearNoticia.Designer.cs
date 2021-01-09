namespace CampusApS.Vistas.CreacionRecursos
{
    partial class CrearNoticia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearNoticia));
            this.tTitularNoticia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tTextoNoticia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tTitularNoticia
            // 
            this.tTitularNoticia.Location = new System.Drawing.Point(32, 47);
            this.tTitularNoticia.Name = "tTitularNoticia";
            this.tTitularNoticia.Size = new System.Drawing.Size(547, 20);
            this.tTitularNoticia.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escribe el titular de la noticia";
            // 
            // tTextoNoticia
            // 
            this.tTextoNoticia.Location = new System.Drawing.Point(32, 118);
            this.tTextoNoticia.Multiline = true;
            this.tTextoNoticia.Name = "tTextoNoticia";
            this.tTextoNoticia.Size = new System.Drawing.Size(547, 250);
            this.tTextoNoticia.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Añade el contenido de la noticia";
            // 
            // bConfirmar
            // 
            this.bConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConfirmar.Location = new System.Drawing.Point(527, 415);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 10;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            // 
            // CrearNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tTextoNoticia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tTitularNoticia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearNoticia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Noticia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tTitularNoticia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tTextoNoticia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bConfirmar;
    }
}
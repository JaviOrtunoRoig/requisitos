namespace CampusApS.Vistas.CreacionRecursos
{
    partial class CrearActividadSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearActividadSocial));
            this.tNombreActSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tDescActSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNombreActSocial
            // 
            this.tNombreActSocial.Location = new System.Drawing.Point(30, 47);
            this.tNombreActSocial.Name = "tNombreActSocial";
            this.tNombreActSocial.Size = new System.Drawing.Size(252, 20);
            this.tNombreActSocial.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escriba el nombre de la actividad social";
            // 
            // tDescActSocial
            // 
            this.tDescActSocial.Location = new System.Drawing.Point(30, 114);
            this.tDescActSocial.Multiline = true;
            this.tDescActSocial.Name = "tDescActSocial";
            this.tDescActSocial.Size = new System.Drawing.Size(252, 76);
            this.tDescActSocial.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Añade una descripción para la actividad social";
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(231, 226);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 8;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            // 
            // CrearActividadSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 261);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tDescActSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNombreActSocial);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearActividadSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Actividad Social";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombreActSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tDescActSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bConfirmar;
    }
}
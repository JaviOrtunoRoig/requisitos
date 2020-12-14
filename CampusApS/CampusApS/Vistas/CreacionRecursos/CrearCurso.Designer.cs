namespace CampusApS.Vistas {
    partial class CrearCurso {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCurso));
            this.label1 = new System.Windows.Forms.Label();
            this.tNombreCurso = new System.Windows.Forms.TextBox();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba el nombre del curso";
            // 
            // tNombreCurso
            // 
            this.tNombreCurso.Location = new System.Drawing.Point(29, 48);
            this.tNombreCurso.Name = "tNombreCurso";
            this.tNombreCurso.Size = new System.Drawing.Size(252, 20);
            this.tNombreCurso.TabIndex = 1;
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(206, 215);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 2;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escriba una descripcion para el curso";
            // 
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(29, 125);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(252, 73);
            this.tDescripcion.TabIndex = 4;
            // 
            // CrearCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 262);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tNombreCurso);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNombreCurso;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDescripcion;
    }
}
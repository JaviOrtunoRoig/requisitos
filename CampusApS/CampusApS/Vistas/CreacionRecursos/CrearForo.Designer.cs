namespace CampusApS.Vistas.CreacionRecursos
{
    partial class CrearForo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearForo));
            this.tTituloForo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tDescForo = new System.Windows.Forms.TextBox();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tTituloForo
            // 
            this.tTituloForo.Location = new System.Drawing.Point(27, 48);
            this.tTituloForo.Name = "tTituloForo";
            this.tTituloForo.Size = new System.Drawing.Size(252, 20);
            this.tTituloForo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba el título del foro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Añade una descripción para el foro";
            // 
            // tDescForo
            // 
            this.tDescForo.Location = new System.Drawing.Point(27, 114);
            this.tDescForo.Multiline = true;
            this.tDescForo.Name = "tDescForo";
            this.tDescForo.Size = new System.Drawing.Size(252, 76);
            this.tDescForo.TabIndex = 5;
            // 
            // bConfirmar
            // 
            this.bConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConfirmar.Location = new System.Drawing.Point(227, 230);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 6;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // CrearForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(314, 265);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.tDescForo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tTituloForo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearForo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Foro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tTituloForo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDescForo;
        private System.Windows.Forms.Button bConfirmar;
    }
}
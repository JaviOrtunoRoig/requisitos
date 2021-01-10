namespace CampusApS.Vistas.Opciones {
    partial class NuevoMensaje {
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
            this.cUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tMensaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cUsuarios
            // 
            this.cUsuarios.FormattingEnabled = true;
            this.cUsuarios.Location = new System.Drawing.Point(60, 96);
            this.cUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cUsuarios.Name = "cUsuarios";
            this.cUsuarios.Size = new System.Drawing.Size(547, 24);
            this.cUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elija al usuario al que quiere enviarle el mensaje";
            // 
            // tMensaje
            // 
            this.tMensaje.Location = new System.Drawing.Point(60, 208);
            this.tMensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tMensaje.Multiline = true;
            this.tMensaje.Name = "tMensaje";
            this.tMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tMensaje.Size = new System.Drawing.Size(547, 217);
            this.tMensaje.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escriba un mensaje";
            // 
            // bEnviar
            // 
            this.bEnviar.BackColor = System.Drawing.Color.White;
            this.bEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnviar.Location = new System.Drawing.Point(209, 463);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(245, 48);
            this.bEnviar.TabIndex = 4;
            this.bEnviar.Text = "Enviar Mensaje";
            this.bEnviar.UseVisualStyleBackColor = false;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            this.bEnviar.MouseLeave += new System.EventHandler(this.bEnviar_MouseLeave);
            this.bEnviar.MouseHover += new System.EventHandler(this.bEnviar_MouseHover);
            // 
            // NuevoMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(679, 542);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NuevoMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoMensaje";
            this.Load += new System.EventHandler(this.NuevoMensaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bEnviar;
    }
}
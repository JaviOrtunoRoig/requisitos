namespace CampusApS.Vistas.Apartados {
    partial class EliminarUsuarioCurso {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarUsuarioCurso));
            this.label1 = new System.Windows.Forms.Label();
            this.cUsuarios = new System.Windows.Forms.ComboBox();
            this.bEliminar = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Elija al usuario al que quiere eliminar\r\nde este curso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cUsuarios
            // 
            this.cUsuarios.FormattingEnabled = true;
            this.cUsuarios.Location = new System.Drawing.Point(20, 124);
            this.cUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cUsuarios.Name = "cUsuarios";
            this.cUsuarios.Size = new System.Drawing.Size(417, 24);
            this.cUsuarios.TabIndex = 5;
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.bEliminar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bEliminar.ButtonImage")));
            this.bEliminar.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.bEliminar.ButtonText = "Eliminar";
            this.bEliminar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.bEliminar.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.bEliminar.CornerRadius = 5;
            this.bEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEliminar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.bEliminar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.bEliminar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEliminar.Location = new System.Drawing.Point(88, 180);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(267, 62);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.bEliminar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // EliminarUsuarioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(453, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cUsuarios);
            this.Controls.Add(this.bEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EliminarUsuarioCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarUsuario";
            this.Load += new System.EventHandler(this.EliminarUsuarioCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cUsuarios;
        private XanderUI.XUIButton bEliminar;
    }
}
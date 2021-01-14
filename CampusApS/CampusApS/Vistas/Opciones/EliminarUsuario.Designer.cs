namespace CampusApS.Vistas.Opciones {
    partial class EliminarUsuario {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarUsuario));
            this.bEliminar = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cUsuarios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.bEliminar.Location = new System.Drawing.Point(67, 129);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(200, 50);
            this.bEliminar.TabIndex = 0;
            this.bEliminar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.bEliminar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elija al usuario al que quiere eliminar";
            // 
            // cUsuarios
            // 
            this.cUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cUsuarios.FormattingEnabled = true;
            this.cUsuarios.Location = new System.Drawing.Point(16, 78);
            this.cUsuarios.Name = "cUsuarios";
            this.cUsuarios.Size = new System.Drawing.Size(314, 21);
            this.cUsuarios.TabIndex = 2;
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(340, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cUsuarios);
            this.Controls.Add(this.bEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EliminarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.Load += new System.EventHandler(this.EliminarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton bEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cUsuarios;
    }
}
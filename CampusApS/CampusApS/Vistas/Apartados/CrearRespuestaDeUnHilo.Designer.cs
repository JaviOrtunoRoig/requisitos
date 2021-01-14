namespace CampusApS.Vistas.Apartados {
    partial class CrearRespuestaDeUnHilo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearRespuestaDeUnHilo));
            this.bEnviar = new XanderUI.XUIButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bEnviar
            // 
            this.bEnviar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.bEnviar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bEnviar.ButtonImage")));
            this.bEnviar.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.bEnviar.ButtonText = "Enviar";
            this.bEnviar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.bEnviar.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.bEnviar.CornerRadius = 5;
            this.bEnviar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bEnviar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.bEnviar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.bEnviar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bEnviar.Location = new System.Drawing.Point(109, 256);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(200, 50);
            this.bEnviar.TabIndex = 7;
            this.bEnviar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.bEnviar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 70);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 152);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Respuesta";
            // 
            // CrearRespuestaDeUnHilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(415, 346);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrearRespuestaDeUnHilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RespuestaDeUnHilo";
            this.Load += new System.EventHandler(this.CrearRespuestaDeUnHilo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton bEnviar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}
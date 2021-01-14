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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hilo));
            this.ltitulo = new System.Windows.Forms.Label();
            this.lRespuestas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bResponder = new XanderUI.XUIButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.lRespuestas.Location = new System.Drawing.Point(40, 185);
            this.lRespuestas.Name = "lRespuestas";
            this.lRespuestas.Size = new System.Drawing.Size(263, 173);
            this.lRespuestas.TabIndex = 1;
            this.lRespuestas.DoubleClick += new System.EventHandler(this.lRespuestas_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Respuestas";
            // 
            // bResponder
            // 
            this.bResponder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.bResponder.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bResponder.ButtonImage")));
            this.bResponder.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.bResponder.ButtonText = "Responder";
            this.bResponder.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.bResponder.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.bResponder.CornerRadius = 5;
            this.bResponder.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bResponder.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.bResponder.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.bResponder.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bResponder.Location = new System.Drawing.Point(67, 387);
            this.bResponder.Name = "bResponder";
            this.bResponder.Size = new System.Drawing.Size(200, 50);
            this.bResponder.TabIndex = 3;
            this.bResponder.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.bResponder.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bResponder.Click += new System.EventHandler(this.bResponder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(263, 97);
            this.textBox1.TabIndex = 4;
            // 
            // Hilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(345, 493);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bResponder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRespuestas);
            this.Controls.Add(this.ltitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hilo";
            this.Load += new System.EventHandler(this.Hilo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.ListBox lRespuestas;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton bResponder;
        private System.Windows.Forms.TextBox textBox1;
    }
}
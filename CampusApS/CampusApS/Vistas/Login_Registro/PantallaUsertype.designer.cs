namespace CampusApS
{
    partial class PantallaUsertype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaUsertype));
            this.lbLogin = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.bProfesor = new XanderUI.XUIButton();
            this.bONG = new XanderUI.XUIButton();
            this.bAdmin = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(140, 31);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(591, 46);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "¿Cómo quiere entrar en la aplicación?";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.xuiButton1.ButtonImage = global::CampusApS.Properties.Resources.IconoAlumno;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "ALUMNO";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.Black;
            this.xuiButton1.ClickTextColor = System.Drawing.Color.Black;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(475, 138);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(221, 80);
            this.xuiButton1.TabIndex = 5;
            this.xuiButton1.TextColor = System.Drawing.Color.Black;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.bEstudiante_Click);
            // 
            // bProfesor
            // 
            this.bProfesor.BackgroundColor = System.Drawing.Color.White;
            this.bProfesor.ButtonImage = global::CampusApS.Properties.Resources.IconoProfesor;
            this.bProfesor.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bProfesor.ButtonText = "PROFESOR";
            this.bProfesor.ClickBackColor = System.Drawing.Color.Black;
            this.bProfesor.ClickTextColor = System.Drawing.Color.Black;
            this.bProfesor.CornerRadius = 5;
            this.bProfesor.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProfesor.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bProfesor.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bProfesor.HoverTextColor = System.Drawing.Color.White;
            this.bProfesor.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.bProfesor.Location = new System.Drawing.Point(148, 282);
            this.bProfesor.Name = "bProfesor";
            this.bProfesor.Size = new System.Drawing.Size(219, 80);
            this.bProfesor.TabIndex = 3;
            this.bProfesor.TextColor = System.Drawing.Color.Black;
            this.bProfesor.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bProfesor.Click += new System.EventHandler(this.bProfesor_Click);
            // 
            // bONG
            // 
            this.bONG.BackgroundColor = System.Drawing.Color.White;
            this.bONG.ButtonImage = global::CampusApS.Properties.Resources.IconoONG;
            this.bONG.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bONG.ButtonText = " USUARIO DE ONG";
            this.bONG.ClickBackColor = System.Drawing.Color.Black;
            this.bONG.ClickTextColor = System.Drawing.Color.Black;
            this.bONG.CornerRadius = 5;
            this.bONG.Font = new System.Drawing.Font("Bahnschrift Condensed", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bONG.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bONG.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bONG.HoverTextColor = System.Drawing.Color.White;
            this.bONG.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bONG.Location = new System.Drawing.Point(475, 282);
            this.bONG.Name = "bONG";
            this.bONG.Size = new System.Drawing.Size(280, 80);
            this.bONG.TabIndex = 1;
            this.bONG.TextColor = System.Drawing.Color.Black;
            this.bONG.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bONG.Click += new System.EventHandler(this.bONG_Click);
            // 
            // bAdmin
            // 
            this.bAdmin.BackgroundColor = System.Drawing.Color.White;
            this.bAdmin.ButtonImage = global::CampusApS.Properties.Resources.IconoAdmin;
            this.bAdmin.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bAdmin.ButtonText = "ADMINISTRADOR";
            this.bAdmin.ClickBackColor = System.Drawing.Color.Black;
            this.bAdmin.ClickTextColor = System.Drawing.Color.Black;
            this.bAdmin.CornerRadius = 5;
            this.bAdmin.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdmin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bAdmin.HoverBackgroundColor = System.Drawing.Color.Black;
            this.bAdmin.HoverTextColor = System.Drawing.Color.White;
            this.bAdmin.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.bAdmin.Location = new System.Drawing.Point(119, 127);
            this.bAdmin.Name = "bAdmin";
            this.bAdmin.Size = new System.Drawing.Size(266, 100);
            this.bAdmin.TabIndex = 0;
            this.bAdmin.TextColor = System.Drawing.Color.Black;
            this.bAdmin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bAdmin.Click += new System.EventHandler(this.bAdmin_Click);
            // 
            // PantallaUsertype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 434);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.bProfesor);
            this.Controls.Add(this.bONG);
            this.Controls.Add(this.bAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaUsertype";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusApS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton bAdmin;
        private XanderUI.XUIButton bONG;
        private XanderUI.XUIButton bProfesor;
        private System.Windows.Forms.Label lbLogin;
        private XanderUI.XUIButton xuiButton1;
    }
}
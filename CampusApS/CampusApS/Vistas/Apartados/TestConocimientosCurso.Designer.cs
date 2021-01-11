namespace CampusApS.Vistas.Apartados {
    partial class TestConocimientosCurso {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestConocimientosCurso));
            this.bOpciones = new XanderUI.XUIButton();
            this.carta = new XanderUI.XUICard();
            this.bAnadirTest = new XanderUI.XUIButton();
            this.lbTests = new System.Windows.Forms.ListBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.bActSociales = new System.Windows.Forms.Button();
            this.bCursos = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bOpciones
            // 
            this.bOpciones.BackgroundColor = System.Drawing.Color.Transparent;
            this.bOpciones.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bOpciones.ButtonImage")));
            this.bOpciones.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bOpciones.ButtonText = "";
            this.bOpciones.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.bOpciones.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.bOpciones.CornerRadius = 5;
            this.bOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOpciones.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bOpciones.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bOpciones.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bOpciones.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.bOpciones.Location = new System.Drawing.Point(48, 668);
            this.bOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.bOpciones.Name = "bOpciones";
            this.bOpciones.Size = new System.Drawing.Size(92, 76);
            this.bOpciones.TabIndex = 50;
            this.bOpciones.TextColor = System.Drawing.Color.DodgerBlue;
            this.bOpciones.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bOpciones.Click += new System.EventHandler(this.bOpciones_Click);
            // 
            // carta
            // 
            this.carta.BackColor = System.Drawing.Color.Transparent;
            this.carta.Color1 = System.Drawing.Color.Gray;
            this.carta.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carta.ForeColor = System.Drawing.Color.White;
            this.carta.Location = new System.Drawing.Point(31, 80);
            this.carta.Margin = new System.Windows.Forms.Padding(4);
            this.carta.Name = "carta";
            this.carta.Size = new System.Drawing.Size(392, 201);
            this.carta.TabIndex = 49;
            this.carta.Text = "xuiCard1";
            this.carta.Text1 = "Tipo de usuario";
            this.carta.Text2 = "Nombre del usuario";
            this.carta.Text3 = "num expediente";
            // 
            // bAnadirTest
            // 
            this.bAnadirTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirTest.ButtonImage = ((System.Drawing.Image)(resources.GetObject("bAnadirTest.ButtonImage")));
            this.bAnadirTest.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.bAnadirTest.ButtonText = "Añadir un test";
            this.bAnadirTest.ClickBackColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirTest.ClickTextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirTest.CornerRadius = 5;
            this.bAnadirTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAnadirTest.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirTest.HoverBackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirTest.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bAnadirTest.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bAnadirTest.Location = new System.Drawing.Point(1236, 438);
            this.bAnadirTest.Margin = new System.Windows.Forms.Padding(4);
            this.bAnadirTest.Name = "bAnadirTest";
            this.bAnadirTest.Size = new System.Drawing.Size(256, 28);
            this.bAnadirTest.TabIndex = 45;
            this.bAnadirTest.TextColor = System.Drawing.Color.DarkSeaGreen;
            this.bAnadirTest.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bAnadirTest.Click += new System.EventHandler(this.bAnadirTest_Click);
            // 
            // lbTests
            // 
            this.lbTests.FormattingEnabled = true;
            this.lbTests.ItemHeight = 16;
            this.lbTests.Location = new System.Drawing.Point(507, 225);
            this.lbTests.Margin = new System.Windows.Forms.Padding(4);
            this.lbTests.Name = "lbTests";
            this.lbTests.Size = new System.Drawing.Size(516, 404);
            this.lbTests.TabIndex = 44;
            this.lbTests.DoubleClick += new System.EventHandler(this.lbTests_DoubleClick);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(1236, 228);
            this.calendario.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 42;
            // 
            // bActSociales
            // 
            this.bActSociales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bActSociales.Location = new System.Drawing.Point(1368, 21);
            this.bActSociales.Margin = new System.Windows.Forms.Padding(4);
            this.bActSociales.Name = "bActSociales";
            this.bActSociales.Size = new System.Drawing.Size(184, 28);
            this.bActSociales.TabIndex = 41;
            this.bActSociales.Text = "Actividades Sociales";
            this.bActSociales.UseVisualStyleBackColor = true;
            this.bActSociales.Click += new System.EventHandler(this.bActSociales_Click);
            // 
            // bCursos
            // 
            this.bCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCursos.Location = new System.Drawing.Point(1205, 21);
            this.bCursos.Margin = new System.Windows.Forms.Padding(4);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(168, 28);
            this.bCursos.TabIndex = 40;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bForos
            // 
            this.bForos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bForos.Location = new System.Drawing.Point(1041, 21);
            this.bForos.Margin = new System.Windows.Forms.Padding(4);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(169, 28);
            this.bForos.TabIndex = 39;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = true;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNoticias.Location = new System.Drawing.Point(880, 21);
            this.bNoticias.Margin = new System.Windows.Forms.Padding(4);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(169, 28);
            this.bNoticias.TabIndex = 38;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = true;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(493, 63);
            this.label1.TabIndex = 37;
            this.label1.Text = "Test de conocimientos";
            // 
            // TestConocimientosCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CampusApS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1579, 862);
            this.Controls.Add(this.bOpciones);
            this.Controls.Add(this.carta);
            this.Controls.Add(this.bAnadirTest);
            this.Controls.Add(this.lbTests);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.bActSociales);
            this.Controls.Add(this.bCursos);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bNoticias);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestConocimientosCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestConomientosCurso";
            this.Load += new System.EventHandler(this.TestConocimientosCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton bOpciones;
        private XanderUI.XUICard carta;
        private XanderUI.XUIButton bAnadirTest;
        private System.Windows.Forms.ListBox lbTests;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button bActSociales;
        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.Button bNoticias;
        private System.Windows.Forms.Label label1;
    }
}
namespace CampusApS {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.xuiCheckBox1 = new XanderUI.XUICheckBox();
            this.xuiWidgetPanel1 = new XanderUI.XUIWidgetPanel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.xuiCard1 = new XanderUI.XUICard();
            this.WorkingArea = new System.Windows.Forms.Panel();
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuiBanner2 = new XanderUI.XUIBanner();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiCard2 = new XanderUI.XUICard();
            this.xuiCheckBox2 = new XanderUI.XUICheckBox();
            this.xuiCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.xuiClock2 = new XanderUI.XUIClock();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner1.BorderColor = System.Drawing.Color.White;
            this.xuiBanner1.ForeColor = System.Drawing.Color.White;
            this.xuiBanner1.Location = new System.Drawing.Point(431, 241);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(100, 20);
            this.xuiBanner1.TabIndex = 0;
            this.xuiBanner1.Text = "xuiBanner1";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Button";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(490, 138);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(200, 50);
            this.xuiButton1.TabIndex = 2;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiCheckBox1
            // 
            this.xuiCheckBox1.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox1.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiCheckBox1.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox1.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.xuiCheckBox1.Checked = false;
            this.xuiCheckBox1.ForeColor = System.Drawing.Color.White;
            this.xuiCheckBox1.Location = new System.Drawing.Point(705, 241);
            this.xuiCheckBox1.Name = "xuiCheckBox1";
            this.xuiCheckBox1.Size = new System.Drawing.Size(100, 20);
            this.xuiCheckBox1.TabIndex = 3;
            this.xuiCheckBox1.Text = "xuiCheckBox1";
            this.xuiCheckBox1.TickThickness = 2;
            // 
            // xuiWidgetPanel1
            // 
            this.xuiWidgetPanel1.ControlsAsWidgets = false;
            this.xuiWidgetPanel1.Location = new System.Drawing.Point(403, 425);
            this.xuiWidgetPanel1.Name = "xuiWidgetPanel1";
            this.xuiWidgetPanel1.Size = new System.Drawing.Size(200, 100);
            this.xuiWidgetPanel1.TabIndex = 4;
            // 
            // xuiClock1
            // 
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(218, 202);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(120, 130);
            this.xuiClock1.TabIndex = 5;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // xuiCard1
            // 
            this.xuiCard1.BackColor = System.Drawing.Color.Transparent;
            this.xuiCard1.Color1 = System.Drawing.Color.SlateGray;
            this.xuiCard1.Color2 = System.Drawing.Color.Black;
            this.xuiCard1.ForeColor = System.Drawing.Color.White;
            this.xuiCard1.Location = new System.Drawing.Point(862, 241);
            this.xuiCard1.Name = "xuiCard1";
            this.xuiCard1.Size = new System.Drawing.Size(320, 170);
            this.xuiCard1.TabIndex = 6;
            this.xuiCard1.Text = "xuiCard1";
            this.xuiCard1.Text1 = "Administrador";
            this.xuiCard1.Text2 = "Javier Ortuño";
            this.xuiCard1.Text3 = "";
            // 
            // WorkingArea
            // 
            this.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.WorkingArea.Name = "WorkingArea";
            this.WorkingArea.Size = new System.Drawing.Size(1435, 552);
            this.WorkingArea.TabIndex = 0;
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(1435, 591);
            this.xuiFormDesign1.TabIndex = 7;
            this.xuiFormDesign1.TitleText = "Form Name";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiClock2);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiCircleProgressBar1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiCheckBox2);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiCard2);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiButton2);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiBanner2);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1435, 552);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // xuiBanner2
            // 
            this.xuiBanner2.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner2.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner2.BorderColor = System.Drawing.Color.White;
            this.xuiBanner2.ForeColor = System.Drawing.Color.White;
            this.xuiBanner2.Location = new System.Drawing.Point(462, 175);
            this.xuiBanner2.Name = "xuiBanner2";
            this.xuiBanner2.Size = new System.Drawing.Size(100, 20);
            this.xuiBanner2.TabIndex = 0;
            this.xuiBanner2.Text = "xuiBanner2";
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton2.ButtonImage")));
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton2.ButtonText = "Button";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(726, 170);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(200, 50);
            this.xuiButton2.TabIndex = 1;
            this.xuiButton2.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiCard2
            // 
            this.xuiCard2.BackColor = System.Drawing.Color.Transparent;
            this.xuiCard2.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCard2.Color2 = System.Drawing.Color.LimeGreen;
            this.xuiCard2.ForeColor = System.Drawing.Color.White;
            this.xuiCard2.Location = new System.Drawing.Point(417, 305);
            this.xuiCard2.Name = "xuiCard2";
            this.xuiCard2.Size = new System.Drawing.Size(320, 170);
            this.xuiCard2.TabIndex = 2;
            this.xuiCard2.Text = "xuiCard2";
            this.xuiCard2.Text1 = "Administrador";
            this.xuiCard2.Text2 = "Javier Ortuño";
            this.xuiCard2.Text3 = "";
            // 
            // xuiCheckBox2
            // 
            this.xuiCheckBox2.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox2.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiCheckBox2.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox2.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.xuiCheckBox2.Checked = false;
            this.xuiCheckBox2.ForeColor = System.Drawing.Color.Black;
            this.xuiCheckBox2.Location = new System.Drawing.Point(481, 59);
            this.xuiCheckBox2.Name = "xuiCheckBox2";
            this.xuiCheckBox2.Size = new System.Drawing.Size(100, 20);
            this.xuiCheckBox2.TabIndex = 3;
            this.xuiCheckBox2.Text = "xuiCheckBox2";
            this.xuiCheckBox2.TickThickness = 2;
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.AnimationSpeed = 5;
            this.xuiCircleProgressBar1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.xuiCircleProgressBar1.FilledColorAlpha = 130;
            this.xuiCircleProgressBar1.FilledThickness = 40;
            this.xuiCircleProgressBar1.IsAnimated = false;
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(138, 121);
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Percentage = 63;
            this.xuiCircleProgressBar1.ShowText = true;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(200, 200);
            this.xuiCircleProgressBar1.TabIndex = 4;
            this.xuiCircleProgressBar1.TextColor = System.Drawing.Color.Gray;
            this.xuiCircleProgressBar1.TextSize = 25;
            this.xuiCircleProgressBar1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.xuiCircleProgressBar1.UnfilledThickness = 24;
            // 
            // xuiClock2
            // 
            this.xuiClock2.CircleThickness = 6;
            this.xuiClock2.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock2.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock2.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock2.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock2.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock2.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock2.Location = new System.Drawing.Point(917, 338);
            this.xuiClock2.Name = "xuiClock2";
            this.xuiClock2.ShowAmPm = false;
            this.xuiClock2.ShowHexagon = true;
            this.xuiClock2.ShowMinutesCircle = true;
            this.xuiClock2.ShowSecondsCircle = true;
            this.xuiClock2.Size = new System.Drawing.Size(120, 130);
            this.xuiClock2.TabIndex = 5;
            this.xuiClock2.Text = "xuiClock2";
            this.xuiClock2.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock2.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock2.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 591);
            this.Controls.Add(this.xuiFormDesign1);
            this.Controls.Add(this.xuiCard1);
            this.Controls.Add(this.xuiClock1);
            this.Controls.Add(this.xuiWidgetPanel1);
            this.Controls.Add(this.xuiCheckBox1);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.xuiBanner1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIBanner xuiBanner1;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUICheckBox xuiCheckBox1;
        private XanderUI.XUIWidgetPanel xuiWidgetPanel1;
        private XanderUI.XUIClock xuiClock1;
        private XanderUI.XUICard xuiCard1;
        private System.Windows.Forms.Panel WorkingArea;
        private XanderUI.XUIFormDesign xuiFormDesign1;
        private XanderUI.XUIClock xuiClock2;
        private XanderUI.XUICircleProgressBar xuiCircleProgressBar1;
        private XanderUI.XUICheckBox xuiCheckBox2;
        private XanderUI.XUICard xuiCard2;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIBanner xuiBanner2;
    }
}


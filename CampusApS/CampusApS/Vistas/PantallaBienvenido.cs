﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusApS.Vistas;

namespace CampusApS
{
    public partial class PantallaBienvenido : Form
    {
        public PantallaBienvenido()
        {
            InitializeComponent();
        }

        private void bInvitado_Click(object sender, EventArgs e) {
            PantallaInicio ventana = new PantallaInicio();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bRegister_Click(object sender, EventArgs e) {
            PantallaUsertype ventana = new PantallaUsertype();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bLogin_Click(object sender, EventArgs e) {
            PantallaLogin ventana = new PantallaLogin();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS
{
    public partial class PantallaUsertype : Form
    {
        public PantallaUsertype()
        {
            InitializeComponent();
        }

        private void bAdmin_Click(object sender, EventArgs e) {
            PantallaRegistroAdmin ventana = new PantallaRegistroAdmin();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bEstudiante_Click(object sender, EventArgs e) {
            //Todo add pantalla estudiante
            //Panta
            this.Visible = false;
            //ventana.ShowDialog();
            this.Visible = true;
        }
    }
}

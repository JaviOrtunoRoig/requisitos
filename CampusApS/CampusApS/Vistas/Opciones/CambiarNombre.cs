﻿using CampusApS.Modelo.Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS.Vistas.Opciones {
    public partial class CambiarNombre : Form {

        private Usuario usuario;

        public CambiarNombre(Usuario usuario) {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void CambiarNombre_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            // TODO : Update Método cambiar nombre
        }
    }
}

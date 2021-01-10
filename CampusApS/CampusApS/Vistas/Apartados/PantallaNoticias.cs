﻿using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Vistas;
using CampusApS.Vistas.Opciones;
using System;
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
    public partial class PantallaNoticias : Form
    {

        Usuario usuario;

        public PantallaNoticias(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void bCursos_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaCursos ventana = new PantallaCursos(usuario);
            ventana.ShowDialog();
        }
        
        private void bForos_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaForos ventana = new PantallaForos(usuario);
            ventana.ShowDialog();
        }

        private void bActSociales_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaActividadesSociales ventana = new PantallaActividadesSociales(usuario);
            ventana.ShowDialog();
        }

        private void bBaja_Click(object sender, EventArgs e) {
            ConfirmarPassword ventana = new ConfirmarPassword(usuario);
            ventana.ShowDialog();
            this.Close();
        }

        private void PantallaNoticias_Load(object sender, EventArgs e) {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

           
            this.carta.Text1 = this.usuario.getRol();
            this.carta.Text2 = this.usuario.getNombre();

            if (usuario.getRol().Equals("profesor"))
            {
                this.carta.Text3 = this.usuario.getNumExp();
            }
            else if (usuario.getRol().Equals("ong"))
            {
                this.carta.Text3 = this.usuario.getNumRegistro();
            }

            this.bAnadirNoticia.Visible = false;
            this.bEliminarNoticia.Visible = false;
            this.bPapelera.Visible = false;

            if (usuario.getRol().Equals("invitado")) bOpciones.Visible = false;
        }

        private void xuiButton1_Click(object sender, EventArgs e) {
            UsuarioQuery bd = new UsuarioQuery();
            bd.codigoAdmin();
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones ventana = new Opciones(usuario);
            ventana.ShowDialog();
        }
    }
}

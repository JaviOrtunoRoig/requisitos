﻿using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Vistas.CreacionRecursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS.Vistas
{
    public partial class PantallaForos : Form
    {

        Usuario usuario;

        public PantallaForos(Usuario user)
        {
            InitializeComponent();
            this.usuario = user;
        }

        private void PantallaForos_Load(object sender, EventArgs e) {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            this.bAnadirForo.Visible = this.usuario.getPermisos().getPuedeCrearCurso();
            this.bEliminarForo.Visible = this.usuario.getPermisos().getPuedeBorrarCurso();
            this.bPapelera.Visible = false;
            this.bBaja.Visible = usuario.getPermisos().getPuedeDarseDeBaja();
            ForosQuery BD = new ForosQuery();
            lbForos.DataSource = BD.getAllForoGeneral();
        }

        private void bBaja_Click(object sender, EventArgs e) {
            ConfirmarPassword ventana = new ConfirmarPassword(usuario);
            ventana.ShowDialog();
            this.Close();
        }

        private void bNoticias_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaNoticias ventana = new PantallaNoticias(usuario);
            ventana.ShowDialog();
        }

        private void bCursos_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaCursos ventana = new PantallaCursos(usuario);
            ventana.ShowDialog();
        }

        private void bActSociales_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaActividadesSociales ventana = new PantallaActividadesSociales(usuario);
            ventana.ShowDialog();
        }

        private void bAnadirForo_Click(object sender, EventArgs e) {
            CrearForo ventana = new CrearForo(usuario);
            ventana.ShowDialog();
            ForosQuery BD = new ForosQuery();
            lbForos.DataSource = BD.getAllForoGeneral();
        }

        private void bEliminarForo_Click(object sender, EventArgs e) {
            this.bPapelera.Visible = true;
            this.bEliminarForo.BackgroundColor = Color.Gray;
            this.bEliminarForo.TextColor = Color.White;

            ForosQuery BD = new ForosQuery();

            if(usuario.getRol().Equals("administrador"))
            {
                lbForos.DataSource = BD.getAllForoGeneral();
            }
            else
            {
                lbForos.DataSource = BD.getCreadorForoGeneral(usuario.getNombre());
            }
            
        }

        private void bPapelera_Click(object sender, EventArgs e) {
            ForosQuery BD = new ForosQuery();
            if (lbForos.SelectedItem != null) {
                string curso = lbForos.SelectedItem.ToString();
                BD.borrarForoGeneral(curso);
            }

            lbForos.DataSource = BD.getAllForoGeneral();
            this.bEliminarForo.TextColor = Color.Firebrick;
            this.bEliminarForo.BackgroundColor = Color.White;
            this.bPapelera.Visible = false;
        }

        private void lbForos_DoubleClick(object sender, EventArgs e) {
            if (lbForos.SelectedItem != null) {
                ForoRecurso foroRecurso = new ForoRecurso((string) lbForos.SelectedItem); 
                Foro ventana = new Foro(usuario, foroRecurso);
                this.Visible = false;
                ventana.ShowDialog();
                this.Close();
            }
        }

    }
}

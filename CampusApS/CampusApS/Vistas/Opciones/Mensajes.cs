﻿using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using System;
using CampusApS.Vistas.Apartados;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS.Vistas.Opciones {
    public partial class Mensajes : Form, VistaGrande {

        private Usuario usuarioReceptor;
        private String usuarioEmisor;

        public Mensajes(Usuario usuarioReceptor, String usuarioEmisor) {
            InitializeComponent();
            this.usuarioReceptor = usuarioReceptor;
            this.usuarioEmisor = usuarioEmisor;

            lTitulo.Text = usuarioEmisor;
        }

        private void Mensajes_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;


            MensajeQuery BD = new MensajeQuery();

            lbMisMesnajes.DataSource = BD.getMensaje(usuarioEmisor, usuarioReceptor.getNombre());
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones ventana = new Opciones(usuarioReceptor, this);
            ventana.ShowDialog();

        }

        private void bNoticias_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaNoticias ventana = new PantallaNoticias(usuarioReceptor);
            ventana.ShowDialog();
        }

        private void bForos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaForos ventana = new PantallaForos(usuarioReceptor);
            ventana.ShowDialog();
        }

        private void bCursos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaCursos ventana = new PantallaCursos(usuarioReceptor);
            ventana.ShowDialog();
        }

        private void bActSociales_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaActividadesSociales ventana = new PantallaActividadesSociales(usuarioReceptor);
            ventana.ShowDialog();
        }

        private void calendario_DateSelected(object sender, EventArgs e)
        {
            VerEventos ventana = new VerEventos(calendario.SelectionStart.ToString().Substring(0, 10));
            ventana.ShowDialog();
            this.Visible = false;
            this.Close();
            this.Visible = true;
        }

        public void cerrar() {
            this.Close();
        }

        
    }
}

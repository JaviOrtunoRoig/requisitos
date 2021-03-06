﻿using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Vistas;
using CampusApS.Vistas.Apartados;
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
    public partial class PantallaCursos : Form, VistaGrande
    {

         private Usuario usuario;


        public PantallaCursos(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void PantallaCursos_Load(object sender, EventArgs e) {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

           
            this.carta.Text1 = this.usuario.getRol();
            this.carta.Text2 = this.usuario.getNombre();

            if (usuario.getRol().Equals("profesor") || usuario.getRol().Equals("ong"))
            {
                UsuarioQuery BDUsuario = new UsuarioQuery();
                this.carta.Text3 = BDUsuario.getPermiso(this.usuario.getNombre());
            }
            
            

            this.bParticiparCurso.Visible = this.usuario.getPermisos().getPuedeParticiparCurso();
            this.bAnadirCurso.Visible = this.usuario.getPermisos().getPuedeCrearCurso();
            this.bEliminarCurso.Visible = this.usuario.getPermisos().getPuedeBorrarCurso();
            this.bPapelera.Visible = false;
            CursoQuery BD = new CursoQuery();
            lbCursos.DataSource = BD.getAllCursos();

            if (usuario.getRol().Equals("invitado")) bOpciones.Visible = false;
        }

        private void bNoticias_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaNoticias ventana = new PantallaNoticias(usuario);
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

        private void bAnadirCurso_Click(object sender, EventArgs e) {
            CrearCurso ventana = new CrearCurso(usuario);
            ventana.ShowDialog();
            CursoQuery BD = new CursoQuery();
            lbCursos.DataSource = BD.getAllCursos();
        }

        private void bEliminarCurso_Click(object sender, EventArgs e) {
            this.bPapelera.Visible = true;
            this.bEliminarCurso.BackgroundColor = Color.Gray;
            this.bEliminarCurso.TextColor = Color.White;

            CursoQuery BD = new CursoQuery();

            if(usuario.getRol().Equals("administrador"))
            {
                lbCursos.DataSource = BD.getAllCursos();
            }
            else
            {
                lbCursos.DataSource = BD.getCursosCreador(usuario.getNombre());
            }
            
        }

        private void bPapelera_Click(object sender, EventArgs e) {
            CursoQuery BD = new CursoQuery();
            if (lbCursos.SelectedItem != null) {
                string curso = lbCursos.SelectedItem.ToString();
                BD.borrarCurso(curso);
            } 

            this.bEliminarCurso.TextColor = Color.Firebrick;
            this.bEliminarCurso.BackgroundColor = Color.White;
            this.lbCursos.DataSource = BD.getAllCursos();
            this.bPapelera.Visible = false;
        }

        private void lbCursos_DoubleClick(object sender, EventArgs e) {
            /*CursoQuery query = new CursoQuery();
            CursoRecurso cursoRecurso = new CursoRecurso((string) lbCursos.SelectedItem);
            cursoRecurso.setDescripcion(query.getDescripcionCurso((string) lbCursos.SelectedItem));
            Curso ventana = new Curso(usuario, cursoRecurso);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
            */

            // SE ACCEDE POR MIS CURSOS
        }

        private void bParticiparCurso_Click(object sender, EventArgs e) {
            CursoQuery BD = new CursoQuery();
            if (lbCursos.SelectedItem != null) {

                try
                {

                    BD.inscribirseCurso(this.usuario.getNombre(), (string)lbCursos.SelectedItem);


                    lbCursos.DataSource = BD.getAllCursos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            } else {
                MessageBox.Show("No hay ningún curso seleccionado");
            }
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones ventana = new Opciones(usuario, this);
            ventana.ShowDialog();
        }

        private void calendario_DateSelected(object sender, EventArgs e)
        {
            VerEventos ventana = new VerEventos(calendario.SelectionStart.ToString().Substring(0, 10));
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
           
        }

        public void cerrar() {
            this.Close();
        }
    }
}

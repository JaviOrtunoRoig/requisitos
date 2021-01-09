﻿using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Vistas;
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

    public partial class MisCursos : Form {

        private Usuario usuario;

        public MisCursos(Usuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void MisCursos_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            //TODO: Falta cambiar el numero de expediente, num ong, o lo q sea q vaya, depnde del tipo de usuario.
            this.carta.Text1 = this.usuario.getRol();
            this.carta.Text2 = this.usuario.getNombre();

            this.bEliminarCurso.Visible = this.usuario.getPermisos().getPuedeBorrarCurso();
            this.bPapelera.Visible = false;
            this.bBaja.Visible = usuario.getPermisos().getPuedeDarseDeBaja(); ;
            CursoQuery BD = new CursoQuery();
            //TODO : lbMisCursos.DataSource = BD.getAllCursos();   MÉTODO MIS CURSOS
        }

        private void bAnadirCurso_Click(object sender, EventArgs e)
        {
            CrearCurso ventana = new CrearCurso(usuario);
            ventana.ShowDialog();
            CursoQuery BD = new CursoQuery();
            lbMisCursos.DataSource = BD.getAllCursos();
        }

        private void bEliminarCurso_Click(object sender, EventArgs e)
        {
            this.bPapelera.Visible = true;
            this.bEliminarCurso.BackgroundColor = Color.Gray;
            this.bEliminarCurso.TextColor = Color.White;

            CursoQuery BD = new CursoQuery();

            if (usuario.getRol().Equals("administrador"))
            {
                lbMisCursos.DataSource = BD.getAllCursos();
            }
            else
            {
                lbMisCursos.DataSource = BD.getCursosCreador(usuario.getNombre());
            }

        }

        private void bPapelera_Click(object sender, EventArgs e)
        {
            CursoQuery BD = new CursoQuery();
            if (lbMisCursos.SelectedItem != null)
            {
                string curso = lbMisCursos.SelectedItem.ToString();
                BD.borrarCurso(curso);
            }

            this.bEliminarCurso.TextColor = Color.Firebrick;
            this.bEliminarCurso.BackgroundColor = Color.White;
            this.lbMisCursos.DataSource = BD.getAllCursos();
            this.bPapelera.Visible = false;
        }

        private void bCursos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaCursos ventana = new PantallaCursos(usuario);
            ventana.ShowDialog();
        }


        private void bNoticias_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaNoticias ventana = new PantallaNoticias(usuario);
            ventana.ShowDialog();
        }

        private void bForos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaForos ventana = new PantallaForos(usuario);
            ventana.ShowDialog();
        }

        private void bActSociales_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaActividadesSociales ventana = new PantallaActividadesSociales(usuario);
            ventana.ShowDialog();
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones ventana = new Opciones(usuario);
            ventana.ShowDialog();
        }

        private void lbMisCursos_DoubleClick(object sender, EventArgs e)
        {
            CursoQuery query = new CursoQuery();
            CursoRecurso cursoRecurso = new CursoRecurso((string)lbMisCursos.SelectedItem);
            cursoRecurso.setDescripcion(query.getDescripcionCurso((string)lbMisCursos.SelectedItem));
            Curso ventana = new Curso(usuario, cursoRecurso);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

    }
}
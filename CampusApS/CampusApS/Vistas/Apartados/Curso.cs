using CampusApS.Modelo.Logica.Recursos;
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

namespace CampusApS.Vistas {
    public partial class Curso : Form {

        Usuario usuario;
        CursoRecurso cursoRecurso; 

        public Curso(Usuario user, CursoRecurso curRec) {
            InitializeComponent();
            this.usuario = user;
            this.cursoRecurso = curRec;
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

        private void Curso_Load(object sender, EventArgs e) {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            //TODO: Falta cambiar el numero de expediente, num ong, o lo q sea q vaya, depnde del tipo de usuario.
            this.carta.Text1 = this.usuario.getRol();
            this.carta.Text2 = this.usuario.getNombre();

            this.label1.Text = this.cursoRecurso.getNombre();
            this.lDescripcion.Text = this.cursoRecurso.getdescripcion();

            this.bAnadirCurso.Visible = this.usuario.getPermisos().getPuedeCrearCurso();
            this.bEliminarCurso.Visible = this.usuario.getPermisos().getPuedeBorrarCurso();
            this.bPapelera.Visible = false;
            ForosQuery BD = new ForosQuery();
            lbCursos.DataSource = BD.getForoCurso(this.cursoRecurso.getNombre());
        }

        private void bAnadirForo_Click(object sender, EventArgs e) {
            CrearForo ventana = new CrearForo(usuario, cursoRecurso);
            ventana.ShowDialog();
            ForosQuery BD = new ForosQuery();
            lbCursos.DataSource = BD.getForoCurso(cursoRecurso.getNombre());
        }

        private void bEliminarForo_Click(object sender, EventArgs e) {
            this.bPapelera.Visible = true;
            this.bEliminarCurso.BackgroundColor = Color.Gray;
            this.bEliminarCurso.TextColor = Color.White;

            ForosQuery BD = new ForosQuery();
            lbCursos.DataSource = BD.getCreadorForoCurso(cursoRecurso.getNombre(), usuario.getNombre());
        }

        private void bPapelera_Click(object sender, EventArgs e) {
            ForosQuery BD = new ForosQuery();
            if (lbCursos.SelectedItem != null) {
                string foro = lbCursos.SelectedItem.ToString();
                BD.borrarForoCurso(foro);
            }

            this.bEliminarCurso.TextColor = Color.Firebrick;
            this.bEliminarCurso.BackgroundColor = Color.White;
            lbCursos.DataSource = BD.getForoCurso(this.cursoRecurso.getNombre());
            this.bPapelera.Visible = false;
        }

        private void lbForos_DoubleClick(object sender, EventArgs e) {
            ForosQuery query = new ForosQuery();
            ForoRecurso foroRecurso = new ForoRecurso((string)lbCursos.SelectedItem);
            foroRecurso.setDescripcion(query.getDescripcionForo((string)lbCursos.SelectedItem));
            Foro ventana = new Foro(usuario, foroRecurso);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bOpciones_Click(object sender, EventArgs e) {
            //TODO: Implementar

        }
    }
}

using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Vistas;
using CampusApS.Vistas.Apartados;
using CampusApS.Vistas.CreacionRecursos;
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

namespace CampusApS {
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

        private void Curso_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;


            this.carta.Text1 = this.usuario.getRol();
            this.carta.Text2 = this.usuario.getNombre();

            if (usuario.getRol().Equals("profesor") || usuario.getRol().Equals("ong"))
            {
                UsuarioQuery BDUsuario = new UsuarioQuery();
                this.carta.Text3 = BDUsuario.getPermiso(this.usuario.getNombre());
            }

            this.label1.Text = this.cursoRecurso.getNombre();
            this.lDescripcion.Text = this.cursoRecurso.getdescripcion();

            this.bAnadirForo.Visible = this.usuario.getPermisos().getPuedeCrearCurso();
            this.bEliminarForo.Visible = this.usuario.getPermisos().getPuedeBorrarCurso();
            this.bPapelera.Visible = false;
            ForosQuery BD = new ForosQuery();
            lbForos.DataSource = BD.getForoCurso(this.cursoRecurso.getNombre());

            if (usuario.getRol().Equals("invitado"))
            {
                bOpciones.Visible = false;
                bTestSatisfaccion.Visible = false;
                bTestConocimiento.Visible = false;
            }

            if (!usuario.getRol().Equals("profesor")) bEliminarUsuario.Visible = false;
        }

        private void bAnadirForo_Click(object sender, EventArgs e) {
            CrearForo ventana = new CrearForo(usuario, cursoRecurso);
            ventana.ShowDialog();
            ForosQuery BD = new ForosQuery();
            lbForos.DataSource = BD.getForoCurso(cursoRecurso.getNombre());
        }

        private void bEliminarForo_Click(object sender, EventArgs e) {
            this.bPapelera.Visible = true;
            this.bEliminarForo.BackgroundColor = Color.Gray;
            this.bEliminarForo.TextColor = Color.White;

            ForosQuery BD = new ForosQuery();
            lbForos.DataSource = BD.getCreadorForoCurso(cursoRecurso.getNombre(), usuario.getNombre());
        }

        private void bPapelera_Click(object sender, EventArgs e) {
            ForosQuery BD = new ForosQuery();
            if (lbForos.SelectedItem != null) {
                string foro = lbForos.SelectedItem.ToString();
                BD.borrarForoCurso(foro);
            }

            this.bEliminarForo.TextColor = Color.Firebrick;
            this.bEliminarForo.BackgroundColor = Color.White;
            lbForos.DataSource = BD.getForoCurso(this.cursoRecurso.getNombre());
            this.bPapelera.Visible = false;
        }

        private void lbForos_DoubleClick(object sender, EventArgs e) {
            ForosQuery query = new ForosQuery();
            ForoRecurso foroRecurso = new ForoRecurso((string)lbForos.SelectedItem);
            foroRecurso.setDescripcion(query.getDescripcionForo((string)lbForos.SelectedItem));
            Foro ventana = new Foro(usuario, foroRecurso);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones ventana = new Opciones(usuario);
            ventana.ShowDialog();
        }

        private void bTestConocimiento_Click(object sender, EventArgs e)
        {
            TestConocimientosCurso ventana = new TestConocimientosCurso(usuario, cursoRecurso);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuarioCurso ventana = new EliminarUsuarioCurso(usuario, cursoRecurso);
            ventana.ShowDialog();
        }

   

        /*  private void bTestSatisfaccion_Click(object sender, EventArgs e)
          {
              TestSatisfaccion test = new TestSatisfaccion(this.usuario);
              test.ShowDialog();
              this.Close();
          }*/
    }
}

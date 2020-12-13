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

namespace CampusApS
{
    public partial class PantallaCursos : Form
    {

        private Usuario usuario;


        public PantallaCursos(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void PantallaCursos_Load(object sender, EventArgs e) {
            if (usuario.GetType() == typeof(Administrador) || usuario.GetType() == typeof(Alumno) || usuario.GetType() == typeof(ONG)) {
                this.bParticiparCurso.Visible = true; //TODO: aniaidr bool en usuario para ver si se puede participar
            } else {
                this.bParticiparCurso.Visible = false;
            }

            this.bAnadirCurso.Visible = this.usuario.getPermisos().getPuedeCrearCurso();
            this.bEliminarCurso.Visible = this.usuario.getPermisos().getPuedeBorrarCurso();
            this.bPapelera.Visible = this.usuario.getPermisos().getPuedeBorrarCurso();
            UsuarioQuery BD = new UsuarioQuery();
            lbCursos.DataSource = BD.getAllCursos();
        }

        private void bNoticias_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaNoticias ventana = new PantallaNoticias(usuario);
            ventana.ShowDialog();
        }

        private void bActSociales_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaActividadesSociales ventana = new PantallaActividadesSociales(usuario);
            ventana.ShowDialog();
        }

        private void bBaja_Click(object sender, EventArgs e) {
            //TODO: Terminar de implmentar el darse de baja cuando este la vista

        }

        private void bAnadirCurso_Click(object sender, EventArgs e) {
            CrearCurso ventana = new CrearCurso(usuario);
            ventana.ShowDialog();
            UsuarioQuery BD = new UsuarioQuery();
            lbCursos.DataSource = BD.getAllCursos();
        }

        private void bEliminarCurso_Click(object sender, EventArgs e) {
            UsuarioQuery BD = new UsuarioQuery();
            lbCursos.DataSource = BD.getCursosCreador(usuario.getNombre());
        }

        private void bPapelera_Click(object sender, EventArgs e) {
            UsuarioQuery BD = new UsuarioQuery();
            string curso = lbCursos.SelectedItem.ToString();
            BD.borrarCurso(curso);
            lbCursos.DataSource = BD.getAllCursos();
        }

    }
}

using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Vistas;
using CampusApS.Vistas.CreacionRecursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using CampusApS.Vistas.Apartados;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS.Vistas.Opciones {
    public partial class MisActividadesSociales : Form {

        private Usuario usuario;

        public MisActividadesSociales(Usuario usuario) {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void MisActividadesSociales_Load(object sender, EventArgs e)
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

            this.bEliminarAS.Visible = this.usuario.getPermisos().getPuedeBorrarCurso();
            this.bPapelera.Visible = false;

            ActividadSocialQuery BD = new ActividadSocialQuery();

            if (!usuario.getRol().Equals("profesor") && !usuario.getRol().Equals("ong") && !usuario.getRol().Equals("administrador"))
            {
                lMisAS.DataSource = BD.misAS(usuario.getNombre());
            }
            else
            {
                lMisAS.DataSource = BD.getASCreador(usuario.getNombre());
            }

            if (usuario.getRol().Equals("invitado")) bOpciones.Visible = false;
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

        private void bCursos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaCursos ventana = new PantallaCursos(usuario);
            ventana.ShowDialog();
        }

        private void bActSociales_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaActividadesSociales ventana = new PantallaActividadesSociales(usuario);
            ventana.ShowDialog();
        }

        private void bEliminarAS_Click(object sender, EventArgs e)
        {
            this.bPapelera.Visible = true;
            this.bEliminarAS.BackgroundColor = Color.Gray;
            this.bEliminarAS.TextColor = Color.White;

            ActividadSocialQuery BD = new ActividadSocialQuery();

            if (usuario.getRol().Equals("administrador"))
            {
                lMisAS.DataSource = BD.getAllAS();
            }
            else
            {
                lMisAS.DataSource = BD.getASCreador(usuario.getNombre());
            }
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones ventana = new Opciones(usuario);
            ventana.ShowDialog();
        }

        private void lMisAS_DoubleClick(object sender, EventArgs e)
        {
            ActividadSocialQuery query = new ActividadSocialQuery();
            ActividadSocialRecurso ASRecurso = new ActividadSocialRecurso((string)lMisAS.SelectedItem);
            ASRecurso.setDescripcion(query.getDescripcionAS((string)lMisAS.SelectedItem));
            ActividadSocial ventana = new ActividadSocial(usuario, ASRecurso);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bPapelera_Click(object sender, EventArgs e)
        {
            CursoQuery BD = new CursoQuery();
            if (lMisAS.SelectedItem != null)
            {
                string curso = lMisAS.SelectedItem.ToString();
                BD.borrarCurso(curso);
            }

            this.bEliminarAS.TextColor = Color.Firebrick;
            this.bEliminarAS.BackgroundColor = Color.White;
            this.lMisAS.DataSource = BD.getAllCursos();
            this.bPapelera.Visible = false;
        }

        private void calendario_DateSelected(object sender, EventArgs e)
        {
            VerEventos ventana = new VerEventos(calendario.SelectionStart.ToString().Substring(0, 10));
            ventana.ShowDialog();
            this.Close();
        }

    


    }
}

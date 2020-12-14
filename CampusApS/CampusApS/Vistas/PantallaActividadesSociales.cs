using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Vistas;
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
    public partial class PantallaActividadesSociales : Form
    {

        Usuario usuario;

        public PantallaActividadesSociales(Usuario usuario)
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

        private void bNoticias_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaNoticias ventana = new PantallaNoticias(usuario);
            ventana.ShowDialog();
        }

        private void bBaja_Click(object sender, EventArgs e) {
            ConfirmarPassword ventana = new ConfirmarPassword(usuario);
            ventana.ShowDialog();
        }

        private void bForos_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaForos ventana = new PantallaForos(usuario);
            ventana.ShowDialog();
        }

        private void bParticiparAct_Click(object sender, EventArgs e)
        {
            
        }

        private void bAnadirAct_Click(object sender, EventArgs e)
        {
            CrearActividadSocial ventana = new CrearActividadSocial(usuario);
            ventana.ShowDialog();
            ActividadSocialQuery BD = new ActividadSocialQuery();
            lbActSociales.DataSource = BD.getAllAS();
        }

        private void bEliminarAct_Click(object sender, EventArgs e)
        {
            this.bPapelera.Visible = true;
            this.bEliminarAct.BackgroundColor = Color.Gray;
            this.bEliminarAct.TextColor = Color.White;

            ActividadSocialQuery BD = new ActividadSocialQuery();
            lbActSociales.DataSource = BD.getASCreador(usuario.getNombre());
        }

        private void bPapelera_Click(object sender, EventArgs e)
        {
            ActividadSocialQuery BD = new ActividadSocialQuery();
            if (lbActSociales.SelectedItem != null)
            {
                string curso = lbActSociales.SelectedItem.ToString();
                BD.borrarAS(curso);
            }

            this.lbActSociales.DataSource = BD.getAllAS();
            this.bEliminarAct.TextColor = Color.Firebrick;
            this.bEliminarAct.BackgroundColor = Color.White;
            this.bPapelera.Visible = false;
        }

    

        private void PantallaActividadesSociales_Load(object sender, EventArgs e) {
            this.bParticiparAct.Visible = this.usuario.getPermisos().getPuedeParticiparCurso();
            this.bAnadirAct.Visible = this.usuario.getPermisos().getPuedeCrearCurso();
            this.bEliminarAct.Visible = this.usuario.getPermisos().getPuedeBorrarCurso();
            this.bPapelera.Visible = false;
            this.bBaja.Visible = usuario.getPermisos().getPuedeDarseDeBaja();
            this.bParticiparAct.Visible = false;

            ActividadSocialQuery BD = new ActividadSocialQuery();
            lbActSociales.DataSource = BD.getAllAS();
        }

        private void lbActSociales_DoubleClick(object sender, EventArgs e) {
            if (lbActSociales.SelectedItem != null) {

            }
        }
    }
}

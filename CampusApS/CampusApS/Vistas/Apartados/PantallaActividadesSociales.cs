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
using CampusApS.Vistas.Opciones;


namespace CampusApS
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

            if(usuario.getRol().Equals("administrador"))
            {
                lbActSociales.DataSource = BD.getAllAS();
            }
            else
            {
                lbActSociales.DataSource = BD.getASCreador(usuario.getNombre());
            }
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
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

           
            this.carta.Text1 = this.usuario.getRol();
            this.carta.Text2 = this.usuario.getNombre();

            if (usuario.getRol().Equals("profesor") || usuario.getRol().Equals("ong"))
            {
                UsuarioQuery BDUsuario = new UsuarioQuery();
                this.carta.Text3 = BDUsuario.getPermiso(this.usuario.getNombre());
            }

            this.bParticiparAct.Visible = this.usuario.getPermisos().getPuedeParticiparActividadSocial();
            this.bAnadirAct.Visible = this.usuario.getPermisos().getPuedeCrearActividadSocial();
            this.bEliminarAct.Visible = this.usuario.getPermisos().getPuedeBorrarActividadSocial();
            this.bPapelera.Visible = false;

            this.bParticiparAct.Visible = false;

            ActividadSocialQuery BD = new ActividadSocialQuery();
            lbActSociales.DataSource = BD.getAllAS();


            if (usuario.getRol().Equals("invitado")) bOpciones.Visible = false;
        }

        private void lbActSociales_DoubleClick(object sender, EventArgs e) {

            /*
             
            ActividadSocialQuery query = new ActividadSocialQuery();
            ActividadSocialRecurso ASRecurso = new ActividadSocialRecurso((string)lbActSociales.SelectedItem);
            ASRecurso.setDescripcion(query.getDescripcionAS((string)lbActSociales.SelectedItem));
            ActividadSocial ventana = new ActividadSocial(usuario, ASRecurso);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
            */
        
            // SE ACCEDE POR MIS ACTIVIDADES SOCIALES

        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones ventana = new Opciones(usuario);
            ventana.ShowDialog();
        }

      
    }
}

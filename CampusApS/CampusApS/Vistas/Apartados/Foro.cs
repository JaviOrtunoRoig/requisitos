using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Vistas.Opciones;
using CampusApS.Vistas.Apartados;
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
    public partial class Foro : Form, VistaGrande
    {

        ForoRecurso foroRecurso;
        Usuario usuario;

        public Foro(Usuario user, ForoRecurso f)
        {
            InitializeComponent();
            this.usuario = user;
            this.foroRecurso = f;
        }

        private void Foro_Load(object sender, EventArgs e) {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            
            this.carta.Text1 = this.usuario.getRol();
            this.carta.Text2 = this.usuario.getNombre();

            if (usuario.getRol().Equals("profesor") || usuario.getRol().Equals("ong"))
            {
                UsuarioQuery BDUsuario = new UsuarioQuery();
                this.carta.Text3 = BDUsuario.getPermiso(this.usuario.getNombre());
            }

            HilosQuerys queryHilos = new HilosQuerys();
            ForosQuery query = new ForosQuery();
            this.foroRecurso.setDescripcion(query.getDescripcionForo(foroRecurso.getNombre()));

            this.label1.Text = foroRecurso.getNombre();
            this.lDescripción.Text = foroRecurso.getdescripcion();
            this.lbHilos.DataSource = queryHilos.getHilosForo(foroRecurso.getNombre());

            if (usuario.getRol().Equals("invitado"))
            {
                bOpciones.Visible = false;
                bAnadirHilo.Visible = false;
                bPapelera.Visible = false;
            }
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

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones ventana = new Opciones(usuario, this);
            ventana.ShowDialog();
        }

        private void bAnadirHilo_Click(object sender, EventArgs e)
        {
            CrearHilo ventana = new CrearHilo(usuario, foroRecurso);
            ventana.ShowDialog();

            Foro ventanaRecargada = new Foro(usuario, foroRecurso);
            ventanaRecargada.ShowDialog();
        }

        private void lbHilos_DoubleClick(object sender, EventArgs e)
        { 
            if(lbHilos.SelectedItem != null)
            {
                HilosQuerys bd = new HilosQuerys();
                string titulo = (string)lbHilos.SelectedItem;
                string cuerpo = bd.getMensaje(titulo);
                HiloRecurso hiloRec = new HiloRecurso(titulo, cuerpo);
                Hilo ventana = new Hilo(foroRecurso, hiloRec, usuario);
                ventana.ShowDialog();
            }
            
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

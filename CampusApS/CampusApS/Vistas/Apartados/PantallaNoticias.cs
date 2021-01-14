using CampusApS.Modelo.Logica.Recursos;
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
    public partial class PantallaNoticias : Form
    {

        Usuario usuario;

        public PantallaNoticias(Usuario usuario)
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

        private void PantallaNoticias_Load(object sender, EventArgs e) {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

           
            this.carta.Text1 = this.usuario.getRol();
            this.carta.Text2 = this.usuario.getNombre();

            if (usuario.getRol().Equals("profesor") || usuario.getRol().Equals("ong"))
            {
                UsuarioQuery BDUsuario = new UsuarioQuery();
                this.carta.Text3 = BDUsuario.getPermiso(this.usuario.getNombre());
            }

            bPapelera.Visible = false;

            if (usuario.getRol().Equals("invitado") || usuario.getRol().Equals("alumno"))
            {
                bAnadirNoticia.Visible = false;
                bEliminarNoticia.Visible = false;
            }

            if (usuario.getRol().Equals("invitado")) bOpciones.Visible = false;


            NoticiaQuery BD = new NoticiaQuery();
            lbNoticias.DataSource = BD.getAllNoticas();
        }

        private void xuiButton1_Click(object sender, EventArgs e) {
            UsuarioQuery bd = new UsuarioQuery();
            bd.codigoAdmin();
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones ventana = new Opciones(usuario);
            ventana.ShowDialog();
        }

        private void lbNoticias_DoubleClick(object sender, EventArgs e)
        {
            NoticiaQuery BD = new NoticiaQuery((string)lbNoticias.SelectedItem);
            Noticia ventana = new Noticia(BD.getTitulo(), BD.getContenido());
            ventana.ShowDialog();
        }

        private void bAnadirNoticia_Click(object sender, EventArgs e)
        {
            CrearNoticia ventana = new CrearNoticia(usuario);
            ventana.ShowDialog();

            NoticiaQuery BD = new NoticiaQuery();

            lbNoticias.DataSource = BD.getAllNoticas();
        }

        private void bEliminarNoticia_Click(object sender, EventArgs e)
        {
            this.bPapelera.Visible = true;
            this.bEliminarNoticia.BackgroundColor = Color.Gray;
            this.bEliminarNoticia.TextColor = Color.White;

            NoticiaQuery BD = new NoticiaQuery();


            if (usuario.getRol().Equals("administrador"))
            {
                lbNoticias.DataSource = BD.getAllNoticas();
            }
            else
            {
                lbNoticias.DataSource = BD.getNoticiasCreador(usuario.getNombre());
            }

      
        }

        private void bPapelera_Click(object sender, EventArgs e)
        {
            NoticiaQuery BD = new NoticiaQuery();
            if (lbNoticias.SelectedItem != null)
            {
                string noticia = lbNoticias.SelectedItem.ToString();
                BD.borrarNoticia(noticia);
            }

            this.bEliminarNoticia.TextColor = Color.Firebrick;
            this.bEliminarNoticia.BackgroundColor = Color.White;


            lbNoticias.DataSource = BD.getAllNoticas();


            this.bPapelera.Visible = false;
        }

        private void calendario_DateSelected(object sender, EventArgs e)
        {
            VerEventos ventana = new VerEventos(calendario.SelectionStart.ToString().Substring(0, 10));
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
            
        }

 
    }
}

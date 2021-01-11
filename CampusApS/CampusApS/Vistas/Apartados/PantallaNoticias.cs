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

            if (!usuario.getRol().Equals("invitado") && !usuario.getRol().Equals("alumno"))
            {
                bAnadirNoticia.Visible = true;
                bEliminarNoticia.Visible = true;
            }

            if (usuario.getRol().Equals("invitado")) bOpciones.Visible = false;
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
            //TODO: CREAR BD CursoQuery query = new CursoQuery();
            NoticiaRecurso noticiaRecurso = new NoticiaRecurso((string)lbNoticias.SelectedItem);
            //TODO: GET CONTENIDO cursoRecurso.setContenido(query.getContenido((string)lbNoticias.SelectedItem));
            //TODO: NoticiaQuery ventana = new NoticiaQuery(noticiaRecurso.getNombre(), noticiaRecurso.getContenido());
            //TODO: ventana.ShowDialog();
        }

        private void bAnadirNoticia_Click(object sender, EventArgs e)
        {
            CrearNoticia ventana = new CrearNoticia(usuario);
            ventana.ShowDialog();

            //TODO: CREAR BD NoticiaQuery BD = new NoticiaQuery();

            //TODO: AÑADIR NOTICIA lbNoticias.DataSource = BD.getAllNoticias();
        }

        private void bEliminarNoticia_Click(object sender, EventArgs e)
        {
            this.bPapelera.Visible = true;
            this.bEliminarNoticia.BackgroundColor = Color.Gray;
            this.bEliminarNoticia.TextColor = Color.White;

            //TODO: MOSTRAR NOTICIAS NoticiaQuery BD = new NoticiaQuery(); AND GETALLNOTICIAS()

      
        }

        private void bPapelera_Click(object sender, EventArgs e)
        {
            //TODO: CREAR BD NoticiaQuery BD = new NoticiaQuery();
            if (lbNoticias.SelectedItem != null)
            {
                string curso = lbNoticias.SelectedItem.ToString();
                //TODO: ELIMINAR NOTICIA BD.borrarNoticia(lbNoticias.SelectedItem);
            }

            this.bEliminarNoticia.TextColor = Color.Firebrick;
            this.bEliminarNoticia.BackgroundColor = Color.White;
            //TODO: GET ALL NOTICIAS this.lbNoticias.DataSource = BD.getAllNoticias();
            this.bPapelera.Visible = false;
        }

 
    }
}

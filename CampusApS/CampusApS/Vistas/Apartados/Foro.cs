using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
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
    public partial class Foro : Form
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

            if (usuario.getRol().Equals("profesor"))
            {
                this.carta.Text3 = this.usuario.getNumExp();
            }
            else if (usuario.getRol().Equals("ong"))
            {
                this.carta.Text3 = this.usuario.getNumRegistro();
            }

            ForosQuery query = new ForosQuery();
            this.foroRecurso.setDescripcion(query.getDescripcionForo(foroRecurso.getNombre()));

            this.label1.Text = foroRecurso.getNombre();
            this.lDescripción.Text = foroRecurso.getdescripcion();

            if (usuario.getRol().Equals("invitado")) bOpciones.Visible = false;
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
            Opciones ventana = new Opciones(usuario);
            ventana.ShowDialog();
        }

       
    }
}

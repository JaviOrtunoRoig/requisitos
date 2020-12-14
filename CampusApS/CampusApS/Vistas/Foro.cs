using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
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
            ForosQuery query = new ForosQuery();
            this.foroRecurso.setDescripcion(query.getDescripcioForoGeneral(foroRecurso.getNombre()).First());

            this.label1.Text = foroRecurso.getNombre();
            this.lDescripción.Text = foroRecurso.getdescripcion();
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
    }
}

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

        private void bActSociales_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            PantallaActividadesSociales ventana = new PantallaActividadesSociales(usuario);
            ventana.ShowDialog();
        }

        private void bBaja_Click(object sender, EventArgs e) {
            ConfirmarPassword ventana = new ConfirmarPassword(usuario);
            ventana.ShowDialog();
        }

        private void PantallaNoticias_Load(object sender, EventArgs e) {
            //Todo: cambiar la visivilidad si piden añadir o eliminar noticias
            this.bAnadirNoticia.Visible = false;
            this.bEliminarNoticia.Visible = false;
            this.bPapelera.Visible = false;
            this.bBaja.Visible = usuario.getPermisos().getPuedeDarseDeBaja();
        }
    }
}

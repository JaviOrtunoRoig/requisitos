using CampusApS.Modelo.Logica.Usuarios;
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
            //TODO: Terminar de implmentar el darse de baja cuando este la vista

        }
    }
}

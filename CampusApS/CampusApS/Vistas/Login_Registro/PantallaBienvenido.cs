using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusApS.Vistas;
using CampusApS.Modelo.Logica.Usuarios;

namespace CampusApS
{
    public partial class PantallaBienvenido : Form
    {
        public PantallaBienvenido()
        {
            InitializeComponent();
        }

        private void bInvitado_Click(object sender, EventArgs e) {
            Usuario usuario = new Invitado();
            PantallaNoticias ventana = new PantallaNoticias(usuario);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bRegister_Click(object sender, EventArgs e) {
            PantallaUsertype ventana = new PantallaUsertype();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bLogin_Click(object sender, EventArgs e) {
            PantallaLogin ventana = new PantallaLogin();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

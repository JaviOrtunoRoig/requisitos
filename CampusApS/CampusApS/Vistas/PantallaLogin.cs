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

namespace CampusApS
{
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }

        private void bConfirmar_Click(object sender, EventArgs e) {
            UsuarioQuery user = new UsuarioQuery();
            bool usuarioCorrecto = user.iniciarSesion(tCorreo.Text, tPassword.Text);
            if (usuarioCorrecto) {
                PantallaNoticias ventana = new PantallaNoticias();
                this.Visible = false;
                ventana.ShowDialog();
                this.Visible = true;
                this.Close();
            } else {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void bRecuperar_Click(object sender, EventArgs e) {
            PantallaRecuperarContrasena ventana = new PantallaRecuperarContrasena();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}

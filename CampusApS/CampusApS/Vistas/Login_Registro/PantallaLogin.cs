using CampusApS.Modelo.Logica;
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
            bool usuarioCorrecto = user.iniciarSesion(tNombre.Text, tPassword.Text);

            if (usuarioCorrecto) {
                string rolUsuario = user.getUsuario(tNombre.Text);

                if (rolUsuario != null) {
                    Usuario usuario;
                    if (rolUsuario.Equals("administrador")) {
                        usuario = new Administrador(tNombre.Text); 
                    } else if (rolUsuario.Equals("alumno")) {
                        usuario = new Alumno(tNombre.Text); 
                    } else if (rolUsuario.Equals("profesor")) {
                        usuario = new Profesor(tNombre.Text, user.getNumExp(tNombre.Text)); 
                    } else {
                        usuario = new ONG(tNombre.Text, user.getNumRegistro(tNombre.Text)); 
                    }

                    PantallaNoticias ventana = new PantallaNoticias(usuario);
                    this.Visible = false;
                    ventana.ShowDialog();
                    this.Visible = true;
                    this.Close();
                }

            } else {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void bRecuperar_Click(object sender, EventArgs e) {
            PantallaRecuperarContrasena ventana = new PantallaRecuperarContrasena();
            //this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}

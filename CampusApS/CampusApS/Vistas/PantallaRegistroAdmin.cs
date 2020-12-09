using CampusApS.Modelo.Logica;
using CampusApS.Modelo.Logica.Registro_InicioSesion;
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
    public partial class PantallaRegistroAdmin : Form
    {
        public PantallaRegistroAdmin()
        {
            InitializeComponent();
        }

        private void bConfirmar_Click(object sender, EventArgs e) {
            string correo = tCorreo.Text;
            string nombre = tNombre.Text;
            string password = tPassword.Text;
            string confPassword = tConfPassword.Text;
            string codAdmin = tCodigoInvitacion.Text;
            Usuario user = new Administrador(); 

            Registrarse registro = new Registrarse(password, confPassword, correo);
            if (registro.getEstadoRegistro()) {
                UsuarioQuery bd = new UsuarioQuery();
                bd.registrarAdmin(nombre, password, correo, codAdmin, user);
            } else {
                MessageBox.Show("Error en los campos");
            }
        }
    }
}

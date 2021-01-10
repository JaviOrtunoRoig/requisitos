using CampusApS.Modelo.Logica.Usuarios;
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
    public partial class PantallaRegistroONG : Form
    {
        public PantallaRegistroONG()
        {
            InitializeComponent();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            string correo = tCorreo.Text;
            string nombre = tNombre.Text;
            string password = tPassword.Text;
            string confPassword = tConfPassword.Text;
            string numeroONG = tNumRegONG.Text;
            Usuario user = new ONG(nombre, numeroONG);

            Registrarse registro = new Registrarse(password, confPassword, correo);
            if (registro.getEstadoRegistro())
            {
                UsuarioQuery bd = new UsuarioQuery();
                bd.registrarONG(nombre, password, correo, numeroONG, user);
                MessageBox.Show("Usuario de ONG registrado satisfactoriamente!!");
                this.Close();
            }

        }
    }
}

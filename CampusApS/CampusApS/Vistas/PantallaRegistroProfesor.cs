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
    public partial class PantallaRegistroProfesor : Form
    {
        public PantallaRegistroProfesor()
        {
            InitializeComponent();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            String nombre = tNombre.Text;
            String correo = tCorreo.Text;
            String password = tPassword.Text;
            String confPassword = tPassword.Text;
            String nExpediente = tNumExp.Text;
            Usuario user = new Profesor();

            Registrarse registro = new Registrarse(password, confPassword, correo);
            if (registro.getEstadoRegistro())
            {
                UsuarioQuery bd = new UsuarioQuery();
                bd.registrarProf(nombre, password, confPassword, nExpediente, user);
                MessageBox.Show("Profesor registrado satisfactoriamente!!");
                this.Close();
            }

        }
    }
}

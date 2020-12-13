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
    public partial class PantallaRegistroEstudiante : Form
    {
        public PantallaRegistroEstudiante()
        {
            InitializeComponent();
        }

        private void bConfirmar_Click(object sender, EventArgs e) {
            string correo = tCorreo.Text;
            string nombre = tNombre.Text;
            string password = tPassword.Text;
            string confPassword = tConfPassword.Text;
            Usuario user = new Alumno(nombre);

            Registrarse registro = new Registrarse(password, confPassword, correo);
            if (registro.getEstadoRegistro()) {
                UsuarioQuery bd = new UsuarioQuery();
                bd.registrarAlum(nombre, password, correo, user);
                MessageBox.Show("Alumno registrado satisfactoriamente!!");
                this.Close();
            } 
        }
    }
}

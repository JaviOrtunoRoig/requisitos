using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS.Modelo.Logica.Registro_InicioSesion {
    class Registrarse {

        private string password;
        private string confPassword;
        private string correo;

        private bool passwordIguales;
        private bool correoCorrecto;


        public Registrarse(string p1, string p2, string correo) {
            this.password = p1;
            this.confPassword = p2;
            this.correo = correo;
            this.passwordIguales = false;
            this.correoCorrecto = false;
        }

        public bool getEstadoRegistro() {
            comprobarPasswords();
            comprobarCorreo();
            return this.passwordIguales && this.correoCorrecto;
        }

        private void comprobarPasswords() {
            if (password.Equals(confPassword)) {
                this.passwordIguales = true;
            } else {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void comprobarCorreo() {
            if (this.correo.Contains("@hotmail.com") || this.correo.Contains("@hotmail.es") || this.correo.Contains("@gmail.com") || 
                this.correo.Contains("@gmail.es") || this.correo.Contains("@outlook.com") || this.correo.Contains("@outlook.es") ||
                this.correo.Contains("@uma.es")) {
                this.correoCorrecto = true;
            } else {
                MessageBox.Show("El correo tiene que tener uno de los siguientes dominios: \n " +
                "\t @hotmail.com" +
                "\n\t @hotmail.es" +
                "\n\t @gmail.com" +
                "\n\t @gmail.es" +
                "\n\t @outlook.com" +
                "\n\t @outlook.es" +
                "\n\t @uma.es"
                );
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Logica.Registro_InicioSesion {
    class Registrarse {

        private string password;
        private string confPassword;
        private string codigoRecuperacion;
        private bool registroHaSidoCorrecto;

        public Registrarse(string p1, string p2, string codRecuperacion) {
            this.password = p1;
            this.confPassword = p2;
            this.codigoRecuperacion = codRecuperacion;
            this.registroHaSidoCorrecto = false;
        }

        public void comprobarPasswords() {
            if (password.Equals(confPassword)) {
                this.registroHaSidoCorrecto = true;
            }
        }

        public bool getEstadoRegistro() { return this.registroHaSidoCorrecto; }
    }
}

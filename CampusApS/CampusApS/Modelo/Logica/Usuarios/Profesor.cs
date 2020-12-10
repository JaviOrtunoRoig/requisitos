using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS.Modelo.Logica.Usuarios {
    class Profesor : Usuario {

        private const string rol = "profesor";

        private string nombre;
        private Permisos permisos;

        public Profesor(string nombre) {
            permisos = new Permisos(true, true, true, true, true, true, false, false);
            this.nombre = nombre;
        }


        public void crearCurso() {
            if (!this.permisos.getPuedeCrearCurso()) {
                MessageBox.Show("No tienes permisos para realizar esta acción.");
            }
        }

        public void borrarCurso() {
            if (!this.permisos.getPuedeBorrarCurso()) {
                MessageBox.Show("No tienes permisos para realizar esta acción.");
            }
        }

        public void crearForo() {
            if (!this.permisos.getPuedeCrearForo()) {
                MessageBox.Show("No tienes permisos para realizar esta acción.");
            }
        }

        public void borrarForo() {
            if (!this.permisos.getPuedeBorrarForo()) {
                MessageBox.Show("No tienes permisos para realizar esta acción.");
            }
        }

        public void crearActividadSocial() {
            if (!this.permisos.getPuedeCrearActividadSocial()) {
                MessageBox.Show("No tienes permisos para realizar esta acción.");
            }
        }

        public void borrarActividadSocial() {
            if (!this.permisos.getPuedeBorrarActividadSocial()) {
                MessageBox.Show("No tienes permisos para realizar esta acción.");
            }
        }

        public Permisos getPermisos() {
            return this.permisos;
        }

        public string getRol() {
            return Profesor.rol;
        }

        public string getNombre() {
            return this.nombre;
        }
    }
}

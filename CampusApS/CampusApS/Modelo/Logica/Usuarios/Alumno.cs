using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS.Modelo.Logica {
    class Alumno : Usuario {

        private const string rol = "alumno";

        private Permisos permisos;

        public Alumno() {
            this.permisos = new Permisos(false, false, false, false, false, false);
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
            return Alumno.rol;
        }
    }
}

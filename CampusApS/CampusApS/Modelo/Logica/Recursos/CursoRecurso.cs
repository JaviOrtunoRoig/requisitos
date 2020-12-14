using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Logica.Recursos {
    public class CursoRecurso {

        private string nombre;
        private string descripcion;

        public CursoRecurso(string nombre) {
            this.nombre = nombre;
        }

        public CursoRecurso(string nombre, string descripcion) {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string getNombre() {
            return this.nombre;
        }

        public string getdescripcion() {
            return this.descripcion;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }

        public void setDescripcion(string descripcion) {
            this.descripcion = descripcion;
        }
    }
}

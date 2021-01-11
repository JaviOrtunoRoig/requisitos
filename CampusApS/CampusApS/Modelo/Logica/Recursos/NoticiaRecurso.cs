using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Logica.Recursos
{
    class NoticiaRecurso
    {
        private string nombre;
        private string contenido;

        public NoticiaRecurso(string nombre) {
            this.nombre = nombre;
        }

        public NoticiaRecurso(string nombre, string contenido) {
            this.nombre = nombre;
            this.contenido = contenido;
        }

        public string getNombre() {
            return this.nombre;
        }

        public string getContenido() {
            return this.contenido;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }

        public void setContenido(string contenido) {
            this.contenido = contenido;
        }



    }
}

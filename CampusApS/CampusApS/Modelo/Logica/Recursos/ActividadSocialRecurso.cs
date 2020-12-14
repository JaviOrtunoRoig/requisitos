using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Logica.Recursos
{
    public class ActividadSocialRecurso
    {
        private string nombre;
        private string descripcion;

        public ActividadSocialRecurso(string nombre)
        {
            this.nombre = nombre;
        }

        public ActividadSocialRecurso(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getdescripcion()
        {
            return this.descripcion;
        }

        public void setDescripcion(string descripcion) {
            this.descripcion = descripcion;
        }
    }
}

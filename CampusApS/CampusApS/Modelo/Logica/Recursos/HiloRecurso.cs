using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Logica.Recursos
{

    public class HiloRecurso
    {

        string titulo;
        string cuerpo;

        public HiloRecurso(string titulo)
        {
            this.titulo = titulo;
        }

        public HiloRecurso(string titulo, string cuerpo)
        {
            this.titulo = titulo;
            this.cuerpo = cuerpo;
        }


        public string getNombre()
        {
            return this.titulo;
        }

        public string getMensaje()
        {
            return this.cuerpo;
        }

        public void setNombre(string nombre)
        {
            this.titulo = nombre;
        }

        public void setMensaje(string msj)
        {
            this.cuerpo = msj;
        }
    }
}

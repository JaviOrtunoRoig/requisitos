using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Logica.Recursos
{
    class Test
    {
        private string nombre;
        private Pregunta [] preguntas;


        public Test(string nombre, Pregunta [] preguntas)
        {
            this.nombre = nombre;
            this.preguntas = preguntas;
        }

        private string getNombre()
        {
            return nombre;
        }

        private Pregunta [] getPreguntas()
        {
            return preguntas;
        }

    }
}

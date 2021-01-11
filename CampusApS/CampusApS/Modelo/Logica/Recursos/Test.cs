using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Logica.Recursos
{
    public class Test
    {
        private string nombre;
        private List<Pregunta> preguntas;


        public Test(string nombre, List<Pregunta> preguntas)
        {
            this.nombre = nombre;
            this.preguntas = preguntas;
        }

        public string getNombre()
        {
            return nombre;
        }

        public List<Pregunta> getPreguntas()
        {
            return preguntas;
        }

    }
}

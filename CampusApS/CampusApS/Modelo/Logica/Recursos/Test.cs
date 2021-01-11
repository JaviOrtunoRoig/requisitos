using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Logica.Recursos
{
    public class Test
    {
        private string nombreTest, nombreCurso;
        private List<Pregunta> preguntas;


        public Test(string nombreTest, string nombreCurso, List<Pregunta> preguntas)
        {
            this.nombreTest = nombreTest;
            this.nombreCurso = nombreCurso;
            this.preguntas = preguntas;
        }

        public string getNombreTest()
        {
            return nombreTest;
        }

        public string getNombreCurso()
        {
            return nombreCurso;
        }

        public List<Pregunta> getPreguntas()
        {
            return preguntas;
        }

    }
}

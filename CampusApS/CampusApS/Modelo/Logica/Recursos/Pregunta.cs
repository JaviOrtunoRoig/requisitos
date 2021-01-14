using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Logica.Recursos
{
    public class Pregunta
    {
        private string nombrePregunta, opcionA, opcionB, opcionC, opcionCorrecta;

        public Pregunta(string nombrePregunta, string opcionA, string opcionB, string opcionC, string opcionCorrecta)
        {
            this.nombrePregunta = nombrePregunta;
            this.opcionA = opcionA;
            this.opcionB = opcionB;
            this.opcionC = opcionC;
            this.opcionCorrecta = opcionCorrecta;
        }

        public string getNombre()
        {
            return nombrePregunta;
        }

        public string getOpcionA()
        {
            return opcionA;
        }
        public string getOpcionB()
        {
            return opcionB;
        }
        public string getOpcionC()
        {
            return opcionC;
        }
        public string getOpcionCorrecta()
        {
            return opcionCorrecta;
        }


        public override string ToString()
        {
            return this.nombrePregunta;
        }
    
    }
}

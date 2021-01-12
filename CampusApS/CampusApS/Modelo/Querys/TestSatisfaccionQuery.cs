using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;
using MySql.Data.MySqlClient;

namespace CampusApS.Modelo.Querys
{
    class TestSatisfaccionQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";

        private List<String> testSatisfaccion;
        private string profesor;

        public TestSatisfaccionQuery(string nomProf)
        {
            profesor = nomProf;
            testSatisfaccion = new List<string>();
            testSatisfaccion.Add("Las respuesta de este test se realizan de forma anónima, es decir, en la base de datos no se " +
                "guardan vuestros nombres, tan solo sus respuestas, recordad que las puntuaciones van del 1 al 5. Gracias");

            testSatisfaccion.Add("¿Le parece interesante este grupo para la formación del Aprendiza-Servicio?");
            testSatisfaccion.Add("¿Este grupo alterna tanto en la teoría como en la práctica?");
            testSatisfaccion.Add("¿El encargado de este grupo emplea todo el material del que dispone?");
            testSatisfaccion.Add("¿Le recomendarías a alguna persona entrar a esta aplicación?");
            testSatisfaccion.Add("¿Piensas que su formación sobre el Aprendiza-Servicio ha aumentado al entrar en este grupo?");
            testSatisfaccion.Add("¿Se han llevado a acorde las clases onlines con las presenciales?");
            testSatisfaccion.Add("¿Los trabajos que se han mandado están acorde con la formación del Aprendizaje-Servicio?");
            testSatisfaccion.Add("¿El encargado de este grupo ha otorgado todo tipo de archivo para facilitar el propósito de esta aplicación?");

        }

        public void insertarResultado(int [] res)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO `apsgrupo06`.`testSatisfaccion` (`encargado`, `pregunta1`, `pregunta2`, " +
                "`pregunta3`, `pregunta4`, `pregunta5`, `pregunta6`, `pregunta7`, `pregunta8`) VALUES ('" +
                profesor + "', '" + res[0] + "', '" + res[1] + "', '" + res[2] + "', '" + res[3] + "', '" + 
                res[4] + "', '" + res[5] + "', '" + res[6] + "', '" + res[7] + "');");
        }

        public List<string> getTestSatisfaccion()
        {
            return testSatisfaccion;
        }
    }
}

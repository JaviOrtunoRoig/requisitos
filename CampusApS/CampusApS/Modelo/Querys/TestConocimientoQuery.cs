using CampusApS.Modelo.Logica.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;
using MySql.Data.MySqlClient;

namespace CampusApS.Modelo.Querys
{
    class TestConocimientoQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";

        private Test test;

        public TestConocimientoQuery(Test test, string nomCurso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            this.test = test;

            StringBuilder sb = new StringBuilder("");

            foreach(Pregunta p in test.getPreguntas()){
                sb.Append("', '" + p.getNombre());
            }


            miBD.Insert("INSERT INTO `apsgrupo06`.`testSatisfaccion` (`nombreTest`, `curso`, `pregunta1`, `pregunta2`, " +
                "`pregunta3`, `pregunta4`, `pregunta5`, `pregunta6`, `pregunta7`, `pregunta8`, " +
                "`pregunta9`, `pregunta10`, `pregunta11`, `pregunta12`, `pregunta13`, `pregunta14`, " +
                "`pregunta15`, `pregunta16`, `pregunta17`, `pregunta18`, `pregunta19`, `pregunta20`) VALUES('" + test.getNombre() + 
                "', '" + nomCurso + sb.ToString() + "')");

        }
    }
}

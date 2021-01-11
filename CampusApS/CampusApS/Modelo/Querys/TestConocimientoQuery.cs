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
                "`pregunta3`, `pregunta4`, `pregunta5`) VALUES('" + test.getNombreTest() + "', '" + nomCurso + sb.ToString() + "')");

        }
    }
}

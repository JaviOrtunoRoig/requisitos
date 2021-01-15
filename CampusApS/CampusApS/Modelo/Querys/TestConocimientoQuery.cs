using CampusApS.Modelo.Logica.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CampusApS.Modelo.Querys
{
    class TestConocimientoQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";


        public TestConocimientoQuery()
        {

        }

        public void insertarTest(Test test, string nomCurso, string fecha)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            string nombreTest = test.getNombreTest();

            List<Pregunta> preguntas = test.getPreguntas();

            miBD.Insert("INSERT INTO `apsgrupo06`.`testConocimiento` (`nombreTest`, `curso`, `pregunta1`, `pregunta2`, " +
           "`pregunta3`, `pregunta4`, `pregunta5`, `fechaCreacion`) VALUES('" + nombreTest + "', '" + nomCurso.ToString() + "', '" + preguntas[0] + "', '" + preguntas[1] + "', '" + preguntas[2] + "', '" + preguntas[3] + "', '" + preguntas[4] + "', '" + fecha + "');");

            StringBuilder sb = new StringBuilder("");

            foreach(Pregunta p in test.getPreguntas()){
                sb.Append("', '" + p.getNombre());

                StringBuilder aux = new StringBuilder("");
                aux.Append("', '" + p.getOpcionA());
                aux.Append("', '" + p.getOpcionB());
                aux.Append("', '" + p.getOpcionC());
                aux.Append("', '" + p.getOpcionCorrecta());

                miBD.Insert("INSERT INTO `apsgrupo06`.`preguntas` (`nombreTest`, `pregunta`, `opcionA`, `opcionB`, " +
                "`opcionC`, `opcionCorrecta`) VALUES('" + nombreTest + "', '" + p.getNombre() + aux.ToString() + "')");
            }

           
        }

        public List<String> getAllTests(string nombreCurso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreTest, fechaCreacion FROM testConocimiento WHERE curso = '" + nombreCurso + "';");

            List<String> list = new List<String>();

            if (tupla[0] != null)
            {

                int cont = 0;
                bool stop = false;

                while (!stop && cont < tupla.Length)
                {
                    string fecha = (string)((object[])(tupla[cont]))[1];

                    DateTime d1 = DateTime.Now;
                    DateTime d2 = DateTime.Parse(fecha);

                    if (tupla[cont] != null && (d1 - d2).Days >= 0)
                    {
                        string nombre = (string)((object[])(tupla[cont]))[0];

                        if (nombre != null)
                        {
                            list.Add(nombre);
                            cont++;
                        }
                        else
                        {
                            stop = true;
                        }
                    }
                    else
                    {
                        stop = true;
                    }

                }
            }

            return list;
        }


        public Test getTestConocimiento(string nombreTest)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM testConocimiento WHERE nombreTest = '" + nombreTest + "';");
            List<Pregunta> lista = new List<Pregunta>();

            if (tupla[0] != null)
            {
                string nombre = nombreTest;
                string curso = (string)((object[])(tupla[0]))[1];

                for(int i = 2; i < 7; i++){
                    object[] aux = miBD.Select("SELECT * FROM preguntas WHERE nombreTest = '" + nombreTest + "' AND pregunta = '" +
                    (string)((object[])(tupla[0]))[i] + "' ;");

                    Pregunta p = new Pregunta((string)((object[])(aux[0]))[1], (string)((object[])(aux[0]))[2], (string)((object[])(aux[0]))[3], (string)((object[])(aux[0]))[4], (string)((object[])(aux[0]))[5]);
                    lista.Add(p);
                }

                return new Test(nombreTest, curso, lista);

            } else {
                MessageBox.Show("Este test no existe");
                return null;
            } 
        }

        public Double getPuntuacion(string [] respuestas, string nombreTest)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            Test test = getTestConocimiento(nombreTest);
            int cont = 0;
            Double sol = 0;

            foreach(Pregunta p in test.getPreguntas()){

                if (respuestas[cont].Equals(p.getOpcionCorrecta()))
                {
                    sol++;
                }

                cont++;
            }

            return sol * 2;
        }
    }
}

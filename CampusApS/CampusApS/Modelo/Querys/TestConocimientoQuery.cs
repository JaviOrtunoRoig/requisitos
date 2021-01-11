﻿using CampusApS.Modelo.Logica.Recursos;
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

        public void insertarTest(Test test, string nomCurso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            string nombreTest = test.getNombreTest();

            StringBuilder sb = new StringBuilder("");

            foreach(Pregunta p in test.getPreguntas()){
                sb.Append("', '" + p.getNombre());

                StringBuilder aux = new StringBuilder("");
                aux.Append("', '" + p.getOpcionA());
                aux.Append("', '" + p.getOpcionB());
                aux.Append("', '" + p.getOpcionC());
                aux.Append("', '" + p.getOpcionCorrecta());

                miBD.Insert("INSERT INTO `apsgrupo06`.`testConocimiento` (`nombreTest`, `pregunta`, `opcionA`, `opcionB`, " +
                "`opcionC`, `opcionCorrecta`) VALUES('" + nombreTest + "', '" + p.getNombre() + aux.ToString() + "')");
            }

            miBD.Insert("INSERT INTO `apsgrupo06`.`testSatisfaccion` (`nombreTest`, `curso`, `pregunta1`, `pregunta2`, " +
            "`pregunta3`, `pregunta4`, `pregunta5`) VALUES('" + nombreTest + "', '" + nomCurso + sb.ToString() + "')");
        }

        public List<String> getAllTests(string nombreCurso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreTest FROM testConocimiento WHERE curso = '" + nombreCurso + "';");

            List<String> list = new List<String>();

            if (tupla[0] != null)
            {

                int cont = 0;
                bool stop = false;

                while (!stop && cont < tupla.Length)
                {

                    if (tupla[cont] != null)
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
                string curso = (string) tupla[1];

                for(int i = 2; i < 7; i++){
                    object[] aux = miBD.Select("SELECT * FROM pregunta WHERE nombreTest = '" + nombreTest + "' AND pregunta = '" + 
                    (string) tupla[i] + "' ;");

                    Pregunta p = new Pregunta((string) aux[1], (string) aux[2], (string) aux[3], (string) aux[4], (string) aux[5]);
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
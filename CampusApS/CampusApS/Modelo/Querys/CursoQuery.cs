﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using CampusApS.Modelo.Logica.Usuarios;

namespace CampusApS.Modelo.Querys
{
    class CursoQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";

        public CursoQuery()
        {

        }

        private bool permitirCurso(string nom)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM curso WHERE nombreCurso = '" + nom + "';");

            return tupla[0] == null;
        }

        public void insertarCurso(string nombreCurso, string nombreUsuario, string des, string fecha)
        {
            if (permitirCurso(nombreCurso))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);
                miBD.Insert("INSERT INTO `apsgrupo06`.`curso` (`nombreCurso`, `usuario`, `descripcion`, `fechaCreacion`) VALUES ('" +
                nombreCurso + "', '" + nombreUsuario + "', '" + des + "', '" + fecha + "');");

            }
            else
            {
                MessageBox.Show("Nombre de curso ya escogido");
            }
        }

        public void borrarCurso(string nombreCurso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] participantes = miBD.Select("SELECT * FROM usuario_curso WHERE nombreCurso = '" + nombreCurso + "';");

            if (participantes[0] != null)
            {
                miBD.Delete("DELETE FROM `apsgrupo06`.`usuario_curso` WHERE (nombreCurso = '" + nombreCurso + "');");
            }

            object[] foros = miBD.Select("SELECT * FROM foro_curso WHERE nombreCurso = '" + nombreCurso + "';");

            if (foros[0] != null)
            {
                miBD.Delete("DELETE FROM `apsgrupo06`.`foro_curso` WHERE (nombreCurso = '" + nombreCurso + "');");
            }

            miBD.Delete("DELETE FROM `apsgrupo06`.`curso` WHERE (nombreCurso = '" + nombreCurso + "');");

        }

        public List<String> getCursosCreador(string usuario)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreCurso FROM curso WHERE usuario = '" + usuario + "';");

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

        public List<String> getAllCursos()
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreCurso, fechaCreacion FROM curso ;");

            List<String> list = new List<String>();

            if (tupla[0] != null)
            {

                int cont = 0;
                bool stop = false;

                while (!stop && cont < tupla.Length)
                {

                    if (tupla[cont] != null)
                    {


                        string fecha = (string)((object[])(tupla[cont]))[1];

                        DateTime d1 = DateTime.Now;
                        DateTime d2 = DateTime.Parse(fecha);

                        if ((d1 - d2).Days >= 0)
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
                       

                    }
                    else
                    {
                        stop = true;
                    }
                }


            }
            return list;
        }


        public void inscribirseCurso(string nombreUsuario, string nombreCurso)
        {
            if (noInscrito(nombreUsuario, nombreCurso))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);

                miBD.Insert("INSERT INTO `apsgrupo06`.`usuario_curso` (`nombreCurso`, `nombreUsuario`) VALUES ('" +
                nombreCurso + "', '" + nombreUsuario + "');");

                MessageBox.Show("Te has inscrito con éxito!");

            }
            else
            {
                MessageBox.Show("Este usuario ya está inscrito en el curso");
            }
        }


        public String getDescripcionCurso(string curso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT descripcion FROM curso WHERE nombreCurso = '" + curso + "';");
            string nombre = ""; 

            if (tupla[0] != null)
            {
                nombre = (string)((object[])(tupla[0]))[0];
            }
            else
            {
                MessageBox.Show("Curso no disponible");
            }

            return nombre;
        }

        private bool noInscrito(string nombreUsuario, string nombreCurso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM usuario_curso WHERE nombreCurso = '" + nombreCurso + "' and nombreUsuario = '" + nombreUsuario + "';");

            return tupla[0] == null;
        }

        public List<String> misCursos(string nomUs)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM `apsgrupo06`.`usuario_curso` WHERE nombreUsuario = '" + nomUs + "';");

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

        public List<String> getUsuariosCurso(string nomCurso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreUsuario FROM `apsgrupo06`.`usuario_curso` WHERE nombreCurso = '" + nomCurso + "';");

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

        public void borrarUsuarioCurso(string nomUs, string nomCurso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM `apsgrupo06`.`usuario_curso` WHERE (nombreUsuario = '" + nomUs + "' AND nombreCurso = '"+ nomCurso + "');");
        }

        public string getProfesor(string curso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT usuario FROM curso WHERE nombreCurso = '" + curso + "';");
            string nombre = "";

            if (tupla[0] != null)
            {
                nombre = (string)((object[])(tupla[0]))[0];
            }
            else
            {
                MessageBox.Show("Curso no disponible");
            }

            return nombre;
        }
       
    }
}

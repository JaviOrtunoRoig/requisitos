using System;
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

        public void insertarCurso(string nombreCurso, string nombreUsuario, string des)
        {
            if (permitirCurso(nombreCurso))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);
                miBD.Insert("INSERT INTO `apsgrupo06`.`curso` (`nombreCurso`, `usuario`, `descripcion`) VALUES ('" +
                nombreCurso + "', '" + nombreUsuario + "', '" + des + "');");

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

            object[] tupla = miBD.Select("SELECT nombreCurso FROM curso ;");

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


        public void inscribirseCurso(string nombreUsuario, string nombreCurso)
        {
            if (noInscrito(nombreUsuario, nombreCurso))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);

                miBD.Insert("INSERT INTO `apsgrupo06`.`usuario_curso` (`nombreCurso`, `nombreUsuario`) VALUES ('" +
                nombreCurso + "', '" + nombreUsuario + "');");

            }
            else
            {
                MessageBox.Show("Este usuario ya está inscrito en el curso");
            }
        }

        public List<String> getAllDescripcionCursos()
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT descripcion FROM curso ;");

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

        public String getDescripcionCursosCreador(string curso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT descripcion FROM curso WHERE nombreCurso = '" + curso + "';");
            string nombre = null;

            if (tupla[0] != null)
            {
                    nombre = (string)((object[])(tupla[0]))[0];
            } else {
                MessageBox.Show("Curso no encontrado");
            }

            return nombre;
        }

        private bool noInscrito(string nombreUsuario, string nombreCurso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM usuario_curso WHERE nombreCurso = '" + nombreCurso + "' and nombreUsuario = '" + nombreUsuario + "';");

            return tupla[0] == null;
        }
    }
}

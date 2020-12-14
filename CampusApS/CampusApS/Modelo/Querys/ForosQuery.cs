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
    class ForosQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";

        public ForosQuery()
        {

        }

        private bool permitirForo(string nom)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM foro WHERE nombreForo = '" + nom + "';");

            return tupla[0] == null;
        }

        public void insertarForoGeneral(string nomF, string nomU, string des){
            if(permitirForo(nomF))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);

                miBD.Insert("INSERT INTO `apsgrupo06`.`foro` (`nombreForo`, `usuario`, `general`, `descripcion`) VALUES ('" 
                    + nomF + "', '" + nomU + "', b'1', '" + des + "');");
            }
            else
            {
                MessageBox.Show("Nombre de foro ya escogido");
            }
        }

        public void insertarForoCurso(string nomF, string nomU, string nomC, string des)
        {
            if (permitirForo(nomF))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);

                miBD.Insert("INSERT INTO `apsgrupo06`.`foro` (`nombreForo`, `usuario`, `general`, `descripcion`) VALUES ('"
                + nomF + "', '" + nomU + "', b'0', '" + des + "');");

                miBD.Insert("INSERT INTO `apsgrupo06`.`foro_curso` (`nombreForo`, `nombreCurso`) VALUES ('" + nomF + "', '" + nomC + "');");
            }
            else
            {
                MessageBox.Show("Nombre de foro ya escogido");
            }

        }

        public void borrarForoGeneral(string nom)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM `apsgrupo06`.`foro` WHERE (nombreForo = '" + nom + "');");
        }

        public void borrarForoCurso(string nom)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM `apsgrupo06`.`foro_curso` WHERE (nombreForo = '" + nom + "');");

            miBD.Delete("DELETE FROM `apsgrupo06`.`foro` WHERE (nombreForo = '" + nom + "');");
        }

        public List<String> getAllForoGeneral()
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreForo FROM foro WHERE general = b'1';");

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

        public List<String> getCreadorForoGeneral(string nomUs)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreForo FROM foro WHERE usuario = '" + nomUs + "' AND general = b'1';");

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

        public List<String> getForoCurso(string nomCur)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreForo FROM foro_curso WHERE nombreCurso = '" + nomCur + "';");

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

        public String getDescripcionForo(string foro)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT descripcion FROM foro WHERE nombreForo = '" + foro + "';");
            string nombre = "";

            if (tupla[0] != null)
            {
                nombre = (string)((object[])(tupla[0]))[0];
            }
            else
            {
                MessageBox.Show("Foro no disponible");
            }

            return nombre;
        }

        public List<String> getCreadorForoCurso(string nomCur, string us) {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreForo FROM foro_curso WHERE nombreCurso = '" + nomCur + "';");

            List<String> list = new List<String>();

            if (tupla[0] != null) {

                int cont = 0;
                bool stop = false;

                while (!stop && cont < tupla.Length) {

                    if (tupla[cont] != null) {
                        string nombre = (string)((object[])(tupla[cont]))[0];

                        if (nombre != null) {
                            object[] aux = miBD.Select("SELECT nombreForo FROM foro WHERE nombreForo = '"
                                + nombre + "' AND usuario = '" + us + "';");

                            string nom = (string)((object[])(aux[0]))[0];
                            list.Add(nom);
                            cont++;
                        } else {
                            stop = true;
                        }
                    } else {
                        stop = true;
                    }

                }
            }

            return list;
        }
    }
}

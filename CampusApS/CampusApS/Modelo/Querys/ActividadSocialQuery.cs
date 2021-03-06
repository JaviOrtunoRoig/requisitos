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
    class ActividadSocialQuery
    {

        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";

        public ActividadSocialQuery()
        {

        }

        private bool permitirAS(string nom)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM actividadsocial WHERE nombreAS = '" + nom + "';");

            return tupla[0] == null;
        }

        public void borrarAS(string nombreAS)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            miBD.Delete("DELETE FROM `apsgrupo06`.`actividadsocial` WHERE (nombreAS = '" + nombreAS + "');");

        }

        public void insertarAS(string nombreAS, string nombreUsuario, string des, string fecha)
        {
            if (permitirAS(nombreAS))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);
                miBD.Insert("INSERT INTO `apsgrupo06`.`actividadsocial` (`nombreAS`, `usuario`, `descripcion`, `fechaCreacion`) VALUES ('" +
                nombreAS + "', '" + nombreUsuario + "', '" + des + "', '" + fecha + "');");

            }
            else
            {
                MessageBox.Show("Nombre de actividad social ya escogido");
            }
        }

        public List<String> getASCreador(string usuario)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreAS FROM actividadsocial WHERE usuario = '" + usuario + "';");

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

        public List<String> getAllAS()
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreAS, fechaCreacion FROM actividadsocial;");

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

        public String getDescripcionAS(string AS)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT descripcion FROM actividadsocial WHERE nombreAS = '" + AS + "';");
            string nombre = "";

            if (tupla[0] != null)
            {
                nombre = (string)((object[])(tupla[0]))[0];
            }
            else
            {
                MessageBox.Show("Actividad Social no disponible");
            }

            return nombre;
        }

        public List<String> misAS(string nomUs)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreAS FROM usuario_actividadsocial WHERE nombreUsuario = '" + nomUs + "';");

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

    }
}

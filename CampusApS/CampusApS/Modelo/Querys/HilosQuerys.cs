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
    class HilosQuerys
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";

        public HilosQuerys()
        {

        }

        public void insertarHilos(string titulo, string usuario, string texto, string foro)
        {

            BD miBD = new BD(BD_SERVER, BD_NAME);


            miBD.Insert("INSERT INTO `apsgrupo06`.`hilo` (`titulo`, `mensaje`, `creador`) VALUES " +
           "('" + titulo + "', '" + texto + "', '" + usuario + "');");

            miBD.Insert("INSERT INTO `apsgrupo06`.`foroHilo` (`nombreForo`, `nombreHilo`) VALUES ('" + foro + "', '" + titulo + "');");

            
        }

        private string getRespuesta(int id)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT mensaje FROM mensaje WHERE idm = " + id + ";");

            if (tupla[0] != null)
            {
                string respuesta = (string)((object[])(tupla[0]))[0];
                return respuesta;

            }
            else
            {
                MessageBox.Show("Este hilo no existe");
                return null;
            }
        }

        public string getMensaje(string titulo)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT mensaje FROM hilo WHERE titulo = '" + titulo + "';");

            if (tupla[0] != null)
            {
                return (string)((object[])(tupla[0]))[0];
            }
            else
            {
                MessageBox.Show("Este hilo no existe");
                return null;
            }
        }

        public void responderHilo(string usuario, string titulo, string respuesta, string creadorHilo)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            miBD.Insert("INSERT INTO `apsgrupo06`.`mensaje` (`usuarioEmisor`, `usuarioReceptor`, `mensaje`) VALUES " +
            "('" + usuario + "', '" + creadorHilo + "', '" + respuesta + "');");

            object[] tupla = miBD.Select("SELECT MAX(idm) AS id FROM mensaje");
            int id = (int)((object[])(tupla[0]))[0];
                

            miBD.Insert("INSERT INTO `apsgrupo06`.`hilo_mensajes` (`nombreHilo`, `mensaje`) VALUES ('" + titulo + "', '" + id + "');");


        }

        public List<String> getHilosForo(string nombreForo)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreHilo FROM foroHilo WHERE nombreForo = '" + nombreForo + "';");
            List<String> list = new List<String>();

            if (tupla[0] != null)
            {

                int cont = 0;
                bool stop = false;

                while (!stop && cont < tupla.Length)
                {

                    if (tupla[cont] != null)
                    {
                        string hilo = (string)((object[])(tupla[cont]))[0];

                        if (hilo != null)
                        {
                            list.Add(hilo);
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

        public List<String> getMensajesHilo(string tituloHilo)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT mensaje FROM hilo_mensajes WHERE nombreHilo = '" + tituloHilo + "';");
            List<String> list = new List<String>();

            if (tupla[0] != null)
            {

                int cont = 0;
                bool stop = false;

                while (!stop && cont < tupla.Length)
                {

                    if (tupla[cont] != null)
                    {
                        int id = (int)((object[])(tupla[cont]))[0];
                        string mensaje = getRespuesta(id);

                        if (mensaje != null)
                        {
                            list.Add(mensaje);
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

        public string getCreador(string titulo){
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT creador FROM hilo WHERE titulo = '" + titulo + "';");

            if (tupla[0] != null)
            {
                return (string)((object[])(tupla[0]))[0];
            }
            else
            {
                MessageBox.Show("Este hilo no existe");
                return null;
            }
        }
        
    }
}

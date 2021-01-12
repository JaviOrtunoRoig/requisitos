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
            miBD.Insert("INSERT INTO `apsgrupo06`.`hilo_mensajes` (`nombreHilo`, `mensaje`) VALUES ('" + titulo + "', '" + texto + "');");

            miBD.Insert("INSERT INTO `apsgrupo06`.`foro_hilo` (`nombreForo, `nombreHilo`) VALUES ('" + foro + "', '" + titulo + "');");

            miBD.Insert("INSERT INTO `apsgrupo06`.`mensaje` (`usuarioEmisor`, `mensaje`) VALUES ('" + usuario + "', '" + texto + "');");
            
        }

        public string getMensaje(string titulo)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT mensaje FROM hilo_mensaje WHERE nombreHilo = " + titulo + ";");

            if (tupla[0] != null)
            {
                return (string)tupla[0];
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

            miBD.Insert("INSERT INTO `apsgrupo06`.`hilo_mensajes` (`nombreHilo`, `mensaje`) VALUES ('" + titulo + "', '" + respuesta + "');");

            miBD.Insert("INSERT INTO `apsgrupo06`.`mensaje` (`usuarioEmisor`, `usuarioReceptor`, `mensaje`) VALUES " +
            "('" + usuario + "', '" + creadorHilo + "', '" + respuesta + "');");
        }

        public List<String> getHilosForo(string nombreForo)
        {
            //buscar en BD foros_hilos;
        }

        public List<String> getMensajes(string tituloHilo)
        {
            //buscar en BD hilos_mensajes;
        }
        
    }
}

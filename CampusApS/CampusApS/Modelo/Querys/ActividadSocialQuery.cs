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

        public void insertarAS(string nombreAS, string nombreUsuario)
        {
            if (permitirAS(nombreAS))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);
                miBD.Insert("INSERT INTO `apsgrupo06`.`actividadsocial` (`nombreAS`, `usuario`) VALUES ('" +
                nombreAS + "', '" + nombreUsuario + "');");

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
    }
}

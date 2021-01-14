using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;
using MySql.Data.MySqlClient;

namespace CampusApS.Modelo.Querys
{
    class MensajeQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";

        public MensajeQuery()
        {

        }

        public List<String> getUsuariosEmisores(string nomRe)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT usuarioEmisor FROM mensaje WHERE usuarioReceptor = '" + nomRe + "' AND pertenecerHilo = b'0';");

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

                        if (nombre != null && !list.Contains(nombre))
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

        public void setMensaje(string nombreEm, string nombreRe, string men)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO `apsgrupo06`.`mensaje` (`usuarioEmisor`, `usuarioReceptor`, `mensaje`, `pertenecerHilo`) VALUES ('" +
                nombreEm + "', '" + nombreRe + "', '" + men + "', b'0');");
        }

        public List<String> getMensaje(string nomEm, string nomRe)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT mensaje FROM mensaje WHERE usuarioEmisor = '" + nomEm + "' AND pertenecerHilo = b'0' AND usuarioReceptor = '" + nomRe + "';");

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

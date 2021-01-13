using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Querys
{


    class CalendarioQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";


        public CalendarioQuery()
        {

        }

        public List<String> getCursosFecha(string fecha)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT nombreCurso FROM curso WHERE fechaCreacion = '" + fecha + "';");

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

        public List<String> getNoticiasFecha(string fecha)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT tituloNoticia FROM noticia WHERE fechaCreacion = '" + fecha + "';");

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

        public List<String> getActividadSocialFecha(string fecha)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT nombreAS FROM actividadsocial WHERE fechaCreacion = '" + fecha + "';");

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

        public List<String> getTestConocimientoFecha(string fecha)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT nombreTest FROM testConocimiento WHERE fechaCreacion = '" + fecha + "';");

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

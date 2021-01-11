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
    class NoticiaQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";

        private string nombre;
        private string contenido;

        public NoticiaQuery(string nom, string cont)
        {
            nombre = nom;
            contenido = cont;

            BD miBD = new BD(BD_SERVER, BD_NAME);

            miBD.Insert("INSERT INTO `apsgrupo06`.`noticia` (`tituloNoticia`, `contenidoNoticia`) VALUES ('" +
                nombre + "', '" + contenido + "');");

        }

        public NoticiaQuery(string nom)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT contenidoNoticia FROM noticia WHERE tituloNoticia = '" + nom + "';");

            if (tupla[0] != null)
            {
                contenido = (string) tupla[0];
                nombre = nom;
            }
            else
            {
                MessageBox.Show("Esta noticia no existe");
            }
        }

        public string getContenido(){
            return contenido;
        }

        public string getTitulo(){
            return nombre;
        }

        public void borrarNoticia(string nom){
            BD miBD = new BD(BD_SERVER, BD_NAME);

            miBD.Delete("DELETE FROM `apsgrupo06`.`noticia` WHERE (nombreTitulo = '" + nom + "');");
            nombre = null;
            contenido = null;
        }

        public List<String> getAllNoticas()
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT tituloNoticia FROM noticia");

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CampusApS.Modelo.Querys
{
    class BD
    {

        private string servidor; //Nombre o ip del servidor de MySQL
        private string bd; //Nombre de la base de datos
        private string usuario = "grupo06"; //Usuario de acceso a MySQL
        private string password = "arjonaramet2021"; //Contraseña de usuario de acceso a MySQL
        MySqlConnection conexionBD;
        MySqlDataReader reader;


        public BD(string servidor, string bd)
        {
            this.servidor = servidor;
            this.bd = bd;

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            conexionBD = new MySqlConnection(cadenaConexion);
            reader = null;

        }

        public object [] Select(string consulta)
        {
            
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                object[] datos = new object[10];
                object[] resultado = new object[50];
                int cont = 0;
                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos = new object[10];
                    reader.GetValues(datos); //Almacena cada registro con un salto de linea
                    resultado[cont] = datos;
                    cont++;
                }

                conexionBD.Close();

                return resultado;
            
        }


        public void Insert(string consulta)
        {

            MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
            comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand

            conexionBD.Open();

            comando.ExecuteReader();
       

        }
 






    }
}

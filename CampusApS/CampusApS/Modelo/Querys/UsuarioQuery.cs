using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;
using MySql.Data.MySqlClient;

namespace CampusApS.Modelo.Querys
{
    class UsuarioQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "Campus ApS"; 

        private string username;
        private string password;
        private string email;
        private string rol;

        public UsuarioQuery(string nomb, string contr, string correo, Usuario us, string cod, string reg, string expd){
            Console.WriteLine("aquí llega 1");
            if(permitirNombre(nomb))
            {
                Console.WriteLine("aquí llega 1.5 okmakey");
                if(us.getRol().Equals("administrador")){
                    registrarAdmin(nomb, contr, correo, cod, us.getRol());
                    Console.WriteLine("aquí llega 2");
                }
            
                if(us.getRol().Equals("ong")){
                    registrarONG(nomb, contr, correo, reg);
                }

                if(us.getRol().Equals("profesor")){
                    registrarProf(nomb, contr, correo, expd);
                }

                if(us.getRol().Equals("alumno")){
                    registrarAlum(nomb, contr, correo);
                }
            }
       }

        public void registrarAdmin(string nomb, string contr, string correo, string cod, string nomRol){
            BD miBD = new BD(BD_SERVER, BD_NAME);

            string[] tupla = miBD.Select("SELECT * FROM codadmin WHERE codigo LIKE " + cod + ";");

            Console.WriteLine("aquí llega 3");

            if(tupla.Length == 1){
                miBD.Select("INSERT INTO `grupo06_mysql`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`) VALUES (" + 
                nomb + ", " + contr + ", " + correo + ", " + nomRol +");");
                Console.WriteLine("aquí llega 4");
            }
            else
            {
                Console.WriteLine("Este codigo no es valido");
            }

        }

        public void registrarProf(string nomb, string contr, string correo, string expd){
            
        }

        public void registrarONG(string nomb, string contr, string correo, string reg){
            
        }

        public void registrarAlum(string nomb, string contr, string correo){
            
        }


        public bool permitirNombre(string nom){
            BD miBD = new BD(BD_SERVER, BD_NAME);

            string[] tupla  = miBD.Select("SELECT * FROM usuario WHERE nombre = '" + nom + "';");

            return tupla.Length == 0;
        }



    }
}

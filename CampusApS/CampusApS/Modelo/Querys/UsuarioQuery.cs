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
        private static string BD_NAME = "apsgrupo06"; 

        public UsuarioQuery()
        {

        }

        public void registrarAdmin(string nomb, string contr, string correo, string cod, Usuario us){
            if (permitirNombre(nomb))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);

                object[] tupla = miBD.Select("SELECT * FROM codadmin WHERE codigo = " + cod + ";");

                if (tupla[0] != null)
                {
                   
                    miBD.Insert("INSERT INTO `apsgrupo06`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`) VALUES ('" +
                    nomb + "', '" + contr + "', '" + correo + "', '" + us.getRol() + "');");
                }
                else
                {
                    Console.WriteLine("Este codigo no es valido");
                }
            }
            else
            {
                Console.WriteLine("Este nombre no es valido");
            }
        }

        public void registrarProf(string nomb, string contr, string correo, string expd, Usuario us){
            if (permitirNombre(nomb))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);

                object[] tupla = miBD.Select("SELECT * FROM facmedicina WHERE nExp = '" + expd + "';");

                if (tupla[0] != null)
                {
                    miBD.Insert("INSERT INTO `apsgrupo06`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`) VALUES ('" +
                    nomb + "', '" + contr + "', '" + correo + "', '" + us.getRol() + "');");
                }
                else
                {
                    Console.WriteLine("Este codigo no es valido");
                }
            }
            else
            {
                Console.WriteLine("Este nombre no es valido");
            }
        }

        public void registrarONG(string nomb, string contr, string correo, string reg, Usuario us){
            if (permitirNombre(nomb))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);

                object[] tupla = miBD.Select("SELECT * FROM ong WHERE nRegistro = '" + reg + "';");

                if (tupla[0] != null)
                {
                    miBD.Insert("INSERT INTO `apsgrupo06`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`) VALUES ('" +
                    nomb + "', '" + contr + "', '" + correo + "', '" + us.getRol() + "');");
                }
                else
                {
                    Console.WriteLine("Este codigo no es valido");
                }
            }
            else
            {
                Console.WriteLine("Este nombre no es valido");
            }
        }
     

        public void registrarAlum(string nomb, string contr, string correo, Usuario us){
            if (permitirNombre(nomb))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);
                miBD.Insert("INSERT INTO `apsgrupo06`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`) VALUES ('" +
                nomb + "', '" + contr + "', '" + correo + "', '" + us.getRol() + "');");
                
            } else 
            {
                Console.WriteLine("Ese nombre no es valido");
            }
        }

        public bool permitirNombre(string nom){
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object [] tupla  = miBD.Select("SELECT * FROM usuario WHERE nombre = '" + nom + "';");

            return tupla[0] == null;
        }

        public bool iniciarSesion(string correo, string contr)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT * FROM usuario WHERE correo = '" + correo + "' AND contraseña = '" + contr + "';");

            return tupla[0] != null;
        }
    }
}

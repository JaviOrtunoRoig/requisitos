using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace CampusApS.Modelo.Querys
{
    class UsuarioQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";

        private string username;
        private string password;
        private string email;
        private string rol;

        public UsuarioQuery(string nomb, string contr, string correo, Usuario us, string cod, string reg, string expd){
        
            if(permitirNombre(nomb))
            {
                if(us.Nombre.Equals("administrador")){
                    registrarAdmin(nomb, contr, correo, cod, "admin");
                }
            
                if(r.Nombre.Equals("ONG")){
                    registrarONG(nomb, contr, correo, reg);
                }

                if(r.Nombre.Equals("profesor")){
                    registrarProf(nomb, contr, correo, expd);
                }

                if(r.Nombre.Equals("estudiante")){
                    registrarEstud(nomb, contr, correo);
                }
            }
       }

        public void registrarAdmin(string nomb, string contr, string correo, string cod, string nomRol){
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM codadmin WHERE codigo LIKE " + cod + ";")[0];

            if(tupla.Length == 1){
                miBD.Select("INSERT INTO `grupo06_mysql`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`) VALUES (" + 
                nomb + ", " + contr + ", " + correo + ", " + nomRol +");");
            }

        }

        public void registrarProf(string nomb, string contr, string correo, string expd){
            
        }

        public void registrarONG(string nomb, string contr, string correo, string reg){
            
        }

        public void registrarEstud(string nomb, string contr, string correo){
            
        }


        public bool permitirNombre(string nom){
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM usuario WHERE nombre LIKE " + nom + ";")[0];

            return tupla.Length == 0;
        }



    }
}

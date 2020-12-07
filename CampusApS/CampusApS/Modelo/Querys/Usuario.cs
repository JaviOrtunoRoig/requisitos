using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Usuario
    {
        private static string BD_SERVER = "localhost";
        private static string BD_NAME = "grupo06_mysql";

        private string username;
        private string password;
        private string email;
        private Rol rol;

        public Usuario(string nomb, string contr, string contr2, string correo, Rol r){
        
            if(PermitirNombre(nomb))
            {
                

                if(r.Nombre.Equals("admin")){
                    registrarAdmin(nomb, contr, correo, cod, "admin");
                }
            
                if(r.Nombre.Equals("ONG")){
                    registrarONG(nomb, contr, contr2, correo, reg);
                }

                if(r.Nombre.Equals("profesor")){
                    registrarProf(nomb, contr, contr2, correo, expd);
                }

                if(r.Nombre.Equals("estudiante")){
                    registrarEstud(nomb, contr, contr2, correo);
                }
            }

            
                

       }

        public registrarAdmin(string nomb, string contr, string correo, string cod, string nomRol){
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            object[] tupla = miBD.select("SELECT * FROM codadmin WHERE codigo LIKE " + cod + ";");

            if(tupla.Length == 1){
                miBD.select("INSERT INTO `grupo06_mysql`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`) VALUES (" + 
                nomb + ", " + contr + ", " + correo + ", " + nomRol +");")
            }

        }

        public registrarProf(string nomb, string contr, string contr2, string correo, string expd){
            
        }

        public registrarONG(string nomb, string contr, string contr2, string correo, string reg){
            
        }

        public registrarEstud(string nomb, string contr, string contr2, string correo){
            
        }


        public boolean permitirNombre(string nom){
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM usuario WHERE nombre LIKE " + nom + ";");

            return tupla.Length == 0;
        }



    }
}

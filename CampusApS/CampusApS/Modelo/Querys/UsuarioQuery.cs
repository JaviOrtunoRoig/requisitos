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
    class UsuarioQuery
    {
        private static string BD_SERVER = "ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private static string BD_NAME = "apsgrupo06";

        public UsuarioQuery()
        {

        }

        #region MétodosRegistro

        public void registrarAdmin(string nomb, string contr, string correo, string cod, Usuario us)
        {
            if (permitirNombre(nomb))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);

                object[] tupla = miBD.Select("SELECT * FROM codadmin WHERE codigo = " + cod + ";");

                if (tupla[0] != null)
                {

                    miBD.Insert("INSERT INTO `apsgrupo06`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`, `permiso`) VALUES ('" +
                    nomb + "', '" + contr + "', '" + correo + "', '" + us.getRol() + "', '" + cod + "');");
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

        public void registrarProf(string nomb, string contr, string correo, string expd, Usuario us)
        {
            if (permitirNombre(nomb))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);

                object[] tupla = miBD.Select("SELECT * FROM facmedicina WHERE nExp = '" + expd + "';");

                if (tupla[0] != null)
                {
                    miBD.Insert("INSERT INTO `apsgrupo06`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`, `permiso`) VALUES ('" +
                    nomb + "', '" + contr + "', '" + correo + "', '" + us.getRol() + "', '" + expd + "');");
                }
                else
                {
                    Console.WriteLine("Este numero de expediente no es valido");
                }
            }
            else
            {
                Console.WriteLine("Este nombre no es valido");
            }
        }

        public void registrarONG(string nomb, string contr, string correo, string reg, Usuario us)
        {
            if (permitirNombre(nomb))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);

                object[] tupla = miBD.Select("SELECT * FROM ong WHERE nRegistro = '" + reg + "';");

                if (tupla[0] != null)
                {
                    miBD.Insert("INSERT INTO `apsgrupo06`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`, `permiso`) VALUES ('" +
                    nomb + "', '" + contr + "', '" + correo + "', '" + us.getRol() + "', '" + reg + "');");
                }
                else
                {
                    Console.WriteLine("Este numero de registro no es valido");
                }
            }
            else
            {
                Console.WriteLine("Este nombre no es valido");
            }
        }


        public void registrarAlum(string nomb, string contr, string correo, Usuario us)
        {
            if (permitirNombre(nomb))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);
                miBD.Insert("INSERT INTO `apsgrupo06`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`) VALUES ('" +
                nomb + "', '" + contr + "', '" + correo + "', '" + us.getRol() + "');");

            }
            else
            {
                Console.WriteLine("Ese nombre no es valido");
            }
        }

       

        public bool permitirNombre(string nom)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM usuario WHERE nombre = '" + nom + "';");

            return tupla[0] == null;
        }


        #endregion MétodosRegistro

        #region IniciarSesion

        public bool iniciarSesion(string nom, string contr)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT * FROM usuario WHERE nombre = '" + nom + "' AND contraseña = '" + contr + "';");

            object[] tupla2 = miBD.Select("SELECT contraseña FROM usuario WHERE nombre = '" + nom + "';");

            if(tupla2[0] != null)
            {
                string contraseña = (string)((object[])(tupla2[0]))[0];

                return tupla[0] != null && contraseña.Equals(contr);
            }
            else
            {
                return false;
            }

        }

        #endregion IniciarSesion
            
        #region DarseDeBaja

            public bool existeContraseña(string contr)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM usuario WHERE contraseña = '" + contr + "';");

            return tupla[0] != null;
        }

        public bool darseBaja(string nom, string contr)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            bool res = false;

            if (!permitirNombre(nom) && existeContraseña(contr))
            {
                miBD.Delete("DELETE FROM `apsgrupo06`.`usuario_curso` WHERE (nombreUsuario = '" + nom + "');");

                miBD.Delete("DELETE FROM `apsgrupo06`.`usuario` WHERE (nombre = '" + nom + "' AND contraseña = '" + contr + "');");
                res = true;
            }
            else if (permitirNombre(nom))
            {
                MessageBox.Show("El nombre es incorrecto");

            } else if(!existeContraseña(contr)) {

                MessageBox.Show("La contraseña es incorrecta");
            }

            return res;
        }

        #endregion DarseDeBaja

   

        #region CodigoAdmin

        public void codigoAdmin()
        {
            StringBuilder sb = new StringBuilder("");
            Random rnd = new Random();
            BD miBD = new BD(BD_SERVER, BD_NAME);

            for (int i = 0; i <= 3; i++)
            {
                int n = rnd.Next(10);
                sb.Append(n);
            }
            object[] tupla = miBD.Select("SELECT * FROM codadmin WHERE codigo = " + sb.ToString() + ";");

            if (tupla[0] != null)
            {
                codigoAdmin();
            }
            else
            {
                miBD.Insert("INSERT INTO `apsgrupo06`.`codadmin` (`codigo`) VALUES (" + sb.ToString() + ");");
                MessageBox.Show("El codigo es: " + sb.ToString());
            }

        }

        #endregion CodigoAdmin

        #region RecuperarConstraseña

        public void recuperarContrasena(string nomb){

            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT contraseña FROM usuario WHERE nombre = " + nomb + ";");

            if (tupla[0] != null)
            {
                MessageBox.Show("Se ha enviado un correo con la contraseña");
                //return (string)tupla[0];
            }
            else
            {
                MessageBox.Show("Este usuario no existe, por favor compruebe de nuevo el nombre del usuario");
            }
        }

        #endregion RecuperarContraseña

        #region OtrosMetodos

        public void updateNombreUsuario(string nom, string newNom)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);
            miBD.Update("UPDATE apsgrupo06.usuario SET nombre = '" + newNom + "' " +
            "WHERE (nombre = '" + nom + "');");
        }

        public string getUsuario(string nomb)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT rol FROM usuario WHERE nombre = '" + nomb + "';");

            if (tupla[0] != null)
            {
                return (string)((object[])(tupla[0]))[0];
            }
            else
            {
                MessageBox.Show("Este usuario no existe, por favor compruebe de nuevo");
                return null;
            }

        }

        public List<String> getAllUsuarios()
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombre FROM usuario;");

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

        public string getPermiso(string nomUs)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT permiso FROM usuario WHERE nombre = '" + nomUs + "';");
            string permiso = "";

            if (tupla[0] != null)
            {
                permiso = (string)((object[])(tupla[0]))[0];
            }
            else
            {
                MessageBox.Show("Este usuario no existe");
            }

            return permiso;
        }

        #endregion OtrosMetodos


    }
}
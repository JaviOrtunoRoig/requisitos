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

        public void registrarProf(string nomb, string contr, string correo, string expd, Usuario us)
        {
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
                    miBD.Insert("INSERT INTO `apsgrupo06`.`usuario` (`nombre`, `contraseña`, `correo`, `rol`) VALUES ('" +
                    nomb + "', '" + contr + "', '" + correo + "', '" + us.getRol() + "');");
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

        #region Cursos

        public bool permitirCurso(string nom)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT * FROM curso WHERE nombreCurso = '" + nom + "';");

            return tupla[0] == null;
        }

        public void insertarCurso(string nombreCurso, string nombreUsuario)
        {
            if (permitirCurso(nombreCurso))
            {
                BD miBD = new BD(BD_SERVER, BD_NAME);
                miBD.Insert("INSERT INTO `apsgrupo06`.`curso` (`nombreCurso`, `usuario`) VALUES ('" +
                nombreCurso + "', '" + nombreUsuario + "');");

            }
            else
            {
                MessageBox.Show("Nombre de curso ya escogido");
            }
        }

        public void borrarCurso(string nombreCurso)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            miBD.Delete("DELETE FROM `apsgrupo06`.`curso` WHERE (nombreCurso = '" + nombreCurso + "');");
            
        }

        public List<String> getCursos(string usuario)
        {
            BD miBD = new BD(BD_SERVER, BD_NAME);

            object[] tupla = miBD.Select("SELECT nombreCurso FROM curso WHERE usuario = '" + usuario + "';");

            List<String> list = new List<String>();

            if (tupla[0] != null)
            {

                int cont = 0;
                bool stop = false;

                while (!stop && cont < tupla.Length)
                {


                    string nombre = (string)((object[])(tupla[0]))[cont];

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
            }

            return list;
        }

        #endregion Cursos

        #region ActividadesSociales

        public bool permitirAS(string nom)
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

        public List<String> getAS(string usuario)
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


                    string nombre = (string)((object[])(tupla[0]))[cont];

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
            }

            return list;
        }

        #endregion ActividadesSociales

        #region CodigoAdmin

        public void codigoAdmin()
        {
            StringBuilder sb = null;
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

        #endregion OtrosMetodos


    }
}
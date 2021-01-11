using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS.Vistas.Apartados {
    public partial class CrearNoticia : Form {

        private Usuario usuario;

        public CrearNoticia(Usuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            string titulo = tBoxTitulo.Text;

            string contenido = tBoxContenido.Text;

            if(titulo.Equals(""))
            {
                MessageBox.Show("Error, no ha introducido ningún título");
            }
            else if(contenido.Equals(""))
            {
                MessageBox.Show("Error, no ha introducido ningún contenido");
            }
            else
            {
                NoticiaQuery BD = new NoticiaQuery(titulo, contenido);

                this.Close();
            }
        }

    }
}

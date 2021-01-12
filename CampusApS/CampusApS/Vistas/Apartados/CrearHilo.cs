using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusApS.Modelo.Querys;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Logica.Recursos;

namespace CampusApS.Vistas.Apartados {
    public partial class CrearHilo : Form {

        Usuario usuario;
        ForoRecurso foro;

        public CrearHilo() {
            InitializeComponent();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            string titulo = this.textBox1.Text;
            string cuerpo = this.textBox2.Text;

            if(titulo!=null && cuerpo!=null)
            {
                HilosQuerys bd = new HilosQuerys();
                bd.insertarHilos(titulo, usuario.getNombre(), cuerpo, foro.getNombre());
                this.Close();

            }


        }
    }
}

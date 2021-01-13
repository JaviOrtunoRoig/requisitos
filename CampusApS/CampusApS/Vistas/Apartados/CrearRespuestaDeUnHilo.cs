using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Modelo.Logica.Recursos;

namespace CampusApS.Vistas.Apartados {
    public partial class CrearRespuestaDeUnHilo : Form {

        HiloRecurso hilo;
        Usuario usuario;

        public CrearRespuestaDeUnHilo(Usuario usuario, HiloRecurso hiloRecursos) {
            InitializeComponent();
            this.usuario = usuario;
            this.hilo = hiloRecursos;
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = textBox2.Text;
            
            if (mensaje != null)
            {
                HilosQuerys bd = new HilosQuerys();
                bd.responderHilo(usuario.getNombre(), hilo.getNombre(), mensaje, bd.getCreador(hilo.getNombre()));
                this.Close();
            }
            
        }

        private void CrearRespuestaDeUnHilo_Load(object sender, EventArgs e)
        {

        }
    }
}

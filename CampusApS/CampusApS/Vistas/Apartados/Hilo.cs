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
using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;

namespace CampusApS.Vistas.Apartados {
    public partial class Hilo : Form {

        ForoRecurso foro;
        HiloRecurso hilo;
        Usuario usuario;

        public Hilo(ForoRecurso foro, HiloRecurso hilo, Usuario usuario)
        {
            InitializeComponent();
            this.foro = foro;
            this.hilo = hilo;
            this.usuario = usuario;
        }
      

        private void Hilo_Load(object sender, EventArgs e)
        {
            HilosQuerys bd = new HilosQuerys();
            lRespuestas.DataSource = bd.getMensajes(hilo.getNombre());
            this.ltitulo.Text = hilo.getNombre();
            this.textBox1.Text = hilo.getMensaje();
        }

        private void lRespuestas_DoubleClick(object sender, EventArgs e)
        {
            VerRespuestaHilo ventana = new VerRespuestaHilo((string) lRespuestas.SelectedItem);
            ventana.ShowDialog();
            this.Close();
        }

        private void bResponder_Click(object sender, EventArgs e)
        {
            CrearRespuestaDeUnHilo ventana = new CrearRespuestaDeUnHilo(usuario, hilo);
            ventana.ShowDialog();

            Hilo ventanaRecargada = new Hilo(foro, hilo, usuario);
            ventanaRecargada.ShowDialog();
        }
    }
}


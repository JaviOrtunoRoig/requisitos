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

namespace CampusApS.Vistas.Apartados {
    public partial class Hilo : Form {

        ForoRecurso foro;

        public Hilo(ForoRecurso foro) {
            InitializeComponent();
            this.foro = foro;
            
        }

        private void Hilo_Load(object sender, EventArgs e)
        {
            HilosQuerys bd = new HilosQuerys();
            lRespuestas.DataSource = bd.getMensajes(foro.getNombre());
            this.ltitulo.Text = foro.getNombre();
        }

        private void lRespuestas_DoubleClick(object sender, EventArgs e)
        {
            VerRespuestaHilo ventana = new VerRespuestaHilo((string) lRespuestas.SelectedItem);
            ventana.ShowDialog();
            this.Close();
        }
    }
}

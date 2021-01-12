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
        HiloRecurso hilo;

        public Hilo(ForoRecurso foro, HiloRecurso hilo)
        {
            InitializeComponent();
            this.foro = foro;
            this.hilo = hilo;
        }
      

        private void Hilo_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            HilosQuerys bd = new HilosQuerys();
            lRespuestas.DataSource = bd.getMensajes(hilo.getNombre());
            this.ltitulo.Text = hilo.getNombre();
        }

        private void lRespuestas_DoubleClick(object sender, EventArgs e)
        {
            VerRespuestaHilo ventana = new VerRespuestaHilo((string) lRespuestas.SelectedItem);
            ventana.ShowDialog();
            this.Close();
        }
    }
}


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

namespace CampusApS.Vistas.Apartados {

    public partial class VerEventos : Form {

        private string fecha;
        private List<String> listaCursos;
        private List<String> listaNoticias;
        private List<String> listaAS;
        private List<String> listaTests;
         


        public VerEventos(string fecha) {
            InitializeComponent();
            this.fecha = fecha;
        }

        private void VerEventos_Load(object sender, EventArgs e)
        {
            CalendarioQuery bd = new CalendarioQuery();
            listBox1.DataSource = bd.getCursosFecha(fecha);
            listBox2.DataSource = bd.getActividadSocialFecha(fecha);
            listBox3.DataSource = bd.getNoticiasFecha(fecha);
            listBox4.DataSource = bd.getTestConocimientoFecha(fecha);
            lTitulo.Text = "Eventos programados para: " + fecha;
        }
    }
}

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

    private string fecha; 

    public partial class VerEventos : Form {
        public VerEventos(string fecha) {
            InitializeComponent();
            this.fecha = fecha;
        }

        private void VerEventos_Load(object sender, EventArgs e)
        {
            CalendarioQuery bd = new CalendarioQuery();
            listBox1.DataSource = // Query para los eventos 
            lTitulo.Text = 
        }
    }
}

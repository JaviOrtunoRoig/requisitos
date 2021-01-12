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
    public partial class CrearHilo : Form {
        public CrearHilo() {
            InitializeComponent();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            string titulo = this.textBox1.Text;
            string cuerpo = this.textBox2.Text;

            if(titulo!=null)
            {
                // TODO: INSERT HILO EN LA BD  [ anadirHilo(string foro) ]
                // this.Close();
            }


        }
    }
}

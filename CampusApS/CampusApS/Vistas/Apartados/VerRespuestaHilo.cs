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
    public partial class VerRespuestaHilo : Form {

        string mensaje;

        public VerRespuestaHilo(string mensaje) {
            InitializeComponent();
            this.mensaje = mensaje;
        }

        private void VerRespuestaHilo_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            this.textBox1.Text = mensaje;
        }
    }
}

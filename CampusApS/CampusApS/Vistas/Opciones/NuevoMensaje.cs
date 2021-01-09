using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusApS.Vistas.Opciones {
    public partial class NuevoMensaje : Form {
        public NuevoMensaje() {
            InitializeComponent();
        }

        private void bEnviar_MouseHover(object sender, EventArgs e) {
            bEnviar.ForeColor = Color.White;
            bEnviar.BackColor = Color.Black;
            bEnviar.FlatAppearance.BorderColor = Color.White;
        }

        private void bEnviar_MouseLeave(object sender, EventArgs e) {
            bEnviar.ForeColor = Color.Black;
            bEnviar.BackColor = Color.White;
            bEnviar.FlatAppearance.BorderColor = Color.Black;
        }
    }
}

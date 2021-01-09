using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
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

        private Usuario usuarioEmisor;

        public NuevoMensaje(Usuario usuario) {
            InitializeComponent();
            this.usuarioEmisor = usuario;
        }

        private void NuevoMensaje_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            UsuarioQuery BD = new UsuarioQuery();

            cUsuarios.DataSource = BD.getAllUsuarios();
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

        private void bEnviar_Click(object sender, EventArgs e)
        {
            MensajeQuery BD = new MensajeQuery();
            BD.setMensaje(usuarioEmisor.getNombre(), (string)cUsuarios.SelectedItem, tMensaje.Text);
        }

        
    }
}

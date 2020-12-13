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

namespace CampusApS.Vistas {
    public partial class ConfirmarPassword : Form {

        Usuario usuario;

        public ConfirmarPassword(Usuario user) {
            InitializeComponent();
            usuario = user;
        }

        private void bAceptar_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("¿Estas seguro?", "Aviso", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                UsuarioQuery bd = new UsuarioQuery();
                bd.darseBaja(usuario.getNombre(), tPassword.Text);
            }
        }
    }
}

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
    public partial class CambiarNombre : Form {

        private Usuario usuario;

        public CambiarNombre(Usuario usuario) {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void CambiarNombre_Load(object sender, EventArgs e)
        {
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            UsuarioQuery BD = new UsuarioQuery();
            BD.updateNombreUsuario(usuario.getNombre(), tNuevoNombre.Text);

            this.Close();

        }
    }
}

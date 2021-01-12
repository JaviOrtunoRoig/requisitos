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
    public partial class EliminarUsuario : Form {
        public EliminarUsuario() {
            InitializeComponent();
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            UsuarioQuery BD = new UsuarioQuery();

            cUsuarios.DataSource = BD.getAllUsuarios();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            string usuario =  (string) cUsuarios.SelectedItem;

            if (usuario != null)
            {
                var result = MessageBox.Show("¿Estas seguro?", "Aviso", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    UsuarioQuery bd = new UsuarioQuery();
                    bd.borrarUsuario(usuario);
                    this.Close();
                }
                
            }
        }

       
    }
}

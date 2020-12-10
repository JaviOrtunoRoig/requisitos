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

namespace CampusApS
{
    public partial class PantallaNoticias : Form
    {

        Usuario usuario;

        public PantallaNoticias(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void bDarse_Click(object sender, EventArgs e) {
            //TODO: Terminar de implmentar el darse de baja cuando este la vista
            UsuarioQuery bd = new UsuarioQuery();
            //bd.darseBaja(usuario.getNombre(), "1");
        }
    }
}

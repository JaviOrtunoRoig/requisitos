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
    public partial class PantallaRecuperarContrasena : Form
    {
        public PantallaRecuperarContrasena()
        {
            InitializeComponent();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = tNombre.Text;
            UsuarioQuery bd = new UsuarioQuery();
            bd.recuperarContrasena(nombre);
        }
    }
}

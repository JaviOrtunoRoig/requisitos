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


namespace CampusApS.Vistas.CreacionRecursos
{
    public partial class CrearActividadSocial : Form
    {
        Usuario usuario;

        public CrearActividadSocial(Usuario user)
        {    
            InitializeComponent();
            this.usuario = user;
        }

        private void bConfirmar_Click_1(object sender, EventArgs e)
        {
            ActividadSocialQuery BD = new ActividadSocialQuery();
            BD.insertarAS(tNombreActSocial.Text, usuario.getNombre(), tDescActSocial.Text);
            this.Close();
        }

        private void CrearActividadSocial_Load(object sender, EventArgs e) {
        }
    }
}

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
    public partial class CrearCurso : Form {

        Usuario usuario;

        public CrearCurso(Usuario user) {
            InitializeComponent();
            this.usuario = user;
        }

        private void bConfirmar_Click(object sender, EventArgs e) {
            CursoQuery BD= new CursoQuery();
            BD.insertarCurso(tNombreCurso.Text, usuario.getNombre());
            this.Close();
        }
    }
}

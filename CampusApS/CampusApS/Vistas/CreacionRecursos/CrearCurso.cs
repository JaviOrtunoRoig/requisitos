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
            CursoQuery BD = new CursoQuery();
            string fecha = dateTimePicker1.Value.ToString();
            BD.insertarCurso(tNombreCurso.Text, usuario.getNombre(), tDescripcion.Text, fecha);
            this.Close();
        }

        private void CrearCurso_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
        }
    }
}

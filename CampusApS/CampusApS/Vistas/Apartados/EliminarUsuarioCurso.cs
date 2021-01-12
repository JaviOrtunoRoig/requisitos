using CampusApS.Modelo.Logica.Recursos;
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

namespace CampusApS.Vistas.Apartados {
    public partial class EliminarUsuarioCurso : Form {

        private Usuario usuario;
        private CursoRecurso cursoRecurso;

        public EliminarUsuarioCurso(Usuario usuario, CursoRecurso cursoRecurso) {
            InitializeComponent();
            this.usuario = usuario;
            this.cursoRecurso = cursoRecurso;
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            CursoQuery BD = new CursoQuery();
            BD.borrarUsuarioCurso((string)cUsuarios.SelectedItem, cursoRecurso.getNombre());
        }

        private void EliminarUsuarioCurso_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            CursoQuery BD = new CursoQuery();

            cUsuarios.DataSource = BD.getUsuariosCurso(cursoRecurso.getNombre());

        }
    }
}

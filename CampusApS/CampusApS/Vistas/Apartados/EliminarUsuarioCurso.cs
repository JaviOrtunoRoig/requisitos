using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
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
            //TODO : CREAR BD
            // TODO : ELIMINAR USUARIO DEL CURSO 
        }

        private void EliminarUsuarioCurso_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            // TODO: USUARIOS DE UN CURSO cUsuarios.DataSource = getUsuariosCurso(cursoRecurso.getNombre());
        }
    }
}

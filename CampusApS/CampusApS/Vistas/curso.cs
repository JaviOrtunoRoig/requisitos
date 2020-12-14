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

namespace CampusApS.Vistas {
    public partial class Curso : Form {

        Usuario usuario;
        CursoRecurso cursoRecurso; 

        public Curso(Usuario user, CursoRecurso curRec) {
            InitializeComponent();
            this.usuario = user;
            this.cursoRecurso = curRec;
        }
    }
}

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

namespace CampusApS.Vistas.CreacionRecursos
{
    public partial class CrearForo : Form
    {

        Usuario usuario;
        CursoRecurso cursoRecurso;

        public CrearForo(Usuario user)
        {
            InitializeComponent();
            this.usuario = user;
        }

        public CrearForo(Usuario user, CursoRecurso curso) {
            InitializeComponent();
            this.usuario = user;
            this.cursoRecurso = curso;
        }

        private void bConfirmar_Click(object sender, EventArgs e) {

            if (this.cursoRecurso == null) {
                ForosQuery BD = new ForosQuery();
                BD.insertarForoGeneral(tTituloForo.Text, usuario.getNombre(), tDescForo.Text);
                this.Close();
            } else {
                ForosQuery BD = new ForosQuery();
                BD.insertarForoCurso(tTituloForo.Text, usuario.getNombre(), this.cursoRecurso.getNombre(), tDescForo.Text);
                this.Close();
            }
        }
    }
}

using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Vistas.Opciones;
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
    public partial class TestConocimientosCurso : Form, VistaGrande {

        private Usuario usuario;
        private CursoRecurso cursoRecurso;

        public TestConocimientosCurso(Usuario usuario, CursoRecurso cursoRecurso) {
            InitializeComponent();
            this.usuario = usuario;
            this.cursoRecurso = cursoRecurso;
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            CampusApS.Vistas.Opciones.Opciones ventana = new CampusApS.Vistas.Opciones.Opciones(usuario, this);
            ventana.ShowDialog();
        }

        private void TestConocimientosCurso_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            TestConocimientoQuery BD = new TestConocimientoQuery();
            lbTests.DataSource = BD.getAllTests(cursoRecurso.getNombre());

            if (usuario.getRol().Equals("alumno")) bAnadirTest.Visible = false;
        }

        private void bAnadirTest_Click(object sender, EventArgs e)
        {
            CrearTestConocimiento ventana = new CrearTestConocimiento(cursoRecurso);
            ventana.ShowDialog();
            TestConocimientoQuery BD = new TestConocimientoQuery();
            lbTests.DataSource = BD.getAllTests(cursoRecurso.getNombre());
        }

        private void lbTests_DoubleClick(object sender, EventArgs e)
        {
            TestConocimientoQuery BD = new TestConocimientoQuery();
            Test test = BD.getTestConocimiento((string)lbTests.SelectedItem);

            RealizarTestConocimiento ventana = new RealizarTestConocimiento(usuario, test);
            ventana.ShowDialog();

        }

        private void bNoticias_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaNoticias ventana = new PantallaNoticias(usuario);
            ventana.ShowDialog();
        }

        private void bForos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaForos ventana = new PantallaForos(usuario);
            ventana.ShowDialog();
        }

        private void bActSociales_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaActividadesSociales ventana = new PantallaActividadesSociales(usuario);
            ventana.ShowDialog();
        }

        private void bCursos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaCursos ventana = new PantallaCursos(usuario);
            ventana.ShowDialog();
        }

        private void calendario_DateSelected(object sender, EventArgs e)
        {
            VerEventos ventana = new VerEventos(calendario.SelectionStart.ToString().Substring(0, 10));
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        public void cerrar() {
            this.Close();
        }
    }
}

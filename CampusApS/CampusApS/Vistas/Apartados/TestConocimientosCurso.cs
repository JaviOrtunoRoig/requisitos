using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
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
    public partial class TestConocimientosCurso : Form {

        private Usuario usuario;
        private CursoRecurso cursoRecurso;

        public TestConocimientosCurso(Usuario usuario, CursoRecurso cursoRecurso) {
            InitializeComponent();
            this.usuario = usuario;
            this.cursoRecurso = cursoRecurso;
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            CampusApS.Vistas.Opciones.Opciones ventana = new CampusApS.Vistas.Opciones.Opciones(usuario);
            ventana.ShowDialog();
        }

        private void TestConocimientosCurso_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            //TODO: CREAR BD CursoQuery BD = new CursoQuery();
            //TODO: RECUPERAR TODOS LOS TESTSS lbTests.DataSource = BD.getAllTests();

            if (usuario.getRol().Equals("alumno")) bAnadirTest.Visible = false;
        }

        private void bAnadirTest_Click(object sender, EventArgs e)
        {
            CrearTestConocimiento ventana = new CrearTestConocimiento(cursoRecurso);
            ventana.ShowDialog();
            //TODO: CREAR BD CursoQuery BD = new CursoQuery();
            //TODO: RECUPERAR TODOS LOS TESTSS lbTests.DataSource = BD.getAllTests();
        }

        private void lbTests_DoubleClick(object sender, EventArgs e)
        {
            //TODO: Crear BD CursoQuery query = new CursoQuery();
            //TODO: Crear Test Test test = new test() (Query pedir test)
            //TODO: Pasar objeto test RealizarTestConocimiento ventana = new RealizarTestConocimiento(usuario, test);
            //TODO: Crear ventana ventana.ShowDialog();

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
    }
}

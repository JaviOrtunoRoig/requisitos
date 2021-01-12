using CampusApS.Modelo.Logica.Recursos;
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
    public partial class CrearTestConocimiento : Form {

        private CursoRecurso cursoRecurso;

        public CrearTestConocimiento(CursoRecurso cursoRecurso) {
            InitializeComponent();
            this.cursoRecurso = cursoRecurso;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {

            List<String> rCorrecta = obtenerRespuestasCorrectas();


            Pregunta pregunta1 = new Pregunta(tPregunta1.Text, tRespuesta1A.Text, tRespuesta1B.Text, tRespuesta1C.Text, rCorrecta[0]);
            Pregunta pregunta2 = new Pregunta(tPregunta2.Text, tRespuesta2A.Text, tRespuesta2B.Text, tRespuesta2C.Text, rCorrecta[1]);
            Pregunta pregunta3 = new Pregunta(tPregunta3.Text, tRespuesta3A.Text, tRespuesta3B.Text, tRespuesta3C.Text, rCorrecta[2]);
            Pregunta pregunta4 = new Pregunta(tPregunta4.Text, tRespuesta4A.Text, tRespuesta4B.Text, tRespuesta4C.Text, rCorrecta[3]);
            Pregunta pregunta5 = new Pregunta(tPregunta5.Text, tRespuesta5A.Text, tRespuesta5B.Text, tRespuesta5C.Text, rCorrecta[4]);

            List<Pregunta> preguntas = new List<Pregunta>();
           
            preguntas.Add(pregunta1);
            preguntas.Add(pregunta2);
            preguntas.Add(pregunta3);
            preguntas.Add(pregunta4);
            preguntas.Add(pregunta5);

            Test test = new Test(tNombreTest.Text, cursoRecurso.getNombre(), preguntas);



            TestConocimientoQuery BD = new TestConocimientoQuery();

            BD.insertarTest(test, cursoRecurso.getNombre());

            this.Close();
        }


        private List<String> obtenerRespuestasCorrectas()
        {
            List<String> respuestas = new List<String>();

            string opcion = (string) cSol1.SelectedItem;

            if(opcion.Equals("A"))
            {
                respuestas.Add(tRespuesta1A.Text);
            }
            else if (opcion.Equals("B"))
            {
                respuestas.Add(tRespuesta1B.Text);
            }
            else
            {
                respuestas.Add(tRespuesta1C.Text);
            }

            opcion = (string)cSol2.SelectedItem;

            if (opcion.Equals("A"))
            {
                respuestas.Add(tRespuesta2A.Text);
            }
            else if (opcion.Equals("B"))
            {
                respuestas.Add(tRespuesta2B.Text);
            }
            else
            {
                respuestas.Add(tRespuesta2C.Text);
            }

            opcion = (string)cSol3.SelectedItem;

            if (opcion.Equals("A"))
            {
                respuestas.Add(tRespuesta3A.Text);
            }
            else if (opcion.Equals("B"))
            {
                respuestas.Add(tRespuesta3B.Text);
            }
            else
            {
                respuestas.Add(tRespuesta3C.Text);
            }

            opcion = (string)cSol4.SelectedItem;

            if (opcion.Equals("A"))
            {
                respuestas.Add(tRespuesta4A.Text);
            }
            else if (opcion.Equals("B"))
            {
                respuestas.Add(tRespuesta4B.Text);
            }
            else
            {
                respuestas.Add(tRespuesta4C.Text);
            }

            opcion = (string)cSol5.SelectedItem;

            if (opcion.Equals("A"))
            {
                respuestas.Add(tRespuesta5A.Text);
            }
            else if (opcion.Equals("B"))
            {
                respuestas.Add(tRespuesta5B.Text);
            }
            else
            {
                respuestas.Add(tRespuesta5C.Text);
            }
            

            return respuestas;
        }

        private void CrearTestConocimiento_Load(object sender, EventArgs e)
        {

            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            List<String> Opciones1 = new List<String>();
            List<String> Opciones2 = new List<String>();
            List<String> Opciones3 = new List<String>();
            List<String> Opciones4 = new List<String>();
            List<String> Opciones5 = new List<String>();


            Opciones1.Add("A");
            Opciones1.Add("B");
            Opciones1.Add("C");

            Opciones2.Add("A");
            Opciones2.Add("B");
            Opciones2.Add("C");

            Opciones3.Add("A");
            Opciones3.Add("B");
            Opciones3.Add("C");

            Opciones4.Add("A");
            Opciones4.Add("B");
            Opciones4.Add("C");

            Opciones5.Add("A");
            Opciones5.Add("B");
            Opciones5.Add("C");

            cSol1.DataSource = Opciones1;
            cSol2.DataSource = Opciones2;
            cSol3.DataSource = Opciones3;
            cSol4.DataSource = Opciones4;
            cSol5.DataSource = Opciones5;
        }

    }
}

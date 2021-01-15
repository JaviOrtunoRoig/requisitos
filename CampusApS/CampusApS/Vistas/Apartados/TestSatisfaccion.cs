using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusApS.Modelo.Querys;
using CampusApS.Modelo.Logica.Recursos;

namespace CampusApS.Vistas.Apartados {
    public partial class TestSatisfaccion : Form
    {

        private CursoRecurso curso;

        public TestSatisfaccion(CursoRecurso curso)
        {
            InitializeComponent();
            this.curso = curso;
        }

        private void TestSatisfaccion_Load(object sender, EventArgs e)
        {

            CursoQuery bdCursos = new CursoQuery();
            string profesor = bdCursos.getProfesor(curso.getNombre());

            TestSatisfaccionQuery bd = new TestSatisfaccionQuery(profesor); 
            List<string> testSatisfaccion = bd.getTestSatisfaccion();

            label1.Text = testSatisfaccion.ElementAt(0);
            lPregunta1.Text = testSatisfaccion.ElementAt(1);
            lPregunta2.Text = testSatisfaccion.ElementAt(2);
            lPregunta3.Text = testSatisfaccion.ElementAt(3);
            lPregunta4.Text = testSatisfaccion.ElementAt(4);
            lPregunta5.Text = testSatisfaccion.ElementAt(5);
        }

        private void bEnviarTest_Click(object sender, EventArgs e)
        {

            int respuesta1 = int.Parse(checkedListBox1.SelectedItem.ToString());
            int respuesta2 = int.Parse(checkedListBox2.SelectedItem.ToString());
            int respuesta3 = int.Parse(checkedListBox3.SelectedItem.ToString());
            int respuesta4 = int.Parse(checkedListBox4.SelectedItem.ToString());
            int respuesta5 = int.Parse(checkedListBox5.SelectedItem.ToString());

            if (respuesta1!=null && respuesta2!=null && respuesta3!=null && respuesta4!=null && respuesta5!=null)
            {

                CursoQuery bdCursos = new CursoQuery();
                string profesor = bdCursos.getProfesor(curso.getNombre());

                TestSatisfaccionQuery bd = new TestSatisfaccionQuery(profesor);
                int[] respuestas = new int[6];
                respuestas[0] = respuesta1;
                respuestas[1] = respuesta2;
                respuestas[2] = respuesta3;
                respuestas[3] = respuesta4;
                respuestas[4] = respuesta5;

                bd.insertarResultado(respuestas); 

                MessageBox.Show("Test de Satisfacción enviado correctamente");
                this.Close();
                
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox2.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox2.SetItemChecked(ix, false);
        }

        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox3.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox3.SetItemChecked(ix, false);
        }

        private void checkedListBox4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox4.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox4.SetItemChecked(ix, false);
        }

        private void checkedListBox5_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox5.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox5.SetItemChecked(ix, false);
        }
    }
      
}

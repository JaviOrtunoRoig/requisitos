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

        public TestSatisfaccion()
        {
            InitializeComponent();
        }

        private void TestSatisfaccion_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            TestSatisfaccionQuery bd = new TestSatisfaccionQuery(profesor); // Falta Query que devuelva el profesor de un curso dado su titulo
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

            int respuesta1 = (int)checkedListBox1.SelectedItem;
            int respuesta2 = (int)checkedListBox2.SelectedItem;
            int respuesta3 = (int)checkedListBox3.SelectedItem;
            int respuesta4 = (int)checkedListBox4.SelectedItem;
            int respuesta5 = (int)checkedListBox5.SelectedItem;

            if (respuesta1!=null && respuesta2!=null && respuesta3!=null && respuesta4!=null && respuesta5!=null)
            {
                TestSatisfaccionQuery bd = new TestConocimientoQuery();
                bd.insertarResultado(profesor, respuesta1, respuesta2, respuesta3, respuesta4, respuesta5); // Cambiar el método SQL (solo hay 5 preguntas)

                MessageBox.Show("Test de Satisfacción enviado correctamente");
                this.Close();
                
            }
        }
    }
      
}

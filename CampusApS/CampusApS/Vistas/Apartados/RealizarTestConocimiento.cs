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
    public partial class RealizarTestConocimiento : Form {

        private Usuario usuario;
        private Test test;

        public RealizarTestConocimiento(Usuario usuario, Test test) {
            InitializeComponent();
            this.usuario = usuario;
            this.test = test;
        }

        private void RealizarTestConocimiento_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            tNombreTest.Text = test.getNombreTest();

            List<Pregunta> preguntas = test.getPreguntas();

            tPregunta1.Text = preguntas[0].getNombre();
            tPregunta2.Text = preguntas[1].getNombre();
            tPregunta3.Text = preguntas[2].getNombre();
            tPregunta4.Text = preguntas[3].getNombre();
            tPregunta5.Text = preguntas[4].getNombre();

            clPregunta1.Items.Add(preguntas[0].getOpcionA());
            clPregunta1.Items.Add(preguntas[0].getOpcionB());
            clPregunta1.Items.Add(preguntas[0].getOpcionC());

            clPregunta2.Items.Add(preguntas[1].getOpcionA());
            clPregunta2.Items.Add(preguntas[1].getOpcionB());
            clPregunta2.Items.Add(preguntas[1].getOpcionC());

            clPregunta3.Items.Add(preguntas[2].getOpcionA());
            clPregunta3.Items.Add(preguntas[2].getOpcionB());
            clPregunta3.Items.Add(preguntas[2].getOpcionC());

            clPregunta4.Items.Add(preguntas[3].getOpcionA());
            clPregunta4.Items.Add(preguntas[3].getOpcionB());
            clPregunta4.Items.Add(preguntas[3].getOpcionC());

            clPregunta5.Items.Add(preguntas[4].getOpcionA());
            clPregunta5.Items.Add(preguntas[4].getOpcionB());
            clPregunta5.Items.Add(preguntas[4].getOpcionC());


        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {

            String[] respuestas = new String[5];

            respuestas[0] = ((string)clPregunta1.SelectedItem);
            respuestas[1] = ((string)clPregunta2.SelectedItem);
            respuestas[2] = ((string)clPregunta3.SelectedItem);
            respuestas[3] = ((string)clPregunta4.SelectedItem);
            respuestas[4] = ((string)clPregunta5.SelectedItem);


            TestConocimientoQuery BD = new TestConocimientoQuery();

            double puntuacion = BD.getPuntuacion(respuestas, test.getNombreTest());

            MessageBox.Show("Puntuacion obtenida : " + puntuacion);

            this.Close();
        }

        private void clPregunta1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < clPregunta1.Items.Count; ++ix)
                if (ix != e.Index) clPregunta1.SetItemChecked(ix, false);
        }

        private void clPregunta2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < clPregunta2.Items.Count; ++ix)
                if (ix != e.Index) clPregunta2.SetItemChecked(ix, false);
        }

        private void clPregunta3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < clPregunta3.Items.Count; ++ix)
                if (ix != e.Index) clPregunta3.SetItemChecked(ix, false); 
        }

        private void clPregunta4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < clPregunta4.Items.Count; ++ix)
                if (ix != e.Index) clPregunta4.SetItemChecked(ix, false);
        }

        private void clPregunta5_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < clPregunta5.Items.Count; ++ix)
                if (ix != e.Index) clPregunta5.SetItemChecked(ix, false);
        }
   
    }
}

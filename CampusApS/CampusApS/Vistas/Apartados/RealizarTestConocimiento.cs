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

            tNombreTest.Text = test.getNombre();

            List<Pregunta> preguntas = test.getPreguntas();

            tPregunta1.Text = preguntas[0].getNombre();
            tPregunta2.Text = preguntas[1].getNombre();
            tPregunta3.Text = preguntas[2].getNombre();
            tPregunta4.Text = preguntas[3].getNombre();
            tPregunta5.Text = preguntas[4].getNombre();

            //TODO: RELLENAR CHECKLISTBOX


        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {

            //OBTENER RESPUESTAS

            //TODO: CREAR BD
            //TODO: CALCULO NOTA PASANDO RESPUESTAS Y MOSTRAR POR MESSAGE BOX

            this.Close();
        }
    }
}

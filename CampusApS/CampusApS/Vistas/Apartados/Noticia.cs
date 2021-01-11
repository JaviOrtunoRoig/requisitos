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
    public partial class Noticia : Form {

        private string titulo, contenido;

        public Noticia(string titulo, string contenido) {
            InitializeComponent();
            this.titulo = titulo;
            this.contenido = contenido;

            lTitulo.Text = titulo;
            tBoxContenido.Text = contenido;
        }

    }
}

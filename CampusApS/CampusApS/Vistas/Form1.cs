using CampusApS.Modelo.Logica;
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

namespace CampusApS {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            UsuarioQuery us = new UsuarioQuery("alex", "patata", "alexrametespinosa@uma.es", new Administrador(), "0000", null, null);

            Console.WriteLine("ortu es feo");
        }
    }
}

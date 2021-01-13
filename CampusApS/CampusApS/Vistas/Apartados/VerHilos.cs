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
    public partial class VerHilos : Form {
        public VerHilos() {
            InitializeComponent();
        }

        private void VerHilos_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
        }

        private void calendario_DateSelected(object sender, EventArgs e)
        {
            VerEventos ventana = new VerEventos(calendario.SelectionStart.ToString().Substring(0, 10));
            ventana.ShowDialog();
            this.Close();
        }
    }
}

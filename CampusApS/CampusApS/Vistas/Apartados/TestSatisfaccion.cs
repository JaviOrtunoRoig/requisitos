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

namespace CampusApS.Vistas.Apartados {
    public partial class TestSatisfaccion : Form
    {
        public TestSatisfaccion()
        {
            InitializeComponent();
        }

        private void TestSatisfaccion_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
        }
    }
      
}

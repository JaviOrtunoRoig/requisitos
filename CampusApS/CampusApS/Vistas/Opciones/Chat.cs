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

namespace CampusApS.Vistas.Opciones {
    public partial class Chat : Form {

        private Usuario usuario;

        public Chat(Usuario usuario) {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void bOpciones_Click(object sender, EventArgs e) {
            Opciones ventana = new Opciones(usuario);
            ventana.ShowDialog();

        }

        private void Chat_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            //TODO: Falta cambiar el numero de expediente, num ong, o lo q sea q vaya, depnde del tipo de usuario.
            this.carta.Text1 = this.usuario.getRol();
            this.carta.Text2 = this.usuario.getNombre();


            MensajeQuery BD = new MensajeQuery();
            //TODO: USUARIOS QUE ME HAN MANDADO UN MENSAJE lbUsuariosConMensajes.DataSource = BD.

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

        private void bCursos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaCursos ventana = new PantallaCursos(usuario);
            ventana.ShowDialog();
        }

        private void bActSociales_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            PantallaActividadesSociales ventana = new PantallaActividadesSociales(usuario);
            ventana.ShowDialog();
        }

        private void lbUsuariosConMensajes_DoubleClick(object sender, EventArgs e)
        {
            Mensajes ventana = new Mensajes(usuario, (string)lbUsuariosConMensajes.SelectedItem);
            this.Visible = false;
            ventana.ShowDialog();
            this.Close();
        }

        private void bRedMs_Click(object sender, EventArgs e)
        {
            NuevoMensaje ventana = new NuevoMensaje(usuario);
            ventana.ShowDialog();
        }

    
    }
}

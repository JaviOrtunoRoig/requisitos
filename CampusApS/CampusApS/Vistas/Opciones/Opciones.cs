using CampusApS.Modelo.Logica.Recursos;
using CampusApS.Modelo.Logica.Usuarios;
using CampusApS.Modelo.Querys;
using CampusApS.Vistas;
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
    public partial class Opciones : Form {

        private Usuario usuario;

        public Opciones(Usuario usuario) {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;

            if(usuario.getRol().Equals("administrador"))
            {
                this.bInvitarAdminitrador.Visible = true;
                this.bEliminarUsuario.Visible = true;
            }
            else
            {
                this.bInvitarAdminitrador.Visible = false;
                this.bEliminarUsuario.Visible = false;
            }

        }

        private void bcambiarNombre_Click(object sender, EventArgs e) {
            CambiarNombre ventana = new CambiarNombre(usuario);
            ventana.ShowDialog();
        }

        private void bBandejaEntrada_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            Chat ventana = new Chat(usuario);
            ventana.ShowDialog();
        }

        private void bMisCursos_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            MisCursos ventana = new MisCursos(usuario);
            ventana.ShowDialog();
        }

        private void bMisAS_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.Close();
            MisActividadesSociales ventana = new MisActividadesSociales(usuario);
            ventana.ShowDialog();
        }

        private void bDarseDeBaja_Click(object sender, EventArgs e) {

            ConfirmarPassword ventana = new ConfirmarPassword(usuario);
            ventana.ShowDialog();
            this.Close();

        }

        private void bInvitarAdminitrador_Click(object sender, EventArgs e) {
            UsuarioQuery bd = new UsuarioQuery();
            bd.codigoAdmin();
        }

        private void bEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario ventana = new EliminarUsuario();
            ventana.ShowDialog();
            this.Close();
        }
    }
}

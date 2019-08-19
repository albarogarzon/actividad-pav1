using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico8_8.Clases;

namespace Practico8_8
{
    public partial class frmLogin : Form
    {
        Usuario miUsuario = new Usuario();

        internal Usuario MiUsuario
        {
            get { return miUsuario; }
            set { miUsuario = value; }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsuario.Text)){
                MessageBox.Show("Debe ingresar un usuario.");
                return;
            }
            if (string.IsNullOrEmpty(this.txtClave.Text)){
                MessageBox.Show("Debe ingresar una clave.");
                return;
            }
            miUsuario.N_usuario = txtUsuario.Text;
            miUsuario.Password = txtClave.Text;
            if (miUsuario.validarUsuario(miUsuario.N_usuario, miUsuario.Password) == 0)
            {
                MessageBox.Show("Usuario Invalido");
                txtUsuario.Clear();
                txtClave.Clear();
                txtUsuario.Focus();

            }
            else
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //Comentario agregado por Albaro! 
        }

    }
}

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
    public partial class frmPrincipal : Form
    {
        Usuario usuarioActual;

        internal Usuario UsuarioActual
        {
            get { return usuarioActual; }
            set { usuarioActual = value; }
        }

        
        

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin FL;
            FL = new frmLogin();
            this.Visible = false;
            FL.ShowDialog();
            usuarioActual = FL.MiUsuario;
            this.Visible = true;
            if (usuarioActual.Id_usuario == 0)
            { this.Close(); }
            this.Text = this.Text + "Usuario" + this.usuarioActual.N_usuario;
            FL.Dispose();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro de abandonar la aplicación."
                , "Saliendo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2)
            == System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

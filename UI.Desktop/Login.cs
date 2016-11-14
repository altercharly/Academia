using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Registro(string Usr, string Pass)
        {
            Usuario usu = new Usuario();
            UsuarioLogic ul = new UsuarioLogic();
            usu = ul.GetOne(Usr, Pass);
            if (usu.ID == 0)
            {
                Notificar("Error de identificación", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UsuarioSesion.Sesion = usu;
                FrmPrincipal fp = new FrmPrincipal();
                this.DialogResult = DialogResult.OK;
            }
        }

        public bool Validar()
        {
            if (txtClave.Text == "" || txtUsuario.Text == "")
            {
                Notificar("Error de identificación", "Hay campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Registro(txtUsuario.Text, txtClave.Text);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
}

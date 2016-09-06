using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using Util;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : UI.Desktop.ApplicationForm
    {
        #region Variables

        private Usuario _usuarioActual;
        bool est = true;

        #endregion

        #region Constructores

        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo)
            : this()
        {
            this.Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo)
            : this()
        {
            this.Modo = modo;
            _usuarioActual = new UsuarioLogic().GetOne(ID);
            MapearDeDatos();
            switch (modo)
            {
                case (ModoForm.Alta): this.btnAceptar.Text = "Guardar";
                    break;
                case (ModoForm.Modificacion): this.btnAceptar.Text = "Guardar";
                    break;
                case (ModoForm.Baja): this.btnAceptar.Text = "Eliminar";
                    break;
                case (ModoForm.Consulta): this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }
        #endregion

        #region Propiedades

        public Usuario UsuarioActual
        {
            get { return _usuarioActual; }
            set { _usuarioActual = value; }
        }

        #endregion

        #region Metodos
        public override void MapearDeDatos()
        {
            this.txtID.Text = this._usuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this._usuarioActual.Habilitado;
            this.txtNombre.Text = this._usuarioActual.Nombre;
            this.txtApellido.Text = this._usuarioActual.Apellido;
            this.txtClave.Text = this._usuarioActual.Clave;
            this.txtEmail.Text = this._usuarioActual.Email;
            this.txtUsuario.Text = this._usuarioActual.NombreUsuario;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new UsuarioLogic().Save(_usuarioActual);
        }

        public virtual void MapearADatos()
        {

            switch (this.Modo)
            {
                case (ModoForm.Alta):
                    {
                        _usuarioActual = new Usuario();
                        this._usuarioActual.Habilitado = this.chkHabilitado.Checked;
                        this._usuarioActual.Nombre = this.txtNombre.Text;
                        this._usuarioActual.Apellido = this.txtApellido.Text;
                        this._usuarioActual.Clave = this.txtClave.Text;
                        this._usuarioActual.Email = this.txtEmail.Text;
                        this._usuarioActual.NombreUsuario = this.txtUsuario.Text;
                        this._usuarioActual.State = BusinessEntity.States.New;
                        break;
                    }
                case (ModoForm.Modificacion):
                    {
                        this._usuarioActual.Habilitado = this.chkHabilitado.Checked;
                        this._usuarioActual.Nombre = this.txtNombre.Text;
                        this._usuarioActual.Apellido = this.txtApellido.Text;
                        this._usuarioActual.Clave = this.txtClave.Text;
                        this._usuarioActual.Email = this.txtEmail.Text;
                        this._usuarioActual.NombreUsuario = this.txtUsuario.Text;
                        this._usuarioActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case (ModoForm.Baja):
                    {
                        this._usuarioActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case (ModoForm.Consulta):
                    {
                        this._usuarioActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }
            }
        }

       public override bool Validar()
        {
            Boolean estado = true;
            if (!(this.Modo == ModoForm.Baja))
            {
                foreach (Control control in this.tableLayoutPanel1.Controls)
                {
                    if (!(control == txtID))
                    {
                        if (control is TextBox && control.Text == String.Empty)
                        {
                            estado = false;
                        }
                    }

                }
                if (estado == false)
                {
                    Notificar("Campos vacíos", "Existen campos sin completar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!(Util.ValidarEMails.esMailValido(this.txtEmail.Text)))
                {
                    estado = false;
                    Notificar("Mail no valido", "Mail no valido. Escribe una dirección de correo electrónico con el formato alguien@ejemplo.com.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!(String.Equals(this.txtClave.Text, this.txtConfirmarClave.Text)))
                {
                    estado = false;
                    Notificar("Contraseñas incorrectas", "Las contraseñas no coinciden.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!((this.txtClave.Text).Length >= 8))
                {
                    estado = false;
                    Notificar("Clave corta", "La contraseña debe contener al menos 8 caracteres.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return estado;
        }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        #endregion
        
        #region Eventos

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if(est == true)
            {
                est = false;
                this.txtClave.PasswordChar = '\0';
                this.txtConfirmarClave.PasswordChar = '\0';
            }
            else
            {
                est = true;
                this.txtClave.PasswordChar = '•';
                this.txtConfirmarClave.PasswordChar = '•';
            }
        }
        
        #endregion
       
    }
}

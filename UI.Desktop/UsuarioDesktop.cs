using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : UI.Desktop.ApplicationForm
    {
        public enum ModoForm { Alta, Baja, Modificacion, Consulta };
        private ModoForm _modo;

        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public ModoForm Modo
        {
            get { return _modo; }
            set { _modo = value; }
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }

        



        public Usuario UsuarioActual;
        public override void MapearDeDatos() {


            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email.ToString(); 
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave.ToString();
            /// validar clave?????? comparar los valores de Clave y ConfirmarClave, si son iguales mapear, sino cartel  this.txtConfirmarClave.Text = this.UsuarioActual
            int op = (int) _modo;

            switch (op)

            {
                case 0:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case 1:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case 2:
                    this.btnAceptar.Text = "Guardar";
                    break;
                default:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }
        public override void MapearADatos() {
            Usuario NuevoUsuario = new Usuario();
            int op = (int)_modo;

            switch (op)
            {
                case 0:
                    NuevoUsuario = UsuarioActual;
                    //revisar constructor, debido a falta ID
                    break;
                case 1:
                    ;
                    break;
                case 2:
                    NuevoUsuario = UsuarioActual;
                    break;
                default:
                   ;
                    break;
            }
                   
        }
        public override void GuardarCambios() { }
        public override bool Validar() { return false; }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public UsuarioDesktop(ModoForm modo): this()
        {
             Modo = modo; 
        }
        public UsuarioDesktop(int ID ,ModoForm modo) : this()
        {
            Modo = modo;
            UsuarioLogic u1 = new UsuarioLogic();
            UsuarioActual = u1.GetOne(ID);
            this.MapearDeDatos();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }

        public enum ModoForm { Alta, Baja, Modificacion, Consulta };

        private ModoForm _modo;

        public ModoForm Modo
        {
            get { return _modo; }
            set { _modo = value; }
        }

        public Usuario UsuarioActual;
        public override void MapearDeDatos() { }
        public override void MapearADatos() { }
        public override void GuardarCambios() { }
        public override bool Validar() { return false; }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
          
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
          
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
    }
}

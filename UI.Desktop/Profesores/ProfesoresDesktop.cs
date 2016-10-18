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
//using Util;

namespace UI.Desktop
{
    public partial class ProfesoresDesktop : ApplicationForm
    {
        #region Variables
        private Business.Entities.Personas _profesorActual;
        #endregion

        #region Constructores
        public ProfesoresDesktop()
        {
            InitializeComponent();
        }

        public ProfesoresDesktop(ModoForm modo )
            : this()
        {
            this.Modo = modo;
        }

        public ProfesoresDesktop(int ID, ModoForm modo)
            :this()
        {
            this.Modo = modo;
            _profesorActual = new PersonaLogic().GetOne(ID);
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
        public Business.Entities.Personas ProfesorActual
        {
            get { return _profesorActual; }
            set { _profesorActual = value; }
        }
        #endregion

        #region Metodos
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ProfesorActual.ID.ToString();
            this.txtNombre.Text = this.ProfesorActual.Nombre;
            this.txtApellido.Text = this.ProfesorActual.Apellido;
            this.txtEmail.Text = this.ProfesorActual.Email;
            this.txtDia.Text = this.ProfesorActual.FechaNacimiento.Day.ToString();
            this.txtMes.Text = this.ProfesorActual.FechaNacimiento.Month.ToString();
            this.txtAño.Text = this.ProfesorActual.FechaNacimiento.Year.ToString();
            this.txtDireccion.Text = this.ProfesorActual.Direccion;
            this.txtLegajo.Text = this.ProfesorActual.Legajo.ToString();
            this.txtTelefono.Text = this.ProfesorActual.Telefono;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                new PersonaLogic().Save(ProfesorActual);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void MapearADatos()
        {
            // cambiar visibilidad a Plan
            Business.Entities.Plan planActual = this.DevolverPlan();
            switch (this.Modo)
            {
                case (ModoForm.Alta):
                    {
                        ProfesorActual = new Business.Entities.Personas();
                        this.ProfesorActual.IDPlan = planActual.ID;
                        this.ProfesorActual.Nombre = this.txtNombre.Text;
                        this.ProfesorActual.Apellido = this.txtApellido.Text;
                        this.ProfesorActual.Email = this.txtEmail.Text;
                        this.ProfesorActual.Direccion = this.txtDireccion.Text;
                        DateTime fechaNac = new DateTime(int.Parse(this.txtAño.Text), int.Parse(this.txtMes.Text), int.Parse(this.txtDia.Text), 0, 0, 0);
                        this.ProfesorActual.FechaNacimiento = fechaNac;
                        this.ProfesorActual.Legajo = int.Parse(this.txtLegajo.Text);
                        this.ProfesorActual.Telefono = this.txtTelefono.Text;
                      //this.PersonaActual.TipoPersona = (Business.Entities.Personas.TiposPersonas)Enum.Parse(typeof(Business.Entities.Personas.TiposPersonas), this.cmbTiposPersonas.SelectedValue.ToString());
                        this.ProfesorActual.State = BusinessEntity.States.New;
                        break;
                    }
                case (ModoForm.Modificacion):
                    {
                        this.ProfesorActual.IDPlan = planActual.ID;
                        this.ProfesorActual.Nombre = this.txtNombre.Text;
                        this.ProfesorActual.Apellido = this.txtApellido.Text;
                        this.ProfesorActual.Email = this.txtEmail.Text;
                        this.ProfesorActual.Direccion = this.txtDireccion.Text;
                        DateTime fechaNac = new DateTime(int.Parse(this.txtAño.Text), int.Parse(this.txtMes.Text), int.Parse(this.txtDia.Text), 0, 0, 0);
                        this.ProfesorActual.FechaNacimiento = fechaNac;
                        this.ProfesorActual.Legajo = int.Parse(this.txtLegajo.Text);
                        this.ProfesorActual.Telefono = this.txtTelefono.Text;
                      //this.PersonaActual.TipoPersona = (Business.Entities.Personas.TiposPersonas)Enum.Parse(typeof(Business.Entities.Personas.TiposPersonas), this.cmbTiposPersonas.SelectedValue.ToString());
                        this.ProfesorActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case (ModoForm.Baja):
                    {
                        this.ProfesorActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case (ModoForm.Consulta):
                    {
                        this.ProfesorActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }
            }
        }

        private Plan DevolverPlan()
        {
            // generar PlanLogic
            return new PlanLogic().GetOne(((Business.Entities.Plan)this.cmbPlan.SelectedValue).ID); ;
        }

      /*  public override bool Validar()
        {
            int nro;
            Boolean estado = true;
            try
            {
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
                    else if (!(ValidarEMails.esMailValido(this.txtEmail.Text)))
                    {
                        estado = false;
                        Notificar("Mail no valido", "Mail no valido. Escribe una dirección de correo electrónico con el formato alguien@ejemplo.com.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!(int.TryParse(this.txtAño.Text, out nro)) || !(int.TryParse(this.txtMes.Text, out nro)) || !(int.TryParse(this.txtDia.Text, out nro)))
                    {
                        estado = false;
                        Notificar("Error en la fecha de nacimiento", "Verifique haber ingresado una fecha correcta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!(0 < int.Parse(this.txtAño.Text)))
                    {
                        estado = false;
                        Notificar("Error en la fecha de nacimiento", "Verifique haber ingresado para el año un número positivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!((0 < int.Parse(this.txtMes.Text)) && (int.Parse(this.txtMes.Text) < 13)))
                    {
                        estado = false;
                        Notificar("Error en la fecha de nacimiento", "Verifique haber ingresado para el mes un número positivo menor a 13.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!((0 < int.Parse(this.txtDia.Text)) && (int.Parse(this.txtDia.Text) < 32)))
                    {
                        estado = false;
                        Notificar("Error en la fecha de nacimiento", "Verifique haber ingresado para el día un número positivo menor a 32.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return estado;
            }
            catch (Exception e)
            {
                Notificar("ERROR", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                estado = false;
            }
            return estado;
        }*/

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
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
           // List<String> listaTipos = new PersonaLogic().DevolverTiposPersonas();
           //cmbTiposPersonas.DataSource = listaTipos;

            cmbPlan.DataSource = new PlanLogic().GetAll();
            cmbPlan.DisplayMember = "descripcion";
            cmbPlan.ValueMember = "id_plan";
        }

        #endregion
    }
}

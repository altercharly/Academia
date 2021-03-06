﻿using System;
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
    public partial class MateriaDesktop : ApplicationForm
    {
        #region Variables
        private Business.Entities.Materia _materiaActual;
        #endregion

        #region Constructores
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(ModoForm modo)
            : this()
        {
            this.Modo = modo;
        }

        public MateriaDesktop(int ID, ModoForm modo)
            : this()
        {
            this.Modo = modo;
            _materiaActual = new MateriaLogic().GetOne(ID);
            MapearDeDatos();
            switch (modo)
            {
                case (ModoForm.Alta):
                    this.btnAceptar.Text = "Guardar";
                    break;
                case (ModoForm.Modificacion):
                    this.btnAceptar.Text = "Guardar";
                    break;
                case (ModoForm.Baja):
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case (ModoForm.Consulta):
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }
        #endregion

        #region Propiedades
        public Business.Entities.Materia MateriaActual
        {
            get { return _materiaActual; }
            set { _materiaActual = value; }
        }
        #endregion

        #region Metodos
        public override void MapearDeDatos()
        {
            this.txtId.Text = this.MateriaActual.ID.ToString();
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtHorasSemanales.Text = this.MateriaActual.HSSemanales.ToString();
            this.txtHorasTotales.Text = this.MateriaActual.HSTotales.ToString();
            this.txtIdPlan.Text = this.MateriaActual.IDPlan.ToString();

        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                new MateriaLogic().Save(MateriaActual);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        public override void MapearADatos()
        {
            // cambiar visibilidad a Plan
            Business.Entities.Plan planActual = this.DevolverPlan();
            switch (this.Modo)
            {
                case (ModoForm.Alta):
                    {
                    PersonaActual = new Business.Entities.Personas();
                    this.PersonaActual.IDPlan = planActual.ID;
                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Email = this.txtEmail.Text;
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    DateTime fechaNac = new DateTime(int.Parse(this.txtAño.Text), int.Parse(this.txtMes.Text), int.Parse(this.txtDia.Text), 0, 0, 0);
                    this.PersonaActual.FechaNacimiento = fechaNac;
                    this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                    this.PersonaActual.Telefono = this.txtTelefono.Text;
                    //this.PersonaActual.TipoPersona = (Business.Entities.Personas.TiposPersonas)Enum.Parse(typeof(Business.Entities.Personas.TiposPersonas), this.cmbTiposPersonas.SelectedValue.ToString());
                    this.PersonaActual.State = BusinessEntity.States.New;
                    break;
                }
            case (ModoForm.Modificacion):
                {
                    this.PersonaActual.IDPlan = planActual.ID;
                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Email = this.txtEmail.Text;
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    DateTime fechaNac = new DateTime(int.Parse(this.txtAño.Text), int.Parse(this.txtMes.Text), int.Parse(this.txtDia.Text), 0, 0, 0);
                    this.PersonaActual.FechaNacimiento = fechaNac;
                    this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                    this.PersonaActual.Telefono = this.txtTelefono.Text;
                    //this.PersonaActual.TipoPersona = (Business.Entities.Personas.TiposPersonas)Enum.Parse(typeof(Business.Entities.Personas.TiposPersonas), this.cmbTiposPersonas.SelectedValue.ToString());
                    this.PersonaActual.State = BusinessEntity.States.Modified;
                    break;
                }
            case (ModoForm.Baja):
                {
                    this.PersonaActual.State = BusinessEntity.States.Deleted;
                    break;
                }
            case (ModoForm.Consulta):
                {
                    this.PersonaActual.State = BusinessEntity.States.Unmodified;
                    break;
                }
        }
    }*/
        /*
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

        /*private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            cmbPlan.DataSource = new PlanLogic().GetAll();
            cmbPlan.DisplayMember = "descripcion";
            cmbPlan.ValueMember = "id_plan";
        }*/

        #endregion
    }
}
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
    public partial class Persona : ApplicationForm
    {

        #region Constructores
        public Persona()
        {
            InitializeComponent();
            this.dgvPersonas.AutoGenerateColumns = false;
        }
        #endregion

        #region Metodos
        public void Listar()
        {
            PersonaLogic pl = new PersonaLogic();
            this.dgvPersonas.DataSource = pl.GetAll();
        }
        #endregion

        #region Eventos
        private void Personas_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbsNuevo_Click(object sender,EventArgs e)
        {
            ProfesoresDesktop formPersona = new ProfesoresDesktop(ApplicationForm.ModoForm.Alta);
            formPersona.ShowDialog();
            this.Listar();
        }

        private void tbsEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(this.dgvPersonas.SelectedRows == null))
                {
                    int ID = ((Business.Entities.Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
                    ProfesoresDesktop formpersona = new ProfesoresDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                    formpersona.ShowDialog();
                    this.Listar();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No existen registros a editar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(this.dgvPersonas.SelectedRows == null))
                {
                    int ID = ((Business.Entities.Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
                    ProfesoresDesktop formpersona = new ProfesoresDesktop(ID, ApplicationForm.ModoForm.Baja);
                    formpersona.ShowDialog();
                    this.Listar();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No existen registros a eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}

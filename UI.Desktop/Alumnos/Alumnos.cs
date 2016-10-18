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


namespace UI.Desktop.Alumnos
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
            this.dgvAlumnos.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            PersonaLogic pl = new PersonaLogic();
            dgvAlumnos.DataSource = pl.GetAll();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            this.Listar();
            //revisar el tema de la lista
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

    }
}

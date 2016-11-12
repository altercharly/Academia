using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;

namespace UI.Desktop.Comisiones
{
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
            InitializeComponent();
            ComisionLogic cl = new ComisionLogic();
            dgvComisiones.AutoGenerateColumns = false;
            dgvComisiones.DataSource = cl.DameComisiones(idPlan);
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {

        }
    }
}
}

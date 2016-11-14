using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            iniciarSesion();
        }

        private void iniciarSesion()
        {
            this.tsmiAdministrador.Visible = false;
            this.tsmiReportes.Visible = false;
            this.tsmiDocente.Visible = false;
            this.tsmiAlumno.Visible = false;
            if (UsuarioSesion.Sesion == null)
            {
                Login l = new Login();
                l.ShowDialog();
                if (l.DialogResult != DialogResult.OK)
                {
                    this.Dispose();
                }
                else
                {
                    this.lblApellido.Text = UsuarioSesion.Sesion.Apellido.ToUpper();
                    this.lblNombre.Text = UsuarioSesion.Sesion.Nombre.ToUpper();
                    this.lblTipo.Text = UsuarioSesion.Sesion.TipoPersona.ToString().ToUpper();
                    if (UsuarioSesion.Sesion.TipoPersona.ToString() == "Alumno")
                    {
                        this.tsmiAdministrador.Visible = false;
                        this.tsmiReportes.Visible = false;
                        this.tsmiDocente.Visible = false;
                        this.tsmiAlumno.Visible = true;
                    }
                    else if (UsuarioSesion.Sesion.TipoPersona.ToString() == "Docente")
                    {
                        this.tsmiAdministrador.Visible = false;
                        this.tsmiReportes.Visible = false;
                        this.tsmiAlumno.Visible = false;
                        this.tsmiDocente.Visible = true;
                    }
                    else
                    {
                        this.tsmiAdministrador.Visible = true;
                        this.tsmiReportes.Visible = true;
                        this.tsmiDocente.Visible = true;
                        this.tsmiAlumno.Visible = true;
                    }
                }
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioSesion.Sesion = null;
            this.lblApellido.Text = "";
            this.lblNombre.Text = "";
            this.lblTipo.Text = "";
            this.iniciarSesion();
        }

        private void verDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContraseña cc = new CambiarContraseña();
            cc.Show();
        }

        private void planesYMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanMaterias p = new PlanMaterias();
            p.Show();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades esp = new Especialidades();
            esp.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursosComisiones cc = new CursosComisiones();
            cc.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscripcionCursado ic = new InscripcionCursado();
            ic.Show();
        }

        private void tsbEstadoAcademico_Click(object sender, EventArgs e)
        {
            EstadoAcademico ea = new EstadoAcademico();
            ea.Show();
        }

        private void tsbPlanEstudio_Click(object sender, EventArgs e)
        {
            PlanEstudio pe = new PlanEstudio();
            pe.Show();
        }

        private void tsbInscribirACurso_Click(object sender, EventArgs e)
        {
            AsignacionDocenteCurso adc = new AsignacionDocenteCurso();
            adc.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCalificaciones rc = new RegistroCalificaciones();
            rc.Show();
        }



    }
}
}

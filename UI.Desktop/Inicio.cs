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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void tsmiUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios formUsuario = new Usuarios();
            formUsuario.ShowDialog();
        }

        private void tsmiPersonas_Click(object sender, EventArgs e)
        {
            Personas formPersonas = new Personas();
            formPersonas.ShowDialog();
        }

        private void tsmiPlanes_Click(object sender, EventArgs e)
        {
            Planes formPlan = new Planes();
            formPlan.ShowDialog();
        }

        private void tsmiEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades formEspecialidad = new Especialidades();
            formEspecialidad.ShowDialog();
        }

        private void tsmiMaterias_Click(object sender, EventArgs e)
        {
            Materias formMateria = new Materias();
            formMateria.ShowDialog();
        }

        private void tsmiComisiones_Click(object sender, EventArgs e)
        {
            Comisiones formComision = new Comisiones();
            formComision.ShowDialog();
        }

        private void tsmCursos_Click(object sender, EventArgs e)
        {
            Cursos formCursos = new Cursos();
            formCursos.ShowDialog();
        }
    }
}

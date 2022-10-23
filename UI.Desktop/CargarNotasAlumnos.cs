using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class CargarNotasAlumnos : UI.Desktop.ApplicationForm
    {
        public CargarNotasAlumnos()
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
        }

        static class Global
        {
            public static int ID;
            public static int IdCurso;
        }

        public CargarNotasAlumnos(int idcurso)
        {
            Global.IdCurso = idcurso;
        }


        private void CargarNotasAlumnos_Load(object sender, EventArgs e)
        {
            AlumnoInscripcionLogic c = new AlumnoInscripcionLogic();
            dgvAlumnos.DataSource = c.GetAlumnosCurso(Global.IdCurso);
        }

        private void dgvAlumnos_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.AlumnoInscripcion)this.dgvAlumnos.SelectedRows[0].DataBoundItem).ID;
            AlumnoInscripcionLogic a = new AlumnoInscripcionLogic();
            AlumnoInscripcion al = new AlumnoInscripcion();
            al = a.GetOne(ID);
            Business.Entities.Personas alumno = new Business.Entities.Personas();
            PersonaLogic p = new PersonaLogic();
            alumno = p.GetOne()
        }
    }
}

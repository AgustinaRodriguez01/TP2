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
            public static int IdCurso;
            public static AlumnoInscripcion insc;
        }

        public CargarNotasAlumnos(int idcurso) : this()
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
            int ID = ((AlumnoInscripcion)this.dgvAlumnos.SelectedRows[0].DataBoundItem).ID;
            AlumnoInscripcionLogic a = new AlumnoInscripcionLogic();
            Global.insc = a.GetOne(ID);
            PersonaLogic p = new PersonaLogic();
            Business.Entities.Personas alumno = p.GetOne(Global.insc.IdAlumno);
            lblNombre.Text = alumno.Nombre + " " + alumno.Apellido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Global.insc.Condicion = cmbCondicion.SelectedItem.ToString();
            Global.insc.Nota = Convert.ToInt32(nudNota.Text);
            AlumnoInscripcionLogic a = new AlumnoInscripcionLogic();
            a.Update(Global.insc);
            AlumnoInscripcionLogic c = new AlumnoInscripcionLogic();
            dgvAlumnos.DataSource = c.GetAlumnosCurso(Global.IdCurso);
        }
    }
}

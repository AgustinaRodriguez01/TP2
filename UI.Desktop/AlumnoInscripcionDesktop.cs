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
    public partial class AlumnoInscripcionDesktop : UI.Desktop.ApplicationForm
    {
        public AlumnoInscripcionDesktop()
        {
            InitializeComponent();
        }

        private AlumnoInscripcion _AlumnoInscripcionActual;
        public AlumnoInscripcion AlumnoInscripcionActual
        {
            get { return _AlumnoInscripcionActual; }
            set { _AlumnoInscripcionActual = value; }
        }

        public AlumnoInscripcionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public AlumnoInscripcionDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            this.AlumnoInscripcionActual = ail.GetOne(ID);
            this.MapearDeDatos();
        }

        public void Listar()
        {
            AlumnoInscripcionLogic ai = new AlumnoInscripcionLogic();
            cmbCurso.DataSource = ai.GetCursos();
            cmbCurso.ValueMember = "id_curso";
            cmbCurso.DisplayMember = "id_curso";
            cmbAlumnos.DataSource = ai.GetAlumnos();
            cmbAlumnos.DisplayMember = "apenom";
            cmbAlumnos.ValueMember = "id_persona";
            //cmbAlumnos.DataSource = Enum.GetValues(typeof(A.TipoCargo));

            CursoLogic c = new CursoLogic();
            Curso cur = c.GetOne(Convert.ToInt32(cmbCurso.SelectedValue));
            MateriaLogic m = new MateriaLogic();
            Materia mat = m.GetOne(cur.IdMateria);
            lblMateria.Text = mat.Descripcion;
            ComisionLogic com = new ComisionLogic();
            Comision comi = com.GetOne(cur.IdComision);
            lblComision.Text = comi.Descripcion;
            lblAnioCalendario.Text = cur.AnioCalendario.ToString();
            lblCupo.Text = cur.Cupo.ToString();

        }

        public override void MapearDeDatos()
        {
            this.txtIdInscripcion.Text = this.AlumnoInscripcionActual.ID.ToString();
            this.cmbAlumnos.SelectedValue = this.AlumnoInscripcionActual.IdAlumno;
            this.cmbCurso.SelectedValue = this.AlumnoInscripcionActual.IdCurso;
            this.txtCondicion.Text = this.AlumnoInscripcionActual.Condicion.ToString();
            this.txtNota.Text = this.AlumnoInscripcionActual.Nota.ToString();

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
                if (Modo == ModoForm.Modificacion)
                {
                    this.Text = "Modificar curso";
                }
            }

            if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
                this.Text = "Eliminar curso";
            }

            if (Modo == ModoForm.Consulta)
            {
                btnAceptar.Text = "Aceptar";
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                AlumnoInscripcion ai = new AlumnoInscripcion();
                AlumnoInscripcionActual = ai;
                AlumnoInscripcionActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {

                this.AlumnoInscripcionActual.IdCurso = Convert.ToInt32(this.cmbCurso.SelectedValue);
                this.AlumnoInscripcionActual.IdAlumno = Convert.ToInt32(this.cmbAlumnos.SelectedValue);
                AlumnoInscripcionActual.Condicion = txtCondicion.Text;
                AlumnoInscripcionActual.Nota = Convert.ToInt32(txtNota.Text);

                if (Modo == ModoForm.Modificacion)
                {
                    AlumnoInscripcionActual.State = BusinessEntity.States.Modified;
                }
            }

            if (Modo == ModoForm.Baja)
            {
                AlumnoInscripcionActual.State = BusinessEntity.States.Deleted;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            AlumnoInscripcionLogic aiActual = new AlumnoInscripcionLogic();
            aiActual.Save(AlumnoInscripcionActual);
        }

        private void AlumnoInscripcionDesktop_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CursoLogic c = new CursoLogic();
            Curso cur = c.GetOne(Convert.ToInt32(cmbCurso.SelectedValue));
            MateriaLogic m = new MateriaLogic();
            Materia mat = m.GetOne(cur.IdMateria);
            lblMateria.Text = mat.Descripcion;
            ComisionLogic com = new ComisionLogic();
            Comision comi = com.GetOne(cur.IdComision);
            lblComision.Text = comi.Descripcion;
            lblAnioCalendario.Text = cur.AnioCalendario.ToString();
            lblCupo.Text = cur.Cupo.ToString();
        }
    }
}

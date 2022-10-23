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
    public partial class InscripcionAlumnoDesktop : UI.Desktop.ApplicationForm
    {

        public InscripcionAlumnoDesktop()
        {
            InitializeComponent();
        }

        static class Global
        {
            public static int ID;
        }

        public InscripcionAlumnoDesktop(ModoForm modo, int idPersona) : this()
        {
            Modo = modo;
            Global.ID = idPersona;
        }

        public InscripcionAlumnoDesktop(int ID, ModoForm modo, int idPersona) : this()
        {
            AlumnoInscripcionLogic inscripcion = new AlumnoInscripcionLogic();
            InscActual = inscripcion.GetOne(ID);
            Modo = modo;
            Global.ID = idPersona;
            MapearDeDatos();
        }

        protected AlumnoInscripcion inscActual;
        public AlumnoInscripcion InscActual {
            get { return inscActual; }
            set { inscActual = value; }
        }

        public override void MapearDeDatos()
        {
            cmbCurso.SelectedValue = InscActual.IdCurso.ToString();

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
                if (Modo == ModoForm.Modificacion)
                {
                    this.Text = "Modificar especialidad";
                }
            }

            if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
                this.Text = "Eliminar especialidad";
            }

            if (Modo == ModoForm.Consulta)
            {
                btnAceptar.Text = "Aceptar";
            }
        }
        public override void MapearADatos()
        {
            this.InscActual = new AlumnoInscripcion();
            CursoLogic c = new CursoLogic();
            Curso curso = c.GetOne(Convert.ToInt32(cmbCurso.SelectedValue));
            switch (Modo)
            {
                case ModoForm.Alta:
                    if (curso.Cupo != 0)
                    {
                        this.InscActual.IdAlumno = Global.ID;
                        this.InscActual.IdCurso = Convert.ToInt32(this.cmbCurso.SelectedValue);
                        this.InscActual.Condicion = "Inscripto";
                        this.InscActual.Nota = 0;
                        c.ActualizarCupo(curso.ID, -1);
                        this.InscActual.State = BusinessEntity.States.New;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("No hay cupo en este curso.");
                        break;
                    }
                case ModoForm.Modificacion:
                    this.InscActual.ID = int.Parse(this.txtID.Text);
                    this.AlumnoInscripcionActual.IDAlumno = Global.ID;
                    this.AlumnoInscripcionActual.IDCurso = Convert.ToInt32(this.cbIDCurso.SelectedValue);
                    this.AlumnoInscripcionActual.Condicion = this.cbCondicion.SelectedItem.ToString();
                    this.AlumnoInscripcionActual.Nota = Convert.ToInt32(this.nNota.Value);
                    this.AlumnoInscripcionActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    this.AlumnoInscripcionActual.ID = int.Parse(this.txtID.Text);
                    this.AlumnoInscripcionActual.IDAlumno = Global.ID;
                    this.AlumnoInscripcionActual.IDCurso = Convert.ToInt32(this.cbIDCurso.SelectedValue);
                    this.AlumnoInscripcionActual.Condicion = this.cbCondicion.SelectedItem.ToString();
                    this.AlumnoInscripcionActual.Nota = Convert.ToInt32(this.nNota.Value);
                    int e = 1; ca.CambiaCupo(cur, e);
                    this.AlumnoInscripcionActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    this.AlumnoInscripcionActual.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            AlumnoInscripcionLogic inscActual = new AlumnoInscripcionLogic();
            inscActual.Save(InscActual);
        }
        public override bool Validar()
        {
            return true;
        }

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
            this.Close();
        }
    }

}

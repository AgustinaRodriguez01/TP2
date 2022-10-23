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
            if (Modo == ModoForm.Alta)
            {
                AlumnoInscripcion inscActual = new AlumnoInscripcion();
                InscActual = inscActual;
                InscActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                InscActual.IdCurso = Convert.ToInt32(cmbCurso.SelectedValue);

                if (Modo == ModoForm.Modificacion)
                {
                    InscActual.State = BusinessEntity.States.Modified;
                }
            }

            if (Modo == ModoForm.Baja)
            {
                InscActual.State = BusinessEntity.States.Deleted;
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

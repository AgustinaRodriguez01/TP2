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
    public partial class DocenteCursoDesktop : UI.Desktop.ApplicationForm
    {
        public DocenteCursoDesktop()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
        }

        private void InscripcionDocenteCurso_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            CursoLogic cur = new CursoLogic();
            dgvCursos.DataSource = cur.GetAll();
            PersonaLogic per = new PersonaLogic();
            cmbDocentes.DataSource = per.GetDocentes();
            cmbDocentes.DisplayMember = "apenom";
            cmbDocentes.ValueMember = "id_persona";

        }

        public DocenteCursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public DocenteCursoDesktop(int ID, ModoForm modo) : this()
        {
            DocenteCurso dc = new DocenteCurso();
            especialidadActual = especialidad.GetOne(ID);
            Modo = modo;
            MapearDeDatos();
        }

        protected Especialidad especialidadActual;
        public Especialidad EspecialidadActual {
            get { return especialidadActual; }
            set { especialidadActual = value; }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;


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
                Especialidad especialidadActual = new Especialidad();
                EspecialidadActual = especialidadActual;
                EspecialidadActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                EspecialidadActual.Descripcion = txtDescripcion.Text;

                if (Modo == ModoForm.Modificacion)
                {
                    EspecialidadActual.State = BusinessEntity.States.Modified;
                }
            }

            if (Modo == ModoForm.Baja)
            {
                EspecialidadActual.State = BusinessEntity.States.Deleted;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic espActual = new EspecialidadLogic();
            espActual.Save(EspecialidadActual);
        }
        public override bool Validar()
        {
            if (txtDescripcion.Text == "")
            {
                this.Notificar("La especialidad debe tener una descripcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }

        public new void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);

        }
        public new void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}

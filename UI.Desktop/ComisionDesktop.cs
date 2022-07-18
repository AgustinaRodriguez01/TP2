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
    public partial class ComisionDesktop : UI.Desktop.ApplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            ComisionLogic comision = new ComisionLogic();
            comisionActual = comision.GetOne(ID);
            Modo = modo;
            MapearDeDatos();
        }

        protected Comision comisionActual;
        public Comision ComisionActual
        {
            get { return comisionActual; }
            set { comisionActual = value; }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;
            this.txtAnioEspecialidad.Text = this.ComisionActual.AnioEspecialidad.ToString();
            this.txtIdPlan.Text = this.ComisionActual.IdPlan.ToString();


            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
                if (Modo == ModoForm.Modificacion)
                {
                    this.Text = "Modificar comision";
                }
            }

            if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
                this.Text = "Eliminar comision";
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
                Comision comisionActual = new Comision();
                ComisionActual = comisionActual;
                ComisionActual.State = BusinessEntity.States.New;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                ComisionActual.Descripcion = txtDescripcion.Text;
                ComisionActual.AnioEspecialidad = Convert.ToInt32(txtAnioEspecialidad.Text);
                ComisionActual.IdPlan = Convert.ToInt32(txtIdPlan.Text);

                if (Modo == ModoForm.Modificacion)
                {
                    ComisionActual.State = BusinessEntity.States.Modified;
                }
            }

            if (Modo == ModoForm.Baja)
            {
                ComisionActual.State = BusinessEntity.States.Deleted;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic comActual = new ComisionLogic();
            comActual.Save(ComisionActual);
        }
        public override bool Validar()
        {
            PlanLogic planActual = new PlanLogic();
            var plan = planActual.GetOne(Convert.ToInt32(txtIdPlan.Text));
            if (txtDescripcion.Text == "" || txtAnioEspecialidad.Text == "" || txtIdPlan.Text == "")
            {
                this.Notificar("Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (plan is null)
            {
                this.Notificar("Debe ingresar un id de Plan existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }

        public new void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);

        }
        public new void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

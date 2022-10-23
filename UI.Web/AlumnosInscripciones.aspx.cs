using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;


namespace UI.Web
{
    public partial class AlumnosInscripciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
        }

        AlumnoInscripcionLogic _logic;

        private AlumnoInscripcionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new AlumnoInscripcionLogic();
                }
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private AlumnoInscripcion Entity
        {
            get;
            set;
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else return 0;
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }


        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.ddlCurso.SelectedValue = this.Entity.IdCurso.ToString();
            this.ddlAlumno.SelectedValue = this.Entity.IdAlumno.ToString();
            txtCondicion.Text = Entity.Condicion;
            txtNota.Text = Entity.Nota.ToString();
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                EnableForm(true);
            }
        }

        private void LoadEntity(AlumnoInscripcion alumins)
        {
            alumins.IdCurso = Convert.ToInt32(this.ddlCurso.SelectedValue);
            alumins.IdAlumno = Convert.ToInt32(this.ddlAlumno.SelectedValue);
            alumins.Condicion = txtCondicion.Text;
            alumins.Nota = Convert.ToInt32(txtNota.Text);
        }

        private void SaveEntity(AlumnoInscripcion alumins)
        {
            this.Logic.Save(alumins);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (FormMode)
            {
                case FormModes.Baja:
                    DeleteEntity(SelectedID);
                    LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new AlumnoInscripcion();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Alta:
                    this.Entity = new AlumnoInscripcion();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default: break;
            }
            this.formPanel.Visible = false;
        }

        private void EnableForm(bool enable)
        {
            this.ddlCurso.Enabled = enable;
            this.ddlAlumno.Enabled = enable;
            txtCondicion.Enabled = enable;
            txtNota.Enabled = enable;

            AlumnoInscripcionLogic dcursos = new AlumnoInscripcionLogic();
            ddlCurso.SelectedValue = null;
            ddlCurso.DataSource = dcursos.GetCursos();
            ddlCurso.DataValueField = "id_curso";
            ddlCurso.DataTextField = "id_curso";
            ddlCurso.DataBind();

            ddlAlumno.SelectedValue = null;
            this.ddlAlumno.DataSource = dcursos.GetAlumnos();
            ddlAlumno.DataValueField = "id_persona";
            ddlAlumno.DataTextField = "apenom";
            ddlAlumno.DataBind();

            ActualizarComboCurso();
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                FormMode = FormModes.Baja;
                EnableForm(false);
                LoadForm(SelectedID);
            }
        }

        private void DeleteEntity(int id)
        {
            Logic.Delete(id);
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            formPanel.Visible = true;
            FormMode = FormModes.Alta;
            ClearForm();
            EnableForm(true);
        }

        private void ClearForm()
        {
            txtCondicion.Text = string.Empty;
            txtNota.Text = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            LoadGrid();
            formPanel.Visible = false;
        }

        public void ActualizarComboCurso()
        {
            CursoLogic cl = new CursoLogic();
            Curso cur = cl.GetOne(Convert.ToInt32(this.ddlCurso.SelectedValue));
            MateriaLogic ml = new MateriaLogic();
            Materia mat = ml.GetOne(cur.IdMateria);
            lblMateria.Text = mat.Descripcion;
            ComisionLogic col = new ComisionLogic();
            Comision com = col.GetOne(cur.IdComision);
            lblComision.Text = com.Descripcion;
            lblAnio.Text = cur.AnioCalendario.ToString();
            lblCupo.Text = cur.Cupo.ToString();
            lblComision.DataBind();
            lblMateria.DataBind();
            lblCupo.DataBind();
            lblAnio.DataBind();
        }
        protected void ddlCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            Curso cur = cl.GetOne(Convert.ToInt32(this.ddlCurso.SelectedValue));
            MateriaLogic ml = new MateriaLogic();
            Materia mat = ml.GetOne(cur.IdMateria);
            lblMateria.Text = mat.Descripcion;
            ComisionLogic col = new ComisionLogic();
            Comision com = col.GetOne(cur.IdComision);
            lblComision.Text = com.Descripcion;
            lblComision.DataBind();
            lblMateria.DataBind();
            lblAnio.Text = cur.AnioCalendario.ToString();
            lblCupo.Text = cur.Cupo.ToString();
            lblCupo.DataBind();
            lblAnio.DataBind();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class CargarNotas : System.Web.UI.Page
    {
        static class Global
        {
            public static AlumnoInscripcion aluIns;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DocenteCursoLogic docCurso = new DocenteCursoLogic();
                ddlCursos.DataSource = docCurso.GetCursosDocente(Convert.ToInt32(Session["idPersona"]));
                ddlCursos.DataValueField = "id_curso";
                ddlCursos.DataTextField = "id_curso";
                ddlCursos.DataBind();
                gvAlumnos.Visible = true;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Session["idCurso"] = ddlCursos.SelectedValue;
            AlumnoInscripcionLogic aluIns = new AlumnoInscripcionLogic();
            gvAlumnos.DataSource = aluIns.GetAlumnosCurso(Convert.ToInt32(Session["idCurso"]));
            gvAlumnos.DataBind();

        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDatos.Visible = true;
            this.SelectedID = (int)this.gvAlumnos.SelectedValue;
            AlumnoInscripcionLogic a = new AlumnoInscripcionLogic();
            Global.aluIns = a.GetOne(SelectedID);
            PersonaLogic p = new PersonaLogic();
            Business.Entities.Personas alumno = p.GetOne(Global.aluIns.IdAlumno);
            lblNombre.Text = alumno.Nombre + " " + alumno.Apellido;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Global.aluIns.Condicion = ddlCondicion.SelectedItem.ToString();
            if (ValidarLogic.EstaEntreUnoYDiez(Global.aluIns.Nota))
            {
                Page.Response.Write("<script>alert('La nota debe estar entre 0 y 10')</script>");
            }
            else
            {
                Global.aluIns.Nota = Convert.ToInt32(txtNota.Text);
                AlumnoInscripcionLogic a = new AlumnoInscripcionLogic();
                a.Update(Global.aluIns);
                AlumnoInscripcionLogic c = new AlumnoInscripcionLogic();
                gvAlumnos.DataSource = c.GetAlumnosCurso(Convert.ToInt32(Session["idCurso"]));
                AlumnoInscripcionLogic aluIns = new AlumnoInscripcionLogic();
                gvAlumnos.DataSource = aluIns.GetAlumnosCurso(Convert.ToInt32(Session["idCurso"]));
                gvAlumnos.DataBind();
            } 
        }
    }
}
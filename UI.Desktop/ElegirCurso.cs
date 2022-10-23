using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Logic;
using Business;

namespace UI.Desktop
{
    public partial class ElegirCurso : UI.Desktop.ApplicationForm
    {
        static class Global
        {
            public static int ID;
        }

        public ElegirCurso()
        {
            InitializeComponent();
        }

        public ElegirCurso(int id) : this()
        {
            Global.ID = id;
        }

        private void ElegirCurso_Load(object sender, EventArgs e)
        {
            DocenteCursoLogic docCurso = new DocenteCursoLogic();
            cmbCursos.DataSource = docCurso.GetCursosDocente(Global.ID);
        }
    }
}

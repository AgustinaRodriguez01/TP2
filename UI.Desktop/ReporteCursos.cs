using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Logic;
using Microsoft.Reporting.WinForms;

namespace UI.Desktop
{
    public partial class ReporteCursos : UI.Desktop.ApplicationForm
    {
        public ReporteCursos()
        {
            InitializeComponent();
        }

        private void ReporteCursos_Load(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            ReportDataSource rds = new ReportDataSource("DataSet2", cl.GetAll());
            rvCursos.LocalReport.DataSources.Add(rds);
            this.rvCursos.RefreshReport();
        }
    }
}

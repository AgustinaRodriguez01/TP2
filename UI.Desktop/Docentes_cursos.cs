using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Docentes_cursos : UI.Desktop.ApplicationForm
    {
        public Docentes_cursos()
        {
            InitializeComponent();
            this.dgvDocentes_cursos.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            Docentes_cursosLogic dl = new Docentes_cursosLogic();
            this.dgvDocentes_cursos.DataSource = dl.GetAll();
        }
    }
}

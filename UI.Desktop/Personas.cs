using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
            dgvPersonas.AutoGenerateColumns = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            PersonaLogic per = new PersonaLogic();
            dgvPersonas.DataSource = per.GetAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Personas_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class InscripcionAlumnoDesktop : UI.Desktop.ApplicationForm
    {
        static class Global
        {
            public static int ID;
        }

        public InscripcionAlumnoDesktop()
        {
            InitializeComponent();
        }

        public InscripcionAlumnoDesktop(int id)
        {
            Global.ID = id;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Business.Logic.PersonaLogic personaLogic = new Business.Logic.PersonaLogic();
            personaLogic.GetOne(Global.ID);
        }
    }
}

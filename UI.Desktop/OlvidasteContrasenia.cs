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
    public partial class OlvidasteContrasenia : Form
    {
        public OlvidasteContrasenia()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioLogic usuarioActual = new UsuarioLogic();
            var usuario = usuarioActual.ActualizarContraseña(txtNombreUsuario.Text, txtContraseniaVieja.Text, txtContraseniaNueva.Text);
            if(usuario is null)
            {
                MessageBox.Show("No se encontró el usuario");
            }
            else
            {
                MessageBox.Show("La contraseña se modificó con éxito");
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

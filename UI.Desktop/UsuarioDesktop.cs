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
using Business.Entities;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
           UsuarioLogic usuario = new UsuarioLogic();
           usuarioActual = usuario.GetOne(ID);
           Modo = modo;
           MapearDeDatos();
        }

        protected Usuario usuarioActual;
        public Usuario UsuarioActual {
            get { return usuarioActual; }
            set { usuarioActual = value; }
        }

        public override void MapearDeDatos() {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
            this.txtIdPersona.Text = this.UsuarioActual.IdPersona.ToString();

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
                if (Modo == ModoForm.Modificacion)
                {
                    this.Text = "Modificar usuario";
                }
            }

            if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
                this.Text = "Eliminar usuario";
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
                Usuario usuarioActual = new Usuario();
                UsuarioActual = usuarioActual;
                UsuarioActual.State = BusinessEntity.States.New;
                UsuarioActual.IdPersona = Convert.ToInt32(txtIdPersona.Text);
                UsuarioActual.Habilitado = chkHabilitado.Checked;
                UsuarioActual.Nombre = txtNombre.Text;
                UsuarioActual.Apellido = txtApellido.Text;
                UsuarioActual.Email = txtEmail.Text;
                UsuarioActual.NombreUsuario = txtUsuario.Text;
                UsuarioActual.Clave = txtClave.Text;
            }

            if (Modo == ModoForm.Modificacion)
            {
                UsuarioActual.Habilitado = chkHabilitado.Checked;
                UsuarioActual.Nombre = txtNombre.Text;
                UsuarioActual.Apellido = txtApellido.Text;
                UsuarioActual.Email = txtEmail.Text;
                UsuarioActual.NombreUsuario = txtUsuario.Text;
                UsuarioActual.Clave = txtClave.Text;
                UsuarioActual.IdPersona = Convert.ToInt32(txtIdPersona.Text);
                if (Modo == ModoForm.Modificacion)
                {
                    UsuarioActual.State = BusinessEntity.States.Modified;
                }
            }

            if(Modo == ModoForm.Baja)
            {
                UsuarioActual.State = BusinessEntity.States.Deleted;

            }
        }

        public override void GuardarCambios() 
        {
            MapearADatos();
            UsuarioLogic usuActual = new UsuarioLogic();
            usuActual.Save(UsuarioActual);
        }
        public override bool Validar() 
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtEmail.Text == ""
               || txtUsuario.Text == "" || txtClave.Text == "" || txtConfirmarClave.Text == "")
            {
                this.Notificar("Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ValidarLogic.EsConfirmacionValida(txtClave.Text, txtConfirmarClave.Text) == false)
            {
                this.Notificar("Las contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ValidarLogic.ValidarCantCaractContraseña(txtClave.Text) == false)
            {
                this.Notificar("Las contraseña debe tener 8 o mas caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ValidarLogic.esMailValido(txtEmail.Text) == false)
            {
                this.Notificar("El email no es valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            else
            {
                return true;
            }
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

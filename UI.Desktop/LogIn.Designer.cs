
namespace UI.Desktop
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblIniciarSesion = new System.Windows.Forms.TableLayoutPanel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lnklblOlvidaste = new System.Windows.Forms.LinkLabel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCrearCuentaNueva = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tblIniciarSesion.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblIniciarSesion
            // 
            this.tblIniciarSesion.ColumnCount = 2;
            this.tblIniciarSesion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.07101F));
            this.tblIniciarSesion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.92899F));
            this.tblIniciarSesion.Controls.Add(this.txtContraseña, 1, 2);
            this.tblIniciarSesion.Controls.Add(this.label1, 0, 1);
            this.tblIniciarSesion.Controls.Add(this.txtUsuario, 1, 1);
            this.tblIniciarSesion.Controls.Add(this.label2, 0, 2);
            this.tblIniciarSesion.Controls.Add(this.btnCancelar, 1, 3);
            this.tblIniciarSesion.Controls.Add(this.lnklblOlvidaste, 0, 4);
            this.tblIniciarSesion.Controls.Add(this.btnIngresar, 0, 3);
            this.tblIniciarSesion.Controls.Add(this.btnCrearCuentaNueva, 0, 5);
            this.tblIniciarSesion.Controls.Add(this.label4, 0, 0);
            this.tblIniciarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.tblIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.tblIniciarSesion.Name = "tblIniciarSesion";
            this.tblIniciarSesion.RowCount = 6;
            this.tblIniciarSesion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIniciarSesion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIniciarSesion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIniciarSesion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIniciarSesion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIniciarSesion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblIniciarSesion.Size = new System.Drawing.Size(222, 189);
            this.tblIniciarSesion.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(119, 54);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(98, 22);
            this.txtContraseña.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(119, 24);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(98, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(119, 84);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 28);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // lnklblOlvidaste
            // 
            this.lnklblOlvidaste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklblOlvidaste.AutoSize = true;
            this.tblIniciarSesion.SetColumnSpan(this.lnklblOlvidaste, 2);
            this.lnklblOlvidaste.Location = new System.Drawing.Point(4, 116);
            this.lnklblOlvidaste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblOlvidaste.Name = "lnklblOlvidaste";
            this.lnklblOlvidaste.Size = new System.Drawing.Size(213, 16);
            this.lnklblOlvidaste.TabIndex = 5;
            this.lnklblOlvidaste.TabStop = true;
            this.lnklblOlvidaste.Text = "¿Olvidaste tu contraseña?";
            this.lnklblOlvidaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnklblOlvidaste.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblOlvidaste_LinkClicked);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.Location = new System.Drawing.Point(11, 84);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 28);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCrearCuentaNueva
            // 
            this.btnCrearCuentaNueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblIniciarSesion.SetColumnSpan(this.btnCrearCuentaNueva, 2);
            this.btnCrearCuentaNueva.Location = new System.Drawing.Point(30, 144);
            this.btnCrearCuentaNueva.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCuentaNueva.Name = "btnCrearCuentaNueva";
            this.btnCrearCuentaNueva.Size = new System.Drawing.Size(160, 32);
            this.btnCrearCuentaNueva.TabIndex = 6;
            this.btnCrearCuentaNueva.Text = "Crear cuenta nueva";
            this.btnCrearCuentaNueva.UseVisualStyleBackColor = true;
            this.btnCrearCuentaNueva.Click += new System.EventHandler(this.btnCrearCuentaNueva_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.tblIniciarSesion.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Iniciar Sesión";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tblIniciarSesion);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(222, 189);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(222, 189);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 189);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.Text = "Iniciar Sesion";
            this.tblIniciarSesion.ResumeLayout(false);
            this.tblIniciarSesion.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblIniciarSesion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.LinkLabel lnklblOlvidaste;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btnCrearCuentaNueva;
    }
}
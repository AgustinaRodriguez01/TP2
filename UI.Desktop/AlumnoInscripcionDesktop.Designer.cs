namespace UI.Desktop
{
    partial class AlumnoInscripcionDesktop
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.txtIdInscripcion = new System.Windows.Forms.TextBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAlumno, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCurso, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCondicion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNota, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbAlumnos, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbCurso, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIdInscripcion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCondicion, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNota, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMateria, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblComision, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAnioCalendario, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCupo, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 6, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 473);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(3, 78);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(55, 16);
            this.lblAlumno.TabIndex = 1;
            this.lblAlumno.Text = "Alumno:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(3, 156);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 16);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso:";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(3, 234);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(70, 16);
            this.lblCondicion.TabIndex = 3;
            this.lblCondicion.Text = "Condición:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(3, 312);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(39, 16);
            this.lblNota.TabIndex = 4;
            this.lblNota.Text = "Nota:";
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(132, 81);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(121, 24);
            this.cmbAlumnos.TabIndex = 5;
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(132, 159);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 24);
            this.cmbCurso.TabIndex = 6;
            // 
            // txtIdInscripcion
            // 
            this.txtIdInscripcion.Location = new System.Drawing.Point(132, 3);
            this.txtIdInscripcion.Name = "txtIdInscripcion";
            this.txtIdInscripcion.ReadOnly = true;
            this.txtIdInscripcion.Size = new System.Drawing.Size(100, 22);
            this.txtIdInscripcion.TabIndex = 7;
            this.txtIdInscripcion.Visible = false;
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(132, 237);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(100, 22);
            this.txtCondicion.TabIndex = 8;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(132, 315);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 22);
            this.txtNota.TabIndex = 9;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(261, 156);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(52, 16);
            this.lblMateria.TabIndex = 10;
            this.lblMateria.Text = "Materia";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(390, 156);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(63, 16);
            this.lblComision.TabIndex = 11;
            this.lblComision.Text = "Comision";
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(519, 156);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(31, 16);
            this.lblAnioCalendario.TabIndex = 12;
            this.lblAnioCalendario.Text = "Año";
            // 
            // lblCupo
            // 
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(648, 156);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(39, 16);
            this.lblCupo.TabIndex = 13;
            this.lblCupo.Text = "Cupo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(519, 393);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(648, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AlumnoInscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(776, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AlumnoInscripcionDesktop";
            this.Text = "Alumnos Inscripciones";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.ComboBox cmbAlumnos;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.TextBox txtIdInscripcion;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

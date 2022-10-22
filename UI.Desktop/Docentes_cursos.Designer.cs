namespace UI.Desktop
{
    partial class Docentes_cursos
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
            this.dgvDocentes_cursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes_cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocentes_cursos
            // 
            this.dgvDocentes_cursos.AllowUserToAddRows = false;
            this.dgvDocentes_cursos.AllowUserToDeleteRows = false;
            this.dgvDocentes_cursos.AllowUserToOrderColumns = true;
            this.dgvDocentes_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes_cursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentes_cursos.Location = new System.Drawing.Point(0, 0);
            this.dgvDocentes_cursos.Name = "dgvDocentes_cursos";
            this.dgvDocentes_cursos.ReadOnly = true;
            this.dgvDocentes_cursos.RowHeadersWidth = 51;
            this.dgvDocentes_cursos.RowTemplate.Height = 24;
            this.dgvDocentes_cursos.Size = new System.Drawing.Size(438, 324);
            this.dgvDocentes_cursos.TabIndex = 0;
            // 
            // Docentes_cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(438, 324);
            this.Controls.Add(this.dgvDocentes_cursos);
            this.Name = "Docentes_cursos";
            this.Text = "Docentes Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes_cursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocentes_cursos;
    }
}


namespace UI.Desktop
{
    partial class ReporteCursos
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
            this.rvCursos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvCursos
            // 
            this.rvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvCursos.Location = new System.Drawing.Point(0, 0);
            this.rvCursos.Name = "rvCursos";
            this.rvCursos.ServerReport.BearerToken = null;
            this.rvCursos.Size = new System.Drawing.Size(800, 450);
            this.rvCursos.TabIndex = 0;
            // 
            // ReporteCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvCursos);
            this.Name = "ReporteCursos";
            this.Text = "Reporte Cursos";
            this.Load += new System.EventHandler(this.ReporteCursos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCursos;
    }
}

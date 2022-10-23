﻿
namespace UI.Desktop
{
    partial class Inicio
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInscripcionDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(659, 459);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(659, 487);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoTsmi});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ArchivoTsmi
            // 
            this.ArchivoTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsuarios,
            this.tsmiPersonas,
            this.tsmiPlanes,
            this.tsmiMaterias,
            this.tsmiEspecialidades,
            this.tsmiComisiones,
            this.tsmiCursos,
            this.tsmiInscripcionDocentes,
            this.inscripcionesDeAlumnosToolStripMenuItem});
            this.ArchivoTsmi.Name = "ArchivoTsmi";
            this.ArchivoTsmi.Size = new System.Drawing.Size(224, 26);
            this.ArchivoTsmi.Text = "Ver";
            // 
            // tsmiUsuarios
            // 
            this.tsmiUsuarios.Name = "tsmiUsuarios";
            this.tsmiUsuarios.Size = new System.Drawing.Size(305, 26);
            this.tsmiUsuarios.Text = "Usuarios";
            this.tsmiUsuarios.Click += new System.EventHandler(this.tsmiUsuarios_Click);
            // 
            // tsmiPersonas
            // 
            this.tsmiPersonas.Name = "tsmiPersonas";
            this.tsmiPersonas.Size = new System.Drawing.Size(305, 26);
            this.tsmiPersonas.Text = "Personas";
            this.tsmiPersonas.Click += new System.EventHandler(this.tsmiPersonas_Click);
            // 
            // tsmiPlanes
            // 
            this.tsmiPlanes.Name = "tsmiPlanes";
            this.tsmiPlanes.Size = new System.Drawing.Size(305, 26);
            this.tsmiPlanes.Text = "Planes";
            this.tsmiPlanes.Click += new System.EventHandler(this.tsmiPlanes_Click);
            // 
            // tsmiMaterias
            // 
            this.tsmiMaterias.Name = "tsmiMaterias";
            this.tsmiMaterias.Size = new System.Drawing.Size(305, 26);
            this.tsmiMaterias.Text = "Materias";
            this.tsmiMaterias.Click += new System.EventHandler(this.tsmiMaterias_Click);
            // 
            // tsmiEspecialidades
            // 
            this.tsmiEspecialidades.Name = "tsmiEspecialidades";
            this.tsmiEspecialidades.Size = new System.Drawing.Size(305, 26);
            this.tsmiEspecialidades.Text = "Especialidades";
            this.tsmiEspecialidades.Click += new System.EventHandler(this.tsmiEspecialidades_Click);
            // 
            // tsmiComisiones
            // 
            this.tsmiComisiones.Name = "tsmiComisiones";
            this.tsmiComisiones.Size = new System.Drawing.Size(305, 26);
            this.tsmiComisiones.Text = "Comisiones";
            this.tsmiComisiones.Click += new System.EventHandler(this.tsmiComisiones_Click);
            // 
            // tsmiCursos
            // 
            this.tsmiCursos.Name = "tsmiCursos";
            this.tsmiCursos.Size = new System.Drawing.Size(305, 26);
            this.tsmiCursos.Text = "Cursos";
            this.tsmiCursos.Click += new System.EventHandler(this.tsmCursos_Click);
            // 
            // tsmiInscripcionDocentes
            // 
            this.tsmiInscripcionDocentes.Name = "tsmiInscripcionDocentes";
            this.tsmiInscripcionDocentes.Size = new System.Drawing.Size(305, 26);
            this.tsmiInscripcionDocentes.Text = "Inscripcion de docentes a cursos";
            this.tsmiInscripcionDocentes.Click += new System.EventHandler(this.tsmiInscripcionDocentes_Click);
            // 
            // inscripcionesDeAlumnosToolStripMenuItem
            // 
            this.inscripcionesDeAlumnosToolStripMenuItem.Name = "inscripcionesDeAlumnosToolStripMenuItem";
            this.inscripcionesDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.inscripcionesDeAlumnosToolStripMenuItem.Text = "Inscripciones de alumnos";
            this.inscripcionesDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.inscripcionesDeAlumnosToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 487);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArchivoTsmi;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonas;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlanes;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaterias;
        private System.Windows.Forms.ToolStripMenuItem tsmiEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem tsmiComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsmiCursos;
        private System.Windows.Forms.ToolStripMenuItem tsmiInscripcionDocentes;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesDeAlumnosToolStripMenuItem;
    }
}

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnUsuarios, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEspecialidades, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPlanes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMaterias, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(205, 203);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.Location = new System.Drawing.Point(3, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(199, 44);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuario";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEspecialidades.Location = new System.Drawing.Point(3, 53);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(199, 44);
            this.btnEspecialidades.TabIndex = 1;
            this.btnEspecialidades.Text = "Especialidad";
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanes.Location = new System.Drawing.Point(3, 103);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(199, 44);
            this.btnPlanes.TabIndex = 2;
            this.btnPlanes.Text = "Plan";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaterias.Location = new System.Drawing.Point(3, 153);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(199, 47);
            this.btnMaterias.TabIndex = 3;
            this.btnMaterias.Text = "Materia";
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 203);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnMaterias;
    }
}
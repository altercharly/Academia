namespace UI.Desktop
{
    partial class Form1
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
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAlumnos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDocentes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMaterias, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCursos, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 256);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlumnos.Location = new System.Drawing.Point(33, 52);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(75, 23);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDocentes.Location = new System.Drawing.Point(174, 52);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(75, 23);
            this.btnDocentes.TabIndex = 1;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            // 
            // btnMaterias
            // 
            this.btnMaterias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaterias.Location = new System.Drawing.Point(33, 180);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(75, 23);
            this.btnMaterias.TabIndex = 2;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = true;
            // 
            // btnCursos
            // 
            this.btnCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCursos.Location = new System.Drawing.Point(174, 180);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(75, 23);
            this.btnCursos.TabIndex = 3;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnCursos;
    }
}
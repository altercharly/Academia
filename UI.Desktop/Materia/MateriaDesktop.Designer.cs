namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.tlpABMMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblHorasSemanales = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtHorasSemanales = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tlpABMMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpABMMaterias
            // 
            this.tlpABMMaterias.ColumnCount = 3;
            this.tlpABMMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpABMMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpABMMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpABMMaterias.Controls.Add(this.lblID, 0, 1);
            this.tlpABMMaterias.Controls.Add(this.lblDescripcion, 0, 2);
            this.tlpABMMaterias.Controls.Add(this.lblHorasSemanales, 0, 3);
            this.tlpABMMaterias.Controls.Add(this.txtId, 1, 1);
            this.tlpABMMaterias.Controls.Add(this.txtDescripcion, 1, 2);
            this.tlpABMMaterias.Controls.Add(this.txtHorasSemanales, 1, 3);
            this.tlpABMMaterias.Controls.Add(this.comboBox1, 1, 0);
            this.tlpABMMaterias.Controls.Add(this.label1, 0, 0);
            this.tlpABMMaterias.Controls.Add(this.label2, 0, 4);
            this.tlpABMMaterias.Controls.Add(this.btnAceptar, 1, 5);
            this.tlpABMMaterias.Controls.Add(this.textBox1, 1, 4);
            this.tlpABMMaterias.Controls.Add(this.btnCancelar, 2, 5);
            this.tlpABMMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpABMMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlpABMMaterias.Name = "tlpABMMaterias";
            this.tlpABMMaterias.RowCount = 6;
            this.tlpABMMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpABMMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpABMMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpABMMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpABMMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpABMMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpABMMaterias.Size = new System.Drawing.Size(410, 159);
            this.tlpABMMaterias.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 57);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblHorasSemanales
            // 
            this.lblHorasSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHorasSemanales.AutoSize = true;
            this.lblHorasSemanales.Location = new System.Drawing.Point(3, 83);
            this.lblHorasSemanales.Name = "lblHorasSemanales";
            this.lblHorasSemanales.Size = new System.Drawing.Size(90, 13);
            this.lblHorasSemanales.TabIndex = 3;
            this.lblHorasSemanales.Text = "Horas Semanales";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtId.Location = new System.Drawing.Point(101, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(217, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.Location = new System.Drawing.Point(101, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(217, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtHorasSemanales
            // 
            this.txtHorasSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHorasSemanales.Location = new System.Drawing.Point(101, 80);
            this.txtHorasSemanales.Name = "txtHorasSemanales";
            this.txtHorasSemanales.Size = new System.Drawing.Size(217, 20);
            this.txtHorasSemanales.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(250, 132);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(331, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 2);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Plan:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Horas Totales";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 13;
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 159);
            this.Controls.Add(this.tlpABMMaterias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MateriaDesktop";
            this.Text = "Materias";
            this.tlpABMMaterias.ResumeLayout(false);
            this.tlpABMMaterias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpABMMaterias;
        private System.Windows.Forms.Label lblIdPlan;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHorasSemanales;
        private System.Windows.Forms.Label lblHorasTotales;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtHorasSemanales;
        private System.Windows.Forms.TextBox txtHorasTotales;
        private System.Windows.Forms.TextBox txtIdPlan;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
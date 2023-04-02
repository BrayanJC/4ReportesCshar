namespace ReportesCshar.Por_Filtración_Unica
{
    partial class ReportePORFiltracionUNICA
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.CmbCampo = new System.Windows.Forms.ComboBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TXTcriterio = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsEmpleados = new ReportesCshar.Por_Filtración_Unica.DsEmpleados();
            this.DBPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBPacientesTableAdapter = new ReportesCshar.Por_Filtración_Unica.DsEmpleadosTableAdapters.DBPacientesTableAdapter();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBPacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.Panel1.Controls.Add(this.CmbCampo);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Button5);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.TXTcriterio);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(216, 492);
            this.Panel1.TabIndex = 1;
            // 
            // CmbCampo
            // 
            this.CmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCampo.FormattingEnabled = true;
            this.CmbCampo.Items.AddRange(new object[] {
            "Nombres",
            "Apellidos",
            "Ciudad"});
            this.CmbCampo.Location = new System.Drawing.Point(19, 84);
            this.CmbCampo.Name = "CmbCampo";
            this.CmbCampo.Size = new System.Drawing.Size(178, 21);
            this.CmbCampo.TabIndex = 22;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(20, 256);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(177, 37);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "Refrescar";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Lime;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(19, 204);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(177, 37);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "Filtrar";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(17, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Campo";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(17, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 16);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Criterio";
            // 
            // TXTcriterio
            // 
            this.TXTcriterio.Location = new System.Drawing.Point(19, 37);
            this.TXTcriterio.Name = "TXTcriterio";
            this.TXTcriterio.Size = new System.Drawing.Size(177, 20);
            this.TXTcriterio.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DsEmpleados";
            reportDataSource3.Value = this.DBPacientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesCshar.Por_Filtración_Unica.RepprtUNI.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(216, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(738, 492);
            this.reportViewer1.TabIndex = 2;
            // 
            // DsEmpleados
            // 
            this.DsEmpleados.DataSetName = "DsEmpleados";
            this.DsEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DBPacientesBindingSource
            // 
            this.DBPacientesBindingSource.DataMember = "DBPacientes";
            this.DBPacientesBindingSource.DataSource = this.DsEmpleados;
            // 
            // DBPacientesTableAdapter
            // 
            this.DBPacientesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePORFiltracionUNICA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 492);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Panel1);
            this.Name = "ReportePORFiltracionUNICA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePORFiltracionUNICA";
            this.Load += new System.EventHandler(this.ReportePORFiltracionUNICA_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBPacientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ComboBox CmbCampo;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TXTcriterio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DBPacientesBindingSource;
        private DsEmpleados DsEmpleados;
        private DsEmpleadosTableAdapters.DBPacientesTableAdapter DBPacientesTableAdapter;
    }
}
using Microsoft.Reporting.WinForms;
using ReportesCshar.REPOSITORIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCshar.Por_Filtración_Unica
{
    public partial class ReportePORFiltracionUNICA : Form
    {
        public ReportePORFiltracionUNICA()
        {
            InitializeComponent();
        }

        private void ReportePORFiltracionUNICA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsEmpleados.DBPacientes' Puede moverla o quitarla según sea necesario.
            this.DBPacientesTableAdapter.Fill(this.DsEmpleados.DBPacientes);
            this.reportViewer1.RefreshReport();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var Info = new DsEmpleados();
            string campo = CmbCampo.Text;
            string criterio = TXTcriterio.Text;
            var op = new _3Funciones();
            Info = op.Filtrar(campo, criterio);
            reportViewer1.Visible = true;
            reportViewer1.SetDisplayMode(DisplayMode.Normal);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesCshar.Por_Filtración_Unica.RepprtUNI.rdlc";
            var rds = new ReportDataSource("DsEmpleados", Info.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var Info = new DsEmpleados();
            string campo = CmbCampo.Text;
            string criterio = TXTcriterio.Text;
            var op = new _3Funciones();
            Info = op.Refrescar();
            reportViewer1.Visible = true;
            reportViewer1.SetDisplayMode(DisplayMode.Normal);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesCshar.Por_Filtración_Unica.RepprtUNI.rdlc";
            var rds = new ReportDataSource("DsEmpleados", Info.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}

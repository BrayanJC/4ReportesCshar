using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportesCshar.Por_Datagridview;

namespace ReportesCshar.Por_Datagridview
{

    public partial class ReporteFRM : Form
    {
        public List<Reportes_Filtracion_por_DatagridviewLASS> Datos = new List<Reportes_Filtracion_por_DatagridviewLASS>();
        public ReporteFRM()
        {
            InitializeComponent();
        }
        private void ReporteFRM_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Reporte_Filtracion_Data", Datos));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }
    }
}

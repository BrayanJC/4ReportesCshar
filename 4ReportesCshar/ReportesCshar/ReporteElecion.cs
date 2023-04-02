using ReportesCshar.Por_Datagridview;
using ReportesCshar.Por_Filtración_Unica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCshar
{
    public partial class ReporteElecion : Form
    {
        public ReporteElecion()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var frm = new ReportePORFiltracionUNICA();
            frm.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var frm = new Reportes_Filtracion_por_Datagridview();
            frm.ShowDialog();
        }
    }
}

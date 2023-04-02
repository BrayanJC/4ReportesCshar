using ReportesCshar.REPOSITORIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCshar.Por_Datagridview
{
    public partial class Reportes_Filtracion_por_Datagridview : Form
    {
        public _4Valores Estado;
        public int id = 0;
    
    public Reportes_Filtracion_por_Datagridview()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var rep = new ReporteFRM();
            for (int i = 0, loopTo = DataGridView1.Rows.Count - 1; i <= loopTo; i++)
            {
                var dat = new Reportes_Filtracion_por_DatagridviewLASS();
                dat.Nombres = TextBox1.Text;
                dat.Apellidos = TextBox2.Text;
                dat.Fecha_Nacimiento = DateTimePicker1.Value;
                dat.Ciudad = ComboBox1.Text;
                dat.Imagen = GetBytes(PictureBox1.Image);
                rep.Datos.Add(dat);
            }
            rep.ShowDialog();
        }
        private byte[] GetBytes(Image imageIN)
        {
            var ms = new MemoryStream();
            imageIN.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Se realizará el proceso, ¿Está seguro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ELIMINAR();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ListarDatos()
        {
            var obj = new _3Funciones();
            DataGridView1.DataSource = obj.MOSTRAR();
        }

        public void limpiar()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            this.PictureBox1.Image = null;
            ComboBox1.Text = "";
            Button1.Enabled = false;
        }
        public void ELIMINAR()
        {
            try
            {
                var obj = new _3Funciones();
                Estado = _4Valores.Borrar;
                obj.estado = Estado;
                obj.Id1 = Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString());
                obj.Grabar_PACIENTE();
                limpiar();
                ListarDatos();
            }
            catch (Exception)
            {
            }
        }
        private byte[] ConvertirImg()
        {
            var ms = new MemoryStream();
            PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }

        public void AGREGAR()
        {
            try
            {
                var obj = new _3Funciones();
                Estado = _4Valores.Agregar;
                obj.estado = Estado;
                obj.Nombres1 = TextBox1.Text;
                obj.Apellidos1 = TextBox2.Text;
                obj.Fecha_Nacimiento1 = DateTimePicker1.Value;
                obj.Ciudad1 = ComboBox1.Text;
                obj.Imagen1 = ConvertirImg();
                obj.Grabar_PACIENTE();
                limpiar();
                ListarDatos();
            }

            catch (Exception)
            {
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" & TextBox2.Text != "" & ComboBox1.Text != "")
            {
                if (this.PictureBox1.Image is null)
                {
                    MessageBox.Show("¡Error!, Suba una imagen e referencia", "Llene Todos Los Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (MessageBox.Show("Se realizará el proceso, ¿Está seguro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    AGREGAR();

                }
            }
            else
            {
                MessageBox.Show("¡Error!, No pueden haber campos vacios", "Llene Todos Los Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.Image = new Bitmap(openFile.FileName);
            }
        }

        private void Reportes_Filtracion_por_Datagridview_Load(object sender, EventArgs e)
        {
            ListarDatos();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            FilterData(TextBox4.Text);
        }

        public void FilterData(string valueToSearch)
        {
            using (var cnn = new SqlConnection("Server=(local);DataBase=CRUD_Example_Reportes; Integrated Security=true"))
            {
                cnn.Open();
                string ConsultaSQL = "Select * from DBPacientes WHERE CONCAT(id,Nombres,Apellidos) like '%" + valueToSearch + "%'";
                var cmd = new SqlCommand(ConsultaSQL, cnn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                DataGridView1.DataSource = table;
                cnn.Close();
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                TextBox1.Text = (string)DataGridView1.CurrentRow.Cells[1].Value;
                TextBox2.Text = (string)DataGridView1.CurrentRow.Cells[2].Value;
                DateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;
                ComboBox1.Text = (string)DataGridView1.CurrentRow.Cells[4].Value;

                byte[] img = (byte[])DataGridView1.CurrentRow.Cells[5].Value;
                var ms = new MemoryStream(img);
                PictureBox1.Image = Image.FromStream(ms);
                Button1.Enabled = true;
            }
            else
            {
            }

        }
    }
}

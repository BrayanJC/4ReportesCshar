using ReportesCshar.Por_Filtración_Unica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesCshar.REPOSITORIOS
{

    public partial class _3Funciones: _2RepositorioMaestro
    {
        public _4Valores estado;

        // '''Paciente 
        private int Id;
        private string Nombres;
        private string Apellidos;
        private DateTime Fecha_Nacimiento;
        private string Ciudad;
        private byte[] Imagen;

        public int Id1 { get => Id; set => Id = value; }
        public string Nombres1 { get => Nombres; set => Nombres = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public DateTime Fecha_Nacimiento1 { get => Fecha_Nacimiento; set => Fecha_Nacimiento = value; }
        public string Ciudad1 { get => Ciudad; set => Ciudad = value; }
        public byte[] Imagen1 { get => Imagen; set => Imagen = value; }
    

    public void INSERTAR()
    {
        string TransactSQL = " insert into DBPacientes values (@Nombres, @Apellidos, @Fecha_Nacimiento, @Ciudad, @Imagen)";
        parametros = new List<SqlParameter>();
        parametros.Add(new SqlParameter("@Nombres", Nombres1));
        parametros.Add(new SqlParameter("@Apellidos", Apellidos1));
        parametros.Add(new SqlParameter("@Fecha_Nacimiento", Fecha_Nacimiento1));
        parametros.Add(new SqlParameter("@Ciudad", Ciudad1));
        parametros.Add(new SqlParameter("@Imagen", Imagen1));
        ExecuteNonQuery(TransactSQL);
    }
    public void ELIMINAR()
    {
        string TrsnsactSQL = " DELETE FROM DBPacientes WHERE Id = @Id";
        parametros = new List<SqlParameter>();
        parametros.Add(new SqlParameter("@Id", Id1));
        ExecuteNonQuery(TrsnsactSQL);
    }

    public DataTable MOSTRAR()
    {
        string TransactSQL = "Select * from DBPacientes";
        return ExecuteReader2(TransactSQL);
    }
        public void Grabar_PACIENTE()
        {
            try
            {
                switch (estado)
                {
                    case var @case when @case == _4Valores.Agregar:
                        {
                            INSERTAR();
                            MessageBox.Show("Paciente grabado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case var case1 when case1 == _4Valores.Borrar:
                        {
                            ELIMINAR();
                            MessageBox.Show("Paciente borrado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                }
            }
            catch (Exception)
            {
            }
        }
        public string sql { get; set; }
        public DsEmpleados Filtrar(string campo, string criterio)
        {
            var DA = new SqlDataAdapter();
            var ds = new DsEmpleados();
            sql = "Select * from DBPacientes where " + campo + " like '%" + criterio + "%'";
            try
            {
                using (var conexion = ObtenerConexion())
                {
                    conexion.Open();
                    DA = new SqlDataAdapter(sql, ObtenerConexion());
                    DA.Fill(ds, "DBPacientes");
                    conexion.Close();
                    return ds;
                }
            }
            catch (Exception)
            {
            }
            return ds;
        }
        public DsEmpleados Refrescar()
        {
            var DA = new SqlDataAdapter();
            var ds = new DsEmpleados();
            sql = "Select * from DBPacientes";
            try
            {
                using (var conexion = ObtenerConexion())
                {
                    conexion.Open();
                    DA = new SqlDataAdapter(sql, ObtenerConexion());
                    DA.Fill(ds, "DBPacientes");
                    conexion.Close();
                    return ds;
                }
            }
            catch (Exception)
            {
            }
            return ds;
        }
    }
}

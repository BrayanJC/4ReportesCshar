using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportesCshar.REPOSITORIOS
{

    public abstract partial class _1Conexion
    {
        private string CadenaConexion;
        public _1Conexion()
        {
            CadenaConexion = "Server=(local);DataBase=CRUD_Example_Reportes; Integrated Security=true";
        }
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}

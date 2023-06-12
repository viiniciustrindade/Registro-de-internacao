using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_internacao
{
    public class DaoConnection
    {
        public static SqlConnection GetConexao()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=PROG\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;MultipleActiveResultSets=true;");
            connection.Open();

            return connection;
        }
    }
}

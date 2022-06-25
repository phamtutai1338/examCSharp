using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class SqlServerConnection
    {
        public SqlConnection getData()
        {
            string connectionString = "Data source = localhost ; Initial Catalog = Dbtest ;  Integrated security = SSPI";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

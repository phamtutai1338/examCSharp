using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
   class Delete
    {
        private SqlConnection connection;

        public SqlConnection Sqlconnection { get; private set; }

        public void DeleteExam(int id)
        {
            Sqlconnection = new SqlServerConnection().getData();
            connection.Open();

            SqlCommand command = new SqlCommand("Delete from product where id = @id ", connection);
            command.Parameters.AddWithValue("@id", id);
            int i = command.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("Delete success !");
            }
            else
            {
                Console.WriteLine("Delete false !");
            }



        }
    }
}
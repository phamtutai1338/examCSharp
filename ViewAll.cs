using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Exam;

namespace Exam
{
    internal class ViewAll
    {
        SqlConnection connection = new SqlServerConnection().getData();
        public List<Exam> getData()
        {
            List<Exam> exams = new List<Exam>();
            string query = "select * from Exam";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id1 = Convert.ToInt32(reader[0]);
                string id = Convert.ToString(reader[1]);
                string name = Convert.ToString(reader[2]);
                double price = Convert.ToDouble(reader[3]);
                exams.Add(new Exam { Id = id1, ProductId = id, ProductName = name, Price = price });
            }
            connection.Close();
            return exams;
        }

    }
}

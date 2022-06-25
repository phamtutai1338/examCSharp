
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exam
{
    internal class Add
    {
       
            SqlConnection connection = new SqlServerConnection().getData();
            public void getData(Exam exam)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Exam values (@proId,@proName,@price)", connection);
                command.Prepare();
                command.Parameters.AddWithValue("@proId", exam.ProductId);
                command.Parameters.AddWithValue("@proName", exam.ProductName);
                command.Parameters.AddWithValue("@price", exam.Price);
                int check = command.ExecuteNonQuery();
                if (check >= 1)
                {
                    Console.WriteLine("Add success !");
                }
                else
                {
                    Console.WriteLine("Add false !");
                }
                connection.Close();
            }
          
       
    }
}
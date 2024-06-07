using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentcrud
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=DESKTOP-KCB2BH6\MSSQLSERVER02;Initial Catalog=studentCRUD;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string delete = "delete record ";
            SqlCommand deletequery = new SqlCommand(delete, sqlConnection);

            deletequery.ExecuteNonQuery();

            
            

            sqlConnection.Close();





            Console.ReadKey();
        }
    }
}

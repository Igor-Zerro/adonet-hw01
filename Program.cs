using System;
using System.Data.SqlClient;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HomeworkOne;Integrated Security=True");
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
               
                //sqlCommand.CommandText = "Select * from OvociAndFrukti";
                
                //sqlCommand.CommandText = "Select [Name] from OvociAndFrukti";
               
                //sqlCommand.CommandText = "Select [Color] from OvociAndFrukti";
               
               // sqlCommand.CommandText = "Select Max([Collories]) from OvociAndFrukti";
               
               // sqlCommand.CommandText = "Select Min([Collories]) from OvociAndFrukti";
               
               // sqlCommand.CommandText = "Select AVG([Collories]) from OvociAndFrukti";
               
                //Console.WriteLine(sqlCommand.ExecuteScalar());
                //using (SqlDataReader exReader = sqlCommand.ExecuteReader())
                //{
                //    while (exReader.Read())
                //    {
                //        //Console.WriteLine(exReader.GetString(1)+ "    " +
                //        //   exReader.GetString(2) + "    " 
                //        //   + exReader.GetString(3) + "    "
                //        //   + exReader.GetInt32(4));
                //        // Console.WriteLine(String.Format("{0,15} {1,5} {2,15} {3, 10}", exReader.GetString(1), exReader.GetString(2), exReader.GetString(3), exReader.GetInt32(4)));
                //
                //       Console.WriteLine(String.Format("{0,15}", exReader.GetString(0)));
                 //
                 //       Console.WriteLine(String.Format("{0,15}", exReader.GetString(0)));

                //    }
                //}

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //if(sqlConnection != null)
                //{
                //    sqlConnection.Close();
                //}
                sqlConnection?.Close();
            }
        }
    }
}

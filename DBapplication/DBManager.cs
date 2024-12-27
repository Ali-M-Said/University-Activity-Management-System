using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class DBManager
    {
        static string DB_Connection_String = @"Data Source=DESKTOP-KPE39BO\SQLEXPRESS02;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
        SqlConnection myConnection;

        public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open();
                Console.WriteLine("The DB connection is opened successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("The DB connection is failed");
                Console.WriteLine(e.ToString());
            }
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                // Ensure the connection object is initialized
                if (myConnection.State != ConnectionState.Open)
                    myConnection.Open();

                using (SqlCommand myCommand = new SqlCommand(query, myConnection))
                {
                    // Add parameters to the command
                    foreach (var param in parameters)
                    {
                        myCommand.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }

                    // Execute the query and return the number of affected rows
                    return myCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close(); // Ensure connection is closed
            }
        }
        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                // Ensure the connection object is initialized
                if (myConnection.State != ConnectionState.Open)
                    myConnection.Open();

                using (SqlCommand myCommand = new SqlCommand(query, myConnection))
                {
                    // Add parameters to the command
                    foreach (var param in parameters)
                    {
                        myCommand.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(myCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable); // Populate DataTable with query result
                        return dataTable; // Return the result
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null; // Return null in case of error
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close(); // Ensure connection is closed
            }
        }



        //public DataTable ExecuteReader(string query, Dictionary<string, object> parameters)
        //{
        //    try
        //    {
        //        SqlCommand myCommand = new SqlCommand(query, myConnection);
        //        SqlDataReader reader = myCommand.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            DataTable dt = new DataTable();
        //            dt.Load(reader);
        //            reader.Close();
        //            return dt;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}
        public DataTable ExecuteReader(string query, Dictionary<string, object> parameters)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);

                // Add parameters to the command if provided
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        myCommand.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int ExecuteQuery(string query, SqlParameter[] parameters)
        {
            // Replace `myConnection` with the actual connection string
            string connectionString = "your_connection_string_here"; // Update this with your actual connection string

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open(); // Open the connection
                return cmd.ExecuteNonQuery(); // Execute and return the number of affected rows
            }
        }


        public object ExecuteScalar(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

      
    }
}
;
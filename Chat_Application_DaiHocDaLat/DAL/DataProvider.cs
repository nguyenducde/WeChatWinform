using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Application_DaiHocDaLat.DAL
{
   public class DataProvider
    {
        private static DataProvider instance;
        private readonly string CONNECT_STRING;

        private DataProvider()
        {
            // CONNECT_STRING = ConfigurationManager.ConnectionStrings["Chatapp"].ConnectionString;
            CONNECT_STRING = @"Data Source=DESKTOP-8QPAO1I\DE;Initial Catalog=Chatapp;Integrated Security=True";
        }

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }

            private set { instance = value; }
            }

        public DataTable ExecuteQuery(string query, object[] paramater = null)
        {
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(CONNECT_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listParamater = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParamater)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i++]);
                        }
                    }
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not access to database");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] paramater = null)
        {
            int data = 0;
            SqlConnection connection = new SqlConnection(CONNECT_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listParamater = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParamater)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i++]);
                        }
                    }
                }
                data = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not access to database");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] paramater = null)
        {
            SqlConnection connection = new SqlConnection(CONNECT_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listParamater = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParamater)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i++]);
                        }
                    }
                }
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not access to database");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }
    }
}

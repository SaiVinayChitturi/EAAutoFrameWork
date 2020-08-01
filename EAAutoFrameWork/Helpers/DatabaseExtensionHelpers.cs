using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EAAutoFrameWork.Helpers
{
    public static class DatabaseExtensionHelpers
    {
        public static SqlConnection DBConnect(this SqlConnection sqlConnection, string connectionstring)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionstring);
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception e)
            {
                LogHelpers.Write($"Error opening Sql {e.Message}");
            }

            return null;
        }


        public static void DBConnect(this SqlConnection sqlConnection)
        {
            try
            {

                sqlConnection.Close();

            }
            catch (Exception e)
            {
                LogHelpers.Write($"Error closing Sql {e.Message}");
            }
        }
        public static DataTable ExecuteQuery(this SqlConnection sqlConnection, string queryString)
        {
            DataSet dataSet;
            try
            {


                if (sqlConnection == null || ((sqlConnection != null && (sqlConnection.State == ConnectionState.Closed ||
                    sqlConnection.State == ConnectionState.Broken))))
                    sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = new SqlCommand(queryString, sqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "table");
                sqlConnection.Close();

                return dataSet.Tables["table"];
            }
            catch (Exception e)
            {
                dataSet = null;
                LogHelpers.Write($"Error Fetchching SqlData {e.Message}");
                sqlConnection.Close();
                return null;
            }
            finally
            {
                sqlConnection.Close();
                dataSet = null;
                
            }


        }
    }
    }


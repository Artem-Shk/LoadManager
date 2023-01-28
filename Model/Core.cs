using LoadManager.Model.DataModels;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace LoadManager.Model
{
    public class Core
    {

    }

    public class Sql
    {
       
        private readonly static string _connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private SqlConnection connection = new SqlConnection(_connection_string);
        private SqlCommand command;
        private SqlDataReader reader;
        
        public Sql() { 
        connection.Open();
        }
        public void SelectFromFile()
        {
            string query = "SELECT TOP (1000) [Id],[filename]FROM [loadManagerDB].[dbo].[mainTb]";
            command = new SqlCommand(query,connection);
            reader = command.ExecuteReader();

            


        }
    }
}

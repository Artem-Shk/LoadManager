using LoadManager.Model.DataModels;
using System.Data.SqlClient;
using System.Diagnostics;

namespace LoadManager.Model
{
    public class Sql
    {

        private readonly static string _connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly SqlConnection connection = new(_connection_string);
        private SqlCommand? command;
        private SqlDataReader? reader;
        private string? query;
        private readonly List<object> output = new ();
        private readonly SqlDataAdapter adapter= new ();

        public Sql()
        {
            connection.Open();
			
		}
        public List<FileRoot> SelectFromFileRoot()
        {
			
			query = "SELECT TOP (1000) [Id],[filename]FROM [loadManagerDB].[dbo].[mainTb]";
            command = new SqlCommand(query, connection);
			reader = command.ExecuteReader();
			while (reader.Read())
            {
                FileRoot result = new(reader.GetString(1));
                output.Add(result);
                Debug.WriteLine(reader.GetString(1));
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            foreach(FileRoot ou in output.Cast<FileRoot>())
            {
                Debug.WriteLine(ou);
            }
            return output.Cast<FileRoot>().ToList();




        }

        public void InsertInFileRoot(FileRoot file)
        {
            query = "INSERT INTO [dbo].[mainTb] ([filename]) VALUES (<"+file.FileName+"?, varchar(50),>)";
            command = new SqlCommand(query, connection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

        }
        //TODO solve "a lot of code" problem
        //private List<ModelClass> SelectFromFileRoot <ModelClass>(ModelClass modelClass)
        //where ModelClass : class
        //{
        //    if (modelClass is null)
        //    {
        //        throw new ArgumentNullException(nameof(modelClass));
        //    }
        //    query = "SELECT TOP (1000) [Id],[filename]FROM [loadManagerDB].[dbo].[mainTb]";
        //    command = new SqlCommand(query, connection);
        //    reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        output.Add(new ModelClass(reader.GetString(1)));

        //    }
        //    reader.Close();
        //    command.Dispose();
        //    connection.Close();

        //    return output.Cast<ModelClass>().ToList();

        //}
    }
}

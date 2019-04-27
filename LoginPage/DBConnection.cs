using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinancialApp
{
	class DBConnection
	{
		private const string V = "Data Source = MSSQLLocalDB; Initial Catalog = financial; Integrated Security = True; Pooling = False;";

		public static void OpenSqlConnection()
		{
			string connectionString = GetConnectionString();

			using (SqlConnection connection = new SqlConnection())
			{
				connection.ConnectionString = connectionString;

				connection.Open();

				Console.WriteLine("State: {0}", connection.State);
				Console.WriteLine("ConnectionString: {0}",
					connection.ConnectionString);
			}
		}

		public static void CloseSqlConnection()
		{
			string connectionString = GetConnectionString();

			using (SqlConnection connection = new SqlConnection())
			{
				connection.ConnectionString = connectionString;

				connection.Close();

				Console.WriteLine("State: {0}", connection.State);
				Console.WriteLine("ConnectionString: {0}",
					connection.ConnectionString);
			}
		}

		static private string GetConnectionString()
		{
			// To avoid storing the connection string in your code, 
			// you can retrieve it from a configuration file.
			return V;
		}
	}
}

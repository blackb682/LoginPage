using System.Data.SqlClient;

namespace FinancialApp
{
	class SignIn
	{
		public static string GetUsername(string inputedUserName)
		{
			string username = "";
			string usernameSQL = "Select username From UsersDatabase where userName = '" + inputedUserName + "';";

			SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = financial; Integrated Security = True; Pooling = False;");
			SqlCommand cmdUsername = new SqlCommand(usernameSQL, connection);
			connection.Open();
			using (SqlDataReader reader = cmdUsername.ExecuteReader())
			{
				while (reader.Read())
				{
					username = reader["userName"].ToString();
				}
				connection.Close();
			}
			return username;
		}
		public static string GetPassword(string inputedUsername)
		{
			string password = "";
			string passwordSQL = "Select password From UsersDatabase where userName = '" + inputedUsername + "';";

			SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = financial; Integrated Security = True; Pooling = False;");
			SqlCommand cmdPassword = new SqlCommand(passwordSQL, connection);
			connection.Open();
			using (SqlDataReader reader = cmdPassword.ExecuteReader())
			{
				while (reader.Read())
				{
					password = reader["password"].ToString();
				}
				connection.Close();
			}
			return password;
		}
	}
}


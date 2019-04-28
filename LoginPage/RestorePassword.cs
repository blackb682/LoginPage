using System.Data.SqlClient;

namespace FinancialApp
{
	class RestorePassword
	{
		public static void InsertNewPassword(string username, string password)
		{
			string newPassword = "UPDATE dbo.UsersDatabase SET password = @pw WHERE userName = @un";
			string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = financial; Integrated Security = True; Pooling = False;";
			SqlConnection connection = new SqlConnection(connectionString);

			using (connection)
			{
				using (SqlCommand cmd = connection.CreateCommand())
				{
					cmd.CommandText = newPassword;

					cmd.Parameters.AddWithValue("@pw", password);
					cmd.Parameters.AddWithValue("@un", username);
					connection.Open();

					cmd.ExecuteNonQuery();

					connection.Close();
				}
			}
		}
	}
}


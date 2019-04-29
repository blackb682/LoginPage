using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LoginPage
{
	class Users
	{

	}
	class InsertUser
	{
		public static void NewUser(string username,string password,string name, string surname, char gender,
									string birthDay,string email, string company)
		{
			string newUser = "INSERT INTO dbo.UsersDatabase (userName, password, name, surName" +
				"gender, birthDay, emailAddress, company, creationTime) VALUES " +
				"(@un, @pw, @nm, @sn, @gd, @bd, @em, @cp, @ct)";
			string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = financial; Integrated Security = True; Pooling = False;";
			SqlConnection connection = new SqlConnection(connectionString);
			DateTime creationTime = DateTime.Now;

			using (connection)
			{
				using (SqlCommand cmd = connection.CreateCommand())
				{
					cmd.CommandText = newUser;

					cmd.Parameters.AddWithValue("@un", username);
					cmd.Parameters.AddWithValue("@pw", password);
					cmd.Parameters.AddWithValue("@nm", name);
					cmd.Parameters.AddWithValue("@sn", surname);
					cmd.Parameters.AddWithValue("@gd", gender);
					cmd.Parameters.AddWithValue("@bd", birthDay);
					cmd.Parameters.AddWithValue("@em", email);
					cmd.Parameters.AddWithValue("@cp", company);
					cmd.Parameters.AddWithValue("@ct", creationTime);

					cmd.ExecuteNonQuery();

					connection.Close();
				}
			}
		}
	}
}

﻿using System;
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
	}

	public class DBLogin
	{
		public static string SqlLogin(string inputedUserName, string inputedPassword)
		{
			string username = "Select username From financial where username =" + inputedUserName + ";";
			string password = "Select password From financial where username =" + inputedUserName + ";";
			string rLogin;
			bool status = false;

			SqlConnection connection = new SqlConnection(@"Data Source = MSSQLLocalDB; Initial Catalog = financial; Integrated Security = True; Pooling = False;");
			SqlCommand cmd = new SqlCommand(username, connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();

			if (inputedUserName != username)
			{
				rLogin = "Usuário não cadastrado";
				status = false;
			}
			else 
			{
				if (inputedPassword != password)
				{

				}
			}

		}
		
	}
}
